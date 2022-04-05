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
    public partial class YeniDuyuru : Form
    {
        public YeniDuyuru()
        {
            InitializeComponent();
        }

        private void DuyuruOlusturButon_Click(object sender, EventArgs e)
        {

            if (new FormControl().TextBoxesAreEmpty(this))
            {
                new Duyuru().Ekle(DuyuruBasligiTextBox.Text, DuyuruMetniRichTextBox.Text, DuyuruBaslangic.Value.ToString(), DuyuruBitis.Value.ToShortDateString());
                new FormControl().TexboxClear(this);
            }
        }
    }
}
