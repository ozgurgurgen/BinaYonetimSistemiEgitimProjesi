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
    public partial class BorcOdemeyenler : Form
    {
        List<Borclar.BorcluKullanici> borcluKullanicilar;

        public BorcOdemeyenler()
        {
            InitializeComponent();
            FormDoldur();
        }

        private void FormDoldur()
        {
            borcluKullanicilar = new Borclar().BorcluGetir();

            for (int i = 0; i < borcluKullanicilar.Count; i++)
            {
                var id = borcluKullanicilar[i].id;
                string binaDaireNo = borcluKullanicilar[i].borc.Find(x => x.Kullanicilar.Id == id).Kullanicilar.Adres1.BinaNo + "/" + borcluKullanicilar[i].borc.Find(x => x.Kullanicilar.Id == id).Kullanicilar.Adres1.DaireNo;
                string adi = borcluKullanicilar[i].borc.Find(x => x.Kullanicilar.Id == id).Kullanicilar.Adi + " " + borcluKullanicilar[i].borc.Find(x => x.Kullanicilar.Id == id).Kullanicilar.Soyadi;
                var borcAdedi = borcluKullanicilar[i].borc.Count();
                string borcu = borcluKullanicilar[i].borc.Sum(x => x.Borc.FaturaTutari) + " ₺";

                BorcluList.Rows.Add(id,adi,binaDaireNo,borcAdedi,borcu);

            }


        }

        private void BorcluList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string borcluAdi = BorcluList.Rows[e.RowIndex].Cells[1].Value.ToString();
            string binaDaire = BorcluList.Rows[e.RowIndex].Cells[2].Value.ToString();
            int kullaniciBorcId = (int)BorcluList.Rows[e.RowIndex].Cells[0].Value;
            List<KullaniciBorc> borcListesi = borcluKullanicilar.Find(x => x.id == kullaniciBorcId).borc;
            new BorcluAyrinti(borcluAdi, kullaniciBorcId, borcListesi, binaDaire).Show();



        }

        private void YenileButon_Click(object sender, EventArgs e)
        {
            BorcluList.Rows.Clear();
            FormDoldur();
        }
    }
}
