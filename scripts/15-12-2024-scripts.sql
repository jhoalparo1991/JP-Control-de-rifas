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
update tbl_usuarios_permisos set desbloquear_boleta=0
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
--select sum(valor_abono) abono, ((sum(valor_abono) * 30) / 100 ) comision
--from tbl_abonos_boleta
-- AGREGAR CAMPO al procedimiento - sp_guardar_usuarios
--@bloquear_desbloquear bit = 0

