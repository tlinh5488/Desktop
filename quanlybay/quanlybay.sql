USE [master]
GO
/****** Object:  Database [quanlybay]    Script Date: 7/5/2025 10:12:13 PM ******/
CREATE DATABASE [quanlybay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlybay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.THUYLINH\MSSQL\DATA\quanlybay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'quanlybay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.THUYLINH\MSSQL\DATA\quanlybay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [quanlybay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlybay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlybay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlybay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlybay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlybay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlybay] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlybay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlybay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlybay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlybay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlybay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlybay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlybay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlybay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlybay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlybay] SET  ENABLE_BROKER 
GO
ALTER DATABASE [quanlybay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlybay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlybay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlybay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlybay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlybay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlybay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlybay] SET RECOVERY FULL 
GO
ALTER DATABASE [quanlybay] SET  MULTI_USER 
GO
ALTER DATABASE [quanlybay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlybay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlybay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlybay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [quanlybay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [quanlybay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'quanlybay', N'ON'
GO
ALTER DATABASE [quanlybay] SET QUERY_STORE = OFF
GO
USE [quanlybay]
GO
/****** Object:  Table [dbo].[chuyenbay]    Script Date: 7/5/2025 10:12:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chuyenbay](
	[machuyen] [nchar](10) NULL,
	[tenchuyenbay] [nvarchar](max) NULL,
	[sochongoi] [numeric](18, 0) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datve]    Script Date: 7/5/2025 10:12:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datve](
	[id] [nchar](10) NULL,
	[machuyen] [nchar](10) NULL,
	[giatien] [int] NULL,
	[thoigiandatve] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khach]    Script Date: 7/5/2025 10:12:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khach](
	[id] [nchar](10) NULL,
	[hoten] [nvarchar](max) NULL,
	[ngaysinh] [date] NULL,
	[diachi] [nvarchar](max) NULL,
	[gioitinh] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 7/5/2025 10:12:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [nchar](10) NULL,
	[tennv] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
	[quyentruycap] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 7/5/2025 10:12:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[cdv] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[chuyenbay] ([machuyen], [tenchuyenbay], [sochongoi]) VALUES (N'CB01      ', N'ĐN', CAST(42 AS Numeric(18, 0)))
INSERT [dbo].[chuyenbay] ([machuyen], [tenchuyenbay], [sochongoi]) VALUES (N'CB02      ', N'HN', CAST(36 AS Numeric(18, 0)))
INSERT [dbo].[chuyenbay] ([machuyen], [tenchuyenbay], [sochongoi]) VALUES (N'CB03      ', N'Huế', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[chuyenbay] ([machuyen], [tenchuyenbay], [sochongoi]) VALUES (N'CB04      ', N'QN', CAST(36 AS Numeric(18, 0)))
INSERT [dbo].[chuyenbay] ([machuyen], [tenchuyenbay], [sochongoi]) VALUES (N'CB05      ', N'TP HCM', CAST(58 AS Numeric(18, 0)))
GO
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K01       ', N'CB01      ', 500000, CAST(N'2025-06-07T08:00:00.000' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K02       ', N'CB01      ', 500000, CAST(N'2025-06-15T10:00:00.000' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K03       ', N'CB02      ', 480000, CAST(N'2025-07-03T15:00:00.000' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K04       ', N'CB02      ', 480000, CAST(N'2025-07-05T21:30:00.000' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K02       ', N'CB01      ', 200000, CAST(N'2025-07-05T17:04:20.233' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K03       ', N'CB01      ', 500000, CAST(N'2025-07-05T17:44:43.800' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K03       ', N'CB01      ', 500000, CAST(N'2025-07-05T17:44:43.803' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K01       ', N'CB01      ', 500000, CAST(N'2025-07-05T21:19:13.030' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K06       ', N'CB05      ', 500000, CAST(N'2025-07-05T21:21:51.467' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K06       ', N'CB04      ', 500000, CAST(N'2025-07-05T21:21:51.467' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K04       ', N'CB01      ', 500000, CAST(N'2025-07-05T17:49:38.137' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K04       ', N'CB01      ', 480000, CAST(N'2025-07-05T17:50:17.517' AS DateTime))
INSERT [dbo].[datve] ([id], [machuyen], [giatien], [thoigiandatve]) VALUES (N'K02       ', N'CB02      ', 500000, CAST(N'2025-07-03T17:53:11.000' AS DateTime))
GO
INSERT [dbo].[khach] ([id], [hoten], [ngaysinh], [diachi], [gioitinh]) VALUES (N'K01       ', N'Nguyễn Ngọc Châu Anh', CAST(N'2000-04-30' AS Date), N'Hải Phòng', N'Nữ')
INSERT [dbo].[khach] ([id], [hoten], [ngaysinh], [diachi], [gioitinh]) VALUES (N'K02       ', N'Nguyễn Hoàng Gia Khánh', CAST(N'2000-12-25' AS Date), N'Hà Nội', N'Nam')
INSERT [dbo].[khach] ([id], [hoten], [ngaysinh], [diachi], [gioitinh]) VALUES (N'K03       ', N'Nguyễn Công Trường', CAST(N'2000-02-16' AS Date), N'Hải Phòng', N'Nam')
INSERT [dbo].[khach] ([id], [hoten], [ngaysinh], [diachi], [gioitinh]) VALUES (N'K04       ', N'Phạm Huyền Chi', CAST(N'2000-09-05' AS Date), N'Hải Phòng', N'Nữ')
INSERT [dbo].[khach] ([id], [hoten], [ngaysinh], [diachi], [gioitinh]) VALUES (N'K05       ', N'Nguyễn Thị Cẩm Thiên', CAST(N'2005-03-27' AS Date), N'Phù Mỹ', N'Nữ')
INSERT [dbo].[khach] ([id], [hoten], [ngaysinh], [diachi], [gioitinh]) VALUES (N'K06       ', N'Nguyễn Thị Thuận Thiên', CAST(N'2005-09-21' AS Date), N'Phù Cát', N'Nữ')
GO
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [email], [matkhau], [quyentruycap]) VALUES (N'NV01      ', N'Nguyễn Thị Mai', N'021455465', N'ntm@gmail.com', N'123456', N'nhân viên')
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [email], [matkhau], [quyentruycap]) VALUES (N'NV02      ', N'Trần Huyền Diệp', N'026563335', N'thd@gmail.com', N'123456', N'nhân viên')
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [email], [matkhau], [quyentruycap]) VALUES (N'K01       ', N'Nguyễn Ngọc Châu Anh', N'025955463', N'nnca@gmail.com', N'123456', N'khách')
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [email], [matkhau], [quyentruycap]) VALUES (N'K02       ', N'Nguyễn Hoàng Gia Khánh', N'054654652', N'nhgk@gmail.com', N'123456', N'khách')
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [email], [matkhau], [quyentruycap]) VALUES (N'K03       ', N'Nguyễn Công Trường', N'054646855', N'nct@gmail.com', N'123456', N'khách')
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [email], [matkhau], [quyentruycap]) VALUES (N'K04       ', N'Phạm Huyền Chi', N'015613135', N'phc@gmail.com', N'123456', N'khách')
GO
USE [master]
GO
ALTER DATABASE [quanlybay] SET  READ_WRITE 
GO
