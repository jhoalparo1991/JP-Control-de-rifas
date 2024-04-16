USE [master]
GO
/****** Object:  Database [db_rifas]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_abonos_boleta]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
 CONSTRAINT [PK__tbl_abon__3213E83F466A0B0F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_boletas]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_boletas_vendedores]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_clientes]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_config]    Script Date: 14/04/2024 3:35:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_config](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro_botones] [int] NOT NULL,
	[nro_registros_por_pagina] [int] NOT NULL,
	[color] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_facturar_boleta]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_inicio_sesion]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_rifas]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_asignar_boletas_vendedor]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_crear_rifa]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
end
commit
end try
begin catch
	rollback
	print error_message()
end catch




GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_clientes]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_guardar_config]    Script Date: 14/04/2024 3:35:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_guardar_config]
@id int = 0,
@nro_botones int = 0,
@nro_registros_por_pagina int =0,
@color int = 0
as
if @id <= 0
begin
	insert into tbl_config values(@nro_botones,@nro_registros_por_pagina,@color) 
end
else
begin
	update tbl_config set nro_botones=@nro_botones,
						  nro_registros_por_pagina=@nro_registros_por_pagina,
						  color=@color
						  where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_usuarios]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_iniciar_sesion]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrar_abonos]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrar_boletas]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrar_boletas_2]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrar_reporte_formas_pago]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrar_todos_abonos]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_registrar_abono_boleta]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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

		insert into tbl_abonos_boleta values(@usuario_id,@vendedor_id,@cliente_id,@boleta_id,@nro_boleta,@valor_por_pagar,@valor_abono,@valor_comision,getdate(),getdate(),@forma_pago)
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
/****** Object:  StoredProcedure [dbo].[sp_reporte_abonos_fecha_monto]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_reporte_abonos_por_boleta]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_reporte_boletas_por_estados]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_reporte_mostrar_todos_abonos]    Script Date: 14/04/2024 3:35:56 p.m. ******/
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
USE [master]
GO
ALTER DATABASE [db_rifas] SET  READ_WRITE 
GO
