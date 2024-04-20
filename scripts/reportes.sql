create proc sp_reporte_pagos
@fecha_ini date = null,
@fecha_fin date = null
as
select * from tbl_pago_abonos
where fecha_pago between @fecha_ini and @fecha_fin
go
create proc sp_reporte_detalle_pago_comisiones
@fecha_ini date = null,
@fecha_fin date = null
as
select * from tbl_pagos_abono_detalle
where fecha_pago between @fecha_ini and @fecha_fin
go
create proc sp_reporte_detalle_pago_comisiones_vendedores
@vendedor_id int = 0
as
select * from tbl_pagos_abono_detalle
where vendedor_id=@vendedor_id
go
create proc sp_mostrar_abonos_por_boleta
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
go
create proc sp_mostrar_boletas_vendida_por_vendedores
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
go
ALTER proc [dbo].[sp_reporte_detalle_pago_comisiones]
@fecha_ini date = null,
@fecha_fin date = null
as
select * from tbl_pagos_abono_detalle
where fecha_pago between @fecha_ini and @fecha_fin
order by nombre_vendedor 
go