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
    
    public partial class KullaniciBorc
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int BorcId { get; set; }
        public string OdemeZamani { get; set; }
    
        public virtual Borc Borc { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
