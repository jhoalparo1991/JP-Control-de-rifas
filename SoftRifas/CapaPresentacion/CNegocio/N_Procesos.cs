
using CDatos;
using CEntidades;

namespace CapaNegocio
{
    public class N_Procesos
    {
        public static bool getConnectionTest(ProcesoConexion conexion)
        {
            return D_Procesos.getConnectionTest(conexion);
        }
     
    }
}
