select * from tbl_pago_abonos;
select * from tbl_pagos_abono_detalle
select * from tbl_abonos_boleta;
select * from tbl_boleta_abono_pagado;
go
ALTER proc [dbo].[sp_registrar_pagos]
@usuario_id int =0,
@identificador varchar(50)='',
@fecha_pago date = null,
@hora_pago time = null,
@periodo_pagado varchar(50) = '',
@valor_pagos decimal(18,2) = 0.00,
@descripcion varchar(255) = '',
@terminal varchar(50) = '',
@detalles ty_pagos_abono_detalle readonly
as
begin try
begin tran
	declare @pago_id int
	insert into tbl_pago_abonos values (@usuario_id,@identificador,@fecha_pago,@periodo_pagado,@hora_pago,@valor_pagos,@descripcion)

	set @pago_id = SCOPE_IDENTITY()

	insert into tbl_pagos_abono_detalle select @pago_id,x.vendedor_id,x.nombre_vendedor,x.valor_pagado,getdate(),x.forma_pago,x.periodo_pagado,1 from @detalles x

	update a set a.abono_pagado=1 from tbl_abonos_boleta a inner join tbl_tmp_pago_abono b on a.id=b.codigo_abono

	insert into tbl_boleta_abono_pagado select x.codigo_abono, x.boleta_id,x.vendedor_id,x.pagado,@fecha_pago from tbl_tmp_pago_abono x where x.codigo=@identificador
	
	insert into tbl_info_boleta_pagada select x.boleta_id,@pago_id,x.codigo_abono,x.vendedor_id,x.pagado,@fecha_pago from tbl_tmp_pago_abono x where x.codigo=@identificador


	delete from tbl_tmp_pago_abono where terminal=@terminal

commit
end try
begin catch
	rollback
	print error_message()
end catch
go

create table tbl_info_boleta_pagada
(
	id int primary key identity(1,1),
	boleta_id int not null,
	pago_id int not null,
	codigo_abono int not null,
	vendedor_id int not null,
	pagado bit not null,
	fecha date not null,
)
go

create proc sp_mostrar_detalle_pagado
@id int = 0
as
select 
		f.id detalle_pago_id,a.id,a.boleta_id,a.pago_id,a.codigo_abono,a.vendedor_id,a.pagado,
		e.nombre_completo vendedor,a.fecha,
		b.nro_boleta,d.valor_comision from tbl_info_boleta_pagada a
		inner join tbl_boletas b on a.boleta_id=b.id
		inner join tbl_pago_abonos c on a.pago_id = c.id
		inner join tbl_abonos_boleta d on a.codigo_abono=d.id
		inner join tbl_usuarios e on a.vendedor_id = e.id
		inner join tbl_pagos_abono_detalle f on c.id=f.pago_id
		where f.id=@id
go
ALTER proc [dbo].[sp_borrar_pago_comision]
@id int = 0,
@abono_id int = 0,
@vendedor_id int = 0,
@boleta_id int = 0,
@pago_id int = 0,
@valor decimal(10,2) = 0.00,
@idInfoBoletaPagada int = 0
as
begin try
	begin tran
		
		update tbl_abonos_boleta set abono_pagado=0 where id=@abono_id
		update tbl_boleta_abono_pagado set pagado=0 where codigo_abono=@abono_id and vendedor_id=@vendedor_id and boleta_id=@boleta_id
		delete from tbl_boleta_abono_pagado where codigo_abono=@abono_id and vendedor_id=@vendedor_id and boleta_id=@boleta_id		
		update tbl_pago_abonos set valor_pagos = (valor_pagos - @valor) where id=@pago_id
		update tbl_pagos_abono_detalle set valor_pagado = (valor_pagado - @valor) where id=@id
		delete from tbl_info_boleta_pagada where id = @idInfoBoletaPagada
	commit
end try
begin catch
	rollback
	print error_message()
end catch
go




