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
    
    public partial class San
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San()
        {
            this.BangGiaSans = new HashSet<BangGiaSan>();
            this.ChiTietSans = new HashSet<ChiTietSan>();
        }
    
        public string MaSan { get; set; }
        public string TenSan { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> SoLuongSan { get; set; }
        public string AnhSan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangGiaSan> BangGiaSans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSan> ChiTietSans { get; set; }
    }
}