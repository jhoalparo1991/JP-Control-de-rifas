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
