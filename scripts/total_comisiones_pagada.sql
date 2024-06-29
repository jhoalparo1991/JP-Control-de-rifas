create proc sp_mostrar_total_comisiones_pagada
as
select sum(valor_comision) comision
 from tbl_abonos_boleta 
where abono_pagado=1
and valor_comision > 0
go

create proc sp_mostrar_total_comisiones_por_pagada
as
select sum(valor_comision) comision
 from tbl_abonos_boleta 
where abono_pagado=0
and valor_comision > 0
go

