using BinaYonetimSistemi.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    public partial class BinaBilgileri : Form
    {
        public BinaBilgileri()
        {
            InitializeComponent();
            BilgileriDoldur();

            if (GirisEkrani.user.Yetki == "Daire Sakini")
            {
                AidatPanel.Visible = false;
                this.Size = new Size(352, 363);
            }


        }
        private void BilgileriDoldur()
        {
            SiteBinaAdıLabel.Text = GirisEkrani.user.Adres1.SiteBina1.SiteBinaAd;
            var bilgiler = new BinaAidatBilgileri().Getir();

            if (bilgiler.Id != -1)
            {
                AidatTutariLabel.Text = bilgiler.AidatTutari + "₺";
                AidatGünüLabel.Text = "Her ayın " + bilgiler.AidatGunu +". günü.";
                AidatTutariTextBox.Text = "₺" + bilgiler.AidatTutari;
                AidatGunuTextBox.Text = bilgiler.AidatGunu.ToString();
            }
            else
            {
                AidatTutariLabel.Text = "Bilgi Yok";
                AidatGünüLabel.Text = "Bilgi Yok";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AidatDuzenleButon_Click(object sender, EventArgs e)
        {
            decimal aidatTutari = Convert.ToDecimal(AidatTutariTextBox.Text.Remove(0, 1));
            int gun = Convert.ToInt16(AidatGunuTextBox.Text);
           new BinaAidatBilgileri().Ekle(GirisEkrani.user.Adres1.SiteBina, aidatTutari,gun );
            BilgileriDoldur();
        }

        private void AidatTutariTextBox_Leave(object sender, EventArgs e)
        {
            new FormControl().ParaBirimi(AidatTutariTextBox);
            
        }
    }
}
