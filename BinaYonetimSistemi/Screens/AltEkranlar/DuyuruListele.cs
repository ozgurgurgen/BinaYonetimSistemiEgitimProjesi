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
    public partial class DuyuruListele : Form
    {
        public DuyuruListele()
        {
            InitializeComponent();
            DuyurulariGetir();
        }

        private void DuyurulariGetir()
        {
            Duyuru duyurular = new Duyuru();

            ToplamDuyuruLabel.Text = new Controller.AnaSayfa().DuyuruSayisi().ToString();

            for (int i = 0; i < duyurular.ListeGetir().Count; i++)
            {
                int kalanGunFonksiyonDonus = GunHesapla(duyurular.ListeGetir()[i].DuyuruBitisTarihi);
                string kalanGun;

                DataGridViewCellStyle style = new DataGridViewCellStyle();


                if (kalanGunFonksiyonDonus > 0)
                {
                    style.BackColor = Color.FromArgb(69, 128, 99);
                    style.ForeColor = Color.White;
                    kalanGun = kalanGunFonksiyonDonus + " Gün";
                }
                else if (kalanGunFonksiyonDonus == 0)
                {
                    style.BackColor = Color.FromArgb(69, 128, 99);
                    style.ForeColor = Color.White;
                    kalanGun = "Son Gün";
                }
                else
                {
                    style.BackColor = Color.FromArgb(163, 163, 163);
                    style.ForeColor = Color.DimGray;
                    kalanGun = "Duyuru Zamanı Doldu";
                }

                DuyuruList.Rows.Add(duyurular.ListeGetir()[i].Id, duyurular.ListeGetir()[i].DuyuruBasligi, duyurular.ListeGetir()[i].DuyuruTarihi, kalanGun);

                //Satır renklendirme

                DuyuruList.Rows[i].DefaultCellStyle = style;
            }

        }

        private int GunHesapla(string bitisTarihi)
        {
            DateTime bitis = Convert.ToDateTime(bitisTarihi);
            DateTime simdi = DateTime.Now.Date;
            int kalanGun;
            if (simdi <= bitis)
            {
                TimeSpan gun = bitis - simdi;
                kalanGun = (int)gun.TotalDays;
            }
            else
            {
                kalanGun = -1;
            }
            Console.WriteLine(kalanGun);
            return kalanGun;
        }

        private void DuyuruList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = DuyuruList.Rows[rowIndex];

            int duyuruId = int.Parse(row.Cells[0].Value.ToString());
            new DuyuruAyrinti(duyuruId).Show();
        }

    }
}
