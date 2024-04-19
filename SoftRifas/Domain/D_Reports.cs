using DataAccess;
using System;
using System.Data;

namespace Domain
{
    public class D_Reports
    {

        public static DataTable ObtenerEstadosBoletas()
        {
            return DA_Reports.ObtenerEstadosBoletas();
        }

        public static DataTable mostrarAbonos()
        {
            return DA_Reports.mostrarAbonos();
        }
        public static DataTable mostrarAbonosPorBoleta(string boleta)
        {
            return DA_Reports.mostrarAbonosPorBoleta(boleta);
        }

        public static DataTable mostrarboletasVendidasPorVendedores()
        {
            return DA_Reports.mostrarboletasVendidasPorVendedores();
        }

        public static DataTable mostrarReporteFormasPago(DateTime fechaIni, DateTime fechaFin, int rifaId)
        {
            return DA_Reports.mostrarReporteFormasPago(fechaIni, fechaFin, rifaId);
        }

        public static DataTable mostrarAbonosFechaValor(DateTime fechaIni, DateTime fechaFin, decimal valor)
        {
            return DA_Reports.mostrarAbonosFechaValor(fechaIni, fechaFin, valor);
        }

        public static DataTable mostrarPagos(DateTime fechaIni, DateTime fechaFin)
        {
            return DA_Reports.mostrarPagos(fechaIni, fechaFin);
        }

        public static DataTable mostrarDetallePagoComisiones(DateTime fechaIni, DateTime fechaFin)
        {
            return DA_Reports.mostrarDetallePagoComisiones(fechaIni, fechaFin);
        }

        public static DataTable mostrarPagoComisionesPorVendedores(int vendedorId)
        {
            return DA_Reports.mostrarPagoComisionesPorVendedores(vendedorId);
        }
    }
}
