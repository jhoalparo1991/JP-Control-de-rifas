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
UPDATE [dbo].[tbl_usuarios_permisos] set
      [vendedores] = 1
      ,[clientes] = 1
      ,[rifas] =1
      ,[boletas] =1
      ,[pago_comisiones] = 1
      ,[reportes] = 1
      ,[egresos] = 1
      ,[crear_tipo_egreso] = 1
      ,[borrar_egreso] = 1
      ,[editar_egreso] = 1
      ,[crear_egreso] =1
      ,[imprimir_egreso] = 1
      ,[crear_copia_seguridad] =1
      ,[registrar_abono] = 1
      ,[borrar_abono] = 1
      ,[cambiar_fp_abono] = 1
      ,[cambiar_cliente_abono] = 1
 WHERE usuario_id=1
GO 
create proc sp_mostrar_listado_vendedores_permisos
as
select * from tbl_usuarios a inner join tbl_usuarios_permisos b
on a.id = b.usuario_id
go
alter table tbl_usuarios
drop column is_admin
go
alter table tbl_usuarios
add activo bit default 1
go
update tbl_usuarios set activo=1
go
create table tbl_logs(
	id bigint primary key identity(1,1),
	usuario_id int not null,
	terminal varchar(50) not null,
	fecha date not null,
	hora time not null,
	accion varchar(100) not null
)
go
create proc sp_guardar_log
@usuario_id int = 0,
@terminal varchar(50)='',
@accion varchar(100)=''
as
insert into tbl_logs values(@usuario_id,@terminal,getdate(),getdate(),@accion)
go
create proc sp_mostrar_log
@buscar varchar(30)=''
as
select a.id,b.nombre_completo,a.terminal,a.fecha,a.hora,a.accion
from tbl_logs a left join tbl_usuarios b on a.usuario_id=b.id
where b.nombre_completo+a.accion like '%'+@buscar+'%'
go