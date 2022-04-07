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
            int daireSecimIndex = DaireSeçim.SelectedIndex;
            FormControl formControl = new FormControl();
            FormControl.ComboBoxItem daireSecimi = DaireSeçim.SelectedItem as FormControl.ComboBoxItem;
            int kullaniciId = (int)daireSecimi.Value;
            decimal faturaTutari = Convert.ToDecimal(FaturaTutariTextBox.Text.Remove(0, 1));

            if (formControl.TextBoxesAreEmpty(this) & daireSecimIndex != -1)
            {
                new Borclar().Ekle(BorcTuruTextBox.Text, BorcAdiTextBox.Text, FaturaTarihi.Value.ToShortDateString(),
                faturaTutari, FaturaNoTextBox.Text, false, FaturaAciklamasiTextBox.Text, kullaniciId);
            }
            if (daireSecimIndex == -1)
            {
                UyariLabel.Text = "* Daire seçimi yapmadınız!";
            }
            formControl.TexboxClear(this);

        }

        private void FaturaTutariTextBox_Leave(object sender, EventArgs e)
        {
            new FormControl().ParaBirimi(FaturaTutariTextBox);
        }

    }

}
