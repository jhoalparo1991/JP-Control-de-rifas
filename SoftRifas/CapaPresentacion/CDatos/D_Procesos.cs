
using CEntidades;

namespace CDatos
{
    public class D_Procesos
    {
        public static bool getConnectionTest(ProcesoConexion conexion)
        {
            return Conexion.getConnectionTest(conexion);
        }
    }
}
