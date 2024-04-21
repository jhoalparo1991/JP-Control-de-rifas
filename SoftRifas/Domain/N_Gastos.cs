using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Domain
{
    public class N_Gastos
    {

        public static List<DtoMostarGastos> mostrarGastos()
        {
            return D_Gastos.mostrarGastos();
        }

        public static bool crearGastos(Gastos obj)
        {
            return D_Gastos.crearGastos(obj);
        }
        public static bool borrar(int id)
        {
            return D_Gastos.borrar(id);
        }


    }
}
