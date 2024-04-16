use master
go
drop database db_rifas
go
create database db_rifas
go
use db_rifas
go
create table tbl_usuarios(
	id int primary key identity(1,1),
	nombre_completo varchar(100) not null,
	nro_doc varchar(20) not null unique,
	direccion varchar(50) null,
	celular varchar(20) null,
	telefono varchar(20) null,
	clave text not null,
	comision decimal(10,2) not null,
	is_admin bit not null,
)
go
create table tbl_clientes(
	id int primary key identity(1,1),
	nombre_completo varchar(100) not null,
	nro_doc varchar(20) not null unique,
	direccion varchar(50) null,
	celular varchar(20) null,
	telefono varchar(20) null,
)
go
create table tbl_rifas(
	id int primary key identity(1,1),
	usuario_id int not null,
	nombre varchar(50) not null,
	descripcion varchar(255) null,
	fecha_inicio date not null,
	fecha_final date not null,
	nro_inicial int not null,
	nro_final int not null,
	activa bit not null,
	valor_rifa decimal(18,2) not null,
	constraint ck_nro_inicial_nro_final check(nro_inicial <= nro_final),
	constraint ck_fecha_inicial_fecha_final check(fecha_inicio <= fecha_final)
)
go
create table tbl_boletas(
	id int primary key identity(1,1),
	rifa_id int not null,
	nro_boleta varchar(50) not null,
	valor_boleta decimal(18,2) not null
)
go
create table tbl_facturar_boleta
(
	id int primary key identity(1,1),
	vendedor_id int not null,
	cliente_id int not null,
	boleta_id int not null,
	nro_boleta varchar(50) not null,
	fecha_venta date not null,
	hora_venta time not null,	
)
go
create table tbl_abonos_boleta
(
	id int primary key identity(1,1),
	usuario_id int not null,
	vendedor_id int not null,
	boleta_id int not null,
	nro_boleta varchar(50) not null,
	valor_por_pagar decimal(18,2) not null,
	valor_abono decimal(18,2) not null,	
	valor_comision decimal(18,2) not null,	
	fecha_abono date,
	hora_abono time,
	participa_sorteo bit,
	constraint ck_validar_pago check (valor_abono <= valor_por_pagar)
)















go
-- Constraint
alter table tbl_abonos_boleta
add constraint fk_abonos_boleta_usuario
foreign key (usuario_id) references tbl_usuarios(id)
on update cascade on delete no action
go

alter table tbl_abonos_boleta
add constraint fk_abonos_boleta_vendedor
foreign key (vendedor_id) references tbl_usuarios(id)
on update cascade on delete no action
go

alter table tbl_abonos_boleta
add constraint fk_abonos_boleta_boleta
foreign key (boleta_id) references tbl_boletas(id)
on update cascade on delete no action
go

alter table tbl_boletas
add constraint fk_boleta_rifa
foreign key (rifa_id) references tbl_rifas(id)
on update cascade on delete no action
go

alter table tbl_facturar_boleta
add constraint fk_facturar_boleta_vendedor
foreign key (vendedor_id) references tbl_usuarios(id)
on update cascade on delete no action
go

alter table tbl_facturar_boleta
add constraint fk_facturar_boleta_cliente
foreign key (cliente_id) references tbl_clientes(id)
on update cascade on delete no action
go

alter table tbl_rifas
add constraint fk_rifas_usuarios
foreign key (usuario_id) references tbl_usuarios(id)
on update cascade on delete no action
go