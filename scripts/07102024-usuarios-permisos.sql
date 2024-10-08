create table tbl_usuarios_permisos
(
	id int primary key identity(1,1),
	usuario_id int not null unique,
	vendedores bit not null,
	clientes bit not null,
	rifas bit not null,
	boletas bit not null,
	pago_comisiones bit not null,
	reportes bit not null,
	egresos bit not null,
	crear_tipo_egreso bit not null,
	borrar_egreso bit not null,
	editar_egreso bit not null,
	crear_egreso bit not null,
	imprimir_egreso bit not null,
	crear_copia_seguridad bit not null,
	registrar_abono bit not null,
	borrar_abono bit not null,
	cambiar_fp_abono bit not null,
	cambiar_cliente_abono bit not null,
)
go
insert into tbl_usuarios_permisos select id,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 from tbl_usuarios
go
create proc sp_mostrar_listado_vendedores_permisos
as
select * from tbl_usuarios a inner join tbl_usuarios_permisos b
on a.id = b.usuario_id