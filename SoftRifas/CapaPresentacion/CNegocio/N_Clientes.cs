using CDatos;
using CEntidades;
using System.Collections.Generic;

namespace CNegocio
{
    public class N_Clientes
    {

        public static List<Clientes> mostrarClientes()
        {
            return D_Clientes.mostrarClientes();
        }
    
        public static bool guardar(Clientes obj)
        {
            return D_Clientes.guardar(obj);
        }
        public static bool borrar(int clienteId)
        {
            return D_Clientes.borrar(clienteId);
        }
    }
}
