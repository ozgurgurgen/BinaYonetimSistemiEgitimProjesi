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
            timer1.Start();
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
            BorcOdemeyenLAbel.Text = anaSayfa.BorcOdemeyenSayisi().ToString();
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
    }
}
