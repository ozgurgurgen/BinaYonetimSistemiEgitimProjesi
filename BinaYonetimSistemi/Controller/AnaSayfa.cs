using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;

namespace BinaYonetimSistemi.Controller
{
    internal class AnaSayfa
    {
        BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
        public int Komsularim()
        {
            var sorgu = from komsularim in db.Kullanicilar
                        where komsularim.Adres1.SiteBina == GirisEkrani.user.Adres1.SiteBina
                        select komsularim;

            return sorgu.Where(x => x.Id != GirisEkrani.user.Id).Count();
        }

        public string KasaTutari()
        {
            var sorgu = from kasa in db.Kasa
                        where kasa.SiteBina1.Id == GirisEkrani.user.Adres1.SiteBina1.Id
                        select kasa;
            var tutar = sorgu.FirstOrDefault().KasaTutarı;
            return  tutar + " ₺";
        }

        public int DuyuruSayisi()
        {
            var sorgu = from duyuru in db.Duyurular
                        where duyuru.SiteBina == GirisEkrani.user.Adres1.SiteBina1.Id
                        select duyuru;
            return sorgu.ToList<Duyurular>().Count(x => Convert.ToDateTime(x.DuyuruBitisTarihi) >= DateTime.Now.Date);
        }

        public string KullaniciBorc()
        {
            double toplamBorc = 0;
            var sorgu = from borc in db.KullaniciBorc
                        where borc.OdemeZamani == null && borc.KullaniciId == GirisEkrani.user.Id
                        select borc;

            foreach (var borc in sorgu.ToList())
            {
                toplamBorc += Convert.ToDouble(borc.Borc.FaturaTutari);
            }
            return toplamBorc.ToString() + " ₺";
        }

        public int BorcOdemeyenSayisi()
        {
            var sorgu = from kullanici in db.KullaniciBorc
                        where kullanici.OdemeZamani == null & kullanici.Kullanicilar.Adres1.SiteBina == GirisEkrani.user.Adres1.SiteBina
                        select kullanici;

            return sorgu.GroupBy(x => x.KullaniciId).Count();
        }
    }
}
