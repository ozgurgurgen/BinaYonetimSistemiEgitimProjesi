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
    public partial class Tamamlandi : Form
    {
        public Tamamlandi()
        {
            InitializeComponent();
        }
        public Tamamlandi (string mesaj)
        {
            InitializeComponent();
            MesajLabel.Text = mesaj;
        }
                
        private void TamamButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
