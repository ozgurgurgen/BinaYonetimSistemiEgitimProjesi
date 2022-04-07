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
    public partial class KomsuDüzenle : Form
    {
        int komsuId;
        public KomsuDüzenle()
        {
            InitializeComponent();
        }
        public KomsuDüzenle(int komsuId)
        {
            this.komsuId = komsuId;
            InitializeComponent();
            FormDoldur(komsuId);
        }

        private void FormDoldur(int komsuId)
        {
            var komsu = new Komsu().KomsumGetir(komsuId);

            KomsuAdiTextBox.Text = komsu.Adi;
            KomsuSoyadiTextBox.Text = komsu.Soyadi;
            KullaniciAdiTextBox.Text = komsu.KullaniciAdi;
            MailTextBox.Text = komsu.Mail;
            ParolaTextBox.Text = komsu.Parola;
            BinaNoTextBox.Text = komsu.Adres1.BinaNo;
            DaireNoTextBox.Text = komsu.Adres1.DaireNo;
        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            Console.WriteLine(new FormControl().TextBoxesAreEmpty(this));
            if (new FormControl().TextBoxesAreEmpty(this))
            {
                new Komsu().KomsuGuncelle(komsuId,BinaNoTextBox.Text, DaireNoTextBox.Text, KomsuAdiTextBox.Text, KomsuSoyadiTextBox.Text,
                    KullaniciAdiTextBox.Text, ParolaTextBox.Text, MailTextBox.Text);

                new Tamamlandi(KomsuAdiTextBox.Text + " Adlı Kullanıcı Başarılı Şekilde Güncellendi").Show();
            }
            
        }
    }
}
