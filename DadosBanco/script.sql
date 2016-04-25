USE [master]
GO
/****** Object:  Database [Estoque]    Script Date: 25/04/2016 15:49:58 ******/
CREATE DATABASE [Estoque]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Estoque', FILENAME = N'C:\bd\Estoque.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Estoque_log', FILENAME = N'C:\bd\Estoque_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Estoque] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Estoque].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Estoque] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Estoque] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Estoque] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Estoque] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Estoque] SET ARITHABORT OFF 
GO
ALTER DATABASE [Estoque] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Estoque] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Estoque] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Estoque] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Estoque] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Estoque] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Estoque] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Estoque] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Estoque] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Estoque] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Estoque] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Estoque] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Estoque] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Estoque] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Estoque] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Estoque] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Estoque] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Estoque] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Estoque] SET  MULTI_USER 
GO
ALTER DATABASE [Estoque] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Estoque] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Estoque] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Estoque] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Estoque] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Estoque', N'ON'
GO
USE [Estoque]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[cat_cod] [int] IDENTITY(1,1) NOT NULL,
	[cat_nome] [varchar](95) NULL,
 CONSTRAINT [XPKcategoria] PRIMARY KEY NONCLUSTERED 
(
	[cat_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cli_cod] [int] IDENTITY(1,1) NOT NULL,
	[cli_nome] [varchar](95) NULL,
	[cli_cpfcnpj] [varchar](95) NULL,
	[cli_rgie] [varchar](95) NULL,
	[cli_rsocial] [varchar](95) NULL,
	[cli_tipo] [int] NULL,
	[cli_cep] [varchar](20) NULL,
	[cli_endereco] [varchar](95) NULL,
	[cli_bairro] [varchar](95) NULL,
	[cli_fone] [varchar](95) NULL,
	[cli_cel] [varchar](95) NULL,
	[cli_email] [varchar](95) NULL,
	[cli_endnumero] [varchar](10) NULL,
	[cli_cidade] [varchar](95) NULL,
	[cli_estado] [varchar](95) NULL,
 CONSTRAINT [XPKcliente] PRIMARY KEY NONCLUSTERED 
(
	[cli_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[compra]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[com_cod] [int] IDENTITY(1,1) NOT NULL,
	[com_data] [datetime] NULL,
	[com_nfiscal] [int] NULL,
	[com_total] [money] NULL,
	[com_nparcelas] [int] NULL,
	[com_status] [int] NULL,
	[for_cod] [int] NULL,
	[tpa_cod] [int] NULL,
 CONSTRAINT [XPKcompra] PRIMARY KEY NONCLUSTERED 
(
	[com_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fornecedor](
	[for_cod] [int] IDENTITY(1,1) NOT NULL,
	[for_nome] [varchar](95) NULL,
	[for_rsocial] [varchar](95) NULL,
	[for_ie] [varchar](95) NULL,
	[for_cnpj] [varchar](95) NULL,
	[for_cep] [varchar](95) NULL,
	[for_endereco] [varchar](95) NULL,
	[for_bairro] [varchar](95) NULL,
	[for_fone] [varchar](95) NULL,
	[for_cel] [varchar](95) NULL,
	[for_email] [varchar](95) NULL,
	[for_endnumero] [varchar](95) NULL,
	[for_cidade] [varchar](95) NULL,
	[for_estado] [varchar](95) NULL,
 CONSTRAINT [XPKfornecedor] PRIMARY KEY NONCLUSTERED 
(
	[for_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itenscompra]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itenscompra](
	[itc_cod] [int] NOT NULL,
	[itc_qtde] [float] NULL,
	[itc_valor] [money] NULL,
	[com_cod] [int] NOT NULL,
	[pro_cod] [int] NOT NULL,
 CONSTRAINT [XPKitenscompra] PRIMARY KEY NONCLUSTERED 
(
	[itc_cod] ASC,
	[com_cod] ASC,
	[pro_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[itensvenda]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itensvenda](
	[itv_cod] [int] NOT NULL,
	[itv_qtde] [float] NULL,
	[itv_valor] [money] NULL,
	[ven_cod] [int] NOT NULL,
	[pro_cod] [int] NOT NULL,
 CONSTRAINT [XPKitensVenda] PRIMARY KEY NONCLUSTERED 
(
	[itv_cod] ASC,
	[ven_cod] ASC,
	[pro_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[parcelascompra]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelascompra](
	[pco_cod] [int] NOT NULL,
	[pco_valor] [money] NULL,
	[pco_datapagto] [date] NULL,
	[pco_datavecto] [date] NULL,
	[com_cod] [int] NOT NULL,
 CONSTRAINT [XPKparcelascompra] PRIMARY KEY CLUSTERED 
(
	[pco_cod] ASC,
	[com_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[parcelasvenda]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelasvenda](
	[ven_cod] [int] NOT NULL,
	[pve_cod] [int] NOT NULL,
	[pve_valor] [money] NULL,
	[pve_datapagto] [date] NULL,
	[pve_datavecto] [date] NULL,
 CONSTRAINT [XPKparcelasvenda] PRIMARY KEY CLUSTERED 
(
	[ven_cod] ASC,
	[pve_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[produto]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[produto](
	[pro_cod] [int] IDENTITY(1,1) NOT NULL,
	[pro_nome] [varchar](95) NULL,
	[pro_descricao] [text] NULL,
	[pro_foto] [image] NULL,
	[pro_valorpago] [money] NULL,
	[pro_valorvenda] [money] NULL,
	[pro_qtde] [float] NULL,
	[umed_cod] [int] NULL,
	[cat_cod] [int] NULL,
	[scat_cod] [int] NULL,
 CONSTRAINT [XPKproduto] PRIMARY KEY NONCLUSTERED 
(
	[pro_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subcategoria]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subcategoria](
	[scat_cod] [int] IDENTITY(1,1) NOT NULL,
	[scat_nome] [varchar](95) NULL,
	[cat_cod] [int] NULL,
 CONSTRAINT [XPKsubcategoria] PRIMARY KEY NONCLUSTERED 
(
	[scat_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipopagamento]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipopagamento](
	[tpa_cod] [int] NOT NULL,
	[tpa_nome] [varchar](90) NULL,
 CONSTRAINT [XPKtipopagamento] PRIMARY KEY CLUSTERED 
(
	[tpa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[undmedida]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[undmedida](
	[umed_cod] [int] IDENTITY(1,1) NOT NULL,
	[umed_nome] [varchar](95) NULL,
 CONSTRAINT [XPKmedida] PRIMARY KEY NONCLUSTERED 
(
	[umed_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venda]    Script Date: 25/04/2016 15:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[ven_cod] [int] IDENTITY(1,1) NOT NULL,
	[ven_data] [datetime] NULL,
	[ven_nfiscal] [int] NULL,
	[ven_total] [money] NULL,
	[ven_nparcelas] [int] NULL,
	[ven_status] [int] NULL,
	[cli_cod] [int] NULL,
	[tpa_cod] [int] NULL,
 CONSTRAINT [XPKvenda] PRIMARY KEY NONCLUSTERED 
(
	[ven_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [R_21] FOREIGN KEY([for_cod])
REFERENCES [dbo].[fornecedor] ([for_cod])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [R_21]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [R_24] FOREIGN KEY([tpa_cod])
REFERENCES [dbo].[tipopagamento] ([tpa_cod])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [R_24]
GO
ALTER TABLE [dbo].[itenscompra]  WITH CHECK ADD  CONSTRAINT [R_15] FOREIGN KEY([com_cod])
REFERENCES [dbo].[compra] ([com_cod])
GO
ALTER TABLE [dbo].[itenscompra] CHECK CONSTRAINT [R_15]
GO
ALTER TABLE [dbo].[itenscompra]  WITH CHECK ADD  CONSTRAINT [R_17] FOREIGN KEY([pro_cod])
REFERENCES [dbo].[produto] ([pro_cod])
GO
ALTER TABLE [dbo].[itenscompra] CHECK CONSTRAINT [R_17]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [R_13] FOREIGN KEY([ven_cod])
REFERENCES [dbo].[venda] ([ven_cod])
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [R_13]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [R_14] FOREIGN KEY([pro_cod])
REFERENCES [dbo].[produto] ([pro_cod])
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [R_14]
GO
ALTER TABLE [dbo].[parcelascompra]  WITH CHECK ADD  CONSTRAINT [R_25] FOREIGN KEY([com_cod])
REFERENCES [dbo].[compra] ([com_cod])
GO
ALTER TABLE [dbo].[parcelascompra] CHECK CONSTRAINT [R_25]
GO
ALTER TABLE [dbo].[parcelasvenda]  WITH CHECK ADD  CONSTRAINT [R_22] FOREIGN KEY([ven_cod])
REFERENCES [dbo].[venda] ([ven_cod])
GO
ALTER TABLE [dbo].[parcelasvenda] CHECK CONSTRAINT [R_22]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_11] FOREIGN KEY([cat_cod])
REFERENCES [dbo].[categoria] ([cat_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_11]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_12] FOREIGN KEY([scat_cod])
REFERENCES [dbo].[subcategoria] ([scat_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_12]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_9] FOREIGN KEY([umed_cod])
REFERENCES [dbo].[undmedida] ([umed_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_9]
GO
ALTER TABLE [dbo].[subcategoria]  WITH CHECK ADD  CONSTRAINT [R_10] FOREIGN KEY([cat_cod])
REFERENCES [dbo].[categoria] ([cat_cod])
GO
ALTER TABLE [dbo].[subcategoria] CHECK CONSTRAINT [R_10]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [R_20] FOREIGN KEY([cli_cod])
REFERENCES [dbo].[cliente] ([cli_cod])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [R_20]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [R_23] FOREIGN KEY([tpa_cod])
REFERENCES [dbo].[tipopagamento] ([tpa_cod])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [R_23]
GO
USE [master]
GO
ALTER DATABASE [Estoque] SET  READ_WRITE 
GO
