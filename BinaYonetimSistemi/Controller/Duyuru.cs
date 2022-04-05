using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;

namespace BinaYonetimSistemi.Controller
{
    internal class Duyuru
    {
        public void Ekle(string duyuruBasligi, string duyuruMetni, string baslangic, string bitis)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();
            Duyurular yeniDuyuru = new Duyurular();

            yeniDuyuru.SiteBina = GirisEkrani.user.Adres1.SiteBina1.Id;
            yeniDuyuru.DuyuruBasligi = duyuruBasligi;
            yeniDuyuru.DuyuruAciklamasi = duyuruMetni;
            yeniDuyuru.DuyuruTarihi = baslangic;
            yeniDuyuru.DuyuruBitisTarihi = bitis;

            db.Duyurular.Add(yeniDuyuru);
            db.SaveChanges();

            new Screens.AltEkranlar.Tamamlandi("Yeni Duyuru Ekleme İşlemi Başarıyla Tamamlandı").Show();
            Console.WriteLine("asdasd");

            
        }
    }
}
