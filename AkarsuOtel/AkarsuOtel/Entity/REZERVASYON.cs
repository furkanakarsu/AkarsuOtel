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
    
    public partial class REZERVASYON
    {
        public int REZERVASYONID { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<System.DateTime> GIRISTARIHI { get; set; }
        public Nullable<System.DateTime> CIKISTARIHI { get; set; }
        public string KISISAYISI { get; set; }
        public Nullable<int> ODA { get; set; }
        public string REZERVASYONADSOYAD { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual CARI CARI1 { get; set; }
        public virtual DURUM DURUM1 { get; set; }
        public virtual ODALAR ODALAR { get; set; }
    }
}