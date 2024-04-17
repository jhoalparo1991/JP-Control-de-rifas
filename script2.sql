use db_rifas
go
alter table tbl_abonos_boleta add abono_pagado bit
go
CREATE TABLE [dbo].[tbl_boleta_abono_pagado](
	[id] [int] primary key IDENTITY(1,1) NOT NULL,
	[codigo_abono] [int] NULL,
	[boleta_id] [int] NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[pagado] [bit] NOT NULL,
	[fecha_pagado] [date] NOT NULL,
)
go
CREATE TABLE tbl_pago_abonos(
	[id] [int] primary key IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NOT NULL,
	[identificador] [varchar](50) NOT NULL unique,
	[fecha_pago] [date] NOT NULL,
	[periodo_pagado] [varchar](50) NOT NULL,
	[hora_pago] [time](7) NOT NULL,
	[valor_pagos] [decimal](18, 2) NOT NULL,
	[descripcion] [varchar](255) NULL,
)
go
CREATE TABLE [dbo].[tbl_pagos_abono_detalle](
	[id] [int] primary key IDENTITY(1,1) NOT NULL,
	[pago_id] [int] NOT NULL,
	[vendedor_id] [int] NOT NULL,
	[nombre_vendedor] [varchar](150) NOT NULL,
	[valor_pagado] [decimal](18, 2) NOT NULL,
	[fecha_pago] [datetime] NOT NULL,
	[forma_pago] [varchar](50) NOT NULL,
	[periodo_pagado] [varchar](50) NOT NULL,
	[pagado] [bit] NOT NULL,
)
go
CREATE TABLE [dbo].[tbl_tmp_pago_abono](
	[codigo_abono] [int] NULL,
	[codigo] [varchar](50) NULL,
	[boleta_id] [int] NULL,
	[vendedor_id] [int] NULL,
	[pagado] [bit] NULL,
	[terminal] [varchar](50) NULL
) 
go
alter proc [dbo].[sp_registrar_abono_boleta]
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


go
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
go
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
go
CREATE proc sp_registrar_pagos
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
	
	delete from tbl_tmp_pago_abono where terminal=@terminal

commit
end try
begin catch
	rollback
	print error_message()
end catch
go