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