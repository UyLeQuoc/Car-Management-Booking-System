USE [master]
GO
/****** Object:  Database [FUFlowerBouquetManagementV4]    Script Date: 8/22/2023 4:37:48 PM ******/
CREATE DATABASE [FUFlowerBouquetManagementV4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FUFlowerBouquetManagementV4', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.LONGVU\MSSQL\DATA\FUFlowerBouquetManagementV4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FUFlowerBouquetManagementV4_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.LONGVU\MSSQL\DATA\FUFlowerBouquetManagementV4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FUFlowerBouquetManagementV4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ARITHABORT OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET  MULTI_USER 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET QUERY_STORE = ON
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FUFlowerBouquetManagementV4]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/22/2023 4:37:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [varchar](40) NOT NULL,
	[CategoryDescription] [nvarchar](150) NULL,
	[CategoryNote] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 8/22/2023 4:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CustomerName] [varchar](180) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	[Birthday] [date] NULL,
	[CustomerStatus] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FlowerBouquet]    Script Date: 8/22/2023 4:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FlowerBouquet](
	[FlowerBouquetID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[FlowerBouquetName] [varchar](40) NOT NULL,
	[Description] [varchar](220) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
	[FlowerBouquetStatus] [tinyint] NULL,
	[SupplierID] [int] NULL,
	[Morphology] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[FlowerBouquetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 8/22/2023 4:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] NOT NULL,
	[CustomerID] [int] NULL,
	[OrderDate] [datetime] NOT NULL,
	[ShippedDate] [datetime] NULL,
	[Total] [money] NULL,
	[OrderStatus] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 8/22/2023 4:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderID] [int] NOT NULL,
	[FlowerBouquetID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[FlowerBouquetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 8/22/2023 4:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
	[SupplierAddress] [nvarchar](150) NULL,
	[Telephone] [nchar](15) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription], [CategoryNote]) VALUES (1, N'Hand-tied bouquets', N'This type of bouquet is made by gathering flowers and foliage in a natural, unstructured way, then tying them together with ribbon or twine.', NULL)
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription], [CategoryNote]) VALUES (2, N'Posy bouquets', N'Posy bouquets are small, compact bouquets that are often used for bridesmaids or as a toss bouquet.', NULL)
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription], [CategoryNote]) VALUES (3, N'Cascading bouquets', N'These bouquets feature flowers that trail down in a cascading shape, often with a mix of different types of flowers and foliage.', NULL)
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription], [CategoryNote]) VALUES (4, N'Presentation bouquets', N'These bouquets are often long-stemmed and held upright, such as when presenting flowers to a performer or as a gift to someone.', NULL)
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription], [CategoryNote]) VALUES (5, N'Nosegay bouquets', N'Nosegay bouquets are dense, circular bouquets that are often used for weddings and feature a mix of different types of flowers and foliage.', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (1, N'DavidCopperfield@fuflowerbouquetsystem.com', N'David Copperfield', N'HCM', N'Viet Nam', N'1', CAST(N'1990-02-02' AS Date), 1)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (2, N'StevenAllanSpielber@fuflowerbouquetsystem.com', N'Steven Allan Spielber', N'Thu Duc', N'Viet Nam', N'1', CAST(N'1999-05-05' AS Date), 1)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (3, N'RobertCapshaw@fuflowerbouquetsystem.com', N'Robert Capshaw', N'London', N'UK', N'1', CAST(N'1988-05-09' AS Date), 0)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (4, N'JohnLemon@fuflowerbouquetsystem.com', N'John Lemon', N'London', N'UK', N'2', CAST(N'2000-05-05' AS Date), 0)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (5, N'vulongbinhduong@gmail.com', N'Long', N'TDM', N'VN', N'1', CAST(N'2023-08-14' AS Date), 1)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (6, N'mai@example.com', N'Mai', N'ST', N'VN', N'1', CAST(N'2023-08-20' AS Date), 0)
GO
INSERT [dbo].[Customer] ([CustomerID], [Email], [CustomerName], [City], [Country], [Password], [Birthday], [CustomerStatus]) VALUES (7, N'hoadnt@gmail.com', N'Hoa Doan ', N'Long An', N'VN', N'3', CAST(N'1993-02-27' AS Date), 1)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (1, 2, N'A New Day', N'Flowers to put a smile on their face. Let them know that you''re thinking of them with this fun petite collection of flowers and foliage to send same day. ', 130.0000, 10, 1, 2, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (2, 1, N'Hello', N'Say hello in style with this fabulous hand-tied.', 125.0000, 10, 1, 1, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (3, 2, N'Splash of Colour', N'A vibrant gerbera posy hand-tied featuring a mix of colours carefully selected by the local florist. Hand-delivered in a gift bag or box.', 230.0000, 10, 1, 2, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (4, 2, N'Lemon & Lime', N'A beautiful collection of flowers simply wrapped and ready to arrange.
', 140.0000, 10, 1, 1, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (5, 2, N'Mother''s Day', N'Let the experts work their magic with a unique Mother’s Day gift.', 160.0000, 5, 1, 2, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (6, 1, N'Pink Roses', N'Vase of pink roses with mixed foliages and white waxflower', 175.0000, 5, 1, 1, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (7, 1, N'Cool Breeze', N'This classical stylish collection of flowers make this hand tied the perfect gift. Professionally arranged and delivered by a local florist. Available for same day delivery when ordered before 2pm.', 120.0000, 10, 1, 1, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (8, 1, N'Rose', N'qqq', 120.0000, 2, 0, 3, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (9, 3, N'Hong Le Hong Tham', N'cha biet nua', 120.0000, 5, 0, 2, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (11, 1, N'1', N'1', 1.0000, 1, 1, 1, NULL)
GO
INSERT [dbo].[FlowerBouquet] ([FlowerBouquetID], [CategoryID], [FlowerBouquetName], [Description], [UnitPrice], [UnitsInStock], [FlowerBouquetStatus], [SupplierID], [Morphology]) VALUES (111, 1, N'', N'', 1.0000, 1, 1, 1, NULL)
GO
INSERT [dbo].[Order] ([OrderID], [CustomerID], [OrderDate], [ShippedDate], [Total], [OrderStatus]) VALUES (4000, 1, CAST(N'2023-04-26T00:00:00.000' AS DateTime), CAST(N'2023-04-27T00:00:00.000' AS DateTime), 670.0000, N'1         ')
GO
INSERT [dbo].[Order] ([OrderID], [CustomerID], [OrderDate], [ShippedDate], [Total], [OrderStatus]) VALUES (4001, 2, CAST(N'2023-04-26T00:00:00.000' AS DateTime), CAST(N'2023-04-27T00:00:00.000' AS DateTime), 295.0000, N'1         ')
GO
INSERT [dbo].[OrderDetail] ([OrderID], [FlowerBouquetID], [UnitPrice], [Quantity], [Discount]) VALUES (4000, 1, 100.0000, 2, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [FlowerBouquetID], [UnitPrice], [Quantity], [Discount]) VALUES (4000, 2, 120.0000, 2, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [FlowerBouquetID], [UnitPrice], [Quantity], [Discount]) VALUES (4000, 3, 230.0000, 1, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [FlowerBouquetID], [UnitPrice], [Quantity], [Discount]) VALUES (4001, 1, 120.0000, 1, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [FlowerBouquetID], [UnitPrice], [Quantity], [Discount]) VALUES (4001, 6, 175.0000, 1, 0)
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierAddress], [Telephone]) VALUES (1, N'007 Flower', N'142A Vo Thi Sau Street, Ward 12, District 3, HCMC', N'1800 6102      ')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierAddress], [Telephone]) VALUES (2, N'Flower Lovers', N'09 3/2 Street, Ward 11, District 10, HCMC', N'093 204 05 15  ')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierAddress], [Telephone]) VALUES (3, N'Love Florist', N'3 Tran Quoc Thao Streed, Ward 6, District 3, HCMC', N'093 888 61 02  ')
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CustomerStatus]  DEFAULT ((1)) FOR [CustomerStatus]
GO
ALTER TABLE [dbo].[FlowerBouquet]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FlowerBouquet]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([FlowerBouquetID])
REFERENCES [dbo].[FlowerBouquet] ([FlowerBouquetID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [FUFlowerBouquetManagementV4] SET  READ_WRITE 
GO
