USE [Agencija za nekretnine]
GO
ALTER TABLE [dbo].[Zahtev] DROP CONSTRAINT [FK_Zahtev_Kupac1]
GO
ALTER TABLE [dbo].[Zahtev] DROP CONSTRAINT [FK_Zahtev_Agent]
GO
ALTER TABLE [dbo].[Nekretnina] DROP CONSTRAINT [FK_Nekretnina_Prodavac1]
GO
ALTER TABLE [dbo].[Nekretnina] DROP CONSTRAINT [FK_Nekretnina_Agent1]
GO
/****** Object:  Table [dbo].[Zahtev]    Script Date: 24-Mar-18 5:14:19 PM ******/
DROP TABLE [dbo].[Zahtev]
GO
/****** Object:  Table [dbo].[Prodavac]    Script Date: 24-Mar-18 5:14:19 PM ******/
DROP TABLE [dbo].[Prodavac]
GO
/****** Object:  Table [dbo].[Nekretnina]    Script Date: 24-Mar-18 5:14:19 PM ******/
DROP TABLE [dbo].[Nekretnina]
GO
/****** Object:  Table [dbo].[Kupac]    Script Date: 24-Mar-18 5:14:19 PM ******/
DROP TABLE [dbo].[Kupac]
GO
/****** Object:  Table [dbo].[Agent]    Script Date: 24-Mar-18 5:14:19 PM ******/
DROP TABLE [dbo].[Agent]
GO
USE [master]
GO
/****** Object:  Database [Agencija za nekretnine]    Script Date: 24-Mar-18 5:14:19 PM ******/
DROP DATABASE [Agencija za nekretnine]
GO
/****** Object:  Database [Agencija za nekretnine]    Script Date: 24-Mar-18 5:14:19 PM ******/
CREATE DATABASE [Agencija za nekretnine]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Agencija za nekretnine', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Agencija za nekretnine.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Agencija za nekretnine_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Agencija za nekretnine_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Agencija za nekretnine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Agencija za nekretnine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET ARITHABORT OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Agencija za nekretnine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Agencija za nekretnine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Agencija za nekretnine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Agencija za nekretnine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET RECOVERY FULL 
GO
ALTER DATABASE [Agencija za nekretnine] SET  MULTI_USER 
GO
ALTER DATABASE [Agencija za nekretnine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Agencija za nekretnine] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Agencija za nekretnine] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Agencija za nekretnine] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Agencija za nekretnine] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Agencija za nekretnine', N'ON'
GO
USE [Agencija za nekretnine]
GO
/****** Object:  Table [dbo].[Agent]    Script Date: 24-Mar-18 5:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agent](
	[IdAgenta] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](20) NOT NULL,
	[Prezime] [varchar](20) NOT NULL,
	[JMBG] [varchar](13) NOT NULL,
	[BrojLicneKarte] [varchar](9) NOT NULL,
	[BrojLicence] [varchar](10) NOT NULL,
	[OpstinaRada] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Agent] PRIMARY KEY CLUSTERED 
(
	[IdAgenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kupac]    Script Date: 24-Mar-18 5:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kupac](
	[IdKupac] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](20) NOT NULL,
	[Prezime] [varchar](20) NOT NULL,
	[JMBG] [varchar](13) NOT NULL,
	[Telefon] [varchar](20) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Kupac] PRIMARY KEY CLUSTERED 
(
	[IdKupac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nekretnina]    Script Date: 24-Mar-18 5:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nekretnina](
	[IdNekretnine] [int] IDENTITY(1,1) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
	[Spratnost] [varchar](20) NOT NULL,
	[Povrsina] [varchar](20) NOT NULL,
	[Cena] [numeric](18, 0) NOT NULL,
	[Namestenost] [varchar](20) NOT NULL,
	[VrstaNekretnine] [varchar](20) NOT NULL,
	[Struktura] [varchar](20) NOT NULL,
	[Stanje] [varchar](20) NOT NULL,
	[Sprat] [int] NOT NULL,
	[Opstina] [varchar](30) NOT NULL,
	[DodatneKarakteristike] [varchar](max) NULL,
	[Napomena] [varchar](max) NULL,
	[IdAgenta] [int] NOT NULL,
	[IdProdavca] [int] NOT NULL,
 CONSTRAINT [PK_Nekretnina] PRIMARY KEY CLUSTERED 
(
	[IdNekretnine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodavac]    Script Date: 24-Mar-18 5:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodavac](
	[IdProdavac] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](20) NOT NULL,
	[Prezime] [varchar](20) NOT NULL,
	[JMBG] [varchar](13) NOT NULL,
	[Telefon] [varchar](20) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prodavac] PRIMARY KEY CLUSTERED 
(
	[IdProdavac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zahtev]    Script Date: 24-Mar-18 5:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zahtev](
	[IdZahtev] [int] IDENTITY(1,1) NOT NULL,
	[Opstina] [varchar](30) NULL,
	[Cena] [numeric](18, 0) NULL,
	[Povrsina] [varchar](20) NULL,
	[Struktura] [varchar](20) NULL,
	[IdAgenta] [int] NULL,
	[IdKupca] [int] NOT NULL,
 CONSTRAINT [PK_Zahtev] PRIMARY KEY CLUSTERED 
(
	[IdZahtev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Agent] ON 

INSERT [dbo].[Agent] ([IdAgenta], [Ime], [Prezime], [JMBG], [BrojLicneKarte], [BrojLicence], [OpstinaRada]) VALUES (7, N'Slavko', N'Zeljkovic', N'56456455454', N'100025', N'10025', N'Rakovica')
INSERT [dbo].[Agent] ([IdAgenta], [Ime], [Prezime], [JMBG], [BrojLicneKarte], [BrojLicence], [OpstinaRada]) VALUES (8, N'Vojin', N'Cetkovic', N'5965547888888', N'1234569', N'10026', N'Palilula')
INSERT [dbo].[Agent] ([IdAgenta], [Ime], [Prezime], [JMBG], [BrojLicneKarte], [BrojLicence], [OpstinaRada]) VALUES (9, N'Bojan', N'Becek', N'89655455111', N'100265999', N'50369', N'Novi Beograd')
INSERT [dbo].[Agent] ([IdAgenta], [Ime], [Prezime], [JMBG], [BrojLicneKarte], [BrojLicence], [OpstinaRada]) VALUES (10, N'Svetlana', N'Arantujev', N'0126554477777', N'002568889', N'1000569', N'Zemun')
INSERT [dbo].[Agent] ([IdAgenta], [Ime], [Prezime], [JMBG], [BrojLicneKarte], [BrojLicence], [OpstinaRada]) VALUES (11, N'Mirko', N'Perkovic', N'8764656465445', N'212121212', N'12121', N'Cukarica')
INSERT [dbo].[Agent] ([IdAgenta], [Ime], [Prezime], [JMBG], [BrojLicneKarte], [BrojLicence], [OpstinaRada]) VALUES (13, N'Zoran', N'Madzarevic', N'1203979710214', N'008965444', N'999', N'Stari grad')
SET IDENTITY_INSERT [dbo].[Agent] OFF
SET IDENTITY_INSERT [dbo].[Kupac] ON 

INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (1, N'Zivko', N'Milosevic', N'5465645645645', N'654564654564', N'54548451515')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (2, N'sasa', N'milosevic', N'1233454546545', N'545456464', N'545454545')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (3, N'bogdan', N'rajkovic', N'2415444564654', N'545454', N'54564654')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (4, N'Bogdan', N'Rajkovic', N'1156454546656', N'514545455445', N'bogdanBogdangmail.com')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (5, N'Milos', N'Jerosimic', N'1545487885787', N'121545454545', N'JerosimicM@gmail.com')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (6, N'Milos', N'Milic', N'5454645465464', N'123441', N'124241')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (7, N'Milos', N'Milosevic', N'4152122311231', N'12121212', N'dsgaggaa')
INSERT [dbo].[Kupac] ([IdKupac], [Ime], [Prezime], [JMBG], [Telefon], [Mail]) VALUES (8, N'Jovan', N'Jovic', N'4654465445646', N'1124154', N'alfssaf')
SET IDENTITY_INSERT [dbo].[Kupac] OFF
SET IDENTITY_INSERT [dbo].[Nekretnina] ON 

INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (8, N'123', N'1', N'12', CAST(12 AS Numeric(18, 0)), N'Polunamesten', N'Kuca', N'Jednosoban', N'Standardan ', 32, N'Novi Beograd', N'Topla voda; Ima vodu; Ima struju; ', N'sdggsdgsd', 10, 1)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (10, N'1234', N'1', N'123', CAST(123 AS Numeric(18, 0)), N'Polunamesten', N'Stan', N'Jednosoban', N'Za adaptaciju', 12, N'Rakovica', N'Kanalizacija; Uknjizen; Lift; ', N'ggdgdsd', 9, 2)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (11, N'milojkoviceva 10', N'1', N'345', CAST(150000 AS Numeric(18, 0)), N'Namesten', N'Lokal', N'Cetvorosoban i veci', N'Ocuvan ', 5, N'Vracar', N'Topla voda; Ima vodu; Ima struju; ', N'', 8, 3)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (14, N'Javorova 23', N'1', N'35', CAST(45000 AS Numeric(18, 0)), N'Nenamesten', N'Stan', N'Jednosoban', N'Standardan ', 3, N'Novi Beograd', N'Kanalizacija; Grejanje; Topla voda; Ima vodu; Ima struju; ', N'', 10, 4)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (15, N'Put za Ovcu bb', N'1', N'150', CAST(200000 AS Numeric(18, 0)), N'Namesten', N'Kuca', N'Trosoban', N'Standardan ', 1, N'Palilula', N'Kanalizacija; Lodja; Terasa; Uknjizen; Grejanje; Topla voda; Ima vodu; Ima struju; ', N'Sve je full', 8, 5)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (16, N'Mekenzijeva 12', N'2', N'140', CAST(185000 AS Numeric(18, 0)), N'Namesten', N'Stan', N'Trosoban', N'Standardan ', 5, N'Rakovica', N'', N'', 7, 6)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (17, N'123', N'1', N'1235', CAST(100000 AS Numeric(18, 0)), N'Polunamesten', N'Kuca', N'Jednoiposoban', N'Luksuzan', 2, N'Novi Beograd', N'', N'', 9, 1)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (18, N'1515', N'1', N'123', CAST(1500000 AS Numeric(18, 0)), N'Polunamesten', N'Kuca', N'Jednosoban', N'Ocuvan ', 1, N'Palilula', N'Topla voda; Ima vodu; Ima struju; ', N'', 8, 8)
INSERT [dbo].[Nekretnina] ([IdNekretnine], [Adresa], [Spratnost], [Povrsina], [Cena], [Namestenost], [VrstaNekretnine], [Struktura], [Stanje], [Sprat], [Opstina], [DodatneKarakteristike], [Napomena], [IdAgenta], [IdProdavca]) VALUES (19, N'5454', N'1', N'12345', CAST(124566 AS Numeric(18, 0)), N'Polunamesten', N'Garaza', N'Trosoban', N'Ocuvan ', 12, N'Zemun', N'Uknjizen; Grejanje; Topla voda; Ima vodu; Ima struju; ', N'', 10, 9)
SET IDENTITY_INSERT [dbo].[Nekretnina] OFF
SET IDENTITY_INSERT [dbo].[Prodavac] ON 

INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (1, N'Mika', N'Mikici', N'7894561239412', N'21245445454', N'123', N'123')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (2, N'grr', N'eqwqew', N'12313', N'123123', N'1234', N'12312')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (3, N'Zoran', N'Zokic', N'1234554545545', N'545645645646', N'milojkoviceva 10', N'affafafaf')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (4, N'Jakov', N'Bozinov', N'1265456444844', N'445445454', N'Javorova 23', N'JakovB@gmail.com')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (5, N'Denis', N'Redza', N'1524554554555', N'222121154555', N'Put za Ovcu bb', N'DenisDenis@gamil.com')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (6, N'Mirko', N'Ljubinkovic', N'1954523123121', N'212313156454', N'Mekenzijeva 12', N'Mirko@gmail.com')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (7, N'Jovan', N'Jovic', N'1545646545646', N'545454', N'123', N'123')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (8, N'Bogdan', N'Rajkovic', N'5645645646465', N'545445', N'1515', N'54515')
INSERT [dbo].[Prodavac] ([IdProdavac], [Ime], [Prezime], [JMBG], [Telefon], [Adresa], [Mail]) VALUES (9, N'KOVIC', N'SHFJAHAFS', N'5641546564564', N'65456456', N'5454', N'544')
SET IDENTITY_INSERT [dbo].[Prodavac] OFF
SET IDENTITY_INSERT [dbo].[Zahtev] ON 

INSERT [dbo].[Zahtev] ([IdZahtev], [Opstina], [Cena], [Povrsina], [Struktura], [IdAgenta], [IdKupca]) VALUES (1, N'Novi Beograd', CAST(415446 AS Numeric(18, 0)), N'', N'Garsonjera', 10, 3)
INSERT [dbo].[Zahtev] ([IdZahtev], [Opstina], [Cena], [Povrsina], [Struktura], [IdAgenta], [IdKupca]) VALUES (2, N'Palilula', CAST(200000 AS Numeric(18, 0)), N'', N'Troiposoban', 8, 4)
INSERT [dbo].[Zahtev] ([IdZahtev], [Opstina], [Cena], [Povrsina], [Struktura], [IdAgenta], [IdKupca]) VALUES (3, N'Stari grad', CAST(1500000 AS Numeric(18, 0)), N'1000', N'Dvoiposoban', 13, 5)
INSERT [dbo].[Zahtev] ([IdZahtev], [Opstina], [Cena], [Povrsina], [Struktura], [IdAgenta], [IdKupca]) VALUES (6, N'Palilula', CAST(1234 AS Numeric(18, 0)), N'1344', N'Dvosoban', 8, 7)
INSERT [dbo].[Zahtev] ([IdZahtev], [Opstina], [Cena], [Povrsina], [Struktura], [IdAgenta], [IdKupca]) VALUES (8, N'Novi Beograd', CAST(1564 AS Numeric(18, 0)), N'', N'Garsonjera', 9, 8)
SET IDENTITY_INSERT [dbo].[Zahtev] OFF
ALTER TABLE [dbo].[Nekretnina]  WITH CHECK ADD  CONSTRAINT [FK_Nekretnina_Agent1] FOREIGN KEY([IdAgenta])
REFERENCES [dbo].[Agent] ([IdAgenta])
GO
ALTER TABLE [dbo].[Nekretnina] CHECK CONSTRAINT [FK_Nekretnina_Agent1]
GO
ALTER TABLE [dbo].[Nekretnina]  WITH CHECK ADD  CONSTRAINT [FK_Nekretnina_Prodavac1] FOREIGN KEY([IdProdavca])
REFERENCES [dbo].[Prodavac] ([IdProdavac])
GO
ALTER TABLE [dbo].[Nekretnina] CHECK CONSTRAINT [FK_Nekretnina_Prodavac1]
GO
ALTER TABLE [dbo].[Zahtev]  WITH CHECK ADD  CONSTRAINT [FK_Zahtev_Agent] FOREIGN KEY([IdAgenta])
REFERENCES [dbo].[Agent] ([IdAgenta])
GO
ALTER TABLE [dbo].[Zahtev] CHECK CONSTRAINT [FK_Zahtev_Agent]
GO
ALTER TABLE [dbo].[Zahtev]  WITH CHECK ADD  CONSTRAINT [FK_Zahtev_Kupac1] FOREIGN KEY([IdKupca])
REFERENCES [dbo].[Kupac] ([IdKupac])
GO
ALTER TABLE [dbo].[Zahtev] CHECK CONSTRAINT [FK_Zahtev_Kupac1]
GO
USE [master]
GO
ALTER DATABASE [Agencija za nekretnine] SET  READ_WRITE 
GO
