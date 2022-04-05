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
using BinaYonetimSistemi.Controller;

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
            if (GirisEkrani.user.Yetki.Equals("Yonetici"))
            {
                if ( new FormControl().TextBoxesAreEmpty(this) )
                {
                    new Komsu().Ekle(BinaNoTextBox.Text, DaireNoTextBox.Text, KomsuAdiTextBox.Text, KomsuSoyadiTextBox.Text,
                    KullaniciAdiTextBox.Text, ParolaTextBox.Text, ParolaDogrulamaTextBox.Text, MailTextBox.Text);

                    new FormControl().TexboxClear(this);
                }
                else
                {
                    HataLabel.Text = "Lütfen tüm alanların doldurulduğundan ve doğruluğundan emin olun!";
                }
            }
        }

    }
}
