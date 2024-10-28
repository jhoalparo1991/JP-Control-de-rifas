using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Domain
{
    public class N_Pagos
    {

        public static List<Pagos> mostrarPagos()
        {
            return D_Pagos.mostrarPagos();
        }
        public static bool registrarPagos(Pagos obj, DataTable detalle)
        {
            return D_Pagos.registrarPagos(obj, detalle);
        }
        public static List<DtoMostrarDetallePagos> mostrarDetallePagos()
        {
            return D_Pagos.mostrarDetallePagos();
        }
        public static bool borrarPagos(int id, int abonoId, int vendedorId, int boletaId, int pagoId, decimal valor, int idInfoBoletaPagada)
        {
            return D_Pagos.borrarPagos(id, abonoId, vendedorId, boletaId, pagoId, valor, idInfoBoletaPagada);
        }

        public static DataTable mostrarDetallePagado(int idDetalle, int vendedorId)
        {
            return D_Pagos.mostrarDetallePagado(idDetalle, vendedorId);
        }

        public static bool borrarPagosTemporalesPorTerminal()
        {
            return D_Pagos.borrarPagosTemporalesPorTerminal();
        }

        #region Pago comision vendedores
        public static bool sp_pagar_comision_vendedor(int vendedorId, int clienteId, int boletaId, int abonoId, decimal valorPagado)
        {
            return D_Pagos.sp_pagar_comision_vendedor(vendedorId, clienteId, boletaId, abonoId, valorPagado);
        }

        public static bool borrar_pago_comision_vendedor(int vendedorId, int clienteId, int boletaId, int abonoId)
        {
            return D_Pagos.borrar_pago_comision_vendedor(vendedorId, clienteId, boletaId, abonoId);
        }

        public static DataTable mostrarPagoComisionPorVendedor(int vendedorId, DateTime fecha1, DateTime fecha2)
        {
            return D_Pagos.mostrarPagoComisionPorVendedor(vendedorId, fecha1, fecha2);
        }

        public static bool sp_pagar_comision_vendedor_por_fecha(int vendedorId, DateTime fecha1, DateTime fecha2)
        {
            return D_Pagos.sp_pagar_comision_vendedor_por_fecha(vendedorId, fecha1, fecha2);
        }
        #endregion

    }
}
