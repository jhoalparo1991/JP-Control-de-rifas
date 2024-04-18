using CDatos;
using System;
using System.Data;

namespace CNegocio
{
    public class N_Reportes
    {
        public static void mostrar_formas_de_pago(ref DataSet ds, int rifaId, DateTime fIni, DateTime fFin)
        {
            D_Reportes.mostrar_formas_de_pago(ref ds, rifaId, fIni, fFin);
        }

        public static void mostrarAbonosFecha(ref decimal total, DateTime fechaIni, DateTime fechafin)
        {
            D_Reportes.mostrarAbonosFecha(ref total, fechaIni, fechafin);
        }

        public static void mostrarComisionesPagadaFecha(ref decimal total, DateTime fechaIni, DateTime fechafin)
        {
            D_Reportes.mostrarComisionesPagadaFecha(ref total, fechaIni, fechafin);
        }

        public static DataTable mostrarAbonosPorFormasPago(DateTime fechaIni, DateTime fechafin)
        {
            return D_Reportes.mostrarAbonosPorFormasPago(fechaIni, fechafin);
        }

        public static void mostrarComisionesDeldia(ref decimal total, DateTime fechaIni, DateTime fechafin)
        {
            D_Reportes.mostrarComisionesDeldia(ref total, fechaIni, fechafin);
        }
    }
}
