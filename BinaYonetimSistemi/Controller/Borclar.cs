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
        public void Ekle(string borcTuru, string borcAdi, string faturaTarihi, string faturaTutari, string faturaNo,
            string daireBasiDusenTutar, bool kasadanOdenecek, string borcAciklamasi, int komsuSayisi)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            Entities.Borc yeniBorc = new Entities.Borc();

            yeniBorc.BorcTuru = borcTuru;
            yeniBorc.BorcAdi = borcAdi;
            yeniBorc.FaturaTarihi = faturaTarihi;
            yeniBorc.FaturaTutari = Convert.ToDecimal(faturaTutari.Remove(0, 1));
            yeniBorc.FaturaNo = faturaNo;
            yeniBorc.KisiBasinaDusenTutar = Convert.ToDecimal(daireBasiDusenTutar.Remove(0, 1));
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

        public void Ekle(string borcTuru, string borcAdi, string faturaTarihi, string faturaTutari, string faturaNo,
            bool kasadanOdenecek, string borcAciklamasi, string daireSeçimi)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            int index = daireSeçimi.IndexOf(':');
            string daireNo = daireSeçimi.Substring(index + 2);

            var sorgu = from kullanici in db.Kullanicilar
                        where kullanici.Adres1.DaireNo == daireNo & kullanici.Adres1.SiteBina1.Id == GirisEkrani.user.Adres1.SiteBina1.Id
                        select kullanici;


            Entities.Borc yeniBorc = new Entities.Borc();

            yeniBorc.BorcTuru = borcTuru;
            yeniBorc.BorcAdi = borcAdi;
            yeniBorc.FaturaTarihi = faturaTarihi;
            yeniBorc.FaturaTutari = Convert.ToDecimal(faturaTutari.Remove(0, 1));
            yeniBorc.FaturaNo = faturaNo;
            yeniBorc.KasadanOdenecek = kasadanOdenecek;
            yeniBorc.BorcAciklamasi = borcAciklamasi;
            yeniBorc.KisiBasinaDusenTutar = 0;
            yeniBorc.BorcTarihi = DateTime.Now.ToString();

            db.Borc.Add(yeniBorc);
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

        public Array Getir()
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var liste = db.KullaniciBorc.Where(x => x.KullaniciId == GirisEkrani.user.Id).OrderByDescending((x => x.Borc.BorcTarihi)).Select(x => new
            {
                x.Borc.FaturaNo,
                x.Borc.BorcTuru,
                x.Borc.BorcAdi,
                x.Borc.BorcAciklamasi,
                x.Borc.FaturaTutari,
                x.Borc.FaturaTarihi,
                x.Borc.BorcTarihi,
                x.OdemeZamani,
                x.Id
            }).ToArray();


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


    }
}
