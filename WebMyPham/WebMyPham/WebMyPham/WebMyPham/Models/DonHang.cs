namespace WebMyPham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iddonhang { get; set; }

        public int? idKH { get; set; }

        [StringLength(10)]
        public string idsp { get; set; }

        public int? soluong { get; set; }

        [StringLength(50)]
        public string mota { get; set; }

        public bool? trangthai { get; set; }

        [StringLength(50)]
        public string kieuthanhtoan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayxuat { get; set; }

        public decimal? tongtien { get; set; }

        public int? idnv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
