create proc sp_mostrar_todos_abonos_por_formas_pago
@forma_pago varchar(50) = '',
@fecha1 date = null,
@fecha2 date = null
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
where a.forma_pago=@forma_pago and a.fecha_abono between @fecha1 and @fecha2
and a.valor_abono > 0
group by a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo,
a.cliente_id,c.nombre_completo,
a.valor_por_pagar,a.fecha_abono,a.hora_abono,d.valor_boleta,a.valor_comision,a.forma_pago

