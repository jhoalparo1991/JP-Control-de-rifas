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
    }
}
