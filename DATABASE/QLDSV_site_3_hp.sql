USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER3\MSSQL\DATA\QLDSV.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER3\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  User [GV04]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE USER [GV04] FOR LOGIN [pkt] WITH DEFAULT_SCHEMA=[GV04]
GO
/****** Object:  DatabaseRole [PKeToan]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE ROLE [PKeToan]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE ROLE [PGV]
GO
ALTER ROLE [PKeToan] ADD MEMBER [GV04]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV04]
GO
ALTER ROLE [db_owner] ADD MEMBER [PKeToan]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PGV]
GO
/****** Object:  Schema [GV04]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE SCHEMA [GV04]
GO
/****** Object:  Table [dbo].[CT_DONGHOCPHI]    Script Date: 12/22/2020 4:20:58 PM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E0D0B322828F462E9E368645D6F5DE7F]  DEFAULT (newsequentialid()),
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
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  Table [dbo].[HOCPHI]    Script Date: 12/22/2020 4:20:58 PM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F5DC79992C2B4E00B708F468BFDD55A1]  DEFAULT (newsequentialid()),
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
/****** Object:  Table [dbo].[LOP]    Script Date: 12/22/2020 4:20:58 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENLOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  View [dbo].[V_DSGV]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DSGV]
AS
SELECT MAGV, HO + ' ' + TEN AS HOTEN, MAKH
FROM     dbo.GIANGVIEN


GO
/****** Object:  View [dbo].[V_DSHPSV]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DSHPSV] AS
SELECT dbo.CT_DONGHOCPHI.MASV, dbo.CT_DONGHOCPHI.NIENKHOA, dbo.CT_DONGHOCPHI.HOCKY, dbo.CT_DONGHOCPHI.NGAYDONG, dbo.HOCPHI.HOCPHI, dbo.CT_DONGHOCPHI.SOTIENDONG, 
                  dbo.CT_DONGHOCPHI.SOTIENDONG AS SOTIENDADONG
FROM     dbo.CT_DONGHOCPHI INNER JOIN
                  dbo.HOCPHI ON dbo.CT_DONGHOCPHI.MASV = dbo.HOCPHI.MASV AND dbo.CT_DONGHOCPHI.NIENKHOA = dbo.HOCPHI.NIENKHOA AND dbo.CT_DONGHOCPHI.HOCKY = dbo.HOCPHI.HOCKY

GO
/****** Object:  View [dbo].[V_DSPM]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  View [dbo].[V_DSSV_TaoTK]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  View [dbo].[V_GETDSLOP]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  Index [MSmerge_index_245575913]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_245575913] ON [dbo].[CT_DONGHOCPHI]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_309576141]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_309576141] ON [dbo].[GIANGVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_341576255]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_341576255] ON [dbo].[HOCPHI]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_405576483]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_405576483] ON [dbo].[LOP]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MALOP]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE NONCLUSTERED INDEX [IX_MALOP] ON [dbo].[SINHVIEN]
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_469576711]    Script Date: 12/22/2020 4:20:58 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_469576711] ON [dbo].[SINHVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI]  WITH NOCHECK ADD  CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI] FOREIGN KEY([MASV], [NIENKHOA], [HOCKY])
REFERENCES [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] CHECK CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI]
GO
ALTER TABLE [dbo].[HOCPHI]  WITH NOCHECK ADD  CONSTRAINT [FK_HOCPHI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[HOCPHI] CHECK CONSTRAINT [FK_HOCPHI_SINHVIEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
/****** Object:  StoredProcedure [dbo].[SP_BangDiemSV]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BangDiemSV] @malop NVARCHAR(10), 
@mamh NVARCHAR(10),  
@lan SMALLINT
AS
BEGIN
	
		SELECT SV.HO + ' ' + SV.TEN AS HOTEN, D.MASV, CONVERT(VARCHAR(5), D.DIEM) AS DIEM
		FROM  (SELECT MASV, DIEM FROM dbo.DIEM WHERE MAMH = @mamh AND LAN = @lan)  D
		INNER JOIN
		(SELECT MASV, HO, TEN FROM dbo.SINHVIEN  WITH (INDEX=IX_MALOP) WHERE MALOP = @malop AND NGHIHOC = 'false') SV
		ON D.MASV = SV.MASV
		ORDER BY TEN, HO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKCODE]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKCODE] 
@Code NVARCHAR(15), @Type NVARCHAR(15)
AS
BEGIN
	--MON HOC
	IF(@Type = 'MAMONHOC')
		BEGIN
			IF EXISTS(SELECT * FROM dbo.MONHOC WHERE MAMH = @Code)
			RETURN 1;
		END
	-- LOP
	IF(@Type = 'MALOP')
		BEGIN
			IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.MALOP = @Code)
				RETURN 1; 
	
			ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV.dbo.LOP AS LOP WHERE LOP.MALOP = @Code)
				RETURN 2;
		END
	IF(@Type = 'MASV')
		BEGIN
			IF EXISTS(SELECT * FROM dbo.SINHVIEN WHERE dbo.SINHVIEN.MASV = @Code)
				RETURN 1; 
	
			ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV.dbo.SINHVIEN AS SV WHERE SV.MASV = @Code)
				RETURN 2;	
	END

	RETURN 0	--Không bị trùng được thêm
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKCODEHOCPHI]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKCODEHOCPHI] 
	@masv NVARCHAR(10)
AS
BEGIN
  
  IF EXISTS (SELECT * FROM LINK0.QLDSV.dbo.HOCPHI WHERE MASV = @masv )
    RETURN 1 -- mã tồn tại
  RETURN 0  -- mã không tồn tại.
END


GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKNAME]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKNAME] 
@Name NVARCHAR(15), @Type NVARCHAR(15)
AS
BEGIN
	--MON HOC
	IF(@Type = 'TENMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE TENMH = @Name)
		RETURN 1;
	END

	--LOP
	IF(@Type = 'TENLOP')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.TENLOP = @Name)
			RETURN 1; --trùng
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV.dbo.LOP AS LOP WHERE LOP.TENLOP = @Name)
			RETURN 2;	--trùng
	END

	RETURN 0;

END

GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DSSVNhapDiem]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DSSVNhapDiem] @malop NVARCHAR(10)
AS
BEGIN
		
		SELECT sv.HO + ' ' + sv.TEN AS HOTEN , MASV, DIEM = ''
		FROM  dbo.SINHVIEN sv
		WHERE sv.MALOP = @malop AND sv.NGHIHOC = 'false'
		ORDER BY sv.MASV

END

GO
/****** Object:  StoredProcedure [dbo].[SP_getBangDiemMonHoc]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_getBangDiemTongKet]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getBangDiemTongKet]
@malop NVARCHAR(8)
AS
BEGIN
SELECT SV.MASV, HOTEN = SV.HO + ' ' + SV.TEN, TENMH, TBD.DIEM
	FROM (SELECT D.MASV, D.MAMH, MAX(D.Diem) as DIEM
			FROM Diem D
			GROUP BY D.MAMH, D.MASV) as TBD
INNER JOIN SINHVIEN SV ON SV.MALOP = @malop AND SV.MASV = TBD.MASV
INNER JOIN MONHOC MH ON MH.MAMH = TBD.MAMH
END

GO
/****** Object:  StoredProcedure [dbo].[SP_getPhieuDiem]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHAPDIEM]    Script Date: 12/22/2020 4:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHAPDIEM] @MASV NVARCHAR(12),  
@MAMH NVARCHAR(10),  
@LAN  smallint,  
@DIEM float  
AS  
BEGIN  
            IF EXISTS (SELECT 1 FROM DIEM WHERE MASV=@MASV AND MAMH=@MAMH AND LAN=@LAN)  
                BEGIN  
                    UPDATE DIEM  
                    SET DIEM = @DIEM   
                    WHERE MASV= @MASV AND MAMH=@MAMH AND LAN=@LAN
                END  
            ELSE  
                BEGIN  
                    INSERT INTO DBO.DIEM (MASV, MAMH, LAN, DIEM)  
                    VALUES (@MASV, @MAMH, @LAN, @DIEM)  
                END   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_BDTHI]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_REPORT_DSDHP]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_REPORT_DSSV]    Script Date: 12/22/2020 4:20:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 12/22/2020 4:20:58 PM ******/
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
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO
