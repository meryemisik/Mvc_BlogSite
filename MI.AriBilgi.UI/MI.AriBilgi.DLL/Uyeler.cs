//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MI.AriBilgi.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uyeler
    {
        public int Id { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSifre { get; set; }
        public bool Yazarmi { get; set; }
        public Nullable<System.DateTime> UyelikTarih { get; set; }
        public bool Aktifmi { get; set; }
        public int YetkiId { get; set; }
    }
}
