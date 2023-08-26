USE [master]
GO
/****** Object:  Database [405369-Facturacion]    Script Date: 26/08/2023 19:04:58 ******/
CREATE DATABASE [405369-Facturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'405369-Facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\405369-Facturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'405369-Facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\405369-Facturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [405369-Facturacion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [405369-Facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [405369-Facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [405369-Facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [405369-Facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [405369-Facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [405369-Facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [405369-Facturacion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [405369-Facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [405369-Facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [405369-Facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [405369-Facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [405369-Facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [405369-Facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [405369-Facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [405369-Facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [405369-Facturacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [405369-Facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [405369-Facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [405369-Facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [405369-Facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [405369-Facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [405369-Facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [405369-Facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [405369-Facturacion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [405369-Facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [405369-Facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [405369-Facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [405369-Facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [405369-Facturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [405369-Facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [405369-Facturacion] SET QUERY_STORE = OFF
GO
USE [405369-Facturacion]
GO
/****** Object:  User [Intelicont]    Script Date: 26/08/2023 19:04:58 ******/
CREATE USER [Intelicont] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[ID_Articulo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Articulo] [varchar](100) NOT NULL,
	[Precio_Unitario] [money] NOT NULL,
 CONSTRAINT [pk_Articulos] PRIMARY KEY CLUSTERED 
(
	[ID_Articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Facturas]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Facturas](
	[ID_Detalle_Factura] [int] IDENTITY(1,1) NOT NULL,
	[NroFactura] [int] NOT NULL,
	[ID_Articulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [pk_Detalle_Facturas] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[NroFactura] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ID_Forma_Pago] [int] NOT NULL,
	[Cliente] [varchar](100) NOT NULL,
 CONSTRAINT [pk_Facturas] PRIMARY KEY CLUSTERED 
(
	[NroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formas_Pago]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formas_Pago](
	[ID_Forma_Pago] [int] IDENTITY(1,1) NOT NULL,
	[Detalle] [varchar](100) NOT NULL,
 CONSTRAINT [pk_Formas_Pago] PRIMARY KEY CLUSTERED 
(
	[ID_Forma_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle_Facturas]  WITH CHECK ADD  CONSTRAINT [fk_detalle_facturas_Articulos] FOREIGN KEY([ID_Articulo])
REFERENCES [dbo].[Articulos] ([ID_Articulo])
GO
ALTER TABLE [dbo].[Detalle_Facturas] CHECK CONSTRAINT [fk_detalle_facturas_Articulos]
GO
ALTER TABLE [dbo].[Detalle_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Facturas_Facturas] FOREIGN KEY([NroFactura])
REFERENCES [dbo].[Facturas] ([NroFactura])
GO
ALTER TABLE [dbo].[Detalle_Facturas] CHECK CONSTRAINT [FK_Detalle_Facturas_Facturas]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [fk_facturas_forma_pago] FOREIGN KEY([ID_Forma_Pago])
REFERENCES [dbo].[Formas_Pago] ([ID_Forma_Pago])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [fk_facturas_forma_pago]
GO
/****** Object:  StoredProcedure [dbo].[sp_Articulos_Seleccion]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Articulos_Seleccion]
AS
BEGIN
	SELECT * FROM Articulos ORDER BY Nombre_Articulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Formas_Pago_Seleccion]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Formas_Pago_Seleccion]
AS
BEGIN
	SELECT * FROM Formas_Pago ORDER BY Detalle
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Ingresa_Detalle]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Ingresa_Detalle]
@Nro_Factura int,
@ID_Articulo int,
@Cantidad int

AS
BEGIN
	INSERT INTO Detalle_Facturas VALUES (@Nro_Factura, @ID_Articulo, @Cantidad)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Ingresa_Factura]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Ingresa_Factura]
@Nro_Factura int,
@Fecha datetime,
@ID_Forma_Pago int,
@Cliente varchar(100)

AS
BEGIN
	INSERT INTO Facturas VALUES (@Nro_Factura, @Fecha, @ID_Forma_Pago, @Cliente)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Obtiene_Ultima_Factura]    Script Date: 26/08/2023 19:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Obtiene_Ultima_Factura] 
@Ultima_Factura int OUTPUT,
@Ultima_Fecha datetime OUTPUT

AS
BEGIN
	SELECT @Ultima_Factura = max(F.NroFactura), @Ultima_Fecha =  max(F.fecha) FROM Facturas F
END
GO
USE [master]
GO
ALTER DATABASE [405369-Facturacion] SET  READ_WRITE 
GO
