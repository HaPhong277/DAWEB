//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAWEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatHang
    {
        public int Id { get; set; }
        public Nullable<int> IdSanPham { get; set; }
        public Nullable<System.DateTime> ThoiGianDat { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<int> IdTrangThai { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual TrangThai TrangThai { get; set; }
    }
}