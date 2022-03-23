using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;

namespace BinaYonetimSistemi.Classes
{
    public class GenelGorunum
    {
        BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
        public int Komsularim()
        {
            var sorgu = from komsularim in db.Kullanicilar
                        where komsularim.Adres1.SiteBina == GirisEkrani.user.Adres1.SiteBina
                        select komsularim;

            return sorgu.Count();
        }

        public string KasaTutari()
        {
            var sorgu = from kasa in db.Kasa
                        where kasa.SiteBina1.Id == GirisEkrani.user.Adres1.SiteBina1.Id
                        select kasa.KasaTutarı;

            return sorgu.FirstOrDefault() + " ₺";
        }
        
        public int DuyuruSayisi()
        {
            var sorgu = from duyuru in db.Duyurular
                        where duyuru.SiteBina == GirisEkrani.user.Adres1.SiteBina1.Id
                        select duyuru;
            return sorgu.Count();
        }

        public string KullaniciBorc()
        {
            int toplamBorc = 0;
            var sorgu = from borc in db.KullaniciBorc
                        where borc.OdemeZamani == null && borc.KullaniciId == GirisEkrani.user.Id
                        select borc;
            foreach (var borc in sorgu.ToList())
            {                
                toplamBorc += Convert.ToInt32(borc.Borc.KisiBasinaDusenTutar);
            }
            return toplamBorc.ToString() + " ₺";
        }
    }
}
