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
    public partial class Borclandir : Form
    {
        public Borclandir()
        {
            InitializeComponent();
            ComboBoxHazırla();
        }
        private void ComboBoxHazırla()
        {
            List<Kullanicilar> komsular = new Controller.Komsu().KomsulariGetir();
            foreach (var komsu in komsular)
            {
                DaireSeçim.Items.Add(new FormControl.ComboBoxItem
                {
                    Text = komsu.Adi + " " + komsu.Soyadi,
                    Value = komsu.Id
                });
            }
        }

        private void BorclandirButon_Click(object sender, EventArgs e)
        {
            FormControl formControl = new FormControl();
            FormControl.ComboBoxItem daireSecimi = DaireSeçim.SelectedItem as FormControl.ComboBoxItem;
            if (formControl.TextBoxesAreEmpty(this))
            {
                new Borclar().Ekle(BorcTuruTextBox.Text, BorcAdiTextBox.Text, FaturaTarihi.Value.ToShortDateString(),
                FaturaTutariTextBox.Text, FaturaNoTextBox.Text, false, FaturaAciklamasiTextBox.Text, daireSecimi);
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
        }
        

    }

}
