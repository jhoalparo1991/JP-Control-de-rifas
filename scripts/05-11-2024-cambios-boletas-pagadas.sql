alter proc sp_borrar_abono_boleta  
@boleta_id int = 0,  
@id_abono_boleta int=0,  
@vendedor_id int = 0  
as  
begin try  
begin tran  
declare @contar_pago int = (select count(*) from tbl_info_boleta_pagada   
where boleta_id=@boleta_id and codigo_abono=@id_abono_boleta)  

declare @vendidaPagada int = (select count(id) from tbl_boletas where id=@boleta_id and vendida=1 and pagada=1)


 if @contar_pago > 0  
  begin  
  
   declare @pago_id int = (select pago_id from tbl_info_boleta_pagada   
   where boleta_id=@boleta_id and codigo_abono=@id_abono_boleta)  
   update tbl_pago_abonos set  valor_pagos=(valor_pagos - (select valor_comision from tbl_abonos_boleta where id=@id_abono_boleta and boleta_id=@boleta_id ) )  where id=@pago_id  
   delete from tbl_pagos_abono_detalle where pago_id=@pago_id and vendedor_id=@vendedor_id  
  end  
  
delete from tbl_info_boleta_pagada where boleta_id=@boleta_id and codigo_abono=@id_abono_boleta  
delete from tbl_boleta_abono_pagado where codigo_abono=@id_abono_boleta  
delete from tbl_abonos_boleta  where id=@id_abono_boleta and boleta_id=@boleta_id  
  
declare @nro_abonos int = (select count(*) from tbl_abonos_boleta where boleta_id=@boleta_id)  
  
if @nro_abonos <= 0  
begin  
 update tbl_boletas set vendida=0, pagada=0 where id=@boleta_id  
 delete from tbl_boletas_vendedores where boleta_id=@boleta_id and vendedor_id=@vendedor_id  
end  
  
  if @vendidaPagada > 0
begin
	update tbl_boletas set pagada=0 where id=@boleta_id
end

commit  
end try  
begin catch  
 rollback  
 print error_message()  
end catch  
--select * from tbl_abonos_boleta order by nro_boleta

--select * from tbl_boletas where nro_boleta='0000'