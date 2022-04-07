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
    public partial class KomsuDuzenlemeListesi : Form
    {
        public KomsuDuzenlemeListesi()
        {
            InitializeComponent();
            ListeDoldur();
        }
        private void ListeDoldur()
        {
            var list = new Komsu().KomsulariGetir().Where(x => x.Id != GirisEkrani.user.Id);

            foreach (var item in list)
            {
                KomsuiList.Rows.Add(item.Id, item.Adi + " " + item.Soyadi, item.Adres1.BinaNo + "/" + item.Adres1.DaireNo, item.Mail);
            }
        }

        private void KomsuiList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new KomsuDüzenle((int)KomsuiList.Rows[e.RowIndex].Cells[0].Value).Show();
        }
    }
}
