USE master
GO

CREATE DATABASE [405369-Facturacion]
GO

USE [405369-Facturacion]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 06/09/2023 21:12:30 ******/
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
/****** Object:  Table [dbo].[Detalle_Facturas]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Facturas](
	[ID_Detalle_Factura] [int] IDENTITY(1,1) NOT NULL,
	[NroFactura] [int] NOT NULL,
	[ID_Articulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [money] NOT NULL,
 CONSTRAINT [pk_Detalle_Facturas] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[NroFactura] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[ID_Forma_Pago] [int] NOT NULL,
	[Cliente] [varchar](100) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Estado] [int] NULL,
 CONSTRAINT [pk_Facturas] PRIMARY KEY CLUSTERED 
(
	[NroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formas_Pago]    Script Date: 06/09/2023 21:12:30 ******/
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
SET IDENTITY_INSERT [dbo].[Articulos] ON 

INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (1, N'Pantalon Gabardina', 12525.5000)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (2, N'Camisa Manga Lagra', 16325.2400)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (3, N'Camisa Manga Corta', 14652.2800)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (4, N'Bermuda Gabardina', 8569.3000)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (5, N'Sweater Cuello Base', 18564.7800)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (6, N'Pantalon Jean ', 17659.3000)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (7, N'Remera Manga Larga', 9568.7700)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (8, N'Remera Manga Corta', 6780.5600)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (9, N'Buzo Friza', 23857.4000)
INSERT [dbo].[Articulos] ([ID_Articulo], [Nombre_Articulo], [Precio_Unitario]) VALUES (10, N'Campera Leñadora', 58460.8900)
SET IDENTITY_INSERT [dbo].[Articulos] OFF
SET IDENTITY_INSERT [dbo].[Detalle_Facturas] ON 

INSERT [dbo].[Detalle_Facturas] ([ID_Detalle_Factura], [NroFactura], [ID_Articulo], [Cantidad], [Precio]) VALUES (2, 1, 1, 5, 12525.5000)
INSERT [dbo].[Detalle_Facturas] ([ID_Detalle_Factura], [NroFactura], [ID_Articulo], [Cantidad], [Precio]) VALUES (3, 2, 4, 5, 8569.3000)
INSERT [dbo].[Detalle_Facturas] ([ID_Detalle_Factura], [NroFactura], [ID_Articulo], [Cantidad], [Precio]) VALUES (4, 2, 9, 4, 23857.4000)
INSERT [dbo].[Detalle_Facturas] ([ID_Detalle_Factura], [NroFactura], [ID_Articulo], [Cantidad], [Precio]) VALUES (5, 2, 10, 2, 58460.8900)
INSERT [dbo].[Detalle_Facturas] ([ID_Detalle_Factura], [NroFactura], [ID_Articulo], [Cantidad], [Precio]) VALUES (6, 2, 6, 3, 17659.3000)
INSERT [dbo].[Detalle_Facturas] ([ID_Detalle_Factura], [NroFactura], [ID_Articulo], [Cantidad], [Precio]) VALUES (7, 2, 8, 5, 6780.5600)
SET IDENTITY_INSERT [dbo].[Detalle_Facturas] OFF
INSERT [dbo].[Facturas] ([NroFactura], [Fecha], [ID_Forma_Pago], [Cliente], [Total], [Estado]) VALUES (1, CAST(N'2023-08-25' AS Date), 1, N'Pedro Juarez', CAST(62627.50 AS Decimal(18, 2)), 1)
INSERT [dbo].[Facturas] ([NroFactura], [Fecha], [ID_Forma_Pago], [Cliente], [Total], [Estado]) VALUES (2, CAST(N'2023-09-06' AS Date), 1, N'Carlos Perez', CAST(342078.58 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[Formas_Pago] ON 

INSERT [dbo].[Formas_Pago] ([ID_Forma_Pago], [Detalle]) VALUES (1, N'Contado')
INSERT [dbo].[Formas_Pago] ([ID_Forma_Pago], [Detalle]) VALUES (2, N'Cuenta Corriente')
INSERT [dbo].[Formas_Pago] ([ID_Forma_Pago], [Detalle]) VALUES (3, N'Tarjeta Crédito')
INSERT [dbo].[Formas_Pago] ([ID_Forma_Pago], [Detalle]) VALUES (4, N'Tarjeta Débito')
INSERT [dbo].[Formas_Pago] ([ID_Forma_Pago], [Detalle]) VALUES (5, N'Transferencia Bancaria')
SET IDENTITY_INSERT [dbo].[Formas_Pago] OFF
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
/****** Object:  StoredProcedure [dbo].[sp_Articulos_Seleccion]    Script Date: 06/09/2023 21:12:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Detalle_Factura_Listado]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Detalle_Factura_Listado] 
@NumFactura Int
AS
BEGIN
	SELECT * 
	FROM Detalle_Facturas DF
	WHERE DF.NroFactura = @NumFactura
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Detalle_Facturas_Carga]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Detalle_Facturas_Carga]
@NroFactura int
AS
BEGIN
	SELECT * FROM Detalle_Facturas DF WHERE DF.NroFactura = @NroFactura
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Facturas_Borrado_Logico]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Facturas_Borrado_Logico] 
@NroFactura int

AS
BEGIN
	UPDATE Facturas SET Estado = 1 WHERE NroFactura = @NroFactura
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Facturas_Listado]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Facturas_Listado] 
@Fecha_Desde Date,
@Fecha_Hasta Date,
@Cliente varchar(100)

AS
BEGIN
	SELECT * 
	FROM FACTURAS FA
	WHERE FA.FECHA BETWEEN @Fecha_Desde AND @Fecha_Hasta
		  AND fa.Cliente like '%' + @Cliente + '%'
		  AND fa.Estado = 0
	ORDER BY fa.NroFactura
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Formas_Pago_Seleccion]    Script Date: 06/09/2023 21:12:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Ingresa_Detalle]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Ingresa_Detalle]
@Nro_Factura int,
@ID_Articulo int,
@Cantidad int,
@Precio money

AS
BEGIN
	INSERT INTO Detalle_Facturas VALUES (@Nro_Factura, @ID_Articulo, @Cantidad, @Precio)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Ingresa_Factura]    Script Date: 06/09/2023 21:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Ingresa_Factura]
@Nro_Factura int,
@Fecha date,
@ID_Forma_Pago int,
@Cliente varchar(100),
@Total decimal(18,2),
@Estado int

AS
BEGIN
	INSERT INTO Facturas VALUES (@Nro_Factura, @Fecha, @ID_Forma_Pago, @Cliente, @Total, @Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Obtiene_Ultima_Factura]    Script Date: 06/09/2023 21:12:30 ******/
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
