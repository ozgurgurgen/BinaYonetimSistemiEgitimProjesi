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

namespace BinaYonetimSistemi.Screens
{
    public partial class AnaSayfa : Form
    {
        
        public AnaSayfa()
        {
            InitializeComponent();
            new Borclar().AidatBorclandir();
            timer1.Start();
            if (GirisEkrani.user.Yetki.Equals("Daire Sakini"))
            {
                KomsuEkle.Visible = false;
                KomsuEkleText.Visible = false;
                BorclandirPanel.Visible = false;
                BorclandirText.Visible = false;
                YeniDuyuruPanel.Visible = false;
                YeniDuyuruText.Visible = false;
                KomsuDuzenlePanel.Visible = false;
                KomsuDuzenleText.Visible = false;
                BorcOdemeyenLabel.Visible = false;
                BorcOdemeyenlerPanel.Visible = false;
                BorcOdemeyenSayisiLabel.Visible = false;
                YeniGiderLabel.Visible = false;
                YeniGiderPabel.Visible = false;
                DuyuruDuzenleLabel.Visible = false;
                DuyuruDuzenlePanel.Visible = false;
                this.Size = new Size(635, 614);
            }
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            timer1.Stop();
        }

        private void KomsuEkle_Click(object sender, MouseEventArgs e)
        {
            new AltEkranlar.KomsuEkle().Show();
        }

        private void AddNewAnnounce(object sender, MouseEventArgs e)
        {
            new AltEkranlar.YeniDuyuru().Show();
        }

        private void GiderEkle_click(object sender, MouseEventArgs e)
        {
            new AltEkranlar.YeniGider().Show();
        }

        private void Borclandir_Click(object sender, MouseEventArgs e)
        {
            new AltEkranlar.Borclandir().Show();
        }

        private void BorcListele_Click(object sender, MouseEventArgs e)
        {
            new AltEkranlar.BorcListele().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Controller.AnaSayfa anaSayfa = new Controller.AnaSayfa();
            KomsuSayi.Text = anaSayfa.Komsularim().ToString();
            KasaTutar.Text = anaSayfa.KasaTutari();
            DuyuruSayi.Text = anaSayfa.DuyuruSayisi().ToString();
            BorcTutar.Text = anaSayfa.KullaniciBorc();
            BorcOdemeyenSayisiLabel.Text = anaSayfa.BorcOdemeyenSayisi().ToString();
            KullaniciAdiText.Text = GirisEkrani.user.Adi;
        }

        private void KasaHareketleri_Click(object sender, MouseEventArgs e)
        {
            new AltEkranlar.KasaHareketleri().Show();
        }

        private void AktifDuyuru_MouseClick(object sender, MouseEventArgs e)
        {
            new AltEkranlar.DuyuruListele().Show();
        }

        private void BorcOdemeyenler_MouseClick(object sender, MouseEventArgs e)
        {
            new AltEkranlar.BorcOdemeyenler().Show();
        }

        private void KomsularimLabel_MouseClick(object sender, MouseEventArgs e)
        {
            new AltEkranlar.KomsuListesi().Show();
        }

        private void KomsuDuzenle_MouseClick(object sender, MouseEventArgs e)
        {
            new AltEkranlar.KomsuDuzenlemeListesi().Show();
        }

        private void DuyuruDuzenle_MouseClick(object sender, MouseEventArgs e)
        {
            new AltEkranlar.DuyuruDuzenle().Show();
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            new AltEkranlar.BinaBilgileri().Show();
        }
    }
}
