using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Domain
{
    public class N_Config
    {
        public static bool crearConfig(Config obj)
        {
            return D_Config.crearConfig(obj);
        }

        public static List<Config> mostrarConfig()
        {
            return D_Config.mostrarConfig();
        }

        public static bool crearBackup(string path)
        {
            return Conexion.crearBackup(path);
        }
    }
}
