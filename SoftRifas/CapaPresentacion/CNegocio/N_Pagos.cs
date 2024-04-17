using CapaPresentacion.CEntidades;
using CDatos;
using System.Data;

namespace CNegocio
{
    public class N_Pagos
    {
    
        public static bool registrarPagos(Pagos obj,DataTable detalle)
        {
            return D_Pagos.registrarPagos(obj,detalle);
        }
       
       
    }
}
