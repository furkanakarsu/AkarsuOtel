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
    
    public partial class BANKAHAREKET
    {
        public int BANKAHAREKETID { get; set; }
        public Nullable<int> HESAPID { get; set; }
        public string DEKONT { get; set; }
        public Nullable<decimal> GIREN { get; set; }
        public Nullable<decimal> CIKAN { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> ISLEMID { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual BANKA BANKA { get; set; }
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual ISLEM ISLEM { get; set; }
        public virtual PERSONEL PERSONEL1 { get; set; }
    }
}
