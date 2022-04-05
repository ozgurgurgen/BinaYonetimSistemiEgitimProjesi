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

namespace BinaYonetimSistemi
{
    public partial class GirisEkrani : Form
    {
        public static Kullanicilar user;

        public GirisEkrani()
        {
            InitializeComponent();
            KullaniciAdiTextBox.Text = "ozgurgurgen";
            ParolaTextBox.Text = "1234";
        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var sorgu = from kullanici in db.Kullanicilar
                        where kullanici.KullaniciAdi == KullaniciAdiTextBox.Text && kullanici.Parola == ParolaTextBox.Text
                        select kullanici;

            if (sorgu.Any())
            {
                user = sorgu.FirstOrDefault();
                new Screens.AnaSayfa().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Hata");
            }

        }

        private void IptalButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
