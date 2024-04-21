alter table tbl_config add ruta_copia_seguridad varchar(max)
alter table tbl_config drop column nro_botones
alter table tbl_config drop column nro_registros_por_pagina
alter table tbl_config drop column color

go
create proc sp_editar_forma_pago_boleta
@abono_boleta_id int = 0,
@forma_pago varchar(50) = ''
as
begin
	update tbl_abonos_boleta set forma_pago=@forma_pago
	where id=@abono_boleta_id
end
go
create proc sp_cambiar_cliente_boleta
@cliente_id int = 0,
@boleta_id int = 0
as
begin
	declare @nro_boleta varchar(50) = (select nro_boleta from tbl_boletas where id=@boleta_id)
	update tbl_abonos_boleta set
	cliente_id=@cliente_id
	where @boleta_id=@boleta_id  and nro_boleta=@nro_boleta
end
go
create proc sp_mostrar_abonos_comisiones_por_vendedores
@vendedor_id int = 0,
@fecha_ini date = null,
@fecha_fin date = null
as
select a.id,a.boleta_id,a.nro_boleta,
a.vendedor_id,b.nombre_completo vendedor,
b.nro_doc cc_ve,
a.cliente_id,c.nombre_completo cliente,
c.nro_doc cc_cl,
a.valor_abono,
a.valor_comision,
convert(nchar(10),a.fecha_abono,5) fecha_abono,
convert(nchar(10),a.hora_abono,108) hora_abono,
a.forma_pago,
case 
	when a.abono_pagado=0 then 'Sin Pagar'
	when a.abono_pagado=1 then 'Pagada'
	end as 'ComisionPagada'
 from tbl_abonos_boleta a
inner join tbl_usuarios b on a.vendedor_id=b.id
inner join tbl_clientes c on a.cliente_id=c.id
inner join tbl_boletas d on a.boleta_id =d.id
where a.vendedor_id=@vendedor_id and
a.fecha_abono between @fecha_ini and @fecha_fin
go
alter proc [dbo].[sp_guardar_config]
@id int = 0,
@ruta_copia_seguridad varchar(max) = ''
as
if @id <= 0
begin
	insert into tbl_config values(@ruta_copia_seguridad) 
end
else
begin
	update tbl_config set ruta_copia_seguridad=@ruta_copia_seguridad
						  where id=@id
end

go