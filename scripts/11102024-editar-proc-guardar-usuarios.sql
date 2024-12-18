USE [db_rifas]
GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_usuarios]    Script Date: 11/10/2024 11:33:19 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ALTER proc [dbo].[sp_guardar_usuarios]
@id int = 0,
@nombre_completo varchar(100) = '',
@nro_doc varchar(20) = '',
@direccion varchar(50) = '',
@celular varchar(20) = '',
@telefono varchar(20) = '',
@clave varchar(500) = '',
@comision decimal(10,2) = 0.00,
@activo bit = 0,
-- permisos
@vendedores bit = 0,
@clientes bit = 0,
@rifas bit = 0,
@boletas bit = 0,
@pago_comisiones bit = 0,
@reportes bit = 0,
@egresos bit = 0,
@crear_tipo_egreso bit = 0,
@borrar_egreso bit = 0,
@editar_egreso bit = 0,
@crear_egreso bit = 0,
@imprimir_egreso bit = 0,
@crear_copia_seguridad bit = 0,
@registrar_abono bit = 0,
@borrar_abono bit = 0,
@cambiar_fp_abono bit = 0,
@cambiar_cliente_abono bit = 0,
-- permisos-adicionales
@crear_vendedores bit=0,
@editar_vendedores bit=0,
@borrar_vendedores bit=0,
@asignar_boletas_vendedores bit=0,
@ver_log bit = 0,
@ver_boleta bit = 0
as
begin try
	begin tran
		if @id <= 0
			begin

				if exists(select * from tbl_usuarios where nro_doc=@nro_doc)
				raiserror('Ya existe un usuario un usuario con este número de documento',16,1)
				else
				declare @usuarioId int
				insert into tbl_usuarios values(@nombre_completo,
												@nro_doc,
												@direccion,
												@celular,
												@telefono,
												@clave,
												@comision,
												@activo)

				set @usuarioId = @@IDENTITY

				insert into tbl_usuarios_permisos values(@usuarioId,@vendedores,@clientes,@rifas,@boletas,@pago_comisiones,
					@reportes,@egresos,@crear_tipo_egreso,@borrar_egreso,@editar_egreso,						@crear_egreso,@imprimir_egreso,@crear_copia_seguridad,@registrar_abono,
					@borrar_abono,@cambiar_fp_abono,@cambiar_cliente_abono,@crear_vendedores,
					@editar_vendedores,@borrar_vendedores,@asignar_boletas_vendedores,@ver_log,@ver_boleta)

			end
			else
			begin
				if exists(select * from tbl_usuarios where nro_doc=@nro_doc and id<>@id)
				raiserror('Ya existe un usuario un usuario con este número de documento',16,1)
				else
				update tbl_usuarios set 		nombre_completo=@nombre_completo,
												nro_doc=@nro_doc,
												direccion=@direccion,
												telefono=@telefono,
												comision=@comision,
												activo=@activo,
												clave=@clave
												where id=@id

				update tbl_usuarios_permisos set vendedores=@vendedores,
												clientes=@clientes,
												rifas=@rifas,
												boletas=@boletas,
												pago_comisiones=@pago_comisiones,
												reportes=@reportes,
												egresos=@egresos,
												crear_tipo_egreso=@crear_tipo_egreso,
												borrar_egreso=@borrar_egreso,
												editar_egreso=@editar_egreso,
												crear_egreso=@crear_egreso,
												imprimir_egreso=@imprimir_egreso,
												crear_copia_seguridad=@crear_copia_seguridad,
												registrar_abono=@registrar_abono,
												borrar_abono=@borrar_abono,
												cambiar_fp_abono=@cambiar_fp_abono,
												cambiar_cliente_abono=@cambiar_cliente_abono,
												crear_vendedores=@crear_vendedores,
												editar_vendedores=@editar_vendedores,
												borrar_vendedores=@borrar_vendedores,
												asignar_boletas_vendedores=@asignar_boletas_vendedores,
												ver_log=@ver_log,
												ver_boleta=@ver_boleta
												where usuario_id=@id
			end
	commit
end try
begin catch
	rollback
	print error_message()
end catch


