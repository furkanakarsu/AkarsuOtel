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
    
    public partial class ODALAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ODALAR()
        {
            this.CARIKONUKHAREKET = new HashSet<CARIKONUKHAREKET>();
            this.REZERVASYON = new HashSet<REZERVASYON>();
        }
    
        public int ODAID { get; set; }
        public string ODANO { get; set; }
        public string KAT { get; set; }
        public string KAPASITE { get; set; }
        public string OZELLIK { get; set; }
        public string ACIKLAMA { get; set; }
        public string TELEFON { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARIKONUKHAREKET> CARIKONUKHAREKET { get; set; }
        public virtual DURUM DURUM1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REZERVASYON> REZERVASYON { get; set; }
    }
}
