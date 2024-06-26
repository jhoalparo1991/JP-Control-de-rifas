USE [master]
GO
/****** Object:  Database [db_rifas]    Script Date: 25/04/2024 5:59:42 p. m. ******/
CREATE DATABASE [db_rifas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_rifas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_rifas.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_rifas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_rifas_log.ldf' , SIZE = 3200KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_rifas] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_rifas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_rifas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_rifas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_rifas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_rifas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_rifas] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_rifas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_rifas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_rifas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_rifas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_rifas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_rifas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_rifas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_rifas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_rifas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_rifas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_rifas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_rifas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_rifas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_rifas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_rifas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_rifas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_rifas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_rifas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_rifas] SET  MULTI_USER 
GO
ALTER DATABASE [db_rifas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_rifas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_rifas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_rifas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_rifas] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_rifas]
GO
/****** Object:  UserDefinedTableType [dbo].[ty_pagos_abono_detalle]    Script Date: 25/04/2024 5:59:42 p. m. ******/
CREATE TYPE [dbo].[ty_pagos_abono_detalle] AS TABLE(
	[pago_id] [int] NULL,
	[vendedor_id] [int] NULL,
	[nombre_vendedor] [varchar](150) NULL,
	[valor_pagado] [decimal](18, 2) NULL,
	[forma_pago] [varchar](50) NULL,
	[periodo_pagado] [varchar](50) NULL
)
GO
/****** Object:  Table [dbo].[tbl_abonos_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_abonos_boleta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[cliente_id] [int] NULL,
	[boleta_id] [int] NOT NULL,
	[nro_boleta] [varchar](50) NOT NULL,
	[valor_por_pagar] [decimal](18, 2) NOT NULL,
	[valor_abono] [decimal](18, 2) NOT NULL,
	[valor_comision] [decimal](18, 2) NOT NULL,
	[fecha_abono] [date] NULL,
	[hora_abono] [time](7) NULL,
	[forma_pago] [varchar](50) NULL,
	[abono_pagado] [bit] NULL,
 CONSTRAINT [PK__tbl_abon__3213E83F466A0B0F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_boleta_abono_pagado]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_boleta_abono_pagado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo_abono] [int] NULL,
	[boleta_id] [int] NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[pagado] [bit] NOT NULL,
	[fecha_pagado] [date] NOT NULL,
 CONSTRAINT [PK__tbl_bole__3213E83FCBBF454D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_boletas]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_boletas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rifa_id] [int] NOT NULL,
	[nro_boleta] [varchar](50) NOT NULL,
	[valor_boleta] [decimal](18, 2) NOT NULL,
	[pagada] [bit] NOT NULL,
	[vendida] [bit] NOT NULL,
	[vendedor_id] [int] NULL,
 CONSTRAINT [PK__tbl_bole__3213E83FA1758F9D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_boletas_vendedores]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_boletas_vendedores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[boleta_id] [int] NOT NULL,
	[nro_boleta] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_clientes]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_completo] [varchar](100) NOT NULL,
	[nro_doc] [varchar](20) NOT NULL,
	[direccion] [varchar](50) NULL,
	[celular] [varchar](20) NULL,
	[telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nro_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_config]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_config](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ruta_copia_seguridad] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_facturar_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_facturar_boleta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[cliente_id] [int] NOT NULL,
	[boleta_id] [int] NOT NULL,
	[nro_boleta] [varchar](50) NOT NULL,
	[fecha_venta] [date] NOT NULL,
	[hora_venta] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_gastos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_gastos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_gasto_id] [int] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[referencia] [varchar](50) NULL,
	[descripcion] [varchar](255) NOT NULL,
	[valor] [decimal](18, 2) NOT NULL,
	[fecha] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_info_boleta_pagada]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_info_boleta_pagada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[boleta_id] [int] NOT NULL,
	[pago_id] [int] NOT NULL,
	[codigo_abono] [int] NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[pagado] [bit] NOT NULL,
	[fecha] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_inicio_sesion]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_inicio_sesion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NOT NULL,
	[terminal] [varchar](100) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pago_abonos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pago_abonos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NOT NULL,
	[identificador] [varchar](50) NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[periodo_pagado] [varchar](50) NOT NULL,
	[hora_pago] [time](7) NOT NULL,
	[valor_pagos] [decimal](18, 2) NOT NULL,
	[descripcion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pagos_abono_detalle]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pagos_abono_detalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pago_id] [int] NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[nombre_vendedor] [varchar](150) NOT NULL,
	[valor_pagado] [decimal](18, 2) NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[forma_pago] [varchar](50) NOT NULL,
	[periodo_pagado] [varchar](50) NOT NULL,
	[pagado] [bit] NOT NULL,
 CONSTRAINT [PK__tbl_pago__3213E83F76B89938] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_rifas]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_rifas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NOT NULL,
	[descripcion] [varchar](255) NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_final] [date] NOT NULL,
	[nro_inicial] [int] NOT NULL,
	[nro_final] [int] NOT NULL,
	[activa] [bit] NOT NULL,
	[valor_rifa] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_tipos_gastos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_tipos_gastos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_tmp_pago_abono]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_tmp_pago_abono](
	[codigo_abono] [int] NULL,
	[codigo] [varchar](50) NULL,
	[boleta_id] [int] NULL,
	[vendedor_id] [int] NULL,
	[pagado] [bit] NULL,
	[terminal] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_completo] [varchar](100) NOT NULL,
	[nro_doc] [varchar](20) NOT NULL,
	[direccion] [varchar](50) NULL,
	[celular] [varchar](20) NULL,
	[telefono] [varchar](20) NULL,
	[clave] [varchar](300) NOT NULL,
	[comision] [decimal](10, 2) NOT NULL,
	[is_admin] [bit] NOT NULL,
 CONSTRAINT [PK__tbl_usua__3213E83FB3151302] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__tbl_usua__A4E16938508D42C8] UNIQUE NONCLUSTERED 
(
	[nro_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_abonos_boleta]  WITH CHECK ADD  CONSTRAINT [fk_abonos_boleta_boleta] FOREIGN KEY([boleta_id])
REFERENCES [dbo].[tbl_boletas] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_abonos_boleta] CHECK CONSTRAINT [fk_abonos_boleta_boleta]
GO
ALTER TABLE [dbo].[tbl_abonos_boleta]  WITH CHECK ADD  CONSTRAINT [fk_abonos_boleta_usuario] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[tbl_usuarios] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_abonos_boleta] CHECK CONSTRAINT [fk_abonos_boleta_usuario]
GO
ALTER TABLE [dbo].[tbl_abonos_boleta]  WITH CHECK ADD  CONSTRAINT [FK_tbl_abonos_boleta_tbl_usuarios] FOREIGN KEY([vendedor_id])
REFERENCES [dbo].[tbl_usuarios] ([id])
GO
ALTER TABLE [dbo].[tbl_abonos_boleta] CHECK CONSTRAINT [FK_tbl_abonos_boleta_tbl_usuarios]
GO
ALTER TABLE [dbo].[tbl_boletas]  WITH CHECK ADD  CONSTRAINT [fk_boleta_rifa] FOREIGN KEY([rifa_id])
REFERENCES [dbo].[tbl_rifas] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_boletas] CHECK CONSTRAINT [fk_boleta_rifa]
GO
ALTER TABLE [dbo].[tbl_facturar_boleta]  WITH CHECK ADD  CONSTRAINT [fk_facturar_boleta_cliente] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[tbl_clientes] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_facturar_boleta] CHECK CONSTRAINT [fk_facturar_boleta_cliente]
GO
ALTER TABLE [dbo].[tbl_facturar_boleta]  WITH CHECK ADD  CONSTRAINT [fk_facturar_boleta_vendedor] FOREIGN KEY([vendedor_id])
REFERENCES [dbo].[tbl_usuarios] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_facturar_boleta] CHECK CONSTRAINT [fk_facturar_boleta_vendedor]
GO
ALTER TABLE [dbo].[tbl_facturar_boleta]  WITH CHECK ADD  CONSTRAINT [FK_tbl_facturar_boleta_tbl_boletas] FOREIGN KEY([boleta_id])
REFERENCES [dbo].[tbl_boletas] ([id])
GO
ALTER TABLE [dbo].[tbl_facturar_boleta] CHECK CONSTRAINT [FK_tbl_facturar_boleta_tbl_boletas]
GO
ALTER TABLE [dbo].[tbl_rifas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_rifas_tbl_usuarios] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[tbl_usuarios] ([id])
GO
ALTER TABLE [dbo].[tbl_rifas] CHECK CONSTRAINT [FK_tbl_rifas_tbl_usuarios]
GO
ALTER TABLE [dbo].[tbl_abonos_boleta]  WITH CHECK ADD  CONSTRAINT [ck_validar_pago] CHECK  (([valor_abono]<=[valor_por_pagar]))
GO
ALTER TABLE [dbo].[tbl_abonos_boleta] CHECK CONSTRAINT [ck_validar_pago]
GO
ALTER TABLE [dbo].[tbl_rifas]  WITH CHECK ADD  CONSTRAINT [ck_fecha_inicial_fecha_final] CHECK  (([fecha_inicio]<=[fecha_final]))
GO
ALTER TABLE [dbo].[tbl_rifas] CHECK CONSTRAINT [ck_fecha_inicial_fecha_final]
GO
ALTER TABLE [dbo].[tbl_rifas]  WITH CHECK ADD  CONSTRAINT [ck_nro_inicial_nro_final] CHECK  (([nro_inicial]<=[nro_final]))
GO
ALTER TABLE [dbo].[tbl_rifas] CHECK CONSTRAINT [ck_nro_inicial_nro_final]
GO
/****** Object:  StoredProcedure [dbo].[sp_asignar_boletas_vendedor]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_asignar_boletas_vendedor]
@vendedor_id int = 0,
@nro_boleta varchar(50)=''
as
begin
	declare @boleta_asignada int = (select count(*) from tbl_boletas_vendedores where nro_boleta=@nro_boleta)
	if @boleta_asignada > 0
	begin
		raiserror('Esta boleta ya fue asignada',16,1)
	end
	else
	begin
		declare @boleta_id int = (select id from tbl_boletas where nro_boleta=@nro_boleta)
		if @boleta_id > 0
		begin
			insert into tbl_boletas_vendedores values(@vendedor_id,@boleta_id,@nro_boleta)
			update tbl_boletas set vendedor_id=@vendedor_id where id=@boleta_id
		end
		else
		begin
			raiserror('La boleta que intentas asignar no existe',16,1)
		end
	end
end






GO
/****** Object:  StoredProcedure [dbo].[sp_borrar_pago_comision]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_borrar_pago_comision]
@id int = 0,
@abono_id int = 0,
@vendedor_id int = 0,
@boleta_id int = 0,
@pago_id int = 0,
@valor decimal(10,2) = 0.00,
@idInfoBoletaPagada int = 0
as
begin try
	begin tran
		
		update tbl_abonos_boleta set abono_pagado=0 where id=@abono_id
		update tbl_boleta_abono_pagado set pagado=0 where codigo_abono=@abono_id and vendedor_id=@vendedor_id and boleta_id=@boleta_id
		delete from tbl_boleta_abono_pagado where codigo_abono=@abono_id and vendedor_id=@vendedor_id and boleta_id=@boleta_id		
		update tbl_pago_abonos set valor_pagos = (valor_pagos - @valor) where id=@pago_id
		update tbl_pagos_abono_detalle set valor_pagado = (valor_pagado - @valor) where id=@id
		delete from tbl_info_boleta_pagada where id = @idInfoBoletaPagada
	commit
end try
begin catch
	rollback
	print error_message()
end catch

GO
/****** Object:  StoredProcedure [dbo].[sp_borrar_pagos_temporales]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_borrar_pagos_temporales]
@terminal varchar(50) = ''
as
begin try
begin tran
declare @total int = (select count(*) from tbl_tmp_pago_abono where terminal=@terminal)
if @total > 0
begin
delete from tbl_tmp_pago_abono where terminal=@terminal
end
commit
end try
begin catch
	rollback
	print error_message()
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_cambiar_cliente_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_cambiar_cliente_boleta]
@cliente_id int = 0,
@boleta_id int = 0
as
begin
	declare @nro_boleta varchar(50) = (select nro_boleta from tbl_boletas where id=@boleta_id)
	update tbl_abonos_boleta set
	cliente_id=@cliente_id
	where @boleta_id=@boleta_id  and nro_boleta=@nro_boleta
end

GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_abonos_entre_fecha_and_vendedor]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_consultar_abonos_entre_fecha_and_vendedor]
@vendedor_id int = 0,
@fecha_ini date = null,
@fecha_fin date = null
as
select 
	vendedor_id,sum(valor_comision) total_abono
from tbl_abonos_boleta
where fecha_abono between @fecha_ini and @fecha_fin 
and vendedor_id=@vendedor_id and abono_pagado=0
group by vendedor_id


GO
/****** Object:  StoredProcedure [dbo].[sp_crear_rifa]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_crear_rifa]
@id int = 0,
@usuario_id int =0,
@descripcion varchar(255)='',
@fecha_inicio date = null,
@fecha_final date = null,
@nro_inicial int = 0,
@nro_final int = 0,
@activa bit = 0,
@valor_rifa decimal(18,2) = 0.00
as
begin try
begin tran
if @id <= 0
begin
declare @id_rifa int

insert into tbl_rifas values(
	@usuario_id,
	@descripcion,
	@fecha_inicio,
	@fecha_final,
	@nro_inicial,
	@nro_final,
	@activa,
	@valor_rifa
)
set @id_rifa = @@IDENTITY
declare @total_boletas int = (@nro_final - @nro_inicial);
declare @contador int = 0
while @contador <= @total_boletas
begin
	insert into tbl_boletas values(@id_rifa,format((@nro_inicial+@contador),'0000'),@valor_rifa,0,0,0)
	set @contador = @contador +1 
end

end
else
begin
update tbl_rifas set
	descripcion=@descripcion,
	fecha_inicio=@fecha_inicio,
	fecha_final=@fecha_final,
	nro_inicial=@nro_inicial,
	nro_final=@nro_final,
	activa=@activa,
	valor_rifa=@valor_rifa
where id =@id

update tbl_boletas set valor_boleta=@valor_rifa where rifa_id=@id

end
commit
end try
begin catch
	rollback
	print error_message()
end catch








GO
/****** Object:  StoredProcedure [dbo].[sp_editar_forma_pago_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_forma_pago_boleta]
@abono_boleta_id int = 0,
@forma_pago varchar(50) = ''
as
begin
	update tbl_abonos_boleta set forma_pago=@forma_pago
	where id=@abono_boleta_id
end


GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_clientes]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_guardar_clientes]
@id int = 0,
@nombre_completo varchar(100) = '',
@nro_doc varchar(20) = '',
@direccion varchar(50) = '',
@celular varchar(20) = '',
@telefono varchar(20) = ''
as
if @id <= 0
begin

	if exists(select * from tbl_clientes where nro_doc=@nro_doc)
	raiserror('Ya existe un cliente con este número de documento',16,1)
	else
	insert into tbl_clientes values(@nombre_completo,
								    @nro_doc,
									@direccion,
									@celular,
									@telefono)
end
else
begin
	if exists(select * from tbl_clientes where nro_doc=@nro_doc and id<>@id)
	raiserror('Ya existe un usuario un usuario con este número de documento',16,1)
	else
	update tbl_clientes set 		nombre_completo=@nombre_completo,
								    nro_doc=@nro_doc,
									direccion=@direccion,
									telefono=@telefono
									where id=@id
end









GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_config]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_guardar_config]
@id int = 0,
@ruta_copia_seguridad varchar(max) = ''
as
if @id <= 0
begin
	insert into tbl_config values(@ruta_copia_seguridad) 
end
else
begin
	update tbl_config set ruta_copia_seguridad=@ruta_copia_seguridad
						  where id=@id
end


GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_gastos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_guardar_gastos]
@id int = 0,
@tipo_gasto_id int = 0,
@usuario_id int = 0,
@referencia varchar(50) ='',
@descripcion varchar(255) ='',
@valor decimal(18,2) = 0.00,
@fecha date = null
as
if @id <= 0
begin
	insert into tbl_gastos values(@tipo_gasto_id,@usuario_id,@referencia,@descripcion,
								  @valor,@fecha)
end
else
begin
	update tbl_gastos set tipo_gasto_id=@tipo_gasto_id,referencia=@referencia,
						  descripcion=@descripcion, valor=@valor, fecha=@fecha
						  where id=@id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_tipos_gastos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_guardar_tipos_gastos]
@id int = 0,
@codigo nchar(10) ='',
@descripcion varchar(50) =''
as
if @id <= 0
begin
	if exists (select * from tbl_tipos_gastos where codigo=@codigo)
	raiserror('Ya existe un tipo de gasto con el mismo codigo',16,1)
	else
	insert into tbl_tipos_gastos values(@codigo,@descripcion)
end
else
begin
	if exists (select * from tbl_tipos_gastos where codigo=@codigo and id<>@id)
	raiserror('Ya existe un tipo de gasto con el mismo codigo',16,1)
	else
	update tbl_tipos_gastos set codigo=@codigo,descripcion=@descripcion where id=@id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_usuarios]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[sp_guardar_usuarios]
@id int = 0,
@nombre_completo varchar(100) = '',
@nro_doc varchar(20) = '',
@direccion varchar(50) = '',
@celular varchar(20) = '',
@telefono varchar(20) = '',
@clave varchar(500) = '',
@comision decimal(10,2) = 0.00,
@is_admin bit = 0
as
if @id <= 0
begin

	if exists(select * from tbl_usuarios where nro_doc=@nro_doc)
	raiserror('Ya existe un usuario un usuario con este número de documento',16,1)
	else
	insert into tbl_usuarios values(@nombre_completo,
								    @nro_doc,
									@direccion,
									@celular,
									@telefono,
									@clave,
									@comision,
									@is_admin)
end
else
begin
	if exists(select * from tbl_usuarios where nro_doc=@nro_doc and id<>@id)
	raiserror('Ya existe un usuario un usuario con este número de documento',16,1)
	else
	update tbl_usuarios set 		nombre_completo=@nombre_completo,
								    nro_doc=@nro_doc,
									direccion=@direccion,
									telefono=@telefono,
									comision=@comision,
									is_admin=@is_admin,
									clave=@clave
									where id=@id
end










GO
/****** Object:  StoredProcedure [dbo].[sp_iniciar_sesion]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_iniciar_sesion]
@usuario_id int = 0,
@terminal varchar(50) =''
as
declare @existe int = (select count(*) from tbl_inicio_sesion where usuario_id=@usuario_id);
if @existe > 0
begin
update tbl_inicio_sesion set estado=1, terminal=@terminal where usuario_id=@usuario_id
end
else
begin
insert into tbl_inicio_sesion values(@usuario_id,@terminal,GETDATE(),1)
end








GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_abonos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_abonos]
@boleta_id int = 0
as
select a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo vendedor,
b.nro_doc cc_ve,
a.cliente_id,c.nombre_completo cliente,
c.nro_doc cc_cl,
( d.valor_boleta - sum(a.valor_abono)) valor_por_pagar
,sum(a.valor_abono) abonos,
a.valor_comision,
convert(nchar(10),a.fecha_abono,5) fecha_abono,
convert(nchar(10),a.hora_abono,108) hora_abono,
a.forma_pago
 from tbl_abonos_boleta a
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id =d.id
where boleta_id=@boleta_id
group by a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo,b.nro_doc,
a.cliente_id,c.nombre_completo,c.nro_doc,
a.valor_por_pagar,a.fecha_abono,a.hora_abono,d.valor_boleta,a.valor_comision,a.forma_pago





GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_abonos_comisiones_por_vendedores]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_abonos_comisiones_por_vendedores]
@vendedor_id int = 0,
@fecha_ini date = null,
@fecha_fin date = null
as
select a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo vendedor,
b.nro_doc cc_ve,
a.cliente_id,c.nombre_completo cliente,
c.nro_doc cc_cl,
a.valor_abono,
a.valor_comision,
convert(nchar(10),a.fecha_abono,5) fecha_abono,
convert(nchar(10),a.hora_abono,108) hora_abono,
a.forma_pago,
case 
	when a.abono_pagado=0 then 'Sin Pagar'
	when a.abono_pagado=1 then 'Pagada'
	end as 'ComisionPagada'
 from tbl_abonos_boleta a
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id =d.id
where a.vendedor_id=@vendedor_id and
a.fecha_abono between @fecha_ini and @fecha_fin


GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_abonos_por_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_abonos_por_boleta]
@boleta varchar(10) = ''
as
--nuevos
select a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo vendedor,
b.nro_doc cc_ve,
a.cliente_id,c.nombre_completo cliente,
c.nro_doc cc_cl,
( d.valor_boleta - sum(a.valor_abono)) valor_por_pagar
,sum(a.valor_abono) abonos,
a.valor_comision,
convert(nchar(10),a.fecha_abono,5) fecha_abono,
convert(nchar(10),a.hora_abono,108) hora_abono,
a.forma_pago
 from tbl_abonos_boleta a
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id =d.id
where a.nro_boleta=@boleta
group by a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo,b.nro_doc,
a.cliente_id,c.nombre_completo,c.nro_doc,
a.valor_por_pagar,a.fecha_abono,a.hora_abono,d.valor_boleta,a.valor_comision,a.forma_pago,a.abono_pagado


GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_boletas]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_boletas]
as
select 
  a.id,
  a.rifa_id,
  a.nro_boleta,
  a.valor_boleta,
  a.pagada,
  a.vendida,
  a.vendedor_id
from tbl_boletas a





GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_boletas_2]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_boletas_2]
@desde int = 0,
@hasta int = 0,
@rifa_id int = 0
as
select  *

 from (
	select row_number() over(order by id asc) newRow,
	* from tbl_boletas 
 ) m
where newRow between @desde and @hasta
and rifa_id=@rifa_id






GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_boletas_vendida_por_vendedores]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_boletas_vendida_por_vendedores]
as 
select 
	count(distinct a.id) contar,
	c.id,
	c.nombre_completo
from tbl_boletas a
inner join tbl_abonos_boleta b on a.id=b.boleta_id
inner join tbl_usuarios c on b.vendedor_id=c.id
where a.vendida=1
group by c.id,
	c.nombre_completo


GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_detalle_pagado]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_detalle_pagado]
@id int = 0,
@vendedor_id int = 0
as
select 
		f.id detalle_pago_id,a.id,a.boleta_id,a.pago_id,a.codigo_abono,a.vendedor_id,a.pagado,
		e.nombre_completo vendedor,a.fecha,
		b.nro_boleta,d.valor_comision from tbl_info_boleta_pagada a
		inner join tbl_boletas b on a.boleta_id=b.id
		inner join tbl_pago_abonos c on a.pago_id = c.id
		inner join tbl_abonos_boleta d on a.codigo_abono=d.id
		inner join tbl_usuarios e on a.vendedor_id = e.id
		inner join tbl_pagos_abono_detalle f on c.id=f.pago_id
		where d.valor_comision > 0 and f.id=@id and e.id=@vendedor_id

GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_gastos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_gastos]
as
begin
	select 
		a.id,
		a.tipo_gasto_id,
		a.usuario_id,
		b.codigo,
		b.descripcion tipo_gasto,
		a.referencia,
		a.descripcion,
		a.valor,
		a.fecha
	from tbl_gastos a inner join tbl_tipos_gastos b
	on a.tipo_gasto_id = b.id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_reporte_formas_pago]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_reporte_formas_pago]
@fecha_ini date,
@fecha_fin date,
@rifa_id int = 0
as
select b.forma_pago,sum(b.valor_abono) total_abonos from tbl_boletas a 
left join tbl_abonos_boleta b on a.id =b.boleta_id
where a.rifa_id=@rifa_id and b.fecha_abono between @fecha_ini and @fecha_fin
group by b.forma_pago





GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_todos_abonos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ALTER proc [dbo].[sp_mostrar_abonos]
--@boleta_id int = 0
--as
CREATE proc [dbo].[sp_mostrar_todos_abonos]
as
select a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo vendedor,
a.cliente_id,c.nombre_completo cliente,
( d.valor_boleta - sum(a.valor_abono)) valor_por_pagar
,sum(a.valor_abono) abonos,
a.valor_comision,
convert(nchar(10),a.fecha_abono,5) fecha_abono,
convert(nchar(10),a.hora_abono,108) hora_abono,
a.forma_pago
 from tbl_abonos_boleta a
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id =d.id
group by a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo,
a.cliente_id,c.nombre_completo,
a.valor_por_pagar,a.fecha_abono,a.hora_abono,d.valor_boleta,a.valor_comision,a.forma_pago





GO
/****** Object:  StoredProcedure [dbo].[sp_obtner_boletas_entre_fecha_and_vendedor]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_obtner_boletas_entre_fecha_and_vendedor]
@vendedor_id int = 0,
@fecha_ini date = null,
@fecha_fin date = null,
@codigo varchar(50) = '',
@terminal varchar(50) = ''
as
insert into tbl_tmp_pago_abono select 
	id,
	@codigo,
	boleta_id,
	vendedor_id,
	1,
	@terminal
from tbl_abonos_boleta
where fecha_abono between @fecha_ini and @fecha_fin 
and vendedor_id=@vendedor_id



GO
/****** Object:  StoredProcedure [dbo].[sp_quitar_boleta_vendedor]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_quitar_boleta_vendedor]
@boleta_id int
as
begin try
	begin tran
		declare @boleta_vendida int = (select count(*) from tbl_abonos_boleta where boleta_id=@boleta_id)
		if @boleta_vendida > 0
		begin
			raiserror('No puedes quitar una boleta que ya tiene abonos registrados',16,1)
		end
		begin
		delete from tbl_boletas_vendedores where boleta_id=@boleta_id
		update tbl_boletas set vendedor_id=0 where id=@boleta_id
		end
	commit
end try
begin catch
	rollback
	print error_message()
end catch

GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_abono_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_registrar_abono_boleta]
@id int =0,
@usuario_id int = 0,
@boleta_id int = 0,
@nro_boleta varchar(50) = '',
@valor_por_pagar decimal(18,2) = 0.00,
@valor_abono decimal(18,2) = 0.00,
@valor_comision decimal(18,2) = 0.00,
@forma_pago varchar(50) = '',
@nombre_ve varchar(100) = '',
@cc_ve varchar(20) = '',
@nombre_cl varchar(100) = '',
@cc_cl varchar(20) = ''
as
begin try
	begin tran
	if @id <= 0
	begin
		
		declare @existe_ve int =(select count(*) from tbl_usuarios where nro_doc=@cc_ve)
		if(@existe_ve <= 0)
		begin
			insert into tbl_usuarios values(@nombre_ve,@cc_ve,'','','','',30,0)
		end

		declare @existe_cl int =(select count(*) from tbl_clientes where nro_doc=@cc_cl)
		if(@existe_cl <= 0)
		begin
			insert into tbl_clientes values(@nombre_cl,@cc_cl,'','','')
		end

		
	

		declare @vendedor_id int = (select id from tbl_usuarios where nro_doc=@cc_ve)
		declare @cliente_id int = (select id from tbl_clientes where nro_doc=@cc_cl)
		
		declare @vendedor_boleta_id int = (select vendedor_id from tbl_boletas where id=@boleta_id)
		if(@vendedor_boleta_id <= 0)
		begin
			update tbl_boletas set vendedor_id=@vendedor_id where id=@boleta_id
			insert into tbl_boletas_vendedores values(@vendedor_id,@boleta_id,@nro_boleta)
		end

		insert into tbl_abonos_boleta values(@usuario_id,@vendedor_id,@cliente_id,@boleta_id,@nro_boleta,@valor_por_pagar,@valor_abono,@valor_comision,getdate(),getdate(),@forma_pago,0)
	update tbl_boletas set vendida=1 where id=@boleta_id and vendida=0
	if @valor_abono = @valor_por_pagar
	begin
		update tbl_boletas set pagada=1 where id=@boleta_id
	end
	end
	else
	begin
		update tbl_abonos_boleta set usuario_id=@usuario_id,valor_por_pagar=@valor_por_pagar,valor_abono=@valor_abono,valor_comision=@valor_comision,fecha_abono=getdate(),hora_abono=getdate(),forma_pago=@forma_pago
			where id=@id
		if @valor_abono = @valor_por_pagar
			begin
				update tbl_boletas set pagada=1 where id=@boleta_id
			end
	end

	commit
end try
begin catch
	rollback
	print error_message()
end catch



GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_pagos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_registrar_pagos]
@usuario_id int =0,
@identificador varchar(50)='',
@fecha_pago date = null,
@hora_pago time = null,
@periodo_pagado varchar(50) = '',
@valor_pagos decimal(18,2) = 0.00,
@descripcion varchar(255) = '',
@terminal varchar(50) = '',
@detalles ty_pagos_abono_detalle readonly
as
begin try
begin tran
	declare @pago_id int
	insert into tbl_pago_abonos values (@usuario_id,@identificador,@fecha_pago,@periodo_pagado,@hora_pago,@valor_pagos,@descripcion)

	set @pago_id = SCOPE_IDENTITY()

	insert into tbl_pagos_abono_detalle select @pago_id,x.vendedor_id,x.nombre_vendedor,x.valor_pagado,getdate(),x.forma_pago,x.periodo_pagado,1 from @detalles x

	update a set a.abono_pagado=1 from tbl_abonos_boleta a inner join tbl_tmp_pago_abono b on a.id=b.codigo_abono

	insert into tbl_boleta_abono_pagado select x.codigo_abono, x.boleta_id,x.vendedor_id,x.pagado,@fecha_pago from tbl_tmp_pago_abono x where x.codigo=@identificador
	
	insert into tbl_info_boleta_pagada select x.boleta_id,@pago_id,x.codigo_abono,x.vendedor_id,x.pagado,@fecha_pago from tbl_tmp_pago_abono x where x.codigo=@identificador


	delete from tbl_tmp_pago_abono where terminal=@terminal

commit
end try
begin catch
	rollback
	print error_message()
end catch

GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_abonos_fecha_monto]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_reporte_abonos_fecha_monto]
@valor decimal(18,2),
@fecha_ini date,
@fecha_fin date
as
with cte_consulta
as
(select 
	a.nro_boleta,	
	sum(b.valor_abono) valor,
	b.fecha_abono,
	c.nombre_completo cliente
 from tbl_boletas a
inner join tbl_abonos_boleta b on a.id =b.boleta_id
inner join tbl_clientes c on b.cliente_id=c.id
group by
	a.nro_boleta,
	b.fecha_abono,
	c.nombre_completo
) select * from cte_consulta b
where b.valor >= @valor and b.fecha_abono between @fecha_ini and @fecha_fin





GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_abonos_por_boleta]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_abonos_por_boleta]
@nro_boleta varchar(20) = ''
as
select a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo vendedor,
a.cliente_id,c.nombre_completo cliente,
( d.valor_boleta - sum(a.valor_abono)) valor_por_pagar
,sum(a.valor_abono) abonos,
a.valor_comision,
convert(nchar(10),a.fecha_abono,5) fecha_abono,
convert(nchar(10),a.hora_abono,108) hora_abono,
a.forma_pago
 from tbl_abonos_boleta a
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id =d.id
where d.nro_boleta=@nro_boleta
group by a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo,
a.cliente_id,c.nombre_completo,
a.valor_por_pagar,a.fecha_abono,a.hora_abono,d.valor_boleta,a.valor_comision,a.forma_pago





GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_boletas_por_estados]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_reporte_boletas_por_estados]
as
declare @pagada int =(select count(*) from tbl_boletas where pagada = 1)
declare @sin_pagar int =(select count(*) from tbl_boletas where pagada = 0 and vendida=1)
declare @vendida int =(select count(*) from tbl_boletas where vendida = 1)
declare @sin_vender int =(select count(*) from tbl_boletas where vendida = 0)

select @pagada as pagada,@sin_pagar as sin_pagar,@vendida as vendida,@sin_vender as sin_vender





GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_caja]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_reporte_caja]
@fecha date,
@fecha2 date
as
declare @total_abonos decimal(10,2) = ( select sum(valor_abono) from tbl_abonos_boleta where fecha_abono between @fecha and @fecha2)

declare @total_comisiones decimal(10,2) = ( select sum(valor_comision) from tbl_abonos_boleta where fecha_abono  between @fecha and @fecha2)

--declare @total_gastos decimal(10,2) = ( select sum(valor) from tbl_gastos where fecha=@fecha)

create table #tmp(forma_pago varchar(50),valor decimal(10,2))

insert into #tmp select forma_pago, sum(valor_abono) valor
 from tbl_abonos_boleta where fecha_abono  between @fecha and @fecha2 and valor_abono > 0
group by forma_pago

declare @total_comision_pagada decimal(10,2) = (select sum(valor_pagado) total_comision_pagada from tbl_pagos_abono_detalle where fecha_pago  between @fecha and @fecha2 )

select 
	case when @total_abonos is null then 0 else @total_abonos end as 'total_abonos', 
	case when @total_comisiones is null then 0 else @total_comisiones end as 'total_comisiones',
	case when @total_comision_pagada is null then 0 else @total_comision_pagada end as 'total_comision_pagada',
	* from #tmp
drop table #tmp;

GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_detalle_pago_comisiones]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_reporte_detalle_pago_comisiones]
@fecha_ini date = null,
@fecha_fin date = null
as
select * from tbl_pagos_abono_detalle
where fecha_pago between @fecha_ini and @fecha_fin
order by nombre_vendedor 

GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_detalle_pago_comisiones_vendedores]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_detalle_pago_comisiones_vendedores]
@vendedor_id int = 0
as
select * from tbl_pagos_abono_detalle
where vendedor_id=@vendedor_id



GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_detalle_pago_comisiones_vendedores_por_id]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_detalle_pago_comisiones_vendedores_por_id]
@id int = 0
as
select * from tbl_pagos_abono_detalle
where id=@id

GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_mostrar_todos_abonos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_reporte_mostrar_todos_abonos]
as
select 
	a.id boleta_id,
	a.nro_boleta,
	b.valor_abono,
	b.valor_comision,
	b.fecha_abono,
	b.forma_pago,
	case when c.nombre_completo = '' then 'Sin Asignar' 
	else c.nombre_completo end as vendedor,
	case when d.nombre_completo = '' then 'Sin Asignar' 
	else d.nombre_completo end as cliente
from tbl_boletas a
inner join tbl_abonos_boleta b on a.id=b.boleta_id
inner join tbl_usuarios c on b.vendedor_id=c.id
inner join tbl_clientes d on b.cliente_id = d.id
where a.vendida=1 







GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_pagos]    Script Date: 25/04/2024 5:59:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_pagos]
@fecha_ini date = null,
@fecha_fin date = null
as
select * from tbl_pago_abonos
where fecha_pago between @fecha_ini and @fecha_fin



GO
USE [master]
GO
ALTER DATABASE [db_rifas] SET  READ_WRITE 
GO
