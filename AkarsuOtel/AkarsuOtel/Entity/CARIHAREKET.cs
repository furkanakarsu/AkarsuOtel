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
    
    public partial class CARIHAREKET
    {
        public int CARIHAREKETID { get; set; }
        public Nullable<int> CARIID { get; set; }
        public Nullable<int> ISLEMID { get; set; }
        public string BELGENO { get; set; }
        public Nullable<int> KUR { get; set; }
        public Nullable<decimal> NAKIT { get; set; }
        public Nullable<decimal> KREDIKARTI { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual CARI CARI { get; set; }
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual ISLEM ISLEM { get; set; }
        public virtual KURLAR KURLAR { get; set; }
        public virtual PERSONEL PERSONEL1 { get; set; }
    }
}
