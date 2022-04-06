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
    public partial class KomsuListesi : Form
    {
        public KomsuListesi()
        {
            InitializeComponent();
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            var list = new Komsu().KomsuGetir().Where(x => x.Id != GirisEkrani.user.Id);

            foreach (var item in list)
            {
                KomsuiList.Rows.Add(item.Id, item.Adi + " " + item.Soyadi, item.Adres1.BinaNo + "/" + item.Adres1.DaireNo, item.Mail);
            }
        }
    }
}
