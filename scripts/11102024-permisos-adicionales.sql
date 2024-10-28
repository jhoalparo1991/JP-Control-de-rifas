use db_rifas
go

alter table tbl_usuarios_permisos
add crear_vendedores bit default 0
go

alter table tbl_usuarios_permisos
add editar_vendedores bit default 0
go

alter table tbl_usuarios_permisos
add borrar_vendedores bit default 0
go

alter table tbl_usuarios_permisos
add asignar_boletas_vendedores bit default 0
go

alter table tbl_usuarios_permisos
add ver_log bit default 0
go

-- permiso faltante por ejecutar
alter table tbl_usuarios_permisos
add ver_boleta bit default 0
go
update tbl_usuarios_permisos set
	ver_boleta=0
go
update tbl_usuarios_permisos set
	ver_boleta=1 where usuario_id=1
go
select * from tbl_usuarios_permisos order by usuario_id
-- fin permiso faltante
update tbl_usuarios_permisos set
	crear_vendedores=0,
	editar_vendedores=0,
	borrar_vendedores=0,
	asignar_boletas_vendedores=0,
	ver_log=0
go
create proc sp_mostrar_total_abonos_cliente
as
select 
	b.nombre_completo,
	a.nro_boleta,
	sum(a.valor_abono) total_abonado
from tbl_abonos_boleta a
inner join tbl_clientes b on  a.cliente_id=b.id
group by b.nombre_completo,
	a.nro_boleta
order by b.nombre_completo
go

