USE [master]
GO
/****** Object:  Database [zadanieDomowe2]    Script Date: 02.05.2021 20:30:35 ******/
CREATE DATABASE [zadanieDomowe2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zadanieDomowe2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MCELINSKI\MSSQL\DATA\zadanieDomowe2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zadanieDomowe2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MCELINSKI\MSSQL\DATA\zadanieDomowe2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [zadanieDomowe2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zadanieDomowe2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zadanieDomowe2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET ARITHABORT OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zadanieDomowe2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zadanieDomowe2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zadanieDomowe2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zadanieDomowe2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET RECOVERY FULL 
GO
ALTER DATABASE [zadanieDomowe2] SET  MULTI_USER 
GO
ALTER DATABASE [zadanieDomowe2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zadanieDomowe2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zadanieDomowe2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zadanieDomowe2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zadanieDomowe2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zadanieDomowe2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'zadanieDomowe2', N'ON'
GO
ALTER DATABASE [zadanieDomowe2] SET QUERY_STORE = OFF
GO
USE [zadanieDomowe2]
GO
/****** Object:  Table [dbo].[Awards]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Awards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Awards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BeerCategories]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BeerCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BeerCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Beers]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brewery_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[cat_Id] [int] NOT NULL,
	[Style_Id] [int] NOT NULL,
	[abv] [float] NOT NULL,
	[ibu] [float] NOT NULL,
	[Awards_Id] [int] NOT NULL,
	[Hop_Id] [int] NOT NULL,
	[Package_Id] [int] NOT NULL,
 CONSTRAINT [PK_Beers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BeerStyles]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BeerStyles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cat_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BeerStyles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Breweries]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Breweries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Breweries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hops]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hops](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HopName] [nvarchar](50) NOT NULL,
	[country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Hops] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Packages]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Capacity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Packages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings]    Script Date: 02.05.2021 20:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Beers_Id] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Awards] ON 

INSERT [dbo].[Awards] ([Id], [Name], [Date]) VALUES (1, N'Piwo Roku', CAST(N'2020-06-02' AS Date))
INSERT [dbo].[Awards] ([Id], [Name], [Date]) VALUES (2, N'Złoty Chmiel', CAST(N'2018-10-24' AS Date))
INSERT [dbo].[Awards] ([Id], [Name], [Date]) VALUES (3, N'World Beer Cup', CAST(N'2015-01-30' AS Date))
SET IDENTITY_INSERT [dbo].[Awards] OFF
GO
SET IDENTITY_INSERT [dbo].[BeerCategories] ON 

INSERT [dbo].[BeerCategories] ([Id], [Name]) VALUES (1, N'IPA')
INSERT [dbo].[BeerCategories] ([Id], [Name]) VALUES (2, N'Pszeniczne')
INSERT [dbo].[BeerCategories] ([Id], [Name]) VALUES (3, N'Lambic')
SET IDENTITY_INSERT [dbo].[BeerCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Beers] ON 

INSERT [dbo].[Beers] ([Id], [Brewery_Id], [Name], [cat_Id], [Style_Id], [abv], [ibu], [Awards_Id], [Hop_Id], [Package_Id]) VALUES (1, 1, N'Książęce IPA', 1, 1, 5.4, 20, 1, 1, 1)
INSERT [dbo].[Beers] ([Id], [Brewery_Id], [Name], [cat_Id], [Style_Id], [abv], [ibu], [Awards_Id], [Hop_Id], [Package_Id]) VALUES (2, 2, N'Żywiec Amerykańska Pszenica', 2, 2, 4.9, 9, 2, 2, 2)
INSERT [dbo].[Beers] ([Id], [Brewery_Id], [Name], [cat_Id], [Style_Id], [abv], [ibu], [Awards_Id], [Hop_Id], [Package_Id]) VALUES (4, 3, N'Lindemans Framboise', 3, 3, 2.5, 12, 3, 3, 3)
SET IDENTITY_INSERT [dbo].[Beers] OFF
GO
SET IDENTITY_INSERT [dbo].[BeerStyles] ON 

INSERT [dbo].[BeerStyles] ([Id], [Cat_Id], [Name]) VALUES (1, 1, N'Górna Fermentacja')
INSERT [dbo].[BeerStyles] ([Id], [Cat_Id], [Name]) VALUES (2, 2, N'Dolna Fermentacja')
INSERT [dbo].[BeerStyles] ([Id], [Cat_Id], [Name]) VALUES (3, 3, N'Spontaniczna Fermentacja')
SET IDENTITY_INSERT [dbo].[BeerStyles] OFF
GO
SET IDENTITY_INSERT [dbo].[Breweries] ON 

INSERT [dbo].[Breweries] ([Id], [Name], [Adress], [City], [Country]) VALUES (1, N'Kompania Piwowarska', N'Browarowa 7', N'Tychy', N'Polska')
INSERT [dbo].[Breweries] ([Id], [Name], [Adress], [City], [Country]) VALUES (2, N'Grupa Zywiec', N'Browarnicza 54', N'Zwywiec', N'Polska')
INSERT [dbo].[Breweries] ([Id], [Name], [Adress], [City], [Country]) VALUES (3, N'Brouwerij Lindemans
', N'Lenniksebaan 1479', N'1602 ', N'Belgia')
SET IDENTITY_INSERT [dbo].[Breweries] OFF
GO
SET IDENTITY_INSERT [dbo].[Hops] ON 

INSERT [dbo].[Hops] ([Id], [HopName], [country]) VALUES (1, N'Azacca', N'USA')
INSERT [dbo].[Hops] ([Id], [HopName], [country]) VALUES (2, N'Mosaic', N'USA')
INSERT [dbo].[Hops] ([Id], [HopName], [country]) VALUES (3, N'Aramis', N'Francja')
SET IDENTITY_INSERT [dbo].[Hops] OFF
GO
SET IDENTITY_INSERT [dbo].[Packages] ON 

INSERT [dbo].[Packages] ([Id], [Name], [Capacity]) VALUES (1, N'Puszka', N'0,5')
INSERT [dbo].[Packages] ([Id], [Name], [Capacity]) VALUES (2, N'Butelka', N'0,5')
INSERT [dbo].[Packages] ([Id], [Name], [Capacity]) VALUES (3, N'Butelka', N'0,75')
SET IDENTITY_INSERT [dbo].[Packages] OFF
GO
SET IDENTITY_INSERT [dbo].[Ratings] ON 

INSERT [dbo].[Ratings] ([Id], [Beers_Id], [Username], [Date], [Description]) VALUES (1, 1, N'Piwosz1971', CAST(N'2000-05-04' AS Date), N'Za tą cenę . Z tego browaru . Całkiem niezłe .
')
INSERT [dbo].[Ratings] ([Id], [Beers_Id], [Username], [Date], [Description]) VALUES (3, 2, N'beerboy69', CAST(N'2012-07-14' AS Date), N'Najgorsze piwo jakie piłem, liczyłem na coś lepszego ochyda
')
INSERT [dbo].[Ratings] ([Id], [Beers_Id], [Username], [Date], [Description]) VALUES (4, 3, N'bobby24', CAST(N'2015-10-25' AS Date), N'Oczekiwałem od tego piwa wyrwania z butów. Cóż, jak dla mnie było to jednak zbyt słodkie. Wolę zdecydowanie lambica z wiśnią, jest bardziej taki ułożony i pijalny :) To piwo smakuję identycznie jak sok malinowy.
')
SET IDENTITY_INSERT [dbo].[Ratings] OFF
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_Beers_Awards] FOREIGN KEY([Awards_Id])
REFERENCES [dbo].[Awards] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_Beers_Awards]
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_Beers_BeerCategories] FOREIGN KEY([cat_Id])
REFERENCES [dbo].[BeerCategories] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_Beers_BeerCategories]
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_Beers_BeerStyles] FOREIGN KEY([Style_Id])
REFERENCES [dbo].[BeerStyles] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_Beers_BeerStyles]
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_Beers_Breweries] FOREIGN KEY([Brewery_Id])
REFERENCES [dbo].[Breweries] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_Beers_Breweries]
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_Beers_Hops] FOREIGN KEY([Hop_Id])
REFERENCES [dbo].[Hops] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_Beers_Hops]
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_Beers_Packages] FOREIGN KEY([Package_Id])
REFERENCES [dbo].[Packages] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_Beers_Packages]
GO
USE [master]
GO
ALTER DATABASE [zadanieDomowe2] SET  READ_WRITE 
GO
