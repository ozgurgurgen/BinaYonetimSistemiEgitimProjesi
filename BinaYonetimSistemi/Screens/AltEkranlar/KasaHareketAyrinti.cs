using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaYonetimSistemi.Controller;

namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    public partial class KasaHareketAyrinti : Form
    {
        int kasaGecmisiId;
        public KasaHareketAyrinti()
        {
            InitializeComponent();            
        }
        public KasaHareketAyrinti(int kasaGecmisiId)
        {
            this.kasaGecmisiId = kasaGecmisiId;
            InitializeComponent();
            DataDoldur();
            

        }

        private void DataDoldur()
        {
            var kasaGecmisi = new Kasa().KasaAyrintiGetir(kasaGecmisiId);

            BorcTuruTextBox.Text = kasaGecmisi.Borc.BorcTuru;
            BorcAdiTextBox.Text = kasaGecmisi.Borc.BorcAdi;
            FaturaTarihiTextBox.Text = kasaGecmisi.Borc.FaturaTarihi;
            BorcTarihiTextBox.Text = kasaGecmisi.Borc.BorcTarihi;
            FaturaNumarasiTextBox.Text = kasaGecmisi.Borc.FaturaNo;
            FaturaTutariTextBox.Text = kasaGecmisi.Borc.FaturaTutari.ToString();
            FaturaAciklamasiTextBox.Text = kasaGecmisi.Borc.BorcAciklamasi;
            if (!Convert.ToBoolean(kasaGecmisi.Borc.KasadanOdenecek))
            {
                BorcButonu.Text = "Borç " + kasaGecmisi.Kullanicilar.Adi + " " + kasaGecmisi.Kullanicilar.Soyadi + " Tarafından Ödendi";
            }
            else
            {
                BorcButonu.Text = "Borç Kasadan Ödendi";
                BorcButonu.BackColor = Color.IndianRed;
                BorcButonu.ForeColor = Color.White;
            }

        }
    }
}
