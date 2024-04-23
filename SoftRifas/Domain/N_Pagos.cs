using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Data;

namespace Domain
{
    public class N_Pagos
    {

        public static List<Pagos> mostrarPagos()
        {
            return D_Pagos.mostrarPagos();
        }
        public static bool registrarPagos(Pagos obj,DataTable detalle)
        {
            return D_Pagos.registrarPagos(obj,detalle);
        }
        public static List<DtoMostrarDetallePagos> mostrarDetallePagos()
        {
            return D_Pagos.mostrarDetallePagos();
        }
        public static bool borrarPagos(int id, int abonoId, int vendedorId, int boletaId, int pagoId, decimal valor, int idInfoBoletaPagada)
        {
            return D_Pagos.borrarPagos(id, abonoId,vendedorId,boletaId,pagoId,valor, idInfoBoletaPagada);
        }

        public static DataTable mostrarDetallePagado(int idDetalle, int vendedorId)
        {
            return D_Pagos.mostrarDetallePagado(idDetalle,vendedorId);
        }

    }
}
