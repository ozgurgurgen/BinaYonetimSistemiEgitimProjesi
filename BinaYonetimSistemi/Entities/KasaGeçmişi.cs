//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class KasaGeçmişi
    {
        public int Id { get; set; }
        public string HareketTutarı { get; set; }
        public Nullable<int> BorcId { get; set; }
        public Nullable<int> SiteBinaId { get; set; }
        public Nullable<bool> GelirMi { get; set; }
        public string HareketTarihi { get; set; }
    
        public virtual SiteBina SiteBina { get; set; }
    }
}
