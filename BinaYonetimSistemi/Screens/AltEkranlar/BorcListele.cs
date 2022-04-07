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
    public partial class BorcListele : Form
    {
        public BorcListele()
        {
            InitializeComponent();
            
        }
        private void DataGridDoldur()
        {
            var borclar = new Borclar().Getir();
            foreach (var borc in borclar)
            {
                BorcListesi.Rows.Add(borc.Id, borc.Borc.FaturaNo, borc.Borc.BorcTuru, 
                    borc.Borc.FaturaTutari + "₺", borc.Borc.BorcTarihi, borc.OdemeZamani);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();


            if (BorcListesi.Rows[e.RowIndex].Cells[5].Value != null)
            {
                style.BackColor = Color.FromArgb(69, 128, 99);
                style.ForeColor = Color.White;                
            }
            else
            {
                style.BackColor = Color.FromArgb(245, 98, 98);
                style.ForeColor = Color.White;
            }
            BorcListesi.Rows[e.RowIndex].DefaultCellStyle = style;

        }

        private void BorcListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = BorcListesi.Rows[rowIndex];
            new BorcAyrinti(int.Parse(row.Cells[0].Value.ToString())).Show();

        }

        private void BorcListele_Activated(object sender, EventArgs e)
        {
            BorcListesi.Rows.Clear();
            DataGridDoldur();
        }
    }
}
