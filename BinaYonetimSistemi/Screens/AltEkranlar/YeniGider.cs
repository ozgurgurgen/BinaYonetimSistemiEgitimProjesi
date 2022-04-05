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
    public partial class YeniGider : Form
    {
        public YeniGider()
        {
            InitializeComponent();
        }


        private void GiderEkleButon_Click(object sender, EventArgs e)
        {
            FormControl formControl = new FormControl();
            if (formControl.TextBoxesAreEmpty(this))
            {
                var komsuSayisi = new Komsu().KomsuSayisi();
                new Borclar().Ekle(BorcTuruTextBox.Text, BorcAdiTextBox.Text, FaturaTarihi.Value.ToShortDateString(),
                        FaturaTutariTextBox.Text, FaturaNoTextBox.Text, DBDusenTutarTextBox.Text, true, FaturaAciklamasiTextBox.Text, komsuSayisi);
                Console.WriteLine(new Komsu().KomsuSayisi());
            }
            formControl.TexboxClear(this);
        }

        private void FaturaTutariTextBox_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(FaturaTutariTextBox.Text, out value))
                FaturaTutariTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                FaturaTutariTextBox.Text = String.Empty;

            var komsuSayisi = new Komsu().KomsuSayisi();
            double kisiBasinaDusenTutar = 0;
            if (!FaturaTutariTextBox.Text.Equals(""))
            {
                kisiBasinaDusenTutar = Convert.ToDouble(FaturaTutariTextBox.Text.Remove(0, 1)) / komsuSayisi;
            }
            DBDusenTutarTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", kisiBasinaDusenTutar);

        }
    }
}
