//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AkarsuOtel.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARI()
        {
            this.CARIHAREKET = new HashSet<CARIHAREKET>();
            this.CARIKONUKHAREKET = new HashSet<CARIKONUKHAREKET>();
            this.REZERVASYON = new HashSet<REZERVASYON>();
        }
    
        public int CARIID { get; set; }
        public string CARIADSOYAD { get; set; }
        public string CARIADRES { get; set; }
        public string CARITC { get; set; }
        public string VERGIDAIRESI { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string KIMLIKFOTO1 { get; set; }
        public string KIMLIKFOTO2 { get; set; }
        public Nullable<int> CARITUR { get; set; }
        public string YETKILI { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> UYRUK { get; set; }
        public Nullable<decimal> BAKIYE { get; set; }
        public Nullable<int> DURUM { get; set; }
        public string VERGINO { get; set; }
    
        public virtual CARITUR CARITUR1 { get; set; }
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual UYRUK UYRUK1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARIHAREKET> CARIHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARIKONUKHAREKET> CARIKONUKHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REZERVASYON> REZERVASYON { get; set; }
    }
}
