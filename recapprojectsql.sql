
USE [master]
GO
/****** Object:  Database [ReCapProject]    Script Date: 2/18/2021 4:55:44 PM ******/
CREATE DATABASE [ReCapProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReCapProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ReCapProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReCapProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ReCapProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ReCapProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReCapProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReCapProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ReCapProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ReCapProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ReCapProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ReCapProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [ReCapProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ReCapProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReCapProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReCapProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReCapProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ReCapProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ReCapProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReCapProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ReCapProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReCapProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ReCapProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReCapProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReCapProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReCapProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReCapProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReCapProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReCapProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReCapProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ReCapProject] SET  MULTI_USER 
GO
ALTER DATABASE [ReCapProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReCapProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReCapProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReCapProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReCapProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReCapProject] SET QUERY_STORE = OFF
GO
USE [ReCapProject]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 2/18/2021 4:55:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 2/18/2021 4:55:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NULL,
	[ColorId] [int] NULL,
	[DealyPrice] [decimal](18, 0) NULL,
	[Description] [nvarchar](max) NULL,
	[ModelYear] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 2/18/2021 4:55:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2/18/2021 4:55:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CompanyName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 2/18/2021 4:55:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NULL,
	[CustomerId] [int] NULL,
	[RentDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/18/2021 4:55:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (1, N'Mercedes', N'Mercedes açıklama')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (2, N'Audi', N'Audi açıklama')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (3, N'Skoda', N'Audi açıklama')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [DealyPrice], [Description], [ModelYear]) VALUES (1, 1, 2, CAST(800 AS Decimal(18, 0)), N'açıklama', N'1987')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [DealyPrice], [Description], [ModelYear]) VALUES (2, 2, 1, CAST(900 AS Decimal(18, 0)), N'açıklama 2', N'1993')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [DealyPrice], [Description], [ModelYear]) VALUES (3, 2, 3, CAST(1000 AS Decimal(18, 0)), N'açıklama 3 ', N'200')
GO
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 
GO
INSERT [dbo].[Colors] ([Id], [Name], [Description]) VALUES (1, N'Mavi', N'Mavi açıklama ')
GO
INSERT [dbo].[Colors] ([Id], [Name], [Description]) VALUES (2, N'Sarı', N'Sarı açıklama')
GO
INSERT [dbo].[Colors] ([Id], [Name], [Description]) VALUES (3, N'Lacivert', N'Lacivert Açıklama')
GO
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
USE [master]
GO
ALTER DATABASE [ReCapProject] SET  READ_WRITE 
GO
