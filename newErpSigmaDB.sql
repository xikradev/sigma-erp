USE [master]
GO
/****** Object:  Database [erpSigmadb]    Script Date: 09/11/2023 16:54:18 ******/
CREATE DATABASE [erpSigmadb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'erpSigmadb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MICRO12\MSSQL\DATA\erpSigmadb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'erpSigmadb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MICRO12\MSSQL\DATA\erpSigmadb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [erpSigmadb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [erpSigmadb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [erpSigmadb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [erpSigmadb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [erpSigmadb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [erpSigmadb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [erpSigmadb] SET ARITHABORT OFF 
GO
ALTER DATABASE [erpSigmadb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [erpSigmadb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [erpSigmadb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [erpSigmadb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [erpSigmadb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [erpSigmadb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [erpSigmadb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [erpSigmadb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [erpSigmadb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [erpSigmadb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [erpSigmadb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [erpSigmadb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [erpSigmadb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [erpSigmadb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [erpSigmadb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [erpSigmadb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [erpSigmadb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [erpSigmadb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [erpSigmadb] SET  MULTI_USER 
GO
ALTER DATABASE [erpSigmadb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [erpSigmadb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [erpSigmadb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [erpSigmadb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [erpSigmadb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [erpSigmadb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [erpSigmadb] SET QUERY_STORE = OFF
GO
USE [erpSigmadb]
GO
/****** Object:  Table [dbo].[address]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[address](
	[idaddress] [int] IDENTITY(1,1) NOT NULL,
	[street] [varchar](100) NOT NULL,
	[complement] [varchar](100) NOT NULL,
	[cep] [varchar](9) NOT NULL,
	[number] [int] NOT NULL,
	[uf] [char](2) NOT NULL,
	[city] [varchar](50) NOT NULL,
 CONSTRAINT [idaddress] PRIMARY KEY CLUSTERED 
(
	[idaddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__endereco__D83671A57AC8F6A3] UNIQUE NONCLUSTERED 
(
	[cep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[idclient] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](150) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[register] [varchar](18) NOT NULL,
	[dateOfBirth] [datetime] NOT NULL,
	[idaddress] [int] NOT NULL,
	[sex] [char](1) NULL,
	[businessArea] [varchar](100) NULL,
 CONSTRAINT [idclient] PRIMARY KEY CLUSTERED 
(
	[idclient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__cliente__8235FB38D07285EF] UNIQUE NONCLUSTERED 
(
	[idaddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__cliente__AB6E6164A9B5F1F2] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__cliente__D836E71F1578ACFF] UNIQUE NONCLUSTERED 
(
	[register] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[idproduct] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
	[description] [varchar](500) NOT NULL,
	[quantityStock] [int] NOT NULL,
 CONSTRAINT [idproduct] PRIMARY KEY CLUSTERED 
(
	[idproduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productSupplier]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productSupplier](
	[codProduct] [int] IDENTITY(1,1) NOT NULL,
	[idsupplier] [int] NOT NULL,
	[idproduct] [int] NOT NULL,
 CONSTRAINT [idproductSupplier] PRIMARY KEY CLUSTERED 
(
	[codProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sale]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale](
	[idsale] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NOT NULL,
	[idclient] [int] NOT NULL,
	[totalPrice] [decimal](30, 2) NOT NULL,
	[date] [datetime] NOT NULL,
	[paymentMethod] [varchar](50) NOT NULL,
 CONSTRAINT [idsale] PRIMARY KEY CLUSTERED 
(
	[idsale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saleItems]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saleItems](
	[iditem] [int] IDENTITY(1,1) NOT NULL,
	[idsale] [int] NOT NULL,
	[idproduct] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[unitPrice] [decimal](10, 2) NOT NULL,
	[TotalPrice] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__SaleItems__875AD50E873F2138] PRIMARY KEY CLUSTERED 
(
	[iditem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[idsupplier] [int] IDENTITY(1,1) NOT NULL,
	[idaddress] [int] NOT NULL,
	[fullname] [varchar](150) NOT NULL,
	[register] [varchar](18) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[dateOfBirth] [datetime] NOT NULL,
	[sex] [char](1) NULL,
	[BussinessArea] [varchar](100) NULL,
 CONSTRAINT [idsupplier] PRIMARY KEY CLUSTERED 
(
	[idsupplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__forneced__35BD3E48A708EF9D] UNIQUE NONCLUSTERED 
(
	[register] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__forneced__8235FB3875D31811] UNIQUE NONCLUSTERED 
(
	[idaddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 09/11/2023 16:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](150) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[dateOfBirth] [datetime] NOT NULL,
	[idaddress] [int] NOT NULL,
	[role] [varchar](50) NOT NULL,
	[sex] [char](1) NOT NULL,
 CONSTRAINT [iduser] PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [address_client_fk] FOREIGN KEY([idaddress])
REFERENCES [dbo].[address] ([idaddress])
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [address_client_fk]
GO
ALTER TABLE [dbo].[productSupplier]  WITH CHECK ADD  CONSTRAINT [product_productSupplier_fk] FOREIGN KEY([idproduct])
REFERENCES [dbo].[product] ([idproduct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[productSupplier] CHECK CONSTRAINT [product_productSupplier_fk]
GO
ALTER TABLE [dbo].[productSupplier]  WITH CHECK ADD  CONSTRAINT [productSupplier_supplier_fk] FOREIGN KEY([idsupplier])
REFERENCES [dbo].[supplier] ([idsupplier])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[productSupplier] CHECK CONSTRAINT [productSupplier_supplier_fk]
GO
ALTER TABLE [dbo].[sale]  WITH CHECK ADD  CONSTRAINT [FK_sale_client] FOREIGN KEY([idclient])
REFERENCES [dbo].[client] ([idclient])
GO
ALTER TABLE [dbo].[sale] CHECK CONSTRAINT [FK_sale_client]
GO
ALTER TABLE [dbo].[sale]  WITH CHECK ADD  CONSTRAINT [FK_sale_user] FOREIGN KEY([iduser])
REFERENCES [dbo].[user] ([iduser])
GO
ALTER TABLE [dbo].[sale] CHECK CONSTRAINT [FK_sale_user]
GO
ALTER TABLE [dbo].[saleItems]  WITH CHECK ADD  CONSTRAINT [FK__saleItems__idpro__4BAC3F29] FOREIGN KEY([idproduct])
REFERENCES [dbo].[product] ([idproduct])
GO
ALTER TABLE [dbo].[saleItems] CHECK CONSTRAINT [FK__saleItems__idpro__4BAC3F29]
GO
ALTER TABLE [dbo].[saleItems]  WITH CHECK ADD  CONSTRAINT [FK__saleItems__idsale__4CA06362] FOREIGN KEY([idsale])
REFERENCES [dbo].[sale] ([idsale])
GO
ALTER TABLE [dbo].[saleItems] CHECK CONSTRAINT [FK__saleItems__idsale__4CA06362]
GO
ALTER TABLE [dbo].[supplier]  WITH CHECK ADD  CONSTRAINT [address_supplier_fk] FOREIGN KEY([idaddress])
REFERENCES [dbo].[address] ([idaddress])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[supplier] CHECK CONSTRAINT [address_supplier_fk]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [address_user_fk] FOREIGN KEY([idaddress])
REFERENCES [dbo].[address] ([idaddress])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [address_user_fk]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [CK_Client_Sex] CHECK  (([sex]='F' OR [sex]='M'))
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [CK_Client_Sex]
GO
ALTER TABLE [dbo].[supplier]  WITH CHECK ADD  CONSTRAINT [CK_Supplier_Sex] CHECK  (([sex]='F' OR [sex]='M'))
GO
ALTER TABLE [dbo].[supplier] CHECK CONSTRAINT [CK_Supplier_Sex]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [CK_User_Sex] CHECK  (([sex]='F' OR [sex]='M'))
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [CK_User_Sex]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [CK_User_Sexo] CHECK  (([sex]='F' OR [sex]='M'))
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [CK_User_Sexo]
GO
USE [master]
GO
ALTER DATABASE [erpSigmadb] SET  READ_WRITE 
GO
