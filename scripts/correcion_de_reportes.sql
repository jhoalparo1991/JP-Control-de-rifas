use db_rifas
go
create proc [dbo].[sp_reporte_detalle_pago_comisiones_vendedores_por_id]
@id int = 0
as
select * from tbl_pagos_abono_detalle
where id=@id

go
alter proc sp_mostrar_detalle_pagado
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
go
--sp_reporte_caja '04-23-2024'
go
alter proc sp_reporte_caja
@fecha date
as
declare @total_abonos decimal(10,2) = ( select sum(valor_abono) from tbl_abonos_boleta where fecha_abono=@fecha)

declare @total_comisiones decimal(10,2) = ( select sum(valor_comision) from tbl_abonos_boleta where fecha_abono=@fecha)

--declare @total_gastos decimal(10,2) = ( select sum(valor) from tbl_gastos where fecha=@fecha)

create table #tmp(forma_pago varchar(50),valor decimal(10,2))

insert into #tmp select forma_pago, sum(valor_abono) valor
 from tbl_abonos_boleta where fecha_abono=@fecha and valor_abono > 0
group by forma_pago

declare @total_comision_pagada decimal(10,2) = (select sum(valor_pagado) total_comision_pagada from tbl_pagos_abono_detalle where fecha_pago=@fecha)

select 
	case when @total_abonos is null then 0 else @total_abonos end as 'total_abonos', 
	case when @total_comisiones is null then 0 else @total_comisiones end as 'total_comisiones',
	case when @total_comision_pagada is null then 0 else @total_comision_pagada end as 'total_comision_pagada',
	* from #tmp
drop table #tmp;
go
create proc sp_borrar_pagos_temporales
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