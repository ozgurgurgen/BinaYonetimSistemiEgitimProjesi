using BinaYonetimSistemi.Controller;
using BinaYonetimSistemi.Entities;
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
    public partial class BorcluAyrinti : Form
    {
        int _borcId;
        int seciliSatir;
        public BorcluAyrinti()
        {
            InitializeComponent();
        }
        public BorcluAyrinti(string ad, int kullaniciId, List<KullaniciBorc> borcluListesi, string binaDaireNo)
        {
            InitializeComponent();
            FormDoldur(ad, kullaniciId, borcluListesi, binaDaireNo);
        }
        private void FormDoldur(string ad, int kullaniciId, List<KullaniciBorc> borcluListesi, string binaDaireNo)
        {
            AdTextBox.Text = ad;
            BinaDaireTextBox.Text = binaDaireNo;
            var liste = borcluListesi.Where(x => x.KullaniciId == kullaniciId).Select(x => x.Borc).ToList();

            for (int i = 0; i < liste.Count; i++)
            {
                BorcList.Rows.Add(liste[i].Id, liste[i].BorcTuru, liste[i].BorcAdi, liste[i].BorcTarihi, liste[i].FaturaTutari + " ₺");

            }

        }

        private void BorcList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            seciliSatir = e.RowIndex;
            _borcId = (int)BorcList.Rows[seciliSatir].Cells[0].Value;
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            Console.WriteLine(_borcId);
            if (_borcId != 0)
            {
                new Borclar().Sil(_borcId);
                BorcList.Rows.RemoveAt(seciliSatir);
                _borcId = 0;                
            }
            else
            {
                this.Close();                
            }
            
            
        }
    }
}
