using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Domain
{
    public class N_TiposGastos
    {

        public static List<TiposGastos> mostrarTiposGastos()
        {
            return D_TiposGastos.mostrarTiposGastos();
        }

        public static bool crearTiposGastos(TiposGastos obj)
        {
            return D_TiposGastos.crearTiposGastos(obj);
        }
        public static bool borrar(int id)
        {
            return D_TiposGastos.borrar(id);
        }


    }
}
