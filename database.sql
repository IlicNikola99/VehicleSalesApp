USE [master]
GO
/****** Object:  Database [VehicleSalesDB]    Script Date: 11/12/2024 5:58:14 PM ******/
CREATE DATABASE [VehicleSalesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VehicleSalesDB', FILENAME = N'C:\Users\Nikola\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\VehicleSalesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VehicleSalesDB_log', FILENAME = N'C:\Users\Nikola\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\VehicleSalesDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VehicleSalesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VehicleSalesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VehicleSalesDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [VehicleSalesDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [VehicleSalesDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [VehicleSalesDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [VehicleSalesDB] SET ARITHABORT ON 
GO
ALTER DATABASE [VehicleSalesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VehicleSalesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [VehicleSalesDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [VehicleSalesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [VehicleSalesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VehicleSalesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VehicleSalesDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [VehicleSalesDB] SET  MULTI_USER 
GO
ALTER DATABASE [VehicleSalesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VehicleSalesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VehicleSalesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VehicleSalesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VehicleSalesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VehicleSalesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VehicleSalesDB] SET QUERY_STORE = OFF
GO
USE [VehicleSalesDB]
GO
/****** Object:  Table [dbo].[Advertisement]    Script Date: 11/12/2024 5:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertisement](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[VehicleId] [uniqueidentifier] NOT NULL,
	[AcceptsExchange] [varchar](5) NULL,
	[Price] [float] NULL,
	[Description] [varchar](max) NULL,
	[Year] [int] NULL,
	[Mileage] [int] NULL,
	[FuelType] [varchar](50) NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_Advertisement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 11/12/2024 5:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[AdvertisementId] [uniqueidentifier] NOT NULL,
	[Text] [varchar](max) NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 11/12/2024 5:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[Id] [uniqueidentifier] NOT NULL,
	[Path] [varchar](max) NOT NULL,
	[AdvertisementId] [uniqueidentifier] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[Thumbnail] [varchar](5) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/12/2024 5:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[Username] [varchar](60) NOT NULL,
	[Password] [varchar](60) NOT NULL,
	[FirstName] [varchar](30) NULL,
	[LastName] [varchar](30) NULL,
	[Address] [varchar](30) NULL,
	[City] [varchar](30) NULL,
	[PhoneNumber] [varchar](30) NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 11/12/2024 5:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [uniqueidentifier] NOT NULL,
	[Make] [varchar](30) NULL,
	[Model] [varchar](30) NULL,
	[BodyType] [varchar](30) NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Advertisement] ([Id], [UserId], [VehicleId], [AcceptsExchange], [Price], [Description], [Year], [Mileage], [FuelType], [CreatedOn]) VALUES (N'a084e062-90a4-42b4-af30-64a7685e20c1', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'f9e66289-6bb0-451c-8a47-6c29ad341715', N'False', 12314, N'test2', 2025, 123000, N'Petrol', CAST(N'2024-11-12T14:37:21.000' AS DateTime))
INSERT [dbo].[Advertisement] ([Id], [UserId], [VehicleId], [AcceptsExchange], [Price], [Description], [Year], [Mileage], [FuelType], [CreatedOn]) VALUES (N'4a5117de-95e6-4e34-b6ef-6e54ec1c148b', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'31a474d2-0645-4a6c-bbce-e68f453bacd7', N'true', 2800, N'Fabricko stanje
Oldtimer', 1988, 120000, N'Petrol', CAST(N'2024-09-30T13:54:46.570' AS DateTime))
INSERT [dbo].[Advertisement] ([Id], [UserId], [VehicleId], [AcceptsExchange], [Price], [Description], [Year], [Mileage], [FuelType], [CreatedOn]) VALUES (N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'976b0c1b-06fb-43e3-b7e2-bc341703dfef', N'False', 14599, N'• Vozilo kupljeno novo u Srbiji.
• U fabrickoj garanciji 5+5 godina ili 200.000 kilometara
• MAXX sertifikat , i pregled u 110 tacaka (kompletan detaljan pregled vozila,dostupan na uvid).
• Originalna kilometraža
• Redovno servisirano (servisna istorija ,dostupna na uvid).', 2022, 50000, N'Petrol', CAST(N'2024-09-30T13:59:14.673' AS DateTime))
INSERT [dbo].[Advertisement] ([Id], [UserId], [VehicleId], [AcceptsExchange], [Price], [Description], [Year], [Mileage], [FuelType], [CreatedOn]) VALUES (N'b0fd5776-10aa-4ed5-bda3-b67d36ea56e3', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'f831459f-75fd-42c8-a0e2-a967d2940135', N'False', 123124, N'test1', 312421, 132123, N'Diesel', CAST(N'2024-11-10T17:49:18.000' AS DateTime))
INSERT [dbo].[Advertisement] ([Id], [UserId], [VehicleId], [AcceptsExchange], [Price], [Description], [Year], [Mileage], [FuelType], [CreatedOn]) VALUES (N'834a40e5-2fbf-444a-b22f-d0455e9d1830', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'08ed3ac7-b688-4f69-9f50-65f371b3f6b5', N'false', 15850, N'Peugeot 508 1.5BlueHDI Automatic 
Active', 2019, 157000, N'Diesel', CAST(N'2024-09-30T13:50:00.940' AS DateTime))
INSERT [dbo].[Advertisement] ([Id], [UserId], [VehicleId], [AcceptsExchange], [Price], [Description], [Year], [Mileage], [FuelType], [CreatedOn]) VALUES (N'3c92aeeb-f91c-492c-9f13-e5057912ba27', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'a3630961-217d-409d-abfb-7dcd04c6daee', N'False', 12412321, N'test', 12412321, 12412321, N'Diesel', CAST(N'2024-11-10T17:48:52.000' AS DateTime))
GO
INSERT [dbo].[Comment] ([Id], [UserId], [AdvertisementId], [Text], [CreatedOn]) VALUES (N'4c5352f3-6b33-4f69-8ce2-0d80a719318e', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', N'Hello', CAST(N'2024-11-09T17:29:35.000' AS DateTime))
INSERT [dbo].[Comment] ([Id], [UserId], [AdvertisementId], [Text], [CreatedOn]) VALUES (N'b6373792-ff30-439a-9f13-b6d98b9a349c', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', N'Newest', CAST(N'2024-11-09T17:37:41.000' AS DateTime))
INSERT [dbo].[Comment] ([Id], [UserId], [AdvertisementId], [Text], [CreatedOn]) VALUES (N'a19eb8f4-ddbc-4b4f-bea5-e5fc70400c30', N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', N'New Toyota comment', CAST(N'2024-11-09T17:37:29.000' AS DateTime))
GO
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'f3d95e1f-d6e3-471d-a1b6-0d9d37f64f05', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Toyota Yaris\3.jpg', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', CAST(N'2024-11-12T13:49:18.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'ecc336f8-3f5e-43c2-9a31-4346b7cb1543', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Peugeot 508\2.jpg', N'834a40e5-2fbf-444a-b22f-d0455e9d1830', CAST(N'2024-10-27T22:02:44.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'19dbcc9e-daa6-4092-ba46-4cb79358aafb', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Toyota Yaris\2.jpg', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', CAST(N'2024-11-12T13:49:18.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'4bea424e-ca37-4cad-a3cc-527f7e2bdb62', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Peugeot 508\1.jpg', N'834a40e5-2fbf-444a-b22f-d0455e9d1830', CAST(N'2024-10-27T22:02:44.000' AS DateTime), N'True')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'f81a891c-d437-4ca0-98cd-532b39ece9aa', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Toyota Yaris\4.jpg', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', CAST(N'2024-11-12T13:49:18.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'9b6cee24-41f0-4f5b-a4d0-54dd191779d0', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Fiat 126\3.jpg', N'4a5117de-95e6-4e34-b6ef-6e54ec1c148b', CAST(N'2024-10-11T13:45:01.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'49e7f1e5-7756-41a7-b8b7-76350129ced6', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Fiat 126\1jpg.jpg', N'4a5117de-95e6-4e34-b6ef-6e54ec1c148b', CAST(N'2024-10-11T13:45:01.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'550dde3e-86a8-4707-bf25-77b5b982dcc9', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Fiat 126\2.jpg', N'4a5117de-95e6-4e34-b6ef-6e54ec1c148b', CAST(N'2024-10-11T13:45:01.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'ba2815be-f2fa-4e12-833e-939f64adabb7', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Toyota Yaris\5.jpg', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', CAST(N'2024-11-12T13:49:18.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'58bb7049-cfdf-4a43-91b2-96870ccc7c25', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Peugeot 508\637b8aa0044d-800x600-dw.jpg', N'834a40e5-2fbf-444a-b22f-d0455e9d1830', CAST(N'2024-10-27T22:02:44.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'c0fc7274-18c0-4e6e-96e2-99dbe7b734f9', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Fiat 126\4.jpg', N'4a5117de-95e6-4e34-b6ef-6e54ec1c148b', CAST(N'2024-10-11T13:45:01.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'5f163b50-626b-487a-913a-b93097981fbf', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Peugeot 508\eaad1d3c38f8-800x600-dw.jpg', N'834a40e5-2fbf-444a-b22f-d0455e9d1830', CAST(N'2024-10-27T22:02:44.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'26114c8f-0766-4859-967e-c3db2437c372', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Peugeot 508\b0a7c3629512-800x600-dw.jpg', N'834a40e5-2fbf-444a-b22f-d0455e9d1830', CAST(N'2024-10-27T22:02:44.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'606bb76f-43cd-408b-9f2c-d6782a742610', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Peugeot 508\3.jpg', N'834a40e5-2fbf-444a-b22f-d0455e9d1830', CAST(N'2024-10-27T22:02:44.000' AS DateTime), N'False')
INSERT [dbo].[Image] ([Id], [Path], [AdvertisementId], [CreatedOn], [Thumbnail]) VALUES (N'ae94147e-5363-4a29-9183-fe13f9ea0ef6', N'C:\Users\Nikola\Documents\Projektovanje softvera\PS Projekat\Server\Resource\Images\Toyota Yaris\1.jpg', N'bfe37fb8-2e6b-4fac-b6e6-b2bf62f0ef4d', CAST(N'2024-11-12T13:49:18.000' AS DateTime), N'True')
GO
INSERT [dbo].[User] ([Id], [Username], [Password], [FirstName], [LastName], [Address], [City], [PhoneNumber], [CreatedOn]) VALUES (N'35068fac-9104-4b15-aa49-4b0ad10145c0', N'testUsername', N'testPassword', N'Nikola', N'Ilic', N'Jove Ilica', N'Beograd', N'+381695378778', CAST(N'2024-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[User] ([Id], [Username], [Password], [FirstName], [LastName], [Address], [City], [PhoneNumber], [CreatedOn]) VALUES (N'fd9fb243-e482-4c5b-89ed-c3f54573689c', N'pera', N'pera', N'Pera', N'Zdera', N'Adresa 123', N'Beograd', N'+069123456', CAST(N'2024-11-08T23:17:33.000' AS DateTime))
GO
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'51b056ba-f7ee-4281-af79-0b1fb2313d0e', N'test', N'test', N'Sedane', CAST(N'2024-11-09T18:53:23.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'b5833e33-ce9f-4c27-a6d5-16ff9393aebd', N'test', N'test', N'Sedane', CAST(N'2024-11-10T17:48:22.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'f32fa049-69cf-4a05-ad49-1fe797cd2078', N'qwe', N'qwe', N'Sedane', CAST(N'2024-11-09T18:55:45.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'0829dcac-7586-4691-920e-41fbb5d7dad6', N'test', N'test', N'Sedane', CAST(N'2024-11-09T18:54:14.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'b11d2ec7-56b6-4e79-930d-4b9913cb4e2c', N'test', N'test', N'Sedane', CAST(N'2024-11-09T19:00:06.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'20a2f555-35b2-43bc-944f-4e4572945607', N'test2', N'test2', N'Sedane', CAST(N'2024-11-10T17:49:36.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'08ed3ac7-b688-4f69-9f50-65f371b3f6b5', N'Peugeot', N'508', N'Sedane', CAST(N'2024-09-30T13:50:00.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'31199774-706c-4cab-9dab-6ac76a0f1f30', N'asd', N'asd', N'Sedane', CAST(N'2024-11-08T23:24:02.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'f9e66289-6bb0-451c-8a47-6c29ad341715', N'test2', N'test2', N'Coupe', CAST(N'2024-11-12T14:37:21.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'a3630961-217d-409d-abfb-7dcd04c6daee', N'test', N'test', N'Sedane', CAST(N'2024-11-10T17:48:52.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'69663c24-41d1-48cb-afbc-97516ac5c85b', N'make1', N'model1', N'Sedane', CAST(N'2024-11-09T18:11:31.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'f10e713e-9731-418f-945e-a7483464aa6a', N'Make', N'Model', N'Sedane', CAST(N'2024-11-08T23:27:03.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'f831459f-75fd-42c8-a0e2-a967d2940135', N'test1', N'test1', N'Sedane', CAST(N'2024-11-10T17:49:18.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'976b0c1b-06fb-43e3-b7e2-bc341703dfef', N'Toyota', N'Yaris', N'Hatchback', CAST(N'2024-09-30T13:59:14.000' AS DateTime))
INSERT [dbo].[Vehicle] ([Id], [Make], [Model], [BodyType], [CreatedOn]) VALUES (N'31a474d2-0645-4a6c-bbce-e68f453bacd7', N'Fiat', N'126 P', N'Hatchback', CAST(N'2024-09-30T13:54:46.000' AS DateTime))
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__Id__35BCFE0A]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Vehicle] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Advertisement_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Advertisement_User]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Advertisement_Vehicle] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicle] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Advertisement_Vehicle]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Advertisement] FOREIGN KEY([AdvertisementId])
REFERENCES [dbo].[Advertisement] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Advertisement]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_Advertisement] FOREIGN KEY([AdvertisementId])
REFERENCES [dbo].[Advertisement] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_Advertisement]
GO
USE [master]
GO
ALTER DATABASE [VehicleSalesDB] SET  READ_WRITE 
GO
