USE [master]
GO
/****** Object:  Database [ProductsDB]    Script Date: 31.05.2021 02:14:10 ******/
CREATE DATABASE [ProductsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MCELINSKI\MSSQL\DATA\ProductsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProductsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MCELINSKI\MSSQL\DATA\ProductsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProductsDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductsDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProductsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductsDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProductsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductsDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProductsDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProductsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProductsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProductsDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProductsDB', N'ON'
GO
ALTER DATABASE [ProductsDB] SET QUERY_STORE = OFF
GO
USE [ProductsDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 31.05.2021 02:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 31.05.2021 02:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 31.05.2021 02:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Value] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producers]    Script Date: 31.05.2021 02:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProducerName] [nvarchar](50) NOT NULL,
	[ProducerCountry] [nvarchar](max) NOT NULL,
	[ProducerCity] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Producers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 31.05.2021 02:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProducerId] [int] NOT NULL,
	[ProductionYear] [int] NOT NULL,
	[OrderId] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210530215605_Init', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, N'Nabiał')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, N'Słodycze')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, N'Mięso')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (4, N'Alkohol')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [ProductId], [Quantity], [Value]) VALUES (1, 1, 10, 2000)
INSERT [dbo].[Orders] ([Id], [ProductId], [Quantity], [Value]) VALUES (2, 2, 3, 150)
INSERT [dbo].[Orders] ([Id], [ProductId], [Quantity], [Value]) VALUES (3, 3, 2, 75)
INSERT [dbo].[Orders] ([Id], [ProductId], [Quantity], [Value]) VALUES (4, 4, 120, 180)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Producers] ON 

INSERT [dbo].[Producers] ([Id], [ProducerName], [ProducerCountry], [ProducerCity]) VALUES (1, N'Sokołów', N'Poland', N'Warszawa')
INSERT [dbo].[Producers] ([Id], [ProducerName], [ProducerCountry], [ProducerCity]) VALUES (2, N'Kinder', N'Germany', N'Berlin')
INSERT [dbo].[Producers] ([Id], [ProducerName], [ProducerCountry], [ProducerCity]) VALUES (3, N'Polmos', N'Poland', N'Bielsko Biała')
INSERT [dbo].[Producers] ([Id], [ProducerName], [ProducerCountry], [ProducerCity]) VALUES (4, N'Nestle', N'Swisserland', N'Vevey')
SET IDENTITY_INSERT [dbo].[Producers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductName], [CategoryId], [ProducerId], [ProductionYear], [OrderId]) VALUES (1, N'Tatar Wołowy', 1, 3, 2021, 1)
INSERT [dbo].[Products] ([Id], [ProductName], [CategoryId], [ProducerId], [ProductionYear], [OrderId]) VALUES (2, N'Jajko Niespodzianka', 1, 2, 2019, 3)
INSERT [dbo].[Products] ([Id], [ProductName], [CategoryId], [ProducerId], [ProductionYear], [OrderId]) VALUES (4, N'Jogurt Gratka', 1, 4, 2021, 4)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 31.05.2021 02:14:10 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_OrderId]    Script Date: 31.05.2021 02:14:10 ******/
CREATE NONCLUSTERED INDEX [IX_Products_OrderId] ON [dbo].[Products]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_ProducerId]    Script Date: 31.05.2021 02:14:10 ******/
CREATE NONCLUSTERED INDEX [IX_Products_ProducerId] ON [dbo].[Products]
(
	[ProducerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Orders_OrderId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Producers_ProducerId] FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Producers_ProducerId]
GO
USE [master]
GO
ALTER DATABASE [ProductsDB] SET  READ_WRITE 
GO
