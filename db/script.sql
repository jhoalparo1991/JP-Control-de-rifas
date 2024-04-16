USE [master]
GO
/****** Object:  Database [db_rifas]    Script Date: 10/04/2024 7:05:47 p. m. ******/
CREATE DATABASE [db_rifas]

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
/****** Object:  Table [dbo].[tbl_abonos_boleta]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
	[boleta_id] [int] NOT NULL,
	[nro_boleta] [varchar](50) NOT NULL,
	[valor_por_pagar] [decimal](18, 2) NOT NULL,
	[valor_abono] [decimal](18, 2) NOT NULL,
	[valor_comision] [decimal](18, 2) NOT NULL,
	[fecha_abono] [date] NULL,
	[hora_abono] [time](7) NULL,
	[participa_sorteo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_boletas]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
 CONSTRAINT [PK__tbl_bole__3213E83FA1758F9D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_clientes]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  Table [dbo].[tbl_facturar_boleta]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  Table [dbo].[tbl_inicio_sesion]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  Table [dbo].[tbl_rifas]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_crear_rifa]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
declare @contador int = 1
while @contador <= @total_boletas
begin
	insert into tbl_boletas values(@id_rifa,format((@nro_inicial+@contador),'0000'),@valor_rifa,0,0)
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
end
commit
end try
begin catch
	rollback
	print error_message()
end catch

GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_clientes]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_guardar_usuarios]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_iniciar_sesion]    Script Date: 10/04/2024 7:05:47 p. m. ******/
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
USE [master]
GO
ALTER DATABASE [db_rifas] SET  READ_WRITE 
GO
