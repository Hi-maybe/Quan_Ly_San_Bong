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
    
    public partial class DatSan
    {
        public string MaDS { get; set; }
        public string MaCTS { get; set; }
        public string MaTK { get; set; }
        public Nullable<System.DateTime> NgayDenSan { get; set; }
        public Nullable<int> GioBatDau { get; set; }
        public Nullable<int> GioKetThuc { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ChiTietSan ChiTietSan { get; set; }
    }
}