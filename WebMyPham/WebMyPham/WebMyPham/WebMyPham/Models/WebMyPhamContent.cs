namespace WebMyPham.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebMyPhamContent : DbContext
    {
        public WebMyPhamContent()
            : base("name=WebMyPhamContent")
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.idsp)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.tendanhmuc)
                .IsFixedLength();

            modelBuilder.Entity<DonHang>()
                .Property(e => e.idsp)
                .IsFixedLength();

            modelBuilder.Entity<DonHang>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangSX>()
                .Property(e => e.idhangsx)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.diachi)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSanPham>()
                .Property(e => e.idloaisp)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.idsp)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.idloaisp)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);
        }
    }
}
