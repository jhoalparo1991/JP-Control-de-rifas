create proc [dbo].[sp_reporte_detalle_pago_comisiones_vendedores_por_id]
@id int = 0
as
select * from tbl_pagos_abono_detalle
where id=@id


