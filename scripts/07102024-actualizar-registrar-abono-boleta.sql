alter proc [dbo].[sp_registrar_abono_boleta]  
@id int =0,  
@usuario_id int = 0,  
@boleta_id int = 0,  
@nro_boleta varchar(50) = '',  
@valor_por_pagar decimal(18,2) = 0.00,  
@valor_abono decimal(18,2) = 0.00,
@v_comision decimal(18,2) = 0.00,  
@forma_pago varchar(50) = '',  
@nombre_ve varchar(100) = '',  
@cc_ve varchar(20) = '',  
@nombre_cl varchar(100) = '',  
@cc_cl varchar(20) = ''  
as  
begin try  
 begin tran  
 if @id <= 0  
 begin  
    
  declare @existe_ve int =(select count(*) from tbl_usuarios where nro_doc=@cc_ve)  
  if(@existe_ve <= 0)  
  begin  
   insert into tbl_usuarios values(@nombre_ve,@cc_ve,'','','','',30,0)  
  end  
  
  declare @existe_cl int =(select count(*) from tbl_clientes where nro_doc=@cc_cl)  
  if(@existe_cl <= 0)  
  begin  
   insert into tbl_clientes values(@nombre_cl,@cc_cl,'','','')  
  end  

  declare @vendedor_id int = (select id from tbl_usuarios where nro_doc=@cc_ve)  
  declare @cliente_id int = (select id from tbl_clientes where nro_doc=@cc_cl)  
    
  declare @vendedor_boleta_id int = (select vendedor_id from tbl_boletas where id=@boleta_id)  
  if(@vendedor_boleta_id <= 0)  
  begin  
   update tbl_boletas set vendedor_id=@vendedor_id where id=@boleta_id  
   insert into tbl_boletas_vendedores values(@vendedor_id,@boleta_id,@nro_boleta)  
  end  
  
	declare @valor_comision decimal(18,2) = 0.00
	declare @porcentaje_comision decimal(10,2) = (select comision from tbl_usuarios where id=@vendedor_id)
	set @valor_comision=((@valor_abono *  @porcentaje_comision) /100)


  insert into tbl_abonos_boleta values(@usuario_id,@vendedor_id,@cliente_id,@boleta_id,@nro_boleta,@valor_por_pagar,@valor_abono,@valor_comision,getdate(),getdate(),@forma_pago,0,@porcentaje_comision)  
 update tbl_boletas set vendida=1 where id=@boleta_id and vendida=0  
 if @valor_abono = @valor_por_pagar  
 begin  
  update tbl_boletas set pagada=1 where id=@boleta_id  
 end  
 end  
 else  
 begin  
  update tbl_abonos_boleta set usuario_id=@usuario_id,valor_por_pagar=@valor_por_pagar,valor_abono=@valor_abono,valor_comision=@valor_comision,fecha_abono=getdate(),hora_abono=getdate(),forma_pago=@forma_pago  
   where id=@id  
  if @valor_abono = @valor_por_pagar  
   begin  
    update tbl_boletas set pagada=1 where id=@boleta_id  
   end  
 end  
  
 commit  
end try  
begin catch  
 rollback  
 print error_message()  
end catch  
  
  