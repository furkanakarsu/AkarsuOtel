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
    
    public partial class BIRIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BIRIM()
        {
            this.URUN = new HashSet<URUN>();
        }
    
        public int BIRIMID { get; set; }
        public string BIRIMAD { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual DURUM DURUM1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<URUN> URUN { get; set; }
    }
}
