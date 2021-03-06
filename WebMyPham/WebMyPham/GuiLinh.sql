
/****** Object:  Database [WebMyPham]    Script Date: 5/16/2018 2:48:43 PM ******/
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
ALTER DATABASE [WebMyPham] SET AUTO_CLOSE OFF 
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
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 5/16/2018 2:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[id] [int] NOT NULL,
	[iddonhang] [int] NULL,
	[idsp] [int] NULL,
	[giatien] [float] NULL,
	[soluong] [int] NULL,
	[giamgia] [float] NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 5/16/2018 2:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[iddonhang] [int] NOT NULL,
	[idKH] [int] NULL,
	[idsp] [int] NULL,
	[soluong] [int] NULL,
	[mota] [nvarchar](50) NULL,
	[trangthai] [bit] NULL,
	[kieuthanhtoan] [nvarchar](50) NULL,
	[ngayxuat] [date] NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[iddonhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangSX]    Script Date: 5/16/2018 2:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSX](
	[idhangsx] [int] NOT NULL,
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/16/2018 2:48:43 PM ******/
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
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 5/16/2018 2:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[idloaisp] [int] NOT NULL,
	[tenloai] [nvarchar](50) NULL,
	[idhangsx] [int] NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[idloaisp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/16/2018 2:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[username] [nvarchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/16/2018 2:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idsp] [int] NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[idloaisp] [int] NULL,
	[idhangsx] [int] NULL,
	[mota] [nvarchar](50) NULL,
	[giaban] [float] NULL,
	[soluong] [int] NULL,
	[giamgia] [float] NULL,
	[hinhanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
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
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_SanPham] FOREIGN KEY([idsp])
REFERENCES [dbo].[SanPham] ([idsp])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_SanPham]
GO
ALTER TABLE [dbo].[LoaiSanPham]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSanPham_HangSX] FOREIGN KEY([idhangsx])
REFERENCES [dbo].[HangSX] ([idhangsx])
GO
ALTER TABLE [dbo].[LoaiSanPham] CHECK CONSTRAINT [FK_LoaiSanPham_HangSX]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HangSX] FOREIGN KEY([idhangsx])
REFERENCES [dbo].[HangSX] ([idhangsx])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HangSX]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([idloaisp])
REFERENCES [dbo].[LoaiSanPham] ([idloaisp])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO

ALTER DATABASE [WebMyPham] SET  READ_WRITE 
GO
