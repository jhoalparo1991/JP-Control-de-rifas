create proc sp_reporte_caja
@fecha nchar(10)=''
as
declare @total_abonos decimal(10,2) = ( select sum(valor_abono) from tbl_abonos_boleta where fecha_abono=@fecha)

declare @total_comisiones decimal(10,2) = ( select sum(valor_comision) from tbl_abonos_boleta where fecha_abono=@fecha)

declare @total_gastos decimal(10,2) = ( select sum(valor) from tbl_gastos where fecha=@fecha)

create table #tmp(forma_pago varchar(50),valor decimal(10,2))

insert into #tmp select forma_pago, sum(valor_abono) valor
 from tbl_abonos_boleta where fecha_abono=@fecha
group by forma_pago

declare @total_comision_pagada decimal(10,2) = (select valor_pagado from tbl_pagos_abono_detalle where fecha_pago=@fecha)

select 
	@total_abonos as 'total_abonos', 
	@total_comisiones as 'total_comisiones',
	@total_gastos as 'total_gastos',
	(@total_abonos - (@total_gastos + @total_comision_pagada )) as 'caja',
	@total_comision_pagada as 'total_comision_pagada',
	* from #tmp

drop table #tmp;