create proc sp_reporte_caja-- '04-20-2024'
@fecha date
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
	case when @total_abonos is null then 0 else @total_abonos end as 'total_abonos', 
	case when @total_comisiones is null then 0 else @total_comisiones end as 'total_comisiones',
	case when @total_comision_pagada is null then 0 else @total_comision_pagada end as 'total_comision_pagada',
	case when @total_gastos is null then 0 else @total_gastos end as 'total_gastos',
	case when (@total_abonos - (@total_gastos + @total_comision_pagada )) is null then 0 else 
	(@total_abonos - (@total_gastos + @total_comision_pagada )) end as 'caja'	
	,* from #tmp

drop table #tmp;