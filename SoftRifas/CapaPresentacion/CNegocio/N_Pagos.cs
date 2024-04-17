using CapaPresentacion.CEntidades;
using CDatos;
using System.Collections.Generic;
using System.Data;

namespace CNegocio
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


    }
}
