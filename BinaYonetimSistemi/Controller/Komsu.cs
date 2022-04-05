using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;

namespace BinaYonetimSistemi.Controller
{
    internal class Komsu
    {
        public void Ekle(string binaNo, string daireNo, string ad, string soyad, string kullaniciAdi, string parola, string parolaDogrulama, string mail)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            Kullanicilar yeniKomsu = new Kullanicilar();

            Adres adres = new Adres();

            adres.SiteBina = GirisEkrani.user.Adres1.SiteBina1.Id;
            adres.BinaNo = binaNo.Trim();
            adres.DaireNo = daireNo.Trim();

            yeniKomsu.Adi = ad.Trim();
            yeniKomsu.Soyadi = soyad.Trim();
            yeniKomsu.KullaniciAdi = kullaniciAdi.Trim();
            yeniKomsu.Mail = mail.Trim();
            yeniKomsu.Parola = new Parola().ParolaDogrula(parola.Trim(), parolaDogrulama.Trim());
            yeniKomsu.Yetki = "Bina Sakini";
            yeniKomsu.Adres1 = adres;
            db.Kullanicilar.Add(yeniKomsu);
            db.SaveChanges();
        }

        public int KomsuSayisi()
        {
            return KomsuGetir().Count();
        }

        public List<Kullanicilar> KomsuGetir()
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            var sorgu = from komsu in db.Kullanicilar
                        where komsu.Adres1.SiteBina1.Id == GirisEkrani.user.Adres1.SiteBina1.Id
                        select komsu;
            var list = new List<Kullanicilar>();
            list = sorgu.ToList();
            return list;
        }
    }
}
