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
    
    public partial class BANKA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANKA()
        {
            this.BANKAHAREKET = new HashSet<BANKAHAREKET>();
        }
    
        public int BANKAID { get; set; }
        public string SUBE { get; set; }
        public string BANKAADI { get; set; }
        public string IBAN { get; set; }
        public Nullable<int> KUR { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual KURLAR KURLAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANKAHAREKET> BANKAHAREKET { get; set; }
    }
}
