using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimSistemi.Entities;
namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    internal class BinaAidatBilgileri
    {
        public Aidatlar Getir()
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var sorgu = from aidat in db.Aidatlar
                        where aidat.SiteBinaId == GirisEkrani.user.Adres1.SiteBina
                        select aidat;
            if (sorgu.Count() == 0)
            {
                return new Aidatlar { Id = -1 };
            }
            else
            {
                return sorgu.FirstOrDefault();
            }
        }
        public void Ekle(int siteBinaId, decimal aidatTutari, int aidatGunu)
        {
            BinaYonetimSistemiEntities db = new BinaYonetimSistemiEntities();

            var aidat = Getir();
            if (aidat.Id == -1)
            {
                Aidatlar aidatlar = new Aidatlar();

                aidatlar.AidatTutari = aidatTutari;
                aidatlar.AidatGunu = aidatGunu;
                aidatlar.SiteBinaId = siteBinaId;

                db.Aidatlar.Add(aidatlar);
                db.SaveChanges();
            }
            else
            {
                var sorgu = from _aidat in db.Aidatlar
                            where _aidat.SiteBinaId == GirisEkrani.user.Adres1.SiteBina
                            select _aidat;

                var guncelAidat = sorgu.FirstOrDefault();
                guncelAidat.AidatGunu = aidatGunu;
                guncelAidat.AidatTutari = aidatTutari;
                db.SaveChanges();
            }

            
        }

    }
}
