using CDatos;
using CEntidades;
using System.Collections.Generic;

namespace CNegocio
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
    }
}
