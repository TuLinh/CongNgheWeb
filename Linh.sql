USE [master]
GO
/****** Object:  Database [WebMyPham]    Script Date: 6/24/2018 10:47:36 AM ******/
CREATE DATABASE [WebMyPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebMyPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\WebMyPham.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WebMyPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\WebMyPham_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WebMyPham] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebMyPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebMyPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebMyPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebMyPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebMyPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebMyPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebMyPham] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WebMyPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebMyPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebMyPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebMyPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebMyPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebMyPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebMyPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebMyPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebMyPham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WebMyPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebMyPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebMyPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebMyPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebMyPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebMyPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebMyPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebMyPham] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WebMyPham] SET  MULTI_USER 
GO
ALTER DATABASE [WebMyPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebMyPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebMyPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebMyPham] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WebMyPham] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WebMyPham]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[iddonhang] [int] NOT NULL,
	[idsp] [nchar](10) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[iddonhang] ASC,
	[idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[idchucvu] [int] NOT NULL,
	[tenchucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[idchucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[iddanhmuc] [int] NOT NULL,
	[tendanhmuc] [nchar](10) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[iddanhmuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[iddonhang] [int] NOT NULL,
	[idKH] [int] NULL,
	[idsp] [nchar](10) NULL,
	[soluong] [int] NULL,
	[mota] [nvarchar](50) NULL,
	[trangthai] [bit] NULL,
	[kieuthanhtoan] [nvarchar](50) NULL,
	[ngayxuat] [date] NULL,
	[tongtien] [decimal](18, 0) NULL,
	[idnv] [int] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[iddonhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangSX]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSX](
	[idhangsx] [nchar](10) NOT NULL,
	[tenhang] [nvarchar](50) NULL,
	[website] [nvarchar](50) NULL,
	[lienhe] [nvarchar](50) NULL,
	[mota] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangSX] PRIMARY KEY CLUSTERED 
(
	[idhangsx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKH] [int] NOT NULL,
	[tenKH] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[sdt] [text] NULL,
	[diachi] [text] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[idKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[idloaisp] [nchar](10) NOT NULL,
	[tenloai] [nvarchar](250) NULL,
	[tieudengan] [nvarchar](250) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[idloaisp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[username] [nvarchar](50) NULL,
	[password] [varchar](50) NULL,
	[quyen] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idnv] [int] NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[sdt] [int] NULL,
	[email] [varchar](50) NULL,
	[ngaysinh] [date] NULL,
	[idchucvu] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[idnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idsp] [nchar](10) NOT NULL,
	[tensp] [nvarchar](250) NULL,
	[idloaisp] [nchar](10) NULL,
	[mota] [nvarchar](250) NULL,
	[giaban] [int] NULL,
	[soluong] [int] NULL,
	[giamgia] [float] NULL,
	[hinhanh] [nvarchar](50) NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DonHang] ([iddonhang], [idKH], [idsp], [soluong], [mota], [trangthai], [kieuthanhtoan], [ngayxuat], [tongtien], [idnv]) VALUES (1, 1, N'1         ', 2, NULL, 1, N'tiền mặt', CAST(N'2018-12-02' AS Date), NULL, NULL)
INSERT [dbo].[HangSX] ([idhangsx], [tenhang], [website], [lienhe], [mota]) VALUES (N'1         ', N'kose
', N'kose
.com', N'(08)124612', N'Nhãn hàng nổi tiếng tại Nhật')
INSERT [dbo].[HangSX] ([idhangsx], [tenhang], [website], [lienhe], [mota]) VALUES (N'2         ', N'Innisfree', N'Innisfree.com', N'(08)124612', N'Nhãn hàng nổi tiếng tại Pháp')
INSERT [dbo].[HangSX] ([idhangsx], [tenhang], [website], [lienhe], [mota]) VALUES (N'3         ', N'Mamonde', N'Mamonde.com', N'(08)124612', N'Nhãn hàng nổi tiếng tại Hàn')
INSERT [dbo].[HangSX] ([idhangsx], [tenhang], [website], [lienhe], [mota]) VALUES (N'4         ', N'Laneige', N'Laneige.com', N'(08)124612', N'Nhãn hàng nổi tiếng tại Pháp')
INSERT [dbo].[HangSX] ([idhangsx], [tenhang], [website], [lienhe], [mota]) VALUES (N'5         ', N'Ant Blemith', N'Antiblemith.com', NULL, NULL)
INSERT [dbo].[KhachHang] ([idKH], [tenKH], [ngaysinh], [sdt], [diachi]) VALUES (1, N'Mai Thị Linh', CAST(N'1996-02-08' AS Date), N'0985447015', N'Thanh Hóa')
INSERT [dbo].[KhachHang] ([idKH], [tenKH], [ngaysinh], [sdt], [diachi]) VALUES (2, N'Đào Thanh Tú', CAST(N'1997-05-12' AS Date), N'0932523515', N'Thanh Hóa')
INSERT [dbo].[KhachHang] ([idKH], [tenKH], [ngaysinh], [sdt], [diachi]) VALUES (3, N'Nguyễn Văn Hoàng', CAST(N'1994-03-26' AS Date), N'0974109372', N'Nam Ð?nh')
INSERT [dbo].[KhachHang] ([idKH], [tenKH], [ngaysinh], [sdt], [diachi]) VALUES (4, N'Nguyễn Thị Linh', CAST(N'1997-12-12' AS Date), N'0923583251', N'Son La')
INSERT [dbo].[LoaiSanPham] ([idloaisp], [tenloai], [tieudengan]) VALUES (N'1         ', N'Làm sạch da', N'agd')
INSERT [dbo].[LoaiSanPham] ([idloaisp], [tenloai], [tieudengan]) VALUES (N'2         ', N'Chăm sóc da', N'sdahgfdb')
INSERT [dbo].[LoaiSanPham] ([idloaisp], [tenloai], [tieudengan]) VALUES (N'3         ', N'Trang điểm', N'sdbfmngh')
INSERT [dbo].[LoaiSanPham] ([idloaisp], [tenloai], [tieudengan]) VALUES (N'4         ', N'Chăm sóc tóc', N'fzdhngm')
INSERT [dbo].[LoaiSanPham] ([idloaisp], [tenloai], [tieudengan]) VALUES (N'5         ', N'Chăm sóc toàn thân', N'djfdhm')
INSERT [dbo].[LoaiSanPham] ([idloaisp], [tenloai], [tieudengan]) VALUES (N'6         ', N'Phụ kiện', N'djnfm')
INSERT [dbo].[NguoiDung] ([username], [password], [quyen]) VALUES (N'mailinh', N'mailinh123', N'admin')
INSERT [dbo].[NguoiDung] ([username], [password], [quyen]) VALUES (N'admin', N'admin123', N'khachhang')
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'1         ', N'Kem chống nắng', N'2         ', N'Tốt', 240, 2, 0, N'001.jpg', N'còn hàng')
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'2         ', N'Toner', N'1         ', N'Tốt', 360, 1, 0, N'002.jpg', N'còn hàng')
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'3         ', N'Kem dưỡng da', N'3         ', N'Tốt', 360, 2, 0, N'003.jpg', N'còn hàng')
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'4         ', N'Kem dưỡng da', N'2         ', N'Tốt', 240, 4, 0, N'004.jpg', N'còn hàng')
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'5         ', N' Sữa rửa mặt Cetaphil Gentle Skin Cleanser ', N'1         ', N'Chăm sóc da mụn, giúp làm khô nhân mụn', 98, 0, 0, N'srm01.jpg', N'hết hàng')
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'6         ', N'Tinh chất dưỡng da VICHY IDÉALIA', N'2         ', N' cải thiện độ xỉn màu của làn da', 120, 1, 0, N'tc.jpg', NULL)
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'7         ', N'Kem Lót Kiềm Dầu Innisfree No Sebum Primer', N'3         ', N'có khả năng giúp làm mịn lớp nền', 190, 1, 0, N'i1.jpg', NULL)
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'8         ', N'NULCIRACLE ANTI BLEMISH AQUA CREAML', N'2         ', N' Chiết xuất từ tinh dầu chanh và lô hội', 330, 2, 0, N'02.jpg', NULL)
INSERT [dbo].[SanPham] ([idsp], [tensp], [idloaisp], [mota], [giaban], [soluong], [giamgia], [hinhanh], [trangthai]) VALUES (N'9         ', N'A''PIEU WILD MATT LIPSTICK ', N'2         ', N'son lì đang được ưa chuộng', 112, 2, 0, N'son1.jpg', NULL)
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([iddonhang])
REFERENCES [dbo].[DonHang] ([iddonhang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham] FOREIGN KEY([idsp])
REFERENCES [dbo].[SanPham] ([idsp])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_NhanVien] FOREIGN KEY([idnv])
REFERENCES [dbo].[NhanVien] ([idnv])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_NhanVien]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_SanPham] FOREIGN KEY([idsp])
REFERENCES [dbo].[SanPham] ([idsp])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_SanPham]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([idchucvu])
REFERENCES [dbo].[ChucVu] ([idchucvu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([idloaisp])
REFERENCES [dbo].[LoaiSanPham] ([idloaisp])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
/****** Object:  StoredProcedure [dbo].[dm]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[dm]
as begin 
select idloaisp,tenloai,tenhang from LoaiSanPham,HangSX
where LoaiSanPham.idhangsx = HangSX.idhangsx
end
GO
/****** Object:  StoredProcedure [dbo].[sp]    Script Date: 6/24/2018 10:47:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[sp]
 as
 begin
 select * from SanPham 
 end
GO
USE [master]
GO
ALTER DATABASE [WebMyPham] SET  READ_WRITE 
GO
