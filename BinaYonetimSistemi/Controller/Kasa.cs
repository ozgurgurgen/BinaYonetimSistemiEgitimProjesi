using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;

namespace BinaYonetimSistemi.Controller
{
    internal class Kasa
    {
        public void HareketEkle(string tutar, int borcId,int siteBinaId, bool gelirMi)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            KasaGeçmişi kasaGeçmişi = new KasaGeçmişi();

            kasaGeçmişi.HareketTutarı = Convert.ToDecimal(tutar.Remove(0,1));
            kasaGeçmişi.BorcId = borcId;
            kasaGeçmişi.SiteBinaId = siteBinaId;
            kasaGeçmişi.GelirMi = gelirMi;
            kasaGeçmişi.HareketTarihi = DateTime.Now.ToString();

            db.KasaGeçmişi.Add(kasaGeçmişi);
            db.SaveChanges();
            KasaTutarIslemi(siteBinaId,gelirMi,tutar);
        }

        private void KasaTutarIslemi(int siteBinaId, bool gelirMi, string tutar)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            ///Kasa kasa = new Kasa();
            var sorgu = from kasam in db.Kasa
                        where kasam.SiteBina == siteBinaId
                        select kasam;
            var kasa = sorgu.FirstOrDefault();
            var kasaTutari = Convert.ToDouble(kasa.KasaTutarı);
            if (gelirMi)
            {
                kasaTutari += Convert.ToDouble(tutar);
            }
            else
            {
                kasaTutari -= Convert.ToDouble(tutar.Remove(0,1));
            }
            kasa.KasaTutarı = Convert.ToDecimal(kasaTutari);
            db.SaveChanges();
        }

        public List<KasaGeçmişi> HareketleriGetir()
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var sorgu = from kasa in db.KasaGeçmişi
                        where kasa.SiteBina.Id == GirisEkrani.user.Adres1.SiteBina
                        orderby kasa.Borc.BorcTarihi descending
                        select kasa;
            var liste = new List<KasaGeçmişi>();
            liste = sorgu.ToList();

            return liste;
        }

        public KasaGeçmişi KasaAyrintiGetir(int kasaGecmisiId)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var sorgu = from kasaHareketAyrintisi in db.KasaGeçmişi
                        where kasaHareketAyrintisi.Id == kasaGecmisiId
                        select kasaHareketAyrintisi;
            return sorgu.FirstOrDefault();
        }

        public void KasaGecmisiKullaniciEkle(int kullaniciBorcId, int kullaniciId)
        {
            
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var sorgu = from kasaGeçmiş in db.KasaGeçmişi
                         where kasaGeçmiş.BorcId == kullaniciBorcId
                         select kasaGeçmiş;

            var kasaGeçmişi = sorgu.FirstOrDefault();


            kasaGeçmişi.KullaniciId = kullaniciId;
            db.SaveChanges();
        }
    }
}
