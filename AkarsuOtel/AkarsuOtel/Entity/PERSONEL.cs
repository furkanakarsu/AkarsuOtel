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
    
    public partial class PERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONEL()
        {
            this.BANKAHAREKET = new HashSet<BANKAHAREKET>();
            this.CARIHAREKET = new HashSet<CARIHAREKET>();
            this.CARIKONUKHAREKET = new HashSet<CARIKONUKHAREKET>();
            this.KASAHAREKET = new HashSet<KASAHAREKET>();
            this.URUN = new HashSet<URUN>();
        }
    
        public int PERSONELID { get; set; }
        public string ADSOYAD { get; set; }
        public string PERSONELTC { get; set; }
        public string ADRES { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string KANGRUBU { get; set; }
        public Nullable<System.DateTime> ISEGIRISTARIHI { get; set; }
        public Nullable<System.DateTime> ISTENCIKISTARIHI { get; set; }
        public Nullable<int> DEPARTMAN { get; set; }
        public Nullable<int> GOREV { get; set; }
        public string YETKI { get; set; }
        public string SIFRE { get; set; }
        public string KIMLIKON { get; set; }
        public string KIMLIKARKA { get; set; }
        public string EHLIYET { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANKAHAREKET> BANKAHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARIHAREKET> CARIHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARIKONUKHAREKET> CARIKONUKHAREKET { get; set; }
        public virtual DEPARTMAN DEPARTMAN1 { get; set; }
        public virtual DURUM DURUM1 { get; set; }
        public virtual GOREV GOREV1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KASAHAREKET> KASAHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<URUN> URUN { get; set; }
    }
}