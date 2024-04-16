create proc sp_crear_rifa
@id int = 0,
@usuario_id int =0,
@descripcion varchar(255)='',
@fecha_inicio date = null,
@fecha_final date = null,
@nro_inicial int = 0,
@nro_final int = 0,
@activa bit = 0,
@valor_rifa decimal(18,2) = 0.00
as
begin try
begin tran
if @id <= 0
begin
declare @id_rifa int

insert into tbl_rifas values(
	@usuario_id,
	@descripcion,
	@fecha_inicio,
	@fecha_final,
	@nro_inicial,
	@nro_final,
	@activa,
	@valor_rifa
)
set @id_rifa = @@IDENTITY
declare @total_boletas int = (@nro_final - @nro_inicial);
declare @contador int = 1
while @contador <= @total_boletas
begin
	insert into tbl_boletas values(@id_rifa,format((@nro_inicial+@contador),'00000'),@valor_rifa,0)
	set @contador = @contador +1 
end

end
else
begin
update tbl_rifas set
	descripcion=@descripcion,
	fecha_inicio=@fecha_inicio,
	fecha_final=@fecha_final,
	nro_inicial=@nro_inicial,
	nro_final=@nro_final,
	activa=@activa,
	valor_rifa=@valor_rifa
where id =@id
end
commit
end try
begin catch
	rollback
	print error_message()
end catch