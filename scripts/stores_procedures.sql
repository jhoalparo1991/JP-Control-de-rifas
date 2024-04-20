create proc sp_editar_forma_pago_boleta
@abono_boleta_id int = 0,
@forma_pago varchar(50) = ''
as
begin
	update tbl_abonos_boleta set forma_pago=@forma_pago
	where id=@abono_boleta_id
end
