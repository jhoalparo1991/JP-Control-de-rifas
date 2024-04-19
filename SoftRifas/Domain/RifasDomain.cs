using DataAccess;
using System.Collections.Generic;

namespace Domain
{
    public class RifasDomain
    {

        public static List<Rifas> mostrarRifas()
        {
            return Rifas.mostrarRifas();
        }
    
        public static bool crearRifas(Rifas obj)
        {
            return Rifas.crearRifas(obj);
        }
        public static bool borrar(int clienteId)
        {
            return Rifas.borrar(clienteId);
        }
       
    }
}
