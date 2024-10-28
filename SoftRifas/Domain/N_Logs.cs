using DataAccess;
using System.Data;

namespace Domain
{
    public class N_Logs
    {
        public static void mostrarLog(DataTable dt, string buscar)
        {
            D_Logs.mostrarLog(dt, buscar);
        }
        public static bool guardarLog(int usuarioId, string accion)
        {
            return D_Logs.guardarLog(usuarioId, accion);
        }
    }
}
