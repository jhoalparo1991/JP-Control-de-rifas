-- Agregar campo del porcentaje de la comision a la tabla
alter table tbl_abonos_boleta
add porcentaje_comision decimal(10,2)
go
-- actualiza los porcentajes de comisiones en la tabla de abonos boletas
update a
set a.porcentaje_comision=b.comision
from tbl_abonos_boleta  a
inner join tbl_usuarios b on a.vendedor_id=b.id
go
-- actualizar los comisiones
update a
set a.valor_comision=((a.valor_abono * b.comision) / 100)
from tbl_abonos_boleta  a
inner join tbl_usuarios b on a.vendedor_id=b.id where comision <= 8
go