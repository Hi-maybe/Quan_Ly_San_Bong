//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySanBanh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSan
    {
        public string MaCTS { get; set; }
        public string MaSan { get; set; }
        public string SoSan { get; set; }
    
        public virtual San San { get; set; }
    }
}
