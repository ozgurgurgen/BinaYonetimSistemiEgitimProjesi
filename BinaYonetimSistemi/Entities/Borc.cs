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
    
    public partial class Borc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Borc()
        {
            this.KasaGeçmişi = new HashSet<KasaGeçmişi>();
            this.KullaniciBorc = new HashSet<KullaniciBorc>();
        }
    
        public int Id { get; set; }
        public string BorcTuru { get; set; }
        public string BorcAdi { get; set; }
        public string BorcAciklamasi { get; set; }
        public string BorcTarihi { get; set; }
        public string FaturaTarihi { get; set; }
        public string FaturaNo { get; set; }
        public decimal FaturaTutari { get; set; }
        public decimal KisiBasinaDusenTutar { get; set; }
        public Nullable<bool> KasadanOdenecek { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KasaGeçmişi> KasaGeçmişi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciBorc> KullaniciBorc { get; set; }
    }
}
