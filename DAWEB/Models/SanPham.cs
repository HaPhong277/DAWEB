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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.DatHang = new HashSet<DatHang>();
        }
    
        public int Id { get; set; }
        public string images { get; set; }
        public string Name { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<int> IdSP { get; set; }
        public string Mota { get; set; }
        public Nullable<int> TB { get; set; }
    
        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang> DatHang { get; set; }
    }
}