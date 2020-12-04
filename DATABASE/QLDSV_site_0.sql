USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLDSV.mdf' , SIZE = 23552KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 29504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLDSV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLDSV', N'ON'
GO
USE [QLDSV]
GO
/****** Object:  User [HTKN]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_F87809210A304405BAB6F9EFD325B3DD]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE ROLE [MSmerge_F87809210A304405BAB6F9EFD325B3DD]
GO
/****** Object:  DatabaseRole [MSmerge_34A22E6EDBF54BC5BB2ACA03891C462A]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE ROLE [MSmerge_34A22E6EDBF54BC5BB2ACA03891C462A]
GO
/****** Object:  DatabaseRole [MSmerge_2F654841B4C0406D8369EDE3850F7C31]    Script Date: 12/4/2020 6:46:04 PM ******/
CREATE ROLE [MSmerge_2F654841B4C0406D8369EDE3850F7C31]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PGV]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_F87809210A304405BAB6F9EFD325B3DD]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_34A22E6EDBF54BC5BB2ACA03891C462A]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_2F654841B4C0406D8369EDE3850F7C31]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  Table [dbo].[CT_DONGHOCPHI]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_DONGHOCPHI](
	[MASV] [char](12) NOT NULL,
	[NIENKHOA] [nvarchar](50) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[NGAYDONG] [date] NOT NULL,
	[SOTIENDONG] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_13F730EAD0DD47288627B2BFA234EDEB]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CT_DONGHOCPHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[NIENKHOA] ASC,
	[HOCKY] ASC,
	[NGAYDONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIEM](
	[MASV] [char](12) NOT NULL,
	[MAMH] [char](6) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[DIEM] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_CEA3CFD9B9264C33805370547BA1F0EA]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[MAKH] [char](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_65F365890492400DBDEE8C2AC2645E34]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOCPHI]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCPHI](
	[MASV] [char](12) NOT NULL,
	[NIENKHOA] [nvarchar](50) NOT NULL,
	[HOCKY] [int] NOT NULL CONSTRAINT [DF_HOCPHI_HOCKY]  DEFAULT ((1)),
	[HOCPHI] [int] NOT NULL CONSTRAINT [DF_HOCPHI_HOCPHI]  DEFAULT ((6000000)),
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A96C788EC6D34DB4AA755F6799B498E7]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_HOCPHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[NIENKHOA] ASC,
	[HOCKY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [char](4) NOT NULL,
	[TENKH] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_58F13D34272A43EC923CDEF3A1D8C1DD]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [char](8) NOT NULL,
	[TENLOP] [nvarchar](200) NULL,
	[MAKH] [char](4) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_5AD7F61189C74559A6382892AF65D1AF]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](6) NOT NULL,
	[TENMH] [nvarchar](40) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E2D95BD6903443E5B916798664559E3D]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](12) NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[MALOP] [char](8) NOT NULL,
	[PHAI] [bit] NULL,
	[NGAYSINH] [datetime] NULL,
	[NOISINH] [nvarchar](40) NULL,
	[DIACHI] [nvarchar](80) NULL,
	[GHICHU] [ntext] NULL,
	[NGHIHOC] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_792FB71892C24ACDA9E9DF42D0538349]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[V_DSGV]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DSGV]
AS
SELECT MAGV, HO + ' ' + TEN AS HOTEN, MAKH
FROM     dbo.GIANGVIEN

GO
/****** Object:  View [dbo].[V_DSPM]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DSPM]
AS
SELECT TENKHOA = PUBS.description, TENSERVER = subscriber_server
FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server

GO
/****** Object:  View [dbo].[V_DSSV_TaoTK]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DSSV_TaoTK]
AS
SELECT dbo.SINHVIEN.MASV, dbo.SINHVIEN.HO + ' ' + dbo.SINHVIEN.TEN AS HOTEN, dbo.LOP.MAKH, dbo.SINHVIEN.MALOP
FROM     dbo.SINHVIEN INNER JOIN
                  dbo.LOP ON dbo.SINHVIEN.MALOP = dbo.LOP.MALOP

GO
/****** Object:  View [dbo].[V_GETDSLOP]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_GETDSLOP]
AS
SELECT MALOP, TENLOP, MAKH
FROM     dbo.LOP AS L
WHERE  EXISTS
                      (SELECT MASV, HO, TEN, MALOP, PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU, NGHIHOC, rowguid
                       FROM      dbo.SINHVIEN AS SV
                       WHERE   (MALOP = L.MALOP))

GO
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N15DCCN001  ', N'2015', 1, CAST(N'2020-11-27' AS Date), 10000000, N'20806153-c730-eb11-a854-107d1a400a3c')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08VTA102    ', N'THDC  ', 1, 8, N'a40702e9-6235-eb11-a856-107d1a400a3c')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN001  ', N'CSDL  ', 1, 5, N'7bbbf23d-b034-eb11-a856-107d1a400a3c')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN001  ', N'CSDLPT', 1, 9, N'b48ccefc-6231-eb11-a854-107d1a400a3c')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN001  ', N'CSDLPT', 2, 6, N'efb2280d-6331-eb11-a854-107d1a400a3c')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN002  ', N'CSDLPT', 1, 7, N'f65f8613-6331-eb11-a854-107d1a400a3c')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN002  ', N'CSDLPT', 2, 8, N'cfe79a1f-6331-eb11-a854-107d1a400a3c')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV01      ', N'NGUYEN HONG', N'SON       ', N'CNTT', N'baeed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV02      ', N'TRUONG DINH', N'HUY       ', N'CNTT', N'bbeed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV03      ', N'NGUYEN XUAN', N'KHANH     ', N'VT  ', N'bceed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV04      ', N'TRAN DINH', N'THUAN     ', N'VT  ', N'bdeed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV05      ', N'LUU NGUYEN KY', N'THU', N'CNTT', N'fb9857f8-be32-eb11-a856-107d1a400a3c')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N15DCCN001  ', N'2015', 1, 10000000, N'1f806153-c730-eb11-a854-107d1a400a3c')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N15DCCN002  ', N'2015', 1, 10000000, N'ce3415a8-b633-eb11-a856-107d1a400a3c')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'CNTT', N'Công nghệ thông tin', N'b0eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'VT  ', N'Viễn thông', N'b1eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C10THA1 ', N'Cao dang chính quy CNTT', N'CNTT', N'85ca98ec-3a32-eb11-a855-107d1a400a3c')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C9THA1  ', N'Cao dang chính qui CNTT', N'CNTT', N'beeed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D08VTA1 ', N'Đại học chính qui 1  Viễn thông Khóa 2008', N'VT  ', N'c1eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D09VTA1 ', N'Đại học chính qui 1  Viễn thông Khóa 2009', N'VT  ', N'c2eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D15CQCN1', N'Đại học chính qui 1  ngành Hệ thống thông tin Khóa 2015', N'CNTT', N'c0eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16CQCN1', N'Đại học chính qui 1  ngành Công nghệ thông tin Khóa 2016', N'CNTT', N'bfeed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDL  ', N'Co so du lieu', N'b3eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDLPT', N'Co so du lieu phan tan', N'b4eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CTDL  ', N'Cấu trúc dữ liệu', N'b2eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTCB  ', N'Lap trinh can ban', N'b5eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'THCS1 ', N'Tin hoc co so 1', N'b7eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'THDC  ', N'Tin hoc đại cương', N'b8eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR1  ', N'Toán rời rạc 1', N'b9eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'VB    ', N'Lập trình Visual Basic nang cao', N'b6eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08VTA101    ', N'Nguyễn Thanh', N'Hằng', N'D08VTA1 ', 1, CAST(N'1975-12-07 00:00:00.000' AS DateTime), N'Hà nội', N'11 Lê Văn Sỹ', N'', 0, N'c3eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08VTA102    ', N'Võ Văn', N'Phát', N'D08VTA1 ', 1, CAST(N'1976-05-05 00:00:00.000' AS DateTime), N'Phú Yên', N'246 Phan Đình Phùng', N' ', 0, N'c4eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA101    ', N'Le Thi', N'Van', N'D16CQCN1', 0, CAST(N'1976-06-06 00:00:00.000' AS DateTime), N'Hà Nội', N'Ngô Quyền', N' ', 0, N'c5eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA102    ', N'Trần Thi', N'Hoa', N'D16CQCN1', 0, CAST(N'1976-07-07 00:00:00.000' AS DateTime), N'Sài gòn', N'222 Lý Thái Tổ', N' ', 0, N'c6eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA103    ', N'Nguyễn Thị Yến', N'Lan', N'D16CQCN1', 0, CAST(N'1976-08-08 00:00:00.000' AS DateTime), N'Khánh Hòa', N'333 HHT, BT', NULL, 0, N'c7eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN001  ', N'Tran Nguyen', N'Minh', N'D15CQCN1', 1, CAST(N'1995-06-19 00:00:00.000' AS DateTime), N'PHU TAN', N'22 Cà Mau', N' ', 0, N'c8eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN002  ', N'Nguyen Hoang', N'An', N'D15CQCN1', 1, CAST(N'1995-06-06 00:00:00.000' AS DateTime), N'PHU YEN', N'HA NOI', NULL, 0, N'c9eed4ba-bb0f-eb11-a843-107d1a400a3c')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN003  ', N'Lê Thị', N'Hà', N'D15CQCN1', 0, CAST(N'1995-02-19 00:00:00.000' AS DateTime), N'Phú yên', N'CAN THO', N' ', 0, N'caeed4ba-bb0f-eb11-a843-107d1a400a3c')
/****** Object:  Index [MSmerge_index_245575913]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_245575913] ON [dbo].[CT_DONGHOCPHI]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_277576027]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_277576027] ON [dbo].[DIEM]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_309576141]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_309576141] ON [dbo].[GIANGVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_341576255]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_341576255] ON [dbo].[HOCPHI]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_373576369]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_373576369] ON [dbo].[KHOA]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_TENLOP]    Script Date: 12/4/2020 6:46:05 PM ******/
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [UK_TENLOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_405576483]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_405576483] ON [dbo].[LOP]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MONHOC]    Script Date: 12/4/2020 6:46:05 PM ******/
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [IX_MONHOC] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_437576597]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_437576597] ON [dbo].[MONHOC]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_469576711]    Script Date: 12/4/2020 6:46:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_469576711] ON [dbo].[SINHVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI]  WITH CHECK ADD  CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI] FOREIGN KEY([MASV], [NIENKHOA], [HOCKY])
REFERENCES [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY])
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] CHECK CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_MONHOC1] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_MONHOC1]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[HOCPHI]  WITH CHECK ADD  CONSTRAINT [FK_HOCPHI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[HOCPHI] CHECK CONSTRAINT [FK_HOCPHI_SINHVIEN]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA1] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA1]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM_DIEM] CHECK  (([DIEM]>=(0) AND [DIEM]<=(10)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK_DIEM_DIEM]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM_LAN] CHECK  (([LAN]=(1) OR [LAN]=(2)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK_DIEM_LAN]
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM GIANGVIEN  WHERE MAGV = @TENUSER ),
   NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
               WHERE MEMBERUID= (SELECT UID FROM sys.sysusers  WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_getBangDiemMonHoc]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getBangDiemMonHoc]
@malop NVARCHAR(10), @mamh NVARCHAR(10),  @lan INT
AS
BEGIN
  DECLARE @TENLOP NVARCHAR(100), @TENMH NVARCHAR(100)
  SELECT @TENLOP= TENLOP FROM LOP WHERE MALOP = @malop 
  SELECT @TENMH = TENMH FROM MONHOC WHERE MAMH = @mamh
  
SELECT TENLOP=@TENLOP , TENMH=@TENMH  , SV.MASV , HOTEN=HO+' '+TEN, DIEM 
    FROM 
		(SELECT MASV, HO,TEN 
			FROM SINHVIEN WITH (INDEX=IX_MALOP) 
			WHERE MALOP = @malop) SV, 
		(SELECT MASV , DIEM 
			FROM DIEM 
			WHERE MAMH = @mamh AND LAN = @lan) DIEM
    WHERE	SV.MASV = DIEM.MASV         
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getBangDiemTongKet]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getBangDiemTongKet]
@malop NVARCHAR(8)
AS
BEGIN
SELECT HOTEN = SV.HO + ' ' + SV.TEN, TENMH, TBD.DIEM
	FROM (SELECT D.MASV, D.MAMH, MAX(D.Diem) as DIEM
			FROM Diem D
			GROUP BY D.MAMH, D.MASV) as TBD
INNER JOIN SINHVIEN SV ON SV.MALOP = @malop AND SV.MASV = TBD.MASV
INNER JOIN MONHOC MH ON MH.MAMH = TBD.MAMH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getPhieuDiem]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getPhieuDiem]
@MSSV NVARCHAR(12)
AS
BEGIN
	SELECT MH.TENMH, TBD.DIEM
	FROM (SELECT D.MAMH, MAX(D.Diem) as DIEM
			FROM Diem D
			WHERE D.MASV = @MSSV
			GROUP BY MAMH) as TBD
	INNER JOIN MONHOC MH
	ON MH.MAMH = TBD.MAMH       
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_BDTHI]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_BDTHI](@MALOP NVARCHAR(15), @MAMONHOC NVARCHAR(15),@LAN INT)
AS
BEGIN
  IF EXISTS (SELECT 1 FROM dbo.SINHVIEN SV, dbo.DIEM D WHERE SV.MALOP = @MALOP AND SV.MASV = D.MASV AND D.MAMH = @MAMONHOC AND D.LAN =@LAN)
    BEGIN
      SELECT SV.MASV, SV.HO +' '+ SV.TEN AS HOTEN, DIEM
	  FROM dbo.SINHVIEN SV, dbo.DIEM D
      WHERE SV.MASV = D.MASV AND @MALOP = SV.MALOP AND @LAN = D.LAN AND @MAMONHOC = D.MAMH AND SV.NGHIHOC ='False'
    END
  ELSE RETURN 1;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_DSDHP]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_DSDHP]
(@MALOP NVARCHAR(15),@NIENKHOA NVARCHAR(15),@HK INT)
AS
BEGIN
  IF EXISTS (SELECT 1 FROM dbo.SINHVIEN AS SV WHERE SV.MALOP = @MALOP)
  BEGIN
	   SELECT HO +' '+ TEN AS HOTEN, HOCPHI, ISNULL(SOTIENDONG, 0 ) AS SOTIENDONG
	   FROM dbo.SINHVIEN SV INNER JOIN (dbo.HOCPHI HP LEFT JOIN dbo.CT_DONGHOCPHI CTDHP ON  HP.MASV = CTDHP.MASV)
										 ON SV.MASV = HP.MASV								
	   WHERE SV.MALOP = @MALOP AND HP.NIENKHOA =@NIENKHOA AND HP.HOCKY = @HK AND SV.NGHIHOC = 'False'

  END
  ELSE RETURN 1;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_DSSV]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_DSSV](@MALOP CHAR(15))
AS
BEGIN
	SELECT SV.HO AS HO, SV.TEN AS TEN,
	CASE
		WHEN SV.PHAI = 1 THEN N'Nam'
		WHEN SV.PHAI = 0 THEN N'Nữ'
	END AS PHAI,
	 CONVERT(VARCHAR(12),SV.NGAYSINH,106) AS NGAYSINH, SV.NOISINH, SV.DIACHI FROM dbo.SINHVIEN AS SV WHERE SV.MALOP = @MALOP AND SV.NGHIHOC='false'
	 ORDER BY TEN ASC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 12/4/2020 6:46:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TaoTaiKhoan]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
	-- check login , user bị trùng 
	IF EXISTS(SELECT name FROM sys.server_principals 
						  WHERE TYPE IN ('U', 'S', 'G')	--U: Windows Login Accounts
									 AND name NOT LIKE '%##%'		--S: SQL Login Accounts
									 AND name = @LGNAME)				--G: Windows Group Login Accounts
		RETURN 1	--Trùng Login
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USERNAME)
		RETURN 2	--Trùng User

	-- băt đầu tạo tài khoản
	DECLARE @RET INT
	EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV'
	IF (@RET =1) 
		RETURN 3 -- tạo tài khoản không thành công
 
	EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
	IF (@RET =1) 
	BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 3 -- tạo  tài khoảng không thành công
	END
	EXEC sp_addrolemember @ROLE, @USERNAME

	 --THEM ROLE SECURITYADMIN DE CO QUYEN TAO TAI KHOAN
	IF @ROLE = 'PGV'  OR @ROLE = 'KHOA' OR @ROLE = 'PKeToan'
	BEGIN
  		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
	END
	RETURN 0  -- THANH CONG
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "GIANGVIEN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DSGV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DSGV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SINHVIEN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LOP"
            Begin Extent = 
               Top = 8
               Left = 332
               Bottom = 171
               Right = 526
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DSSV_TaoTK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DSSV_TaoTK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "L"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_GETDSLOP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_GETDSLOP'
GO
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO
