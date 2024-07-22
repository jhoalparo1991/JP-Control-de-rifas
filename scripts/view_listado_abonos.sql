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
create proc sp_pagar_comision_vendedor
@vendedor_id int = 0,
@cliente_id int = 0,
@boleta_id int = 0,
@abono_id int = 0,
@valor_pagado decimal(10,2) = 0.00
as
insert into tbl_pago_comisiones values(@vendedor_id,@cliente_id,@boleta_id,@abono_id,@valor_pagado,getdate())
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
