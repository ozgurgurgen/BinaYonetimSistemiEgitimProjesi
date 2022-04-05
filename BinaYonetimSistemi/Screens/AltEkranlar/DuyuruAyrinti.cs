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
    public partial class DuyuruAyrinti : Form
    {
        public DuyuruAyrinti()
        {
            InitializeComponent();
        }
        public DuyuruAyrinti(int duyuruId)
        {
            InitializeComponent();
            FormDoldur(duyuruId);
        }

        private void FormDoldur(int duyuruId)
        {
            var duyuru = new Duyuru().Getir(duyuruId);
            string[] duyuruTarihi = duyuru.DuyuruTarihi.Split(' ');
            BaslikLabel.Text = duyuru.DuyuruBasligi;
            DuyuruTarihiLabel.Text = duyuruTarihi[0];
            DuyuruSaatiLabel.Text = duyuruTarihi[1];
            DuyuruBitisTarihiLabel.Text = duyuru.DuyuruBitisTarihi;
            DuyuruMetniTextBox.Text = duyuru.DuyuruAciklamasi;
        }
    }
}
