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
    public partial class BorcAyrinti : Form
    {
        int kullaniciBorcId;
        public BorcAyrinti()
        {
            InitializeComponent();            
        }

        public BorcAyrinti(int kullaniciBorcId)
        {
            InitializeComponent();
            this.kullaniciBorcId = kullaniciBorcId;
            Console.WriteLine("Gelen " + kullaniciBorcId);
            AyrintiSayfasiYapilandirma();

        }

        private void AyrintiSayfasiYapilandirma()
        {
            var kullaniciBorc = new Borclar().Getir(kullaniciBorcId);
            BorcTuruTextBox.Text = kullaniciBorc.Borc.BorcTuru.ToString();
            BorcAdiTextBox.Text = kullaniciBorc.Borc.BorcAdi.ToString();
            BorcTarihiTextBox.Text = kullaniciBorc.Borc.BorcTarihi.ToString();
            FaturaTarihiTextBox.Text = kullaniciBorc.Borc.FaturaTarihi.ToString();
            FaturaNumarasiTextBox.Text = kullaniciBorc.Borc.FaturaNo.ToString();
            FaturaTutariTextBox.Text = kullaniciBorc.Borc.FaturaTutari.ToString();
            FaturaAciklamasiTextBox.Text = kullaniciBorc.Borc.BorcAciklamasi.ToString();

            if (kullaniciBorc.OdemeZamani != null)
            {
                BorcOdemeButon.Enabled = false;
                BorcOdemeButon.Text = "Ödemenizi Yaptığınız İçin Teşekkür Ederiz";
            }
        }

        private void BorcOdemeButon_Click(object sender, MouseEventArgs e)
        {
            new Borclar().Ode(kullaniciBorcId, GirisEkrani.user.Id);
            new Tamamlandi("Ödeme İşlemi Başarılı Şekilde Tamamlandı").Show();
            this.Close();
        }

    }
}
