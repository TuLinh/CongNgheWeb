namespace WebMyPham.Models
{
    using Microsoft.Ajax.Utilities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("SanPham")]
    public partial class SanPham
    {
        WebMyPhamContent db = null;
        private WebMyPhamContent context = null;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(10)]
        public string idsp { get; set; }

        [StringLength(250)]
        public string tensp { get; set; }

        [StringLength(10)]
        public string idloaisp { get; set; }

        [StringLength(250)]
        public string mota { get; set; }

        public int giaban { get; set; }

        public int soluong { get; set; }

        public double giamgia { get; set; }

        [StringLength(50)]
        public string hinhanh { get; set; }

        [StringLength(50)]
        public string trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public List<SanPham> ListAll()
        {
            var list = context.Database.SqlQuery<SanPham>("sp").ToList();
            return list;
        }


        public SanPham ViewDetail(string id)
        {
            return db.SanPhams.Find(id);
        }
        

    }
}
