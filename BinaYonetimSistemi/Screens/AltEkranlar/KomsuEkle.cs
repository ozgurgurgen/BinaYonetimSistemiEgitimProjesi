using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaYonetimSistemi.Entities;
using BinaYonetimSistemi.Classes;

namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    public partial class KomsuEkle : Form
    {
        public KomsuEkle()
        {
            InitializeComponent();
        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            Kullanicilar yeniKomsu = new Kullanicilar();

            var sorgu = from adresim in db.Adres
                        where adresim.Id == 2
                        select adresim.SiteBina;
            Adres adres = new Adres();

            adres.SiteBina = sorgu.FirstOrDefault();
            adres.BinaNo = BinaNoTextBox.Text;
            adres.DaireNo = DaireNoTextBox.Text;
            try
            {
                yeniKomsu.Adi = KomsuAdiTextBox.Text;
                yeniKomsu.Soyadi = KomsuSoyadiTextBox.Text;
                yeniKomsu.KullaniciAdi = KullaniciAdiTextBox.Text;
                yeniKomsu.Parola = new Controller().ParolaDogrula(ParolaTextBox, ParolaDogrulamaTextBox);
                yeniKomsu.Yetki = "Bina Sakini";
                yeniKomsu.Adres1 = adres;
                db.Kullanicilar.Add(yeniKomsu);
                db.SaveChanges();

            }
            catch (Exception exceptionss)
            {

                HataLabel.Text = "Tüm Alanları Yeniden Kontrol Edin. Geçersiz veya Eksik Giriş.";
                Console.WriteLine("Hatam Bu: " + exceptionss.Message);
            }
            

            

        }
    }
}
