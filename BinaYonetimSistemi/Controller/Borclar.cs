using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;

namespace BinaYonetimSistemi.Controller
{
    internal class Borclar
    {
        //Genel gider ekle
        public void Eklem(string borcTuru, string borcAdi, string faturaTarihi, string faturaTutari, string faturaNo,
            bool kasadanOdenecek, string borcAciklamasi)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            Entities.Borc yeniBorc = new Entities.Borc();

            yeniBorc.BorcTuru = borcTuru;
            yeniBorc.BorcAdi = borcAdi;
            yeniBorc.FaturaTarihi = faturaTarihi;
            yeniBorc.FaturaTutari = Convert.ToDecimal(faturaTutari.Remove(0, 1));
            yeniBorc.FaturaNo = faturaNo;
            yeniBorc.KasadanOdenecek = kasadanOdenecek;
            yeniBorc.BorcAciklamasi = borcAciklamasi;
            yeniBorc.BorcTarihi = DateTime.Now.ToString();

            db.Borc.Add(yeniBorc);
            db.SaveChanges();

            BinaYonetimSistemiEntities dbx = new BinaYonetimSistemiEntities();
            var sorgu = from borcum in dbx.Borc
                        where borcum.FaturaNo == faturaNo
                        select borcum;
            var borc = sorgu.FirstOrDefault();
            new Kasa().HareketEkle(faturaTutari, borc.Id, GirisEkrani.user.Adres1.SiteBina, false);
        }

        //Kişi borçlandır        
        public void Ekle(string borcTuru, string borcAdi, string faturaTarihi, decimal faturaTutari, string faturaNo,
            bool kasadanOdenecek, string borcAciklamasi, int kullaniciId)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            Borc yeniBorc = new Borc();

            var sorgu = from kullanici in db.Kullanicilar
                        where kullanici.Id == kullaniciId & kullanici.Adres1.SiteBina1.Id == GirisEkrani.user.Adres1.SiteBina1.Id
                        select kullanici;

            yeniBorc.BorcTuru = borcTuru;
            yeniBorc.BorcAdi = borcAdi;
            yeniBorc.FaturaTarihi = faturaTarihi;
            yeniBorc.FaturaTutari = faturaTutari;
            yeniBorc.FaturaNo = faturaNo;
            yeniBorc.KasadanOdenecek = kasadanOdenecek;
            yeniBorc.BorcAciklamasi = borcAciklamasi;
            yeniBorc.BorcTarihi = DateTime.Now.ToString();

            db.Borc.Add(yeniBorc);
            Console.WriteLine(yeniBorc.FaturaTutari);
            db.SaveChanges();

            BinaYonetimSistemiEntities dbx = new BinaYonetimSistemiEntities();

            var sorgu2 = from borc in db.Borc
                         where borc.FaturaNo == faturaNo
                         select borc;

            KullaniciBorc kullaniciBorc = new KullaniciBorc();
            kullaniciBorc.KullaniciId = sorgu.FirstOrDefault().Id;
            kullaniciBorc.BorcId = sorgu2.FirstOrDefault().Id;

            dbx.KullaniciBorc.Add(kullaniciBorc);
            dbx.SaveChanges();
        }

        public List<KullaniciBorc> Getir()
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var liste = db.KullaniciBorc.Where(x => x.KullaniciId == GirisEkrani.user.Id).OrderByDescending((x => x.Borc.BorcTarihi)).ToList<KullaniciBorc>();
            return liste;
        }

        public KullaniciBorc Getir(int kullaniciBorcId)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            var sorgu = from borc in db.KullaniciBorc
                        where borc.Id == kullaniciBorcId
                        select borc;

            return sorgu.FirstOrDefault();
        }

        public KullaniciBorc KullaniciBorcGetir(int kullaniciBorcId)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            var sorgu = from borc in db.KullaniciBorc
                        where borc.Id == kullaniciBorcId
                        select borc;

            return sorgu.FirstOrDefault();
        }

        public void Ode(int kullaniciBorcId, int kullaniciId)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            var sorgu = from kullaniciBorc in db.KullaniciBorc
                        where kullaniciBorc.Id == kullaniciBorcId
                        select kullaniciBorc;


            var kullaniciBorcu = sorgu.FirstOrDefault();
            kullaniciBorcu.OdemeZamani = DateTime.Now.ToString();
            db.SaveChanges();

            Kasa kasa = new Kasa();
            kasa.HareketEkle(kullaniciBorcu.Borc.FaturaTutari.ToString(), kullaniciBorcu.Borc.Id, GirisEkrani.user.Adres1.SiteBina, true);
            kasa.KasaGecmisiKullaniciEkle(kullaniciBorcu.Borc.Id, kullaniciId);

        }

        public List<BorcluKullanici> BorcluGetir()
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            var sorgu = from borclu in db.KullaniciBorc
                        where borclu.Kullanicilar.Adres1.SiteBina == GirisEkrani.user.Adres1.SiteBina & borclu.OdemeZamani == null
                        group borclu by borclu.KullaniciId into borcluKullanici
                        select new BorcluKullanici { id = borcluKullanici.Key, borc = borcluKullanici.ToList<KullaniciBorc>() };

            return sorgu.ToList<BorcluKullanici>();
        }

        public class BorcluKullanici
        {
            public int id { get; set; }
            public List<KullaniciBorc> borc { get; set; }
        }

        public void Sil(int borcId)
        {
            Console.WriteLine("yakalama " + borcId);

            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            var sorgu = from _borc in db.KullaniciBorc
                        where _borc.BorcId == borcId
                        select _borc;
            Borc borc = sorgu.FirstOrDefault().Borc;
            db.Borc.Remove(borc);
            db.KullaniciBorc.Remove(sorgu.FirstOrDefault());
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                Console.WriteLine("Bunu Silemezsin");

            }

        }

        public void AidatBorclandir()
        {
            var buGun = DateTime.Now.Day;
            var buAy = DateTime.Now.ToString("MMMM");
            var faturaNo = AidatFaturaNoYapıcı();

            BinaYonetimSistemiEntities dbm = new BinaYonetimSistemiEntities();

            var sorgu = from _aidat in dbm.Aidatlar
                        where _aidat.SiteBinaId == GirisEkrani.user.Adres1.SiteBina
                        select _aidat;
            var aidat = sorgu.FirstOrDefault();

            if (sorgu.Count() != 0)
            {
                var aidatGunu = aidat.AidatGunu;
                if (buGun == aidatGunu & aidat.AidatlarGonderildi == false)
                {
                    var komsuListesi = new Komsu().KomsulariGetir();
                    aidat.AidatlarGonderildi = true;
                    dbm.SaveChanges();
                    foreach (var komsu in komsuListesi)
                    {
                        Ekle("Aidat", buAy + " Ayı Aidat Ödemesi", DateTime.Now.ToShortDateString(), aidat.AidatTutari, "ADT" + faturaNo,
                            false, "Aidatınızı zamanında ödediğiniz için teşekkür ederiz.", komsu.Id);

                        faturaNo++;
                    }

                }
            }
        }

        private int AidatFaturaNoYapıcı()
        {
            var tarih = DateTime.Now.ToShortDateString().Replace(".", "") + DateTime.Now.Minute;
            return int.Parse(tarih);
        }

    }
}
