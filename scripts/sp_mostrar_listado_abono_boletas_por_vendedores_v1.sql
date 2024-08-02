alter proc sp_mostrar_abonos_boleta_por_vendedor  
@vendedor_id int = 0,
@fecha_ini date,
@fecha_fin date
as  
select id,cliente_id,cliente,fecha_abono,boleta_id,nro_boleta,valor_abono,valor_comision,abono_pagado 
from v_listado_abonos where vendedor_id=@vendedor_id  
and fecha_abono between @fecha_ini and @fecha_fin
and valor_comision>0 order by abono_pagado desc
go

alter proc sp_pagar_comision_vendedor_por_fecha  
@vendedor_id int = 0,  
@fecha_ini date,
@fecha_fin date
as  
begin try  
 begin tran  

create table #tmp (
	vendedor_id int,
	cliente_id int,
	boleta_id int,
	abono_id int,
	valor_pagado decimal(10,2),
	fecha_pago_comision date
)

insert into #tmp  select x.vendedor_id,x.cliente_id,x.boleta_id,
x.id,x.valor_comision,getdate() from v_listado_abonos x where x.vendedor_id=@vendedor_id  
and x.fecha_abono between @fecha_ini and @fecha_fin
and x.abono_pagado='No'

insert into tbl_pago_comisiones select vendedor_id,cliente_id,boleta_id,abono_id,valor_pagado,fecha_pago_comision from #tmp

update a set a.abono_pagado=1 from tbl_abonos_boleta a
inner join #tmp b on a.id=b.abono_id and a.vendedor_id=b.vendedor_id

drop table #tmp
 
 commit  
end try  
begin catch  
 rollback 
 print error_message()
end catch
go