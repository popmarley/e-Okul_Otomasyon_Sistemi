using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace OkulOtomasyonu.DbScript
{
	internal class DbScript
	{
		//Dbadı=  EgitimOtomasyonu


//		/*    ==Scripting Parameters==

//			Source Server Version : SQL Server 2022 (16.0.1000)
//			Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
//			Source Database Engine Type : Standalone SQL Server

//			Target Server Version : SQL Server 2022
//			Target Database Engine Edition : Microsoft SQL Server Enterprise Edition
//			Target Database Engine Type : Standalone SQL Server
//		*/

//		USE[master]
//		GO
///* For security reasons the login is created disabled and with a random password. */
//		/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT* FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
//CREATE LOGIN[##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'TU00mxfWzL2vMdW4lIhgUOY28xpiyQNp5WLNjCCG6co=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
//GO
//ALTER LOGIN[##MS_PolicyEventProcessingLogin##] DISABLE
//GO
///* For security reasons the login is created disabled and with a random password. */
///****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
//CREATE LOGIN[##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'6cFrz66+4CgeZda/8LzOUHrWQPGBZAmsvV39P0cIpIQ=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
//GO
//ALTER LOGIN[##MS_PolicyTsqlExecutionLogin##] DISABLE
//GO
///****** Object:  Login [CD-BT02\Burak]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'CD-BT02\Burak')
//CREATE LOGIN[CD - BT02\Burak] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
//CREATE LOGIN[NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLAgent$FERRA]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLAgent$FERRA')
//CREATE LOGIN[NT SERVICE\SQLAgent$FERRA] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLSERVERAGENT')
//CREATE LOGIN[NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLTELEMETRY]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLTELEMETRY')
//CREATE LOGIN[NT SERVICE\SQLTELEMETRY] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLTELEMETRY$FERRA]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLTELEMETRY$FERRA')
//CREATE LOGIN[NT SERVICE\SQLTELEMETRY$FERRA] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLWriter')
//CREATE LOGIN[NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\Winmgmt')
//CREATE LOGIN[NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
///****** Object:  Login [NT Service\MSSQL$FERRA]    Script Date: 13.10.2023 14:22:45 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT Service\MSSQL$FERRA')
//CREATE LOGIN[NT Service\MSSQL$FERRA] FROM WINDOWS WITH DEFAULT_DATABASE = [master], DEFAULT_LANGUAGE = [us_english]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[CD - BT02\Burak]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\SQLAgent$FERRA]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\SQLSERVERAGENT]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\SQLWriter]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\Winmgmt]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT Service\MSSQL$FERRA]
//GO
//USE[EgitimOtomasyonu]
//GO
///****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[__EFMigrationsHistory](
//	[MigrationId][nvarchar](150) COLLATE Turkish_CI_AS NOT NULL,
//	[ProductVersion][nvarchar](32) COLLATE Turkish_CI_AS NOT NULL,
// CONSTRAINT[PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED
//(
//	[MigrationId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[__EFMigrationsHistory] TO  SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Dersler]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dersler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Dersler](
//	[dersID][int] IDENTITY(1, 1) NOT NULL,
//	[dersAdi][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Dersler__B069CEB48C6E5219] PRIMARY KEY CLUSTERED
//(
//	[dersID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Dersler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Kullanicilar]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kullanicilar]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Kullanicilar]
//		(
//	[kullaniciID][int] IDENTITY(1, 1) NOT NULL,
//	[tipID][int] NULL,
//	[kullaniciAdi][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[sifre][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[eposta][nvarchar] (50) COLLATE Turkish_CI_AS NULL,
//	[telefon][int] NULL,
// CONSTRAINT[PK__Kullanic__848DC54B6FCC88F1] PRIMARY KEY CLUSTERED
//(
//	[kullaniciID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Kullanicilar] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[KullaniciTipleri]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KullaniciTipleri]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[KullaniciTipleri]
//		(
//	[tipID][int] IDENTITY(1, 1) NOT NULL,
//	[tipAdi][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Kullanic__E4250CDB78DFD36D] PRIMARY KEY CLUSTERED
//(
//	[tipID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[KullaniciTipleri] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Mudurler]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mudurler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Mudurler]
//		(
//	[mudurID][int] IDENTITY(1, 1) NOT NULL,
//	[kullaniciID][int] NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[dogumtarihi][datetime] NULL,
//	[tcno][int] NULL,
// CONSTRAINT[PK__Müdürler__27A6DB1DCA055500] PRIMARY KEY CLUSTERED
//(
//	[mudurID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Mudurler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[OgrenciDersleri]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OgrenciDersleri]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[OgrenciDersleri]
//		(
//	[ogrencidersID][int] IDENTITY(1, 1) NOT NULL,
//	[DersAdı][nvarchar] (50) COLLATE Turkish_CI_AS NULL,
//	[ogrenciID][int] NULL,
//	[dersID][int] NULL,
// CONSTRAINT[PK_ÖğrenciDersleri] PRIMARY KEY CLUSTERED
//(
//	[ogrencidersID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[OgrenciDersleri] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Ogrenciler]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ogrenciler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Ogrenciler]
//		(
//	[ogrenciID][int] IDENTITY(1, 1) NOT NULL,
//	[kullaniciID][int] NULL,
//	[sinifID][int] NULL,
//	[veliID][int] NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[ogrencino][int] NULL,
//	[dogumtarihi][datetime] NULL,
//	[tcno][int] NULL,
//	[adres][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Öğrencil__91C9526C930A5FAA] PRIMARY KEY CLUSTERED
//(
//	[ogrenciID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Ogrenciler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[OgretmenBranslari]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OgretmenBranslari]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[OgretmenBranslari]
//		(
//	[OgretmenBransID][int] IDENTITY(1, 1) NOT NULL,
//	[dersID][int] NULL,
// CONSTRAINT[PK_OgretmenBranslari] PRIMARY KEY CLUSTERED
//(
//	[OgretmenBransID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[OgretmenBranslari] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Ogretmenler]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ogretmenler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Ogretmenler]
//		(
//	[ogretmenID][int] IDENTITY(1, 1) NOT NULL,
//	[kullaniciID][int] NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[tcno][int] NULL,
//	[dogumtarihi][datetime] NULL,
//	[OgretmenBransID][int] NULL,
// CONSTRAINT[PK__Öğretmen__06E62308CE76E4F3] PRIMARY KEY CLUSTERED
//(
//	[ogretmenID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Ogretmenler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Sinavlar]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sinavlar]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Sinavlar]
//		(
//	[sinavID][int] IDENTITY(1, 1) NOT NULL,
//	[dersID][int] NULL,
//	[tarih][date] NULL,
// CONSTRAINT[PK__Sınavlar__586AC6C64C4DAA26] PRIMARY KEY CLUSTERED
//(
//	[sinavID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[Sinavlar] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[SinavSonuclari]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SinavSonuclari]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[SinavSonuclari]
//		(
//	[sonucID][int] IDENTITY(1, 1) NOT NULL,
//	[ogrenciID][int] NULL,
//	[sinavID][int] NULL,
//	[puan][float] NULL,
// CONSTRAINT[PK__SınavSon__7B5D1C404BA2CD70] PRIMARY KEY CLUSTERED
//(
//	[sonucID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[SinavSonuclari] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Siniflar]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Siniflar]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Siniflar]
//		(
//	[sinifID][int] IDENTITY(1, 1) NOT NULL,
//	[sinifAdi][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Sınıflar__9CCB809F254FE9B1] PRIMARY KEY CLUSTERED
//(
//	[sinifID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Siniflar] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Veliler]    Script Date: 13.10.2023 14:22:45 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Veliler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Veliler]
//		(
//	[veliID][int] IDENTITY(1, 1) NOT NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[telefon][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Veliler__934C88C042E9126B] PRIMARY KEY CLUSTERED
//(
//	[veliID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Veliler] TO SCHEMA OWNER
//GO
//SET IDENTITY_INSERT[dbo].[Dersler]
//		ON
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(1, N'Matematik')
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(2, N'Kimya')
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(3, N'Fizik')
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(4, N'Beden Eğitimi')
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(5, N'Müzik')
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(6, N'Bilgisayar')
//GO
//INSERT[dbo].[Dersler]
//		([dersID], [dersAdi]) VALUES(7, N'Biyoloji')
//GO
//SET IDENTITY_INSERT[dbo].[Dersler]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[Kullanicilar]
//		ON
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(1, 1, N'1', N'1', N'adasdsad', 123123)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(2, 2, N'2', N'2', N'asdasd', 123)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(3, 3, N'3', N'3', N'asda', 123)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(5, 1, N'asdad', N'a', N'asda', 123)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(6, 2, N'asda', N'asda', N'asdasd', 231)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(7, 2, N'asdas', N'asda', N'zxcx', 13123)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(8, 3, N'2', N'2', N'asd', 1231)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(9, 3, N'asdasd', N'asda', N'asdads', 123)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(10, 2, N'zxcz', N'xzczx', N'zxcz', 231)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(11, 2, N'deneme', N'asdsa', N'asdasd', 1231)
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre], [eposta], [telefon]) VALUES(12, 2, N'asd', N'asd', N'dsa', 123)
//GO
//SET IDENTITY_INSERT[dbo].[Kullanicilar]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[KullaniciTipleri]
//		ON
//GO
//INSERT[dbo].[KullaniciTipleri]
//		([tipID], [tipAdi]) VALUES(1, N'Müdür')
//GO
//INSERT[dbo].[KullaniciTipleri]
//		([tipID], [tipAdi]) VALUES(2, N'Öğretmen')
//GO
//INSERT[dbo].[KullaniciTipleri]
//		([tipID], [tipAdi]) VALUES(3, N'Öğrenci')
//GO
//SET IDENTITY_INSERT[dbo].[KullaniciTipleri]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[Mudurler]
//		ON
//GO
//INSERT[dbo].[Mudurler] ([mudurID], [kullaniciID], [ad], [soyad], [dogumtarihi], [tcno]) VALUES(1, 5, N'asda', N'asda', CAST(N'2023-10-05T21:36:14.000' AS DateTime), 1231)
//GO
//SET IDENTITY_INSERT[dbo].[Mudurler]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[Ogrenciler]
//		ON
//GO
//INSERT[dbo].[Ogrenciler] ([ogrenciID], [kullaniciID], [sinifID], [veliID], [ad], [soyad], [ogrencino], [dogumtarihi], [tcno], [adres]) VALUES(2, 9, 2, 1, N'asdas', N'asda', 123, CAST(N'2023-10-05T21:50:53.000' AS DateTime), 1231, N'asdsa')
//GO
//SET IDENTITY_INSERT[dbo].[Ogrenciler]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[OgretmenBranslari]
//		ON
//GO
//INSERT[dbo].[OgretmenBranslari]
//		([OgretmenBransID], [dersID]) VALUES(2, 4)
//GO
//SET IDENTITY_INSERT[dbo].[OgretmenBranslari]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[Ogretmenler]
//		ON
//GO
//INSERT[dbo].[Ogretmenler] ([ogretmenID], [kullaniciID], [ad], [soyad], [tcno], [dogumtarihi], [OgretmenBransID]) VALUES(1, 12, N'asd', N'asd', 123, CAST(N'2023-10-13T14:20:43.857' AS DateTime), 2)
//GO
//SET IDENTITY_INSERT[dbo].[Ogretmenler]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[Siniflar]
//		ON
//GO
//INSERT[dbo].[Siniflar]
//		([sinifID], [sinifAdi]) VALUES(1, N'1.Sınıf')
//GO
//INSERT[dbo].[Siniflar]
//		([sinifID], [sinifAdi]) VALUES(2, N'2.Sınıf')
//GO
//INSERT[dbo].[Siniflar]
//		([sinifID], [sinifAdi]) VALUES(3, N'3.Sınıf')
//GO
//INSERT[dbo].[Siniflar]
//		([sinifID], [sinifAdi]) VALUES(4, N'4.Sınıf')
//GO
//SET IDENTITY_INSERT[dbo].[Siniflar]
//		OFF
//GO
//SET IDENTITY_INSERT[dbo].[Veliler]
//		ON
//GO
//INSERT[dbo].[Veliler]
//		([veliID], [ad], [soyad], [telefon]) VALUES(1, N'sda', N'asda', N'123')
//GO
//SET IDENTITY_INSERT[dbo].[Veliler]
//		OFF
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Kullanici__tipID__398D8EEE]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kullanicilar]'))
//ALTER TABLE[dbo].[Kullanicilar] WITH CHECK ADD CONSTRAINT[FK__Kullanici__tipID__398D8EEE] FOREIGN KEY([tipID])
//REFERENCES[dbo].[KullaniciTipleri]
//		([tipID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Kullanici__tipID__398D8EEE]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kullanicilar]'))
//ALTER TABLE[dbo].[Kullanicilar]
//		CHECK CONSTRAINT[FK__Kullanici__tipID__398D8EEE]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Müdürler__kullan__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mudurler]'))
//ALTER TABLE[dbo].[Mudurler] WITH CHECK ADD CONSTRAINT[FK__Müdürler__kullan__4BAC3F29] FOREIGN KEY([kullaniciID])
//REFERENCES[dbo].[Kullanicilar]
//		([kullaniciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Müdürler__kullan__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mudurler]'))
//ALTER TABLE[dbo].[Mudurler]
//		CHECK CONSTRAINT[FK__Müdürler__kullan__4BAC3F29]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ÖğrenciDersleri_Dersler]') AND parent_object_id = OBJECT_ID(N'[dbo].[OgrenciDersleri]'))
//ALTER TABLE[dbo].[OgrenciDersleri] WITH CHECK ADD CONSTRAINT[FK_ÖğrenciDersleri_Dersler] FOREIGN KEY([dersID])
//REFERENCES[dbo].[Dersler]
//		([dersID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ÖğrenciDersleri_Dersler]') AND parent_object_id = OBJECT_ID(N'[dbo].[OgrenciDersleri]'))
//ALTER TABLE[dbo].[OgrenciDersleri]
//		CHECK CONSTRAINT[FK_ÖğrenciDersleri_Dersler]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ÖğrenciDersleri_Öğrenciler]') AND parent_object_id = OBJECT_ID(N'[dbo].[OgrenciDersleri]'))
//ALTER TABLE[dbo].[OgrenciDersleri] WITH CHECK ADD CONSTRAINT[FK_ÖğrenciDersleri_Öğrenciler] FOREIGN KEY([ogrenciID])
//REFERENCES[dbo].[Ogrenciler]
//		([ogrenciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ÖğrenciDersleri_Öğrenciler]') AND parent_object_id = OBJECT_ID(N'[dbo].[OgrenciDersleri]'))
//ALTER TABLE[dbo].[OgrenciDersleri]
//		CHECK CONSTRAINT[FK_ÖğrenciDersleri_Öğrenciler]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__kulla__4316F928]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogrenciler]'))
//ALTER TABLE[dbo].[Ogrenciler] WITH CHECK ADD CONSTRAINT[FK__Öğrencile__kulla__4316F928] FOREIGN KEY([kullaniciID])
//REFERENCES[dbo].[Kullanicilar]
//		([kullaniciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__kulla__4316F928]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogrenciler]'))
//ALTER TABLE[dbo].[Ogrenciler]
//		CHECK CONSTRAINT[FK__Öğrencile__kulla__4316F928]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__sinif__440B1D61]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogrenciler]'))
//ALTER TABLE[dbo].[Ogrenciler] WITH CHECK ADD CONSTRAINT[FK__Öğrencile__sinif__440B1D61] FOREIGN KEY([sinifID])
//REFERENCES[dbo].[Siniflar]
//		([sinifID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__sinif__440B1D61]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogrenciler]'))
//ALTER TABLE[dbo].[Ogrenciler]
//		CHECK CONSTRAINT[FK__Öğrencile__sinif__440B1D61]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Öğrenciler_Veliler]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogrenciler]'))
//ALTER TABLE[dbo].[Ogrenciler] WITH CHECK ADD CONSTRAINT[FK_Öğrenciler_Veliler] FOREIGN KEY([veliID])
//REFERENCES[dbo].[Veliler]
//		([veliID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Öğrenciler_Veliler]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogrenciler]'))
//ALTER TABLE[dbo].[Ogrenciler]
//		CHECK CONSTRAINT[FK_Öğrenciler_Veliler]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OgretmenBranslari_Dersler]') AND parent_object_id = OBJECT_ID(N'[dbo].[OgretmenBranslari]'))
//ALTER TABLE[dbo].[OgretmenBranslari] WITH CHECK ADD CONSTRAINT[FK_OgretmenBranslari_Dersler] FOREIGN KEY([dersID])
//REFERENCES[dbo].[Dersler]
//		([dersID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OgretmenBranslari_Dersler]') AND parent_object_id = OBJECT_ID(N'[dbo].[OgretmenBranslari]'))
//ALTER TABLE[dbo].[OgretmenBranslari]
//		CHECK CONSTRAINT[FK_OgretmenBranslari_Dersler]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğretmenl__kulla__48CFD27E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogretmenler]'))
//ALTER TABLE[dbo].[Ogretmenler] WITH CHECK ADD CONSTRAINT[FK__Öğretmenl__kulla__48CFD27E] FOREIGN KEY([kullaniciID])
//REFERENCES[dbo].[Kullanicilar]
//		([kullaniciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğretmenl__kulla__48CFD27E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogretmenler]'))
//ALTER TABLE[dbo].[Ogretmenler]
//		CHECK CONSTRAINT[FK__Öğretmenl__kulla__48CFD27E]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Ogretmenler_OgretmenBranslari]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogretmenler]'))
//ALTER TABLE[dbo].[Ogretmenler] WITH CHECK ADD CONSTRAINT[FK_Ogretmenler_OgretmenBranslari] FOREIGN KEY([OgretmenBransID])
//REFERENCES[dbo].[OgretmenBranslari]
//		([OgretmenBransID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Ogretmenler_OgretmenBranslari]') AND parent_object_id = OBJECT_ID(N'[dbo].[Ogretmenler]'))
//ALTER TABLE[dbo].[Ogretmenler]
//		CHECK CONSTRAINT[FK_Ogretmenler_OgretmenBranslari]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Sınavlar__dersID__403A8C7D]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sinavlar]'))
//ALTER TABLE[dbo].[Sinavlar] WITH CHECK ADD CONSTRAINT[FK__Sınavlar__dersID__403A8C7D] FOREIGN KEY([dersID])
//REFERENCES[dbo].[Dersler]
//		([dersID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Sınavlar__dersID__403A8C7D]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sinavlar]'))
//ALTER TABLE[dbo].[Sinavlar]
//		CHECK CONSTRAINT[FK__Sınavlar__dersID__403A8C7D]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__ogren__4E88ABD4]') AND parent_object_id = OBJECT_ID(N'[dbo].[SinavSonuclari]'))
//ALTER TABLE[dbo].[SinavSonuclari] WITH CHECK ADD CONSTRAINT[FK__SınavSonu__ogren__4E88ABD4] FOREIGN KEY([ogrenciID])
//REFERENCES[dbo].[Ogrenciler]
//		([ogrenciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__ogren__4E88ABD4]') AND parent_object_id = OBJECT_ID(N'[dbo].[SinavSonuclari]'))
//ALTER TABLE[dbo].[SinavSonuclari]
//		CHECK CONSTRAINT[FK__SınavSonu__ogren__4E88ABD4]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__sinav__4F7CD00D]') AND parent_object_id = OBJECT_ID(N'[dbo].[SinavSonuclari]'))
//ALTER TABLE[dbo].[SinavSonuclari] WITH CHECK ADD CONSTRAINT[FK__SınavSonu__sinav__4F7CD00D] FOREIGN KEY([sinavID])
//REFERENCES[dbo].[Sinavlar]
//		([sinavID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__sinav__4F7CD00D]') AND parent_object_id = OBJECT_ID(N'[dbo].[SinavSonuclari]'))
//ALTER TABLE[dbo].[SinavSonuclari]
//		CHECK CONSTRAINT[FK__SınavSonu__sinav__4F7CD00D]
//GO










	}
}
