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

namespace BinaYonetimSistemi.Screens
{
    public partial class AnaSayfa : Form
    {
        
        public AnaSayfa()
        {
            InitializeComponent();
            Classes.GenelGorunum genelGorunum = new Classes.GenelGorunum();
            KomsuSayi.Text = genelGorunum.Komsularim().ToString();
            KasaTutar.Text = genelGorunum.KasaTutari();
            DuyuruSayi.Text = genelGorunum.DuyuruSayisi().ToString();
            BorcTutar.Text = genelGorunum.KullaniciBorc();
            KullaniciAdiText.Text = GirisEkrani.user.Adi;
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KomsuEkle_Click(object sender, MouseEventArgs e)
        {

        }
    }
}
