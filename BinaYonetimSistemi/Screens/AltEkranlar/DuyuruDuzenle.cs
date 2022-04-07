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
    public partial class DuyuruDuzenle : Form
    {
        int duyuruId;
        int secilenSatir;
        public DuyuruDuzenle()
        {
            InitializeComponent();
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            var liste = new Duyuru().ListeGetir();

            foreach (var item in liste)
            {
                DuyuruList.Rows.Add(item.Id, item.DuyuruBasligi, item.DuyuruTarihi,item.DuyuruBitisTarihi);
            }
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            new Duyuru().Sil(duyuruId);
            DuyuruList.Rows.RemoveAt(secilenSatir);
        }

        private void DuyuruList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            secilenSatir = e.RowIndex;
            duyuruId = (int)DuyuruList.Rows[secilenSatir].Cells[0].Value;
            
        }

        private void DuyuruList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new DuyuruAyrintiDuzenle((int)DuyuruList.Rows[e.RowIndex].Cells[0].Value).Show();
        }

        private void DuyuruDuzenle_Activated(object sender, EventArgs e)
        {
            DuyuruList.Rows.Clear();
            ListeDoldur();
        }
    }
}
