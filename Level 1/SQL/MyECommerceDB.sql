USE [master]
GO
/****** Object:  Database [MyECommerceDB]    Script Date: 2022/03/07 16:20:48 ******/
CREATE DATABASE [MyECommerceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyECommerceDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.CHILLISOFT\MSSQL\DATA\MyECommerceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyECommerceDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.CHILLISOFT\MSSQL\DATA\MyECommerceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyECommerceDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyECommerceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyECommerceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyECommerceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyECommerceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyECommerceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyECommerceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyECommerceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyECommerceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyECommerceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyECommerceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyECommerceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyECommerceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyECommerceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyECommerceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyECommerceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyECommerceDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyECommerceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyECommerceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyECommerceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyECommerceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyECommerceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyECommerceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyECommerceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyECommerceDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyECommerceDB] SET  MULTI_USER 
GO
ALTER DATABASE [MyECommerceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyECommerceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyECommerceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyECommerceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyECommerceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyECommerceDB] SET QUERY_STORE = OFF
GO
USE [MyECommerceDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Category_Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](50) NULL,
	[Category_Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Category_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Email] [nvarchar](50) NULL,
	[First_Name] [nvarchar](50) NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](50) NULL,
	[Phone_Number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Order_No] [int] IDENTITY(1,1) NOT NULL,
	[Order_Date] [datetime] NULL,
	[Order_Total] [decimal](18, 2) NULL,
	[Shipping_Date] [datetime] NULL,
	[Is_Delivered] [bit] NULL,
	[Date_Delivered] [datetime] NULL,
	[Customer_Id] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Order_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Order_Details_Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Id] [int] NULL,
	[Product_Qty] [int] NULL,
	[Product_Price] [decimal](18, 2) NULL,
	[Order_No] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Order_Details_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [nvarchar](max) NULL,
	[Product_Description] [nvarchar](max) NULL,
	[Image] [nvarchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[Stock] [int] NULL,
	[Category_Id] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Category_Id], [Category_Name], [Category_Description]) VALUES (1, N'Electronics', N'Electronics products')
INSERT [dbo].[Category] ([Category_Id], [Category_Name], [Category_Description]) VALUES (2, N'Jewelery', N'Jewelery products')
INSERT [dbo].[Category] ([Category_Id], [Category_Name], [Category_Description]) VALUES (3, N'Men clothing', N'Clothing for men')
INSERT [dbo].[Category] ([Category_Id], [Category_Name], [Category_Description]) VALUES (4, N'Womem clothing', N'Clothing for womem')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Customer_Id], [Customer_Email], [First_Name], [Last_Name], [Address], [City], [Phone_Number]) VALUES (1, N'njabulo.dlamini@Chillisoft.co.za', N'Njabulo', N'Dlamini', N'3443 Nana dube road Kwamakhutha', N'Durban', N'0747064125')
INSERT [dbo].[Customer] ([Customer_Id], [Customer_Email], [First_Name], [Last_Name], [Address], [City], [Phone_Number]) VALUES (2, N'john@gmail.co.za', N'John', N'Craig', N'368 Smith Road', N'Johannesburg', N'0825946532')
INSERT [dbo].[Customer] ([Customer_Id], [Customer_Email], [First_Name], [Last_Name], [Address], [City], [Phone_Number]) VALUES (3, N'', N'Khulile', N'Dunga', N'7005 Morningside road', N'Durban', N'0714896135')
INSERT [dbo].[Customer] ([Customer_Id], [Customer_Email], [First_Name], [Last_Name], [Address], [City], [Phone_Number]) VALUES (4, N'', N'Nicole', N'Khuzwayo', N'313 west avenue', N'Cape Town', N'0731569783')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (2, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(168.00 AS Decimal(18, 2)), CAST(N'2022-03-15T00:00:00.000' AS DateTime), 0, NULL, 1)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (3, CAST(N'2022-03-04T00:00:00.000' AS DateTime), CAST(114.00 AS Decimal(18, 2)), CAST(N'2022-03-07T00:00:00.000' AS DateTime), 0, NULL, 1)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (4, CAST(N'2022-03-03T00:00:00.000' AS DateTime), CAST(320.00 AS Decimal(18, 2)), CAST(N'2022-03-08T00:00:00.000' AS DateTime), 0, NULL, 2)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (5, CAST(N'2022-03-06T00:00:00.000' AS DateTime), CAST(695.00 AS Decimal(18, 2)), CAST(N'2022-03-18T00:00:00.000' AS DateTime), 0, NULL, 2)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (6, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(90.00 AS Decimal(18, 2)), CAST(N'2022-03-19T00:00:00.000' AS DateTime), 0, NULL, 2)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (7, CAST(N'2022-03-02T00:00:00.000' AS DateTime), CAST(220.00 AS Decimal(18, 2)), CAST(N'2022-03-20T00:00:00.000' AS DateTime), 0, NULL, 3)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (8, CAST(N'2022-03-06T00:00:00.000' AS DateTime), CAST(168.00 AS Decimal(18, 2)), CAST(N'2022-03-21T00:00:00.000' AS DateTime), 0, NULL, 3)
INSERT [dbo].[Order] ([Order_No], [Order_Date], [Order_Total], [Shipping_Date], [Is_Delivered], [Date_Delivered], [Customer_Id]) VALUES (9, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(218.00 AS Decimal(18, 2)), NULL, 0, NULL, 4)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (2, 4, 1, CAST(168.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (3, 7, 2, CAST(57.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (4, 5, 5, CAST(64.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (5, 3, 1, CAST(695.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (6, 8, 3, CAST(30.00 AS Decimal(18, 2)), 6)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (7, 1, 2, CAST(110.00 AS Decimal(18, 2)), 7)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (8, 4, 1, CAST(168.00 AS Decimal(18, 2)), 8)
INSERT [dbo].[OrderDetails] ([Order_Details_Id], [Product_Id], [Product_Qty], [Product_Price], [Order_No]) VALUES (9, 6, 2, CAST(109.00 AS Decimal(18, 2)), 9)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (1, N'1 Backpack, Fits 15 Laptops', N'Your perfect pack for everyday use and walks in the forest.', N'imag1.jpg', CAST(110.00 AS Decimal(18, 2)), 25, 3)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (2, N'Mens Casual Premium Slim Fit T-Shirts', N'Slim-fitting style, contrast raglan long sleeve, three-button henley placket.', N'imag2.jpg', CAST(22.00 AS Decimal(18, 2)), 65, 3)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (3, N'John Hardy Legends Naga Gold & Silver Dragon Station Chain Bracelet', N'From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the oceans pearl.', N'imag3.jpg', CAST(695.00 AS Decimal(18, 2)), 105, 2)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (4, N'Solid Gold Petite Micropave', N'Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States.', N'imag4.jpg', CAST(168.00 AS Decimal(18, 2)), 63, 2)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (5, N'WD 2TB Elements Portable External Hard Drive - USB 3.0', N'USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity.', N'imag5.jpg', CAST(64.00 AS Decimal(18, 2)), 126, 1)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (6, N'SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s', N'Easy upgrade for faster boot up, shutdown, application load and response.', N'imag6.jpg', CAST(109.00 AS Decimal(18, 2)), 33, 1)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (7, N'BIYLACLESEN Womens 3-in-1 Snowboard Jacket Winter Coats', N'Note:The Jackets is US standard size, Please choose size as your usual wear Material', N'imag7.jpg', CAST(57.00 AS Decimal(18, 2)), 506, 4)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (8, N'Lock and Love Womens Removable Hooded Faux Leather Moto Biker Jacket', N'100% POLYURETHANE(shell) 100% POLYESTER(lining) 75% POLYESTER 25% COTTON (SWEATER)', N'imag8.jpg', CAST(30.00 AS Decimal(18, 2)), 362, 4)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (13, N'Jacket', N'SWEATER', N'imag9.jpg', CAST(29.95 AS Decimal(18, 2)), 100, 8)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (14, N'Moto Biker Jacket', N'100% POLYURETHANE(shell)', N'imag10.jpg', CAST(39.95 AS Decimal(18, 2)), 23, 12)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Product_Description], [Image], [Price], [Stock], [Category_Id]) VALUES (15, N'Lock and Love', N'100% POLYESTER(lining)', N'imag8.jpg', CAST(23.95 AS Decimal(18, 2)), 16, 14)
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([Customer_Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Order] FOREIGN KEY([Order_No])
REFERENCES [dbo].[Order] ([Order_No])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Order]
GO
/****** Object:  StoredProcedure [dbo].[add_category]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[add_category] 
	@Category_Name			NVARCHAR(50), 
	@Category_Description   NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON 

    INSERT INTO dbo.Category
    (                    
		Category_Name,
		Category_Description
    ) 
     VALUES 
    ( 
		@Category_Name,
		@Category_Description
    ) 
END
GO
/****** Object:  StoredProcedure [dbo].[add_customer]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_customer] 
	@Customer_Email		NVARCHAR(50)  = NULL, 
	@First_Name         NVARCHAR(50), 
	@Last_Name          NVARCHAR(50), 
	@Address			NVARCHAR(50),
	@City				NVARCHAR(50),
	@Phone_Number       NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON 

    INSERT INTO dbo.Customer
    (                    
		Customer_Email,
		First_Name,
		Last_Name,
		Address,
		City,
		Phone_Number
    ) 
     VALUES 
    ( 
		@Customer_Email,
		@First_Name,
		@Last_Name,
		@Address,
		@City,
		@Phone_Number
    ) 
END
GO
/****** Object:  StoredProcedure [dbo].[add_product]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_product] 
	@Product_Name			NVARCHAR(MAX), 
	@Product_Description    NVARCHAR(MAX), 
	@Image					NVARCHAR(50), 
	@Price					DECIMAL(18, 2),
	@Stock					INT,
	@Category_Id			INT
AS
BEGIN
	SET NOCOUNT ON 

    INSERT INTO dbo.Product
    (                    
		Product_Name,
		Product_Description,
		Image,
		Price,
		Stock,
		Category_Id
    ) 
     VALUES 
    ( 
		@Product_Name,
		@Product_Description,
		@Image,
		@Price,
		@Stock,
		@Category_Id
    ) 
END
GO
/****** Object:  StoredProcedure [dbo].[add_products_with_no_matching_category]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_products_with_no_matching_category] 
AS
BEGIN
	SET NOCOUNT ON 

    INSERT INTO Product
	(
		Product_Name,
		Product_Description,
		Image,
		Price,
		Stock,
		Category_Id
	)   
	VALUES 
		  ('Jacket','SWEATER','imag9.jpg',29.95, 100, 8)
		 ,('Moto Biker Jacket','100% POLYURETHANE(shell)','imag10.jpg', 39.95, 23, 12)
		 ,('Lock and Love','100% POLYESTER(lining)','imag8.jpg', 23.95, 16, 14)
END
GO
/****** Object:  StoredProcedure [dbo].[deliver_an_order]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[deliver_an_order] 
	@Customer_Id	INT, 
	@Order_No		INT
AS
BEGIN
	SET NOCOUNT ON

	UPDATE O
	SET O.Is_Delivered = 1, O.Date_Delivered = GETDATE()
	FROM [dbo].[Order] AS O
	INNER JOIN [dbo].[OrderDetails] AS OD
		   ON O.Order_No = OD.Order_No 
	WHERE O.Customer_Id = @Customer_Id 
	  AND OD.Order_No = @Order_No
END
GO
/****** Object:  StoredProcedure [dbo].[place_an_order]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[place_an_order] 
	@Order_Date			DATETIME, 
	@Shipping_Date		DATETIME = NULL, 
	@Customer_Id		INT,

	@Product_Id			INT,
	@Product_Qty		INT
AS
BEGIN
	SET NOCOUNT ON 

	-----------------------Get Price for the given product--------------------------------
	DECLARE @Product_Price DECIMAL(18, 2)
	SET @Product_Price = (SELECT Price from [dbo].[Product] WHERE Product_Id = @Product_Id)

	-----------------------Add an order into Order table----------------------------------
    INSERT INTO [dbo].[Order]
    (                    
		Order_Date,
		Order_Total,
		Shipping_Date,
		Is_Delivered,
		Date_Delivered,
		Customer_Id
    ) 
     VALUES 
    ( 
		@Order_Date,
		@Product_Qty * @Product_Price,
		@Shipping_Date,
		0,
		Null,
		@Customer_Id
    ) 

	-----------------------Add order details into OrderDetails table------------------------
	INSERT INTO [dbo].[OrderDetails]
    (                    
		Product_Id,
		Product_Qty,
		Product_Price,
		Order_No
    ) 
     VALUES 
    ( 
		@Product_Id,
		@Product_Qty,
		@Product_Price,
		SCOPE_IDENTITY()
    ) 
END
GO
/****** Object:  StoredProcedure [dbo].[remove_products_with_no_matching_category]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[remove_products_with_no_matching_category]
AS
BEGIN
	SET NOCOUNT ON 

	DELETE FROM [dbo].[Product]
	WHERE Category_Id Not IN 
	( 
		SELECT prod.Category_Id
		FROM [dbo].[Product] prod
		INNER JOIN [dbo].[Category] cat ON cat.Category_Id = prod.Category_Id
	);
END
GO
/****** Object:  StoredProcedure [dbo].[search_for_a_product]    Script Date: 2022/03/07 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[search_for_a_product] 
	@Search	NVARCHAR(MAX) = null
AS
BEGIN
	SET NOCOUNT ON

	SELECT * FROM dbo.Product prod
	LEFT JOIN dbo.Category cat ON prod.Category_Id = cat.Category_Id
	WHERE prod.Product_Name LIKE CASE
	WHEN @Search IS NOT NULL
	THEN 
		'%' + @Search + '%'
	ELSE 
		prod.Product_Name 
	END
END
GO
USE [master]
GO
ALTER DATABASE [MyECommerceDB] SET  READ_WRITE 
GO
