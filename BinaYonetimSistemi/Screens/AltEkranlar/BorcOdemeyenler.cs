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
    public partial class BorcOdemeyenler : Form
    {
        public BorcOdemeyenler()
        {
            InitializeComponent();
            FormDoldur();
        }

        private void FormDoldur()
        {
            var borclu = new Borclar().BorcluGetir().GroupBy(x => x.KullaniciId).ToList();

            for (int i = 0; i < borclu.Count; i++)
            {
                //BorcluList.Rows.Add(1,borclu[i].Key, borclu.);
            }
        }
    }
}
