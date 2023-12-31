USE [master]
GO
/****** Object:  Database [venda_produto]    Script Date: 31/10/2023 11:38:07 ******/
CREATE DATABASE [venda_produto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'venda_produto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\venda_produto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'venda_produto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\venda_produto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [venda_produto] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [venda_produto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [venda_produto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [venda_produto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [venda_produto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [venda_produto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [venda_produto] SET ARITHABORT OFF 
GO
ALTER DATABASE [venda_produto] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [venda_produto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [venda_produto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [venda_produto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [venda_produto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [venda_produto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [venda_produto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [venda_produto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [venda_produto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [venda_produto] SET  ENABLE_BROKER 
GO
ALTER DATABASE [venda_produto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [venda_produto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [venda_produto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [venda_produto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [venda_produto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [venda_produto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [venda_produto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [venda_produto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [venda_produto] SET  MULTI_USER 
GO
ALTER DATABASE [venda_produto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [venda_produto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [venda_produto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [venda_produto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [venda_produto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [venda_produto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [venda_produto] SET QUERY_STORE = OFF
GO
USE [venda_produto]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nomeCompleto] [varchar](150) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[registro] [varchar](18) NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[idendereco] [int] NOT NULL,
	[sexo] [char](3) NULL,
	[seguimento] [varchar](100) NULL,
 CONSTRAINT [idcliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__cliente__8235FB38D07285EF] UNIQUE NONCLUSTERED 
(
	[idendereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__cliente__AB6E6164A9B5F1F2] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__cliente__D836E71F1578ACFF] UNIQUE NONCLUSTERED 
(
	[registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[endereco]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[endereco](
	[idendereco] [int] IDENTITY(1,1) NOT NULL,
	[rua] [varchar](100) NOT NULL,
	[complemento] [varchar](100) NOT NULL,
	[cep] [varchar](9) NOT NULL,
	[numero] [int] NOT NULL,
	[estado] [char](2) NOT NULL,
	[cidade] [varchar](50) NOT NULL,
 CONSTRAINT [idendereco] PRIMARY KEY CLUSTERED 
(
	[idendereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__endereco__D83671A57AC8F6A3] UNIQUE NONCLUSTERED 
(
	[cep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedor](
	[idfornecedor] [int] IDENTITY(1,1) NOT NULL,
	[idendereco] [int] NOT NULL,
	[nomeCompleto] [varchar](150) NOT NULL,
	[registro] [varchar](18) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[sexo] [char](3) NULL,
	[seguimento] [varchar](100) NULL,
 CONSTRAINT [idfornecedor] PRIMARY KEY CLUSTERED 
(
	[idfornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__forneced__35BD3E48A708EF9D] UNIQUE NONCLUSTERED 
(
	[registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__forneced__8235FB3875D31811] UNIQUE NONCLUSTERED 
(
	[idendereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensVenda]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensVenda](
	[iditem] [int] IDENTITY(1,1) NOT NULL,
	[idvenda] [int] NULL,
	[idproduto] [int] NULL,
	[quantidade] [int] NULL,
	[precoUnit] [decimal](10, 2) NULL,
	[precoTotal] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[iditem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[idproduto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[preco] [decimal](10, 2) NOT NULL,
	[descricao] [varchar](500) NOT NULL,
	[estoque_qnt] [int] NOT NULL,
 CONSTRAINT [idproduto] PRIMARY KEY CLUSTERED 
(
	[idproduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto_fornecedor]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto_fornecedor](
	[codProduto] [int] IDENTITY(1,1) NOT NULL,
	[idfornecedor] [int] NOT NULL,
	[idproduto] [int] NOT NULL,
 CONSTRAINT [idprodutos_fornecedor] PRIMARY KEY CLUSTERED 
(
	[codProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nomeCompleto] [varchar](150) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[senha] [varchar](20) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[idendereco] [int] NOT NULL,
	[role] [varchar](50) NOT NULL,
	[sexo] [char](3) NOT NULL,
 CONSTRAINT [idusuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venda]    Script Date: 31/10/2023 11:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[idvenda] [int] IDENTITY(1,1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[precoTotal] [decimal](30, 2) NOT NULL,
	[data] [datetime] NOT NULL,
	[metodo_pagamento] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [idvenda] PRIMARY KEY CLUSTERED 
(
	[idvenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [endereco_cliente_fk] FOREIGN KEY([idendereco])
REFERENCES [dbo].[endereco] ([idendereco])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [endereco_cliente_fk]
GO
ALTER TABLE [dbo].[fornecedor]  WITH CHECK ADD  CONSTRAINT [endereco_fornecedor_fk] FOREIGN KEY([idendereco])
REFERENCES [dbo].[endereco] ([idendereco])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[fornecedor] CHECK CONSTRAINT [endereco_fornecedor_fk]
GO
ALTER TABLE [dbo].[ItensVenda]  WITH CHECK ADD FOREIGN KEY([idproduto])
REFERENCES [dbo].[produto] ([idproduto])
GO
ALTER TABLE [dbo].[ItensVenda]  WITH CHECK ADD FOREIGN KEY([idvenda])
REFERENCES [dbo].[venda] ([idvenda])
GO
ALTER TABLE [dbo].[produto_fornecedor]  WITH CHECK ADD  CONSTRAINT [fornecedor_produtos_fornecedor_fk] FOREIGN KEY([idfornecedor])
REFERENCES [dbo].[fornecedor] ([idfornecedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[produto_fornecedor] CHECK CONSTRAINT [fornecedor_produtos_fornecedor_fk]
GO
ALTER TABLE [dbo].[produto_fornecedor]  WITH CHECK ADD  CONSTRAINT [produto_produtos_fornecedor_fk] FOREIGN KEY([idproduto])
REFERENCES [dbo].[produto] ([idproduto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[produto_fornecedor] CHECK CONSTRAINT [produto_produtos_fornecedor_fk]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [endereco_usuario_fk] FOREIGN KEY([idendereco])
REFERENCES [dbo].[endereco] ([idendereco])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [endereco_usuario_fk]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [FK_venda_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [FK_venda_cliente]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [FK_venda_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [FK_venda_usuario]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [CK_Sexo] CHECK  (([sexo]='N/A' OR [sexo]='F' OR [sexo]='M'))
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [CK_Sexo]
GO
ALTER TABLE [dbo].[fornecedor]  WITH CHECK ADD  CONSTRAINT [CK_Forne_Sexo] CHECK  (([sexo]='N/A' OR [sexo]='F' OR [sexo]='M'))
GO
ALTER TABLE [dbo].[fornecedor] CHECK CONSTRAINT [CK_Forne_Sexo]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_User_Sexo] CHECK  (([sexo]='N/A' OR [sexo]='F' OR [sexo]='M'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_User_Sexo]
GO
USE [master]
GO
ALTER DATABASE [venda_produto] SET  READ_WRITE 
GO
