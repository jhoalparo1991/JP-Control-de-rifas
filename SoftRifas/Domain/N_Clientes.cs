using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Data;

namespace Domain
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

        public static DataTable mostrarBoletasClientes(int clienteId)
        {
            return D_Clientes.mostrarBoletasClientes(clienteId);
        }
    }
}
