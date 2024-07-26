create view v_listado_abonos
as
select a.id,a.usuario_id,a.vendedor_id, d.nombre_completo vendedor,
a.cliente_id, b.nombre_completo cliente,a.boleta_id,a.nro_boleta,
a.valor_por_pagar,a.valor_abono,a.valor_comision,a.fecha_abono,a.forma_pago,
case when a.abono_pagado=1 then 'Si'
else 'No' end as 'abono_pagado' 
from tbl_abonos_boleta a
inner join tbl_clientes b on a.cliente_id = b.id
inner join tbl_boletas c on a.boleta_id = c.id
inner join tbl_usuarios d on a.vendedor_id=d.id
go
create table tbl_pago_comisiones
(
	id int primary key identity(1,1),
	vendedor_id int not null,
	cliente_id int not null,
	boleta_id int not null,
	abono_id int not null,
	valor_pagado decimal(10,2) not null,
	fecha_pago_comision date not null,
)
go
alter proc [dbo].[sp_reporte_abonos_fecha_monto]
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
	c.nombre_completo as cliente,
	d.nombre_completo as vendedor
 from tbl_boletas a
inner join tbl_abonos_boleta b on a.id =b.boleta_id
inner join tbl_clientes c on b.cliente_id=c.id
inner join tbl_usuarios d on a.vendedor_id=d.id
group by
	a.nro_boleta,
	b.fecha_abono,
	c.nombre_completo,
	d.nombre_completo
) select * from cte_consulta b
where b.valor >= @valor and b.fecha_abono between @fecha_ini and @fecha_fin
order by b.vendedor
go
create proc sp_mostrar_reporte_total_caja
as
declare @total_abonos decimal = (select sum(valor_abono) as total_abonos from tbl_abonos_boleta)
declare @total_gastos decimal = (select sum(valor) as total_gastos from tbl_gastos)
declare @total_comision_pagada decimal = (select sum(valor_abono) as total_pagado from tbl_abonos_boleta where abono_pagado=1)

declare @total_caja decimal = (@total_abonos -(@total_gastos + @total_comision_pagada))

select @total_abonos as abonos, @total_gastos as gastos, @total_comision_pagada as comision, @total_caja as caja 
go
create proc sp_mostrar_caja_por_dia
@fecha1 nchar(10) ='',
@fecha2 nchar(10) =''
as
set dateformat 'dmy'
declare @total_abonos decimal = (select sum(valor_abono) as total_abonos from tbl_abonos_boleta where fecha_abono between @fecha1 and @fecha2)
declare @total_gastos decimal = (select sum(valor) as total_gastos from tbl_gastos where fecha between @fecha1 and @fecha2)
declare @total_comision_pagada decimal = (select sum(valor_abono) as total_pagado from tbl_abonos_boleta where abono_pagado=1 and  fecha_abono between @fecha1 and @fecha2)

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
drop proc sp_reporte_caja
-- actualizaciones
go
alter proc sp_pagar_comision_vendedor
@boleta_id int = 0,
@vendedor_id int = 0,
@cliente_id int = 0,
@abono_id int = 0,
@valor_pagado decimal(10,2) = 0.00
as
begin try
	begin tran

		insert into tbl_pago_comisiones values(@vendedor_id,@cliente_id,@boleta_id,@abono_id,@valor_pagado,getdate())

		update tbl_abonos_boleta set abono_pagado=1
			where id=@abono_id and boleta_id=@boleta_id and vendedor_id=@vendedor_id
	commit
end try
begin catch
	rollback
end catch
go
create proc sp_borrar_pago_comision_vendedor
@boleta_id int = 0,
@vendedor_id int = 0,
@cliente_id int = 0,
@abono_id int = 0
as
begin try
	begin tran

		delete from tbl_pago_comisiones where vendedor_id=@vendedor_id and
		cliente_id=@cliente_id and boleta_id=@boleta_id and abono_id=@abono_id

		update tbl_abonos_boleta set abono_pagado=0
			where id=@abono_id and boleta_id=@boleta_id and vendedor_id=@vendedor_id
	commit
end try
begin catch
	rollback
end catch

go
create view view_pago_comisiones
as
select a.id,a.vendedor_id,b.nombre_completo as vendedor,
a.cliente_id, c.nombre_completo as cliente,
a.boleta_id, d.nro_boleta,a.abono_id,
convert(nchar(10),e.fecha_abono) as fecha_abono,e.valor_abono,a.valor_pagado,
a.fecha_pago_comision as fecha_pago
from  tbl_pago_comisiones a 
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id=d.id
inner join tbl_abonos_boleta e on a.abono_id=e.id
go
create proc rpt_listado_pago_comisiones
@vendedor_id int = 0,
@fecha1 Date = getdate,
@fecha2 Date = getdate
as
select * from view_pago_comisiones 
where vendedor_id=@vendedor_id and (fecha_pago between @fecha1 and @fecha2)
go
alter proc [dbo].[sp_mostrar_todos_abonos]  
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
where a.valor_abono > 0
group by a.id,a.boleta_id,a.nro_boleta,  
a.vendedor_id,b.nombre_completo,  
a.cliente_id,c.nombre_completo,  
a.valor_por_pagar,a.fecha_abono,a.hora_abono,d.valor_boleta,a.valor_comision,a.forma_pago  
go
alter proc sp_reporte_detalle_pago_comisiones_vendedores
@vendedor_id int = 0  
as  
select vendedor, cliente, nro_boleta,valor_pagado, fecha_pago
from view_pago_comisiones  
where vendedor_id=@vendedor_id  
go
--drop proc sp_reporte_detalle_pago_comisiones
--go
--drop proc sp_reporte_pagos
create proc rpt_listado_comisiones_pagadas
@fecha_ini date = null,  
@fecha_fin date = null  
as  
select 
vendedor,cliente,nro_boleta,fecha_abono,valor_abono,valor_pagado,fecha_pago
from view_pago_comisiones  
where fecha_pago between @fecha_ini and @fecha_fin 
go
alter proc sp_mostrar_total_comisiones_pagada  
as  
select sum(valor_pagado) comision  
 from tbl_pago_comisiones   
go
alter proc sp_mostrar_total_comisiones_por_pagada  
as  
select sum(valor_comision) comision  
 from tbl_abonos_boleta   
where abono_pagado=0
go
update tbl_abonos_boleta set abono_pagado=0
go
alter proc sp_mostrar_reporte_total_caja  
as  
declare @total_abonos decimal = (select sum(valor_abono) as total_abonos from tbl_abonos_boleta)  
declare @total_gastos decimal = (select sum(valor) as total_gastos from tbl_gastos)  
declare @total_comision_pagada decimal = (select sum(valor_abono) as total_pagado 
											from tbl_abonos_boleta 
											where abono_pagado=1)  
 


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
set @total_caja  = ((@total_abonos - @total_gastos) - @total_comision_pagada)

select 
	@total_abonos as abonos, 
	@total_gastos as gastos, 
	@total_comision_pagada as comision, 
	@total_caja as caja   
go
