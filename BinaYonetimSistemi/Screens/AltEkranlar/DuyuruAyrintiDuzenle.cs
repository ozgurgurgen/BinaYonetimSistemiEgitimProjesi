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
    public partial class DuyuruAyrintiDuzenle : Form
    {
        int duyuruId;
        public DuyuruAyrintiDuzenle()
        {
            InitializeComponent();
        }

        public DuyuruAyrintiDuzenle(int duyuruId)
        {
            this.duyuruId = duyuruId;
            InitializeComponent();
            FormDoldur(duyuruId);
        }
        private void FormDoldur(int duyuruId)
        {
            var duyuru = new Duyuru().Getir(duyuruId);
            string[] duyuruTarihi = duyuru.DuyuruTarihi.Split(' ');
            DuyuruBasligiTextBox.Text = duyuru.DuyuruBasligi;
            DuyuruTarihiPicker.Text = duyuruTarihi[0];
            DuyuruSaatiPicker.Text = duyuruTarihi[1];
            DuyuruBitisTarihiPicker.Text = duyuru.DuyuruBitisTarihi;
            DuyuruMetniTextBox.Text = duyuru.DuyuruAciklamasi;

        }

        private void DeğikilikKaydetButon_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(  + " " + DuyuruSaatiPicker.Text);
            new Duyuru().Guncelle(duyuruId, DuyuruBasligiTextBox.Text, DuyuruMetniTextBox.Text,
                DuyuruTarihiPicker.Value.ToShortDateString() + " " + DuyuruSaatiPicker.Text, DuyuruBitisTarihiPicker.Value.ToShortDateString());
            new Tamamlandi("Duyuru Değişikliği Başarılı Şekilde Kaydedildi").Show();
        }
    }
}
