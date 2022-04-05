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
    public partial class KasaHareketleri : Form
    {
        public KasaHareketleri()
        {
            InitializeComponent();
            Controller.Kasa kasa = new Controller.Kasa();
            var kasaHareketleri = kasa.HareketleriGetir();
            ToplamKasaLabel.Text = new Controller.AnaSayfa().KasaTutari();


            for (int i = 0; i < kasaHareketleri.Count; i++)
            {
                string isim;
                if (kasaHareketleri[i].KullaniciId == null)
                {
                    isim = "Kasa";
                }
                else
                {
                    isim = kasaHareketleri[i].Kullanicilar.Adi + " " + kasaHareketleri[i].Kullanicilar.Soyadi;
                }
                KasaHareketleriList.Rows.Add(kasaHareketleri[i].Id, isim, kasaHareketleri[i].Borc.BorcTarihi, kasaHareketleri[i].Borc.FaturaTutari + " ₺", kasaHareketleri[i].Borc.KasadanOdenecek);

                DataGridViewCellStyle style = new DataGridViewCellStyle();


                if (KasaHareketleriList.Rows[i].Cells[4].Value.ToString() == "False")
                {
                    style.BackColor = Color.Green;
                    style.ForeColor = Color.White;
                }
                else
                {
                    style.BackColor = Color.Red;
                    style.ForeColor = Color.White;
                }
                KasaHareketleriList.Rows[i].DefaultCellStyle = style;
            }




        }

        private void KasaHareketleriList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = KasaHareketleriList.Rows[rowIndex];

            int kasaGecmisiId = int.Parse(row.Cells[0].Value.ToString());
            new KasaHareketAyrinti(kasaGecmisiId).Show();
        }

    }
}
