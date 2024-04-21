use db_rifas
go
create table tbl_tipos_gastos
(
	id int primary key identity(1,1),
	codigo nchar(10) not null unique,
	descripcion varchar(50) not null
)
go
create table tbl_gastos(
	id int primary key identity(1,1),
	tipo_gasto_id int not null,
	usuario_id int not null,
	referencia varchar(50) null,
	descripcion varchar(255) not null,
	valor decimal(18,2) not null,
	fecha date not null
)
go
create proc sp_guardar_tipos_gastos
@id int = 0,
@codigo nchar(10) ='',
@descripcion varchar(50) =''
as
if @id <= 0
begin
	if exists (select * from tbl_tipos_gastos where codigo=@codigo)
	raiserror('Ya existe un tipo de gasto con el mismo codigo',16,1)
	else
	insert into tbl_tipos_gastos values(@codigo,@descripcion)
end
else
begin
	if exists (select * from tbl_tipos_gastos where codigo=@codigo and id<>@id)
	raiserror('Ya existe un tipo de gasto con el mismo codigo',16,1)
	else
	update tbl_tipos_gastos set codigo=@codigo,descripcion=@descripcion where id=@id
end
go
create proc sp_guardar_gastos
@id int = 0,
@tipo_gasto_id int = 0,
@usuario_id int = 0,
@referencia varchar(50) ='',
@descripcion varchar(255) ='',
@valor decimal(18,2) = 0.00,
@fecha date = null
as
if @id <= 0
begin
	insert into tbl_gastos values(@tipo_gasto_id,@usuario_id,@referencia,@descripcion,
								  @valor,@fecha)
end
else
begin
	update tbl_gastos set tipo_gasto_id=@tipo_gasto_id,referencia=@referencia,
						  descripcion=@descripcion, valor=@valor, fecha=@fecha
						  where id=@id
end
go
create proc sp_mostrar_gastos
as
begin
	select 
		a.id,
		a.tipo_gasto_id,
		a.usuario_id,
		b.codigo,
		b.descripcion tipo_gasto,
		a.referencia,
		a.descripcion,
		a.valor,
		a.fecha
	from tbl_gastos a inner join tbl_tipos_gastos b
	on a.tipo_gasto_id = b.id
end
go