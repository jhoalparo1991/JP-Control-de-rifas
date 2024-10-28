using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Domain
{
    public class N_Rifas
    {

        public static List<Rifas> mostrarRifas()
        {
            return D_Rifas.mostrarRifas();
        }

        public static bool crearRifas(Rifas obj)
        {
            return D_Rifas.crearRifas(obj);
        }
        public static bool borrar(int clienteId)
        {
            return D_Rifas.borrar(clienteId);
        }

    }
}
