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
    
    public partial class URUN
    {
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public Nullable<int> URUNGRUPID { get; set; }
        public Nullable<int> BIRIM { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<int> KUR { get; set; }
        public Nullable<decimal> GIREN { get; set; }
        public Nullable<decimal> CIKAN { get; set; }
        public Nullable<decimal> KALAN { get; set; }
        public Nullable<byte> KDV { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual BIRIM BIRIM1 { get; set; }
        public virtual PERSONEL PERSONEL1 { get; set; }
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual URUNGRUP URUNGRUP { get; set; }
    }
}
