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

		
//		/*    ==Scripting Parameters==

//    Source Server Version : SQL Server 2022 (16.0.1050)
//    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
//    Source Database Engine Type : Standalone SQL Server

//    Target Server Version : SQL Server 2022
//    Target Database Engine Edition : Microsoft SQL Server Enterprise Edition
//    Target Database Engine Type : Standalone SQL Server

//	EgitimOtomasyonu db adı


//*/

//		USE[master]
//		GO
///* For security reasons the login is created disabled and with a random password. */
//		/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT* FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
//CREATE LOGIN[##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'RBJUyZD5cz/Ivs7GpkVGZHpYqiI2kpmqCiafnTyMHW0=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
//GO
//ALTER LOGIN[##MS_PolicyEventProcessingLogin##] DISABLE
//GO
///* For security reasons the login is created disabled and with a random password. */
///****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
//CREATE LOGIN[##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'cbZzZNBsjftOadp47CIEsdNXOw9btKnQxGC8jGd7r3k=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
//GO
//ALTER LOGIN[##MS_PolicyTsqlExecutionLogin##] DISABLE
//GO
///****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
//CREATE LOGIN[NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLSERVERAGENT')
//CREATE LOGIN[NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLTELEMETRY]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLTELEMETRY')
//CREATE LOGIN[NT SERVICE\SQLTELEMETRY] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
///****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLWriter')
//CREATE LOGIN[NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
///****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\Winmgmt')
//CREATE LOGIN[NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
///****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'NT Service\MSSQLSERVER')
//CREATE LOGIN[NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
///****** Object:  Login [OZGUVEN\djpus]    Script Date: 9.10.2023 20:16:10 ******/
//IF NOT EXISTS(SELECT * FROM sys.server_principals WHERE name = N'OZGUVEN\djpus')
//CREATE LOGIN[OZGUVEN\djpus] FROM WINDOWS WITH DEFAULT_DATABASE =[master], DEFAULT_LANGUAGE =[us_english]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\SQLSERVERAGENT]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\SQLWriter]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT SERVICE\Winmgmt]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[NT Service\MSSQLSERVER]
//GO
//ALTER SERVER ROLE[sysadmin] ADD MEMBER[OZGUVEN\djpus]
//GO
//USE[EgitimOtomasyonu]
//GO
///****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9.10.2023 20:16:10 ******/
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
///****** Object:  Table [dbo].[Dersler]    Script Date: 9.10.2023 20:16:10 ******/
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
//		(
//	[dersID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Dersler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Kullanicilar]    Script Date: 9.10.2023 20:16:10 ******/
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
//	[kullaniciID][int] IDENTITY(1,1) NOT NULL,
//	[tipID] [int] NULL,
//	[kullaniciAdi][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[sifre][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Kullanic__848DC54B6FCC88F1] PRIMARY KEY CLUSTERED
//		(
//	[kullaniciID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Kullanicilar] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[KullaniciTipleri]    Script Date: 9.10.2023 20:16:10 ******/
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
//	[tipID][int] IDENTITY(1,1) NOT NULL,
//	[tipAdi] [varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Kullanic__E4250CDB78DFD36D] PRIMARY KEY CLUSTERED
//		(
//	[tipID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[KullaniciTipleri] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Müdürler]    Script Date: 9.10.2023 20:16:10 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Müdürler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Müdürler]
//		(
//	[mudurID][int] IDENTITY(1,1) NOT NULL,
//	[kullaniciID] [int] NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Müdürler__27A6DB1DCA055500] PRIMARY KEY CLUSTERED
//		(
//	[mudurID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Müdürler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Öğrenciler]    Script Date: 9.10.2023 20:16:10 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Öğrenciler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Öğrenciler]
//		(
//	[ogrenciID][int] IDENTITY(1,1) NOT NULL,
//	[kullaniciID] [int] NULL,
//	[sinifID][int] NULL,
//	[veliID][int] NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Öğrencil__91C9526C930A5FAA] PRIMARY KEY CLUSTERED
//		(
//	[ogrenciID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Öğrenciler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Öğretmenler]    Script Date: 9.10.2023 20:16:10 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Öğretmenler]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Öğretmenler]
//		(
//	[ogretmenID][int] IDENTITY(1,1) NOT NULL,
//	[kullaniciID] [int] NULL,
//	[ad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Öğretmen__06E62308CE76E4F3] PRIMARY KEY CLUSTERED
//		(
//	[ogretmenID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Öğretmenler] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Sınavlar]    Script Date: 9.10.2023 20:16:10 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sınavlar]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Sınavlar]
//		(
//	[sinavID][int] IDENTITY(1,1) NOT NULL,
//	[dersID] [int] NULL,
//	[tarih][date] NULL,
// CONSTRAINT[PK__Sınavlar__586AC6C64C4DAA26] PRIMARY KEY CLUSTERED
//(
//	[sinavID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[Sınavlar] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[SınavSonuçları]    Script Date: 9.10.2023 20:16:10 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SınavSonuçları]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[SınavSonuçları]
//		(
//	[sonucID][int] IDENTITY(1,1) NOT NULL,
//	[ogrenciID] [int] NULL,
//	[sinavID][int] NULL,
//	[puan][float] NULL,
// CONSTRAINT[PK__SınavSon__7B5D1C404BA2CD70] PRIMARY KEY CLUSTERED
//(
//	[sonucID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//ALTER AUTHORIZATION ON[dbo].[SınavSonuçları] TO SCHEMA OWNER
//GO
///****** Object:  Table [dbo].[Sınıflar]    Script Date: 9.10.2023 20:16:10 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//SET ANSI_PADDING ON
//		GO
//IF NOT EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sınıflar]') AND type in (N'U'))
//BEGIN
//CREATE TABLE[dbo].[Sınıflar]
//		(
//	[sinifID][int] IDENTITY(1,1) NOT NULL,
//	[sinifAdi] [varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Sınıflar__9CCB809F254FE9B1] PRIMARY KEY CLUSTERED
//		(
//	[sinifID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Sınıflar] TO SCHEMA OWNER
//		GO
///****** Object:  Table [dbo].[Veliler]    Script Date: 9.10.2023 20:16:10 ******/
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
//	[veliID][int] IDENTITY(1,1) NOT NULL,
//	[ad] [varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[soyad][varchar] (255) COLLATE Turkish_CI_AS NULL,
//	[telefon][varchar] (255) COLLATE Turkish_CI_AS NULL,
// CONSTRAINT[PK__Veliler__934C88C042E9126B] PRIMARY KEY CLUSTERED
//		(
//	[veliID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//END
//GO
//SET ANSI_PADDING OFF
//GO
//ALTER AUTHORIZATION ON[dbo].[Veliler] TO SCHEMA OWNER
//GO
//SET IDENTITY_INSERT[dbo].[Kullanicilar]
//		ON
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre]) VALUES(1, 1, N'1', N'1')
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre]) VALUES(2, 2, N'2', N'2')
//GO
//INSERT[dbo].[Kullanicilar]
//		([kullaniciID], [tipID], [kullaniciAdi], [sifre]) VALUES(3, 3, N'3', N'3')
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
//SET IDENTITY_INSERT[dbo].[Sınıflar]
//		ON
//GO
//INSERT[dbo].[Sınıflar]
//		([sinifID], [sinifAdi]) VALUES(1, N'1.Sınıf')
//GO
//INSERT[dbo].[Sınıflar]
//		([sinifID], [sinifAdi]) VALUES(2, N'2.Sınıf')
//GO
//INSERT[dbo].[Sınıflar]
//		([sinifID], [sinifAdi]) VALUES(3, N'3.Sınıf')
//GO
//INSERT[dbo].[Sınıflar]
//		([sinifID], [sinifAdi]) VALUES(4, N'4.Sınıf')
//GO
//		SET IDENTITY_INSERT[dbo].[Sınıflar]
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
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Müdürler__kullan__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[Müdürler]'))
//ALTER TABLE[dbo].[Müdürler] WITH CHECK ADD CONSTRAINT[FK__Müdürler__kullan__4BAC3F29] FOREIGN KEY([kullaniciID])
//REFERENCES[dbo].[Kullanicilar]
//		([kullaniciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Müdürler__kullan__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[Müdürler]'))
//ALTER TABLE[dbo].[Müdürler]
//		CHECK CONSTRAINT[FK__Müdürler__kullan__4BAC3F29]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__kulla__4316F928]') AND parent_object_id = OBJECT_ID(N'[dbo].[Öğrenciler]'))
//ALTER TABLE[dbo].[Öğrenciler] WITH CHECK ADD CONSTRAINT[FK__Öğrencile__kulla__4316F928] FOREIGN KEY([kullaniciID])
//REFERENCES[dbo].[Kullanicilar]
//		([kullaniciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__kulla__4316F928]') AND parent_object_id = OBJECT_ID(N'[dbo].[Öğrenciler]'))
//ALTER TABLE[dbo].[Öğrenciler]
//		CHECK CONSTRAINT[FK__Öğrencile__kulla__4316F928]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__sinif__440B1D61]') AND parent_object_id = OBJECT_ID(N'[dbo].[Öğrenciler]'))
//ALTER TABLE[dbo].[Öğrenciler] WITH CHECK ADD CONSTRAINT[FK__Öğrencile__sinif__440B1D61] FOREIGN KEY([sinifID])
//REFERENCES[dbo].[Sınıflar]
//		([sinifID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğrencile__sinif__440B1D61]') AND parent_object_id = OBJECT_ID(N'[dbo].[Öğrenciler]'))
//ALTER TABLE[dbo].[Öğrenciler]
//		CHECK CONSTRAINT[FK__Öğrencile__sinif__440B1D61]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğretmenl__kulla__48CFD27E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Öğretmenler]'))
//ALTER TABLE[dbo].[Öğretmenler] WITH CHECK ADD CONSTRAINT[FK__Öğretmenl__kulla__48CFD27E] FOREIGN KEY([kullaniciID])
//REFERENCES[dbo].[Kullanicilar]
//		([kullaniciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Öğretmenl__kulla__48CFD27E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Öğretmenler]'))
//ALTER TABLE[dbo].[Öğretmenler]
//		CHECK CONSTRAINT[FK__Öğretmenl__kulla__48CFD27E]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Sınavlar__dersID__403A8C7D]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sınavlar]'))
//ALTER TABLE[dbo].[Sınavlar] WITH CHECK ADD CONSTRAINT[FK__Sınavlar__dersID__403A8C7D] FOREIGN KEY([dersID])
//REFERENCES[dbo].[Dersler]
//		([dersID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Sınavlar__dersID__403A8C7D]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sınavlar]'))
//ALTER TABLE[dbo].[Sınavlar]
//		CHECK CONSTRAINT[FK__Sınavlar__dersID__403A8C7D]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__ogren__4E88ABD4]') AND parent_object_id = OBJECT_ID(N'[dbo].[SınavSonuçları]'))
//ALTER TABLE[dbo].[SınavSonuçları] WITH CHECK ADD CONSTRAINT[FK__SınavSonu__ogren__4E88ABD4] FOREIGN KEY([ogrenciID])
//REFERENCES[dbo].[Öğrenciler]
//		([ogrenciID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__ogren__4E88ABD4]') AND parent_object_id = OBJECT_ID(N'[dbo].[SınavSonuçları]'))
//ALTER TABLE[dbo].[SınavSonuçları]
//		CHECK CONSTRAINT[FK__SınavSonu__ogren__4E88ABD4]
//GO
//IF NOT EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__sinav__4F7CD00D]') AND parent_object_id = OBJECT_ID(N'[dbo].[SınavSonuçları]'))
//ALTER TABLE[dbo].[SınavSonuçları] WITH CHECK ADD CONSTRAINT[FK__SınavSonu__sinav__4F7CD00D] FOREIGN KEY([sinavID])
//REFERENCES[dbo].[Sınavlar]
//		([sinavID])
//GO
//IF EXISTS(SELECT* FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SınavSonu__sinav__4F7CD00D]') AND parent_object_id = OBJECT_ID(N'[dbo].[SınavSonuçları]'))
//ALTER TABLE[dbo].[SınavSonuçları]
//		CHECK CONSTRAINT[FK__SınavSonu__sinav__4F7CD00D]
//GO



		
		

	}
}
