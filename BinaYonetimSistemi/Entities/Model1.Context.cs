﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BinaYonetimSistemi.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BinaYonetimSistemiEntities : DbContext
    {
        public BinaYonetimSistemiEntities()
            : base("name=BinaYonetimSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Borc> Borc { get; set; }
        public virtual DbSet<Duyurular> Duyurular { get; set; }
        public virtual DbSet<Kasa> Kasa { get; set; }
        public virtual DbSet<KasaGeçmişi> KasaGeçmişi { get; set; }
        public virtual DbSet<KullaniciBorc> KullaniciBorc { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<SiteBina> SiteBina { get; set; }
        public virtual DbSet<Aidatlar> Aidatlar { get; set; }
    }
}
