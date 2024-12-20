use MiniGestionComercial

CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorias_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Categorias_Codigo] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/12/2024 16:01:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CuitCuil] [varchar](13) NULL,
	[RazonSocial] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Clientes_Codigo] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPedido]    Script Date: 19/12/2024 16:01:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesPedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PedidoId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[DescuentoPorcentaje] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_DetallesPedido_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 19/12/2024 16:01:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaPedido] [date] NOT NULL,
	[Numero] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
 CONSTRAINT [PK_Pedidos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 19/12/2024 16:01:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[CategoriaId] [int] NOT NULL,
 CONSTRAINT [PK_Productos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Productos_Codigo] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_Numero]    Script Date: 19/12/2024 16:01:26 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Pedidos_Numero] ON [dbo].[Pedidos]
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetallesPedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPedido_Pedidos] FOREIGN KEY([PedidoId])
REFERENCES [dbo].[Pedidos] ([Id])
GO
ALTER TABLE [dbo].[DetallesPedido] CHECK CONSTRAINT [FK_DetallesPedido_Pedidos]
GO
ALTER TABLE [dbo].[DetallesPedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPedido_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[DetallesPedido] CHECK CONSTRAINT [FK_DetallesPedido_Productos]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Clientes]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
