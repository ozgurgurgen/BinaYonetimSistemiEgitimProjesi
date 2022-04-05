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
            DataGridDoldur();
        }
        private void DataGridDoldur()
        {
            Borclar borclar = new Borclar();
            BorcListesi.DataSource = borclar.Getir();

            this.BorcListesi.Columns[2].Visible = false;
            this.BorcListesi.Columns[3].Visible = false;
            this.BorcListesi.Columns[5].Visible = false;
            this.BorcListesi.Columns[8].Visible = false;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();


            if (BorcListesi.Rows[e.RowIndex].Cells[7].Value != null)
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
            new BorcAyrinti(int.Parse(row.Cells[8].Value.ToString())).Show();

        }
    }
}
