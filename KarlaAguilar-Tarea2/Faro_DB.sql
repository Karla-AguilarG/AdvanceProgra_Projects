USE [master]
GO

CREATE DATABASE [Faro]
GO
USE [Faro]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[IdArticulo] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
	[PrecioVendedor] [decimal](18, 2) NOT NULL,
	[PrecioFinal] [decimal](18, 2) NOT NULL,
	[CantidadDisponible] [int] NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenCompra](
	[IdOrden] [int] NOT NULL,
	[Identificacion] [varchar](10) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_OrdenCompra] PRIMARY KEY CLUSTERED 
(
	[IdOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenCompraDetalle](
	[IdDetalle] [int] NOT NULL,
	[IdOrden] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[CantidadArticulo] [int] NOT NULL,
	[PrecioVendedor] [decimal](18, 2) NOT NULL,
	[PrecioFinal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OrdenCompraDetalle] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedor](
	[Identificacion] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrimerApellido] [varchar](50) NOT NULL,
	[SegundoApellido] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Genero] [char](1) NOT NULL,
	[FechaIngreso] [date] NULL,
 CONSTRAINT [PK_Vendedor] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrdenCompra]  WITH CHECK ADD  CONSTRAINT [FK_OrdenCompra_Vendedor] FOREIGN KEY([Identificacion])
REFERENCES [dbo].[Vendedor] ([Identificacion])
GO
ALTER TABLE [dbo].[OrdenCompra] CHECK CONSTRAINT [FK_OrdenCompra_Vendedor]
GO
ALTER TABLE [dbo].[OrdenCompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_OrdenCompraDetalle_Articulo] FOREIGN KEY([IdArticulo])
REFERENCES [dbo].[Articulo] ([IdArticulo])
GO
ALTER TABLE [dbo].[OrdenCompraDetalle] CHECK CONSTRAINT [FK_OrdenCompraDetalle_Articulo]
GO
ALTER TABLE [dbo].[OrdenCompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_OrdenCompraDetalle_OrdenCompra] FOREIGN KEY([IdOrden])
REFERENCES [dbo].[OrdenCompra] ([IdOrden])
GO
ALTER TABLE [dbo].[OrdenCompraDetalle] CHECK CONSTRAINT [FK_OrdenCompraDetalle_OrdenCompra]
GO
USE [master]
GO
ALTER DATABASE [Faro] SET  READ_WRITE 
GO