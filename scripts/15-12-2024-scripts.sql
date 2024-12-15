create proc reporte_boletas_entre_fechas
@fecha_inicio date,
@fecha_fin date
as
select c.nombre_completo vendedor, b.nombre_completo cliente,
a.nro_boleta as boleta, a.valor_abono,a.forma_pago,a.valor_comision,a.fecha_abono,
a.hora_abono,
case when a.abono_pagado = 1 then 'Si'
else 'No' end as comision_pagada
from tbl_abonos_boleta a
inner join tbl_clientes b on a.cliente_id=b.id
inner join tbl_usuarios c on a.vendedor_id=c.id
where a.fecha_abono between @fecha_inicio and @fecha_fin
go
alter proc sp_bloquear_desbloquear_boleta
@boleta_id int = 0,
@nro_boleta varchar(10) = ''
as
begin try
begin tran
	declare @pagada int = (select pagada from tbl_boletas where id=@boleta_id)
	declare @vendida int = (select vendida from tbl_boletas where id=@boleta_id)
	if @pagada = 1
	begin
		update tbl_boletas set pagada=0 where id=@boleta_id and nro_boleta=@nro_boleta
	end
	else
	begin
		update tbl_boletas set pagada=1 where id=@boleta_id and nro_boleta=@nro_boleta
	end
commit
end try
begin catch
rollback
end catch
go
alter table tbl_usuarios_permisos
add desbloquear_boleta bit null
go
alter table tbl_usuarios_permisos
add ver_estado_boletas bit null
go
alter table tbl_usuarios_permisos
add ver_caja bit null
go
alter table tbl_usuarios_permisos
add ver_acumulado bit null
go
alter table tbl_usuarios_permisos
add ver_todos_los_abonos bit null
go
alter table tbl_usuarios_permisos
add ver_abonos_totales_por_clientes bit null
go
alter table tbl_usuarios_permisos
add ver_comisiones_vendedores_pagada bit null
go
alter table tbl_usuarios_permisos
add ver_abonos_por_vendedores bit null
go
alter table tbl_usuarios_permisos
add ver_abonos_por_boletas bit null
go
alter table tbl_usuarios_permisos
add ver_boletas_vendidas bit null
go
alter table tbl_usuarios_permisos
add ver_formas_pago bit null
go
alter table tbl_usuarios_permisos
add ver_filtrar_abonos_fecha_valor bit null
go
alter table tbl_usuarios_permisos
add ver_comisiones_pagadas bit null
go
alter table tbl_usuarios_permisos
add ver_gastos bit null
go
alter table tbl_usuarios_permisos
add ver_reporte_abono_formas_pago bit null
go
alter table tbl_usuarios_permisos
add ver_reporte_boletas_entre_fechas bit null
go
update tbl_usuarios_permisos set 
desbloquear_boleta=0,
ver_estado_boletas=0,
ver_caja=0,
ver_acumulado=0,
ver_todos_los_abonos=0,
ver_abonos_totales_por_clientes=0,
ver_comisiones_vendedores_pagada=0,
ver_abonos_por_vendedores=0,
ver_abonos_por_boletas=0,
ver_boletas_vendidas=0,
ver_formas_pago=0,
ver_filtrar_abonos_fecha_valor=0,
ver_comisiones_pagadas=0,
ver_gastos=0,
ver_reporte_abono_formas_pago=0,
ver_reporte_boletas_entre_fechas=0

go
ALTER proc [dbo].[sp_mostrar_reporte_total_caja]  
as  
declare @total_abonos decimal = (select sum(valor_abono) as total_abonos from tbl_abonos_boleta)  
declare @total_gastos decimal = (select sum(valor) as total_gastos from tbl_gastos)  
declare @total_comision_pagada decimal = (select sum(valor_pagado) as total_pagado 
											from tbl_pago_comisiones) 

if @total_comision_pagada is null
begin
	set @total_comision_pagada  = 0
end
if @total_gastos is null
begin
	set @total_gastos  = 0
end
if @total_abonos is null
begin
	set @total_abonos  = 0
end

declare @total_caja decimal(18,2) 
--set @total_caja  = ((@total_abonos - @total_gastos) - @total_comision_pagada)
set @total_caja  = (@total_abonos - (@total_gastos + @total_comision_pagada))

select 
	@total_abonos as abonos, 
	@total_gastos as gastos, 
	@total_comision_pagada as comision, 
	@total_caja as caja   
go
ALTER proc [dbo].[sp_mostrar_total_comisiones_por_pagada]  
as  
--select sum(valor_comision) comision  
-- from tbl_abonos_boleta   
--where abono_pagado=0

declare @comision_pagada decimal(10,0) = (select sum(valor_pagado) comision from tbl_pago_comisiones)
declare @total_abonos decimal(10,0) = (select ((sum(valor_abono) * 30) / 100 ) comision from tbl_abonos_boleta)

select @total_abonos - @comision_pagada as comision
go
ALTER proc [dbo].[sp_mostrar_caja_por_dia]
@fecha1 nchar(10) ='',
@fecha2 nchar(10) =''
as
set dateformat 'dmy'
declare @total_abonos decimal = (select sum(valor_abono) as total_abonos from tbl_abonos_boleta where fecha_abono between @fecha1 and @fecha2)
declare @total_gastos decimal = (select sum(valor) as total_gastos from tbl_gastos where fecha between @fecha1 and @fecha2)
declare @total_comision_pagada decimal = (select sum(valor_pagado) as total_pagado from tbl_pago_comisiones where  fecha_pago_comision between @fecha1 and @fecha2)

declare @total_caja decimal = (@total_abonos -(@total_gastos + @total_comision_pagada))
if @total_abonos is null
begin
	set @total_abonos = 0
end
if @total_gastos is null
begin
	set @total_gastos = 0
end
if @total_comision_pagada is null
begin
	set @total_comision_pagada = 0
end
if @total_caja is null
begin
	set @total_caja = 0
end
select @total_abonos as abonos, @total_gastos as gastos, @total_comision_pagada as comision, @total_caja as caja 
go
ALTER proc [dbo].[sp_guardar_usuarios]
@id int = 0,
@nombre_completo varchar(100) = '',
@nro_doc varchar(20) = '',
@direccion varchar(50) = '',
@celular varchar(20) = '',
@telefono varchar(20) = '',
@clave varchar(500) = '',
@comision decimal(10,2) = 0.00,
@activo bit = 0,
-- permisos
@vendedores bit = 0,
@clientes bit = 0,
@rifas bit = 0,
@boletas bit = 0,
@pago_comisiones bit = 0,
@reportes bit = 0,
@egresos bit = 0,
@crear_tipo_egreso bit = 0,
@borrar_egreso bit = 0,
@editar_egreso bit = 0,
@crear_egreso bit = 0,
@imprimir_egreso bit = 0,
@crear_copia_seguridad bit = 0,
@registrar_abono bit = 0,
@borrar_abono bit = 0,
@cambiar_fp_abono bit = 0,
@cambiar_cliente_abono bit = 0,
-- permisos-adicionales
@crear_vendedores bit=0,
@editar_vendedores bit=0,
@borrar_vendedores bit=0,
@asignar_boletas_vendedores bit=0,
@ver_log bit = 0,
@ver_boleta bit = 0,
@bloquear_desbloquear bit = 0,
@ver_estado_boletas bit = 0,
@ver_caja bit = 0,
@ver_acumulado bit = 0,
@ver_todos_los_abonos bit = 0,
@ver_abonos_totales_por_clientes bit = 0,
@ver_comisiones_vendedores_pagada bit = 0,
@ver_abonos_por_vendedores bit = 0,
@ver_abonos_por_boletas bit = 0,
@ver_boletas_vendidas bit = 0,
@ver_formas_pago bit = 0,
@ver_filtrar_abonos_fecha_valor bit = 0,
@ver_comisiones_pagadas bit = 0,
@ver_gastos bit = 0,
@ver_reporte_abono_formas_pago bit = 0,
@ver_reporte_boletas_entre_fechas bit = 0
as
begin try
	begin tran
		if @id <= 0
			begin

				if exists(select * from tbl_usuarios where nro_doc=@nro_doc)
				raiserror('Ya existe un usuario un usuario con este número de documento',16,1)
				else
				declare @usuarioId int
				insert into tbl_usuarios values(@nombre_completo,
												@nro_doc,
												@direccion,
												@celular,
												@telefono,
												@clave,
												@comision,
												@activo)

				set @usuarioId = @@IDENTITY

				insert into tbl_usuarios_permisos values(@usuarioId,@vendedores,@clientes,@rifas,@boletas,@pago_comisiones,
					@reportes,@egresos,@crear_tipo_egreso,@borrar_egreso,@editar_egreso,						@crear_egreso,@imprimir_egreso,@crear_copia_seguridad,@registrar_abono,
					@borrar_abono,@cambiar_fp_abono,@cambiar_cliente_abono,@crear_vendedores,
					@editar_vendedores,@borrar_vendedores,@asignar_boletas_vendedores,@ver_log,@ver_boleta,@bloquear_desbloquear,
					@ver_estado_boletas,@ver_caja,@ver_acumulado,@ver_todos_los_abonos,@ver_abonos_totales_por_clientes,
					@ver_comisiones_vendedores_pagada,@ver_abonos_por_vendedores,@ver_abonos_por_boletas,@ver_boletas_vendidas,
					@ver_formas_pago,@ver_filtrar_abonos_fecha_valor,@ver_comisiones_pagadas,@ver_gastos,@ver_reporte_abono_formas_pago,
					@ver_reporte_boletas_entre_fechas)

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
												activo=@activo,
												clave=@clave
												where id=@id

				update tbl_usuarios_permisos set vendedores=@vendedores,
												clientes=@clientes,
												rifas=@rifas,
												boletas=@boletas,
												pago_comisiones=@pago_comisiones,
												reportes=@reportes,
												egresos=@egresos,
												crear_tipo_egreso=@crear_tipo_egreso,
												borrar_egreso=@borrar_egreso,
												editar_egreso=@editar_egreso,
												crear_egreso=@crear_egreso,
												imprimir_egreso=@imprimir_egreso,
												crear_copia_seguridad=@crear_copia_seguridad,
												registrar_abono=@registrar_abono,
												borrar_abono=@borrar_abono,
												cambiar_fp_abono=@cambiar_fp_abono,
												cambiar_cliente_abono=@cambiar_cliente_abono,
												crear_vendedores=@crear_vendedores,
												editar_vendedores=@editar_vendedores,
												borrar_vendedores=@borrar_vendedores,
												asignar_boletas_vendedores=@asignar_boletas_vendedores,
												ver_log=@ver_log,
												ver_boleta=@ver_boleta,
												desbloquear_boleta=@bloquear_desbloquear,
												ver_estado_boletas = @ver_estado_boletas,
												ver_caja = @ver_caja,
												ver_acumulado = @ver_acumulado,
												ver_todos_los_abonos = @ver_todos_los_abonos,
												ver_abonos_totales_por_clientes = @ver_abonos_totales_por_clientes,
												ver_comisiones_vendedores_pagada = @ver_comisiones_vendedores_pagada,
												ver_abonos_por_vendedores = @ver_abonos_por_vendedores,
												ver_abonos_por_boletas = @ver_abonos_por_boletas,
												ver_boletas_vendidas = @ver_boletas_vendidas,
												ver_formas_pago = @ver_formas_pago,
												ver_filtrar_abonos_fecha_valor = @ver_filtrar_abonos_fecha_valor,
												ver_comisiones_pagadas = @ver_comisiones_pagadas,
												ver_gastos = @ver_gastos,
												ver_reporte_abono_formas_pago = @ver_reporte_abono_formas_pago,
												ver_reporte_boletas_entre_fechas = @ver_reporte_boletas_entre_fechas
												where usuario_id=@id
			end
	commit
end try
begin catch
	rollback
	print error_message()
end catch
go

