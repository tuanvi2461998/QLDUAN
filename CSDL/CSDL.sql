USE [master]
GO
/****** Object:  Database [QLDUAN]    Script Date: 11/23/2019 11:53:32 ******/
CREATE DATABASE [QLDUAN] ON  PRIMARY 
( NAME = N'QLDUAN', FILENAME = N'F:\QUANLY_DUAN_XAYDUNG\CSDL\QLDUAN.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDUAN_log', FILENAME = N'F:\QUANLY_DUAN_XAYDUNG\CSDL\QLDUAN_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDUAN] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDUAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDUAN] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLDUAN] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLDUAN] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLDUAN] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLDUAN] SET ARITHABORT OFF
GO
ALTER DATABASE [QLDUAN] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLDUAN] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLDUAN] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLDUAN] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLDUAN] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLDUAN] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLDUAN] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLDUAN] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLDUAN] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLDUAN] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLDUAN] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLDUAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLDUAN] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLDUAN] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLDUAN] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLDUAN] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLDUAN] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLDUAN] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLDUAN] SET  READ_WRITE
GO
ALTER DATABASE [QLDUAN] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLDUAN] SET  MULTI_USER
GO
ALTER DATABASE [QLDUAN] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLDUAN] SET DB_CHAINING OFF
GO
USE [QLDUAN]
GO
/****** Object:  Table [dbo].[RUI_RO]    Script Date: 11/23/2019 11:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUI_RO](
	[id] [int] NOT NULL,
	[ma_duan] [int] NOT NULL,
	[tieu_de] [nvarchar](200) NOT NULL,
	[trang_thai] [nvarchar](50) NOT NULL,
	[chitiet] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_RUI_RO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[RUI_RO] ([id], [ma_duan], [tieu_de], [trang_thai], [chitiet]) VALUES (1, 1, N'Het tien', N'Chua xu ly', N'Het tien do troi mua ')
INSERT [dbo].[RUI_RO] ([id], [ma_duan], [tieu_de], [trang_thai], [chitiet]) VALUES (2, 1, N'Thiếu vốn 500000000', N'Đã xử lý', N'Không')
INSERT [dbo].[RUI_RO] ([id], [ma_duan], [tieu_de], [trang_thai], [chitiet]) VALUES (3, 1, N'Het tien', N'Chua xu ly', N'Het tien do troi mua ')
INSERT [dbo].[RUI_RO] ([id], [ma_duan], [tieu_de], [trang_thai], [chitiet]) VALUES (4, 4, N'4', N'4', N'4')
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 11/23/2019 11:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[ma_nhanvien] [int] NOT NULL,
	[hoten_nhanvien] [nvarchar](150) NOT NULL,
	[gioitinh] [nvarchar](5) NOT NULL,
	[ngay_sinh] [date] NOT NULL,
	[dia_chi] [nvarchar](200) NOT NULL,
	[sdt] [varchar](20) NOT NULL,
	[taikhoan] [varchar](100) NOT NULL,
	[matkhau] [varchar](100) NOT NULL,
	[chucvu] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_NHAN_VIEN] PRIMARY KEY CLUSTERED 
(
	[ma_nhanvien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NHAN_VIEN] ([ma_nhanvien], [hoten_nhanvien], [gioitinh], [ngay_sinh], [dia_chi], [sdt], [taikhoan], [matkhau], [chucvu]) VALUES (1, N'Nguyễn Văn A', N'Nam', CAST(0x4F170B00 AS Date), N'An Minh, Kiên Giang', N'019929912', N'vana', N'1234vana', N'Nhân viên')
INSERT [dbo].[NHAN_VIEN] ([ma_nhanvien], [hoten_nhanvien], [gioitinh], [ngay_sinh], [dia_chi], [sdt], [taikhoan], [matkhau], [chucvu]) VALUES (2, N'Nguyễn Văn B', N'Nam', CAST(0x04180B00 AS Date), N'Rạch Giá Kiên Giang', N'019747712', N'vanb', N'1234vanb', N'Nhân viên')
INSERT [dbo].[NHAN_VIEN] ([ma_nhanvien], [hoten_nhanvien], [gioitinh], [ngay_sinh], [dia_chi], [sdt], [taikhoan], [matkhau], [chucvu]) VALUES (3, N'Nguyễn Thị C', N'Nữ', CAST(0x87180B00 AS Date), N'An Minh, Kiên Giang', N'016677912', N'thic', N'1234thic', N'Trưởng phòng')
INSERT [dbo].[NHAN_VIEN] ([ma_nhanvien], [hoten_nhanvien], [gioitinh], [ngay_sinh], [dia_chi], [sdt], [taikhoan], [matkhau], [chucvu]) VALUES (4, N'Nguyễn Văn D', N'Nam', CAST(0x621B0B00 AS Date), N'Vĩnh Thuận, Kiên Giang', N'016967772', N'vand', N'1234vand', N'Phó phòng')
INSERT [dbo].[NHAN_VIEN] ([ma_nhanvien], [hoten_nhanvien], [gioitinh], [ngay_sinh], [dia_chi], [sdt], [taikhoan], [matkhau], [chucvu]) VALUES (5, N'Nguyễn Văn E', N'Nam', CAST(0x81920A00 AS Date), N'Rạch Giá,Kiên Ginag', N'032455775', N'vane', N'1234vane', N'Phó giám đốc')
/****** Object:  Table [dbo].[NHA_THAU]    Script Date: 11/23/2019 11:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHA_THAU](
	[ma_nhathau] [int] NOT NULL,
	[ten_nhathau] [nvarchar](200) NOT NULL,
	[hoten_daidien] [nvarchar](200) NOT NULL,
	[diachi] [nvarchar](200) NOT NULL,
	[so_fax] [varchar](50) NULL,
	[email] [varchar](150) NULL,
	[sdt] [varchar](20) NOT NULL,
	[so_dkkd] [varchar](20) NOT NULL,
 CONSTRAINT [PK_NHA_THAU] PRIMARY KEY CLUSTERED 
(
	[ma_nhathau] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NHA_THAU] ([ma_nhathau], [ten_nhathau], [hoten_daidien], [diachi], [so_fax], [email], [sdt], [so_dkkd]) VALUES (1, N'Doanh Nghiệp Tư Nhân ABC', N'Nguyễn Hoàng Tuấn Anh', N'Rạch Giá, Kiên Giang', N'0192919212', N'ngtuananh@gmail.com', N'0324414240', N'46B099')
INSERT [dbo].[NHA_THAU] ([ma_nhathau], [ten_nhathau], [hoten_daidien], [diachi], [so_fax], [email], [sdt], [so_dkkd]) VALUES (2, N'Công Ty Xây Dựng XYX', N'Nguyễn Văn Chương', N'Rạch Giá, Kiên Giang', N'0122323212', N'vanchuong@gmail.com', N'0312222240', N'26B099')
INSERT [dbo].[NHA_THAU] ([ma_nhathau], [ten_nhathau], [hoten_daidien], [diachi], [so_fax], [email], [sdt], [so_dkkd]) VALUES (3, N'Công Ty Thầu Miền Nam', N'Nguyễn Hoa Kỳ', N'Rạch Giá, Kiên Giang', N'0897626622', N'hoaky@gmail.com', N'0312121102', N'41B099')
INSERT [dbo].[NHA_THAU] ([ma_nhathau], [ten_nhathau], [hoten_daidien], [diachi], [so_fax], [email], [sdt], [so_dkkd]) VALUES (4, N'Công Ty GGF Hàn Quốc', N'Nguyễn Bu Sang', N'Rạch Giá, Kiên Giang', N'0812221146', N'busag@gmail.com', N'0182222102', N'76B099')
/****** Object:  Table [dbo].[HOP_DONG]    Script Date: 11/23/2019 11:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOP_DONG](
	[ma_hopdong] [int] NOT NULL,
	[ten_hopdong] [nvarchar](200) NOT NULL,
	[ngayky] [date] NOT NULL,
	[noidung_chinh] [nvarchar](300) NULL,
	[ma_nhanvien] [int] NOT NULL,
	[ma_nhathau] [int] NOT NULL,
 CONSTRAINT [PK_HOP_DONG] PRIMARY KEY CLUSTERED 
(
	[ma_hopdong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (1, N'Hợp đồng xây dựng nhà ở Phúc Cường', CAST(0xC13D0B00 AS Date), N'Xây dựng nhà ở cấp 3 trong khu đô thị Phú Cường', 1, 1)
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (2, N'Hợp đồng xây dựng nhà yến cho hộ gia đình ông Nguyễn Băng Giá', CAST(0xDE3D0B00 AS Date), N'Xây dựng nhà yến với diện tích 100mx100m', 1, 2)
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (3, N'Hợp đồng xây dựng hố gas CTy TNHH MTV ABC', CAST(0x4A3C0B00 AS Date), N'Xây dựng hố gas ABC', 2, 2)
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (4, N'Hợp đồng xây dựng hồ bơi Phú Gia', CAST(0xF13A0B00 AS Date), N'Hồ bơi 20mx20m', 3, 3)
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (5, N'Hợp đồng xây dựng khu lấn biển  Trần Quan Khải', CAST(0xA23D0B00 AS Date), N'Khu lấn biển 16ha', 4, 2)
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (6, N'Hợp đồng xây dựng cầu Cái Lớn', CAST(0xBC3A0B00 AS Date), N'Xây cầu ', 3, 2)
INSERT [dbo].[HOP_DONG] ([ma_hopdong], [ten_hopdong], [ngayky], [noidung_chinh], [ma_nhanvien], [ma_nhathau]) VALUES (7, N'Hợp đồng xây dựng chung cư FE', CAST(0xA0390B00 AS Date), N'Xây dựng chung cư', 5, 4)
/****** Object:  Table [dbo].[DU_AN]    Script Date: 11/23/2019 11:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DU_AN](
	[ma_duan] [int] NOT NULL,
	[ten_duan] [nvarchar](200) NOT NULL,
	[ngay_batdau] [date] NOT NULL,
	[ngay_ketthuc] [date] NOT NULL,
	[tongmuc_dautu] [bigint] NOT NULL,
	[nguonvon] [nvarchar](150) NOT NULL,
	[chuthich] [nvarchar](200) NULL,
	[ma_hopdong] [int] NOT NULL,
 CONSTRAINT [PK_DU_AN] PRIMARY KEY CLUSTERED 
(
	[ma_duan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (1, N'Xây dựng nhà ở cấp 3', CAST(0xD03D0B00 AS Date), CAST(0x3D3F0B00 AS Date), 25537380, N'Tư nhân', N'Không', 1)
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (2, N'Nhà yến ', CAST(0xC13D0B00 AS Date), CAST(0x363F0B00 AS Date), 23000000, N'Nhà nước', N'Không', 2)
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (3, N'Xây dựng hố gas', CAST(0x623C0B00 AS Date), CAST(0x3C3F0B00 AS Date), 22122889, N'Tư nhân', N'Không', 3)
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (4, N'Xây dựng hồ bơi Phú Gia', CAST(0xDB3A0B00 AS Date), CAST(0x90400B00 AS Date), 52555500, N'Nhà nước', N'Không', 4)
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (5, N'Khu lấn biển TQK', CAST(0x493C0B00 AS Date), CAST(0x90400B00 AS Date), 109999211, N'Nha nuoc', N'Khong', 5)
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (6, N'Cầu Cái Lớn', CAST(0x1E3A0B00 AS Date), CAST(0xD33F0B00 AS Date), 632321212, N'Nhà nước', N'Không', 6)
INSERT [dbo].[DU_AN] ([ma_duan], [ten_duan], [ngay_batdau], [ngay_ketthuc], [tongmuc_dautu], [nguonvon], [chuthich], [ma_hopdong]) VALUES (7, N'Chung cư FE', CAST(0x8E390B00 AS Date), CAST(0xB0400B00 AS Date), 100000002, N'Tư nhân', N'Không', 7)
/****** Object:  Table [dbo].[CONG_TRINH]    Script Date: 11/23/2019 11:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONG_TRINH](
	[ma_congtrinh] [int] NOT NULL,
	[ten_congtrinh] [nvarchar](150) NOT NULL,
	[diadiem] [nvarchar](50) NOT NULL,
	[mota_congtrinh] [nvarchar](250) NULL,
	[trangthai] [nvarchar](50) NOT NULL,
	[ngay_batdau] [date] NOT NULL,
	[ngay_ketthuc] [date] NOT NULL,
	[giatri_congtrinh] [money] NOT NULL,
	[chuthich] [nvarchar](200) NOT NULL,
	[ma_duan] [int] NOT NULL,
 CONSTRAINT [PK_CONG_TRINH] PRIMARY KEY CLUSTERED 
(
	[ma_congtrinh] ASC,
	[diadiem] ASC,
	[ma_duan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (1, N'Nhà ở cấp 3', N'TT.Minh Lương, Châu Thành, Kiên Ginag', N'Nhà cấp 3 có 2 tầng 200m vuông ', N'Đang thi công', CAST(0xD33D0B00 AS Date), CAST(0x233F0B00 AS Date), 25537380.0000, N'Không', 1)
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (2, N'Công trình nhà nuôi yến', N'Rạch Giá, Kiên Giang', N'Nhà yến với diện tích 100x100 m vuông', N'Đang thi công', CAST(0xC13D0B00 AS Date), CAST(0x233F0B00 AS Date), 23000000.0000, N'Không', 2)
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (3, N'Hố gas dân sinh', N'Hòn Đất,Kiên Giang', N'Hố gas đường kính 4m', N'Đang thi công', CAST(0x713C0B00 AS Date), CAST(0xCF3D0B00 AS Date), 22122889.0000, N'Không', 3)
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (4, N'Hồ bơi PC', N'Rạch Giá, Kiên Giang', N'Hồ bơi 50m đường kính', N'Đang thi công', CAST(0xDB3A0B00 AS Date), CAST(0x90400B00 AS Date), 52555500.0000, N'Không', 4)
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (5, N'Khu lấn biển TQK', N'Rạch Giá, Kiên Giang', N'Dài ra biển 100m', N'Đang thi công', CAST(0x493C0B00 AS Date), CAST(0x90400B00 AS Date), 109999211.0000, N'Không', 5)
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (6, N'Cầu Cái Lớn', N'Tắc Cậu, Kiên Giang', N'Dài 1km', N'Hoàn thành', CAST(0x1E3A0B00 AS Date), CAST(0x663E0B00 AS Date), 632321212.0000, N'Không', 6)
INSERT [dbo].[CONG_TRINH] ([ma_congtrinh], [ten_congtrinh], [diadiem], [mota_congtrinh], [trangthai], [ngay_batdau], [ngay_ketthuc], [giatri_congtrinh], [chuthich], [ma_duan]) VALUES (7, N'Chung cư FE', N'Rạch Giá, Kiên Giang', N'Chung cư 230 căn', N'Đang thi công', CAST(0x8E390B00 AS Date), CAST(0xB0400B00 AS Date), 100000002.0000, N'Không', 7)
