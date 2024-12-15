using DataAccess;
using System;
using System.Data;

namespace Domain
{
    public class N_Reports
    {

        public static DataTable ObtenerEstadosBoletas()
        {
            return DA_Reports.ObtenerEstadosBoletas();
        }

        public static DataTable mostrarAbonos()
        {
            return DA_Reports.mostrarAbonos();
        }

        public static DataTable mostrarAbonosPorFormasDePago(DateTime fecha1, DateTime fecha2, string formaPago)
        {
            return DA_Reports.mostrarAbonosPorFormaDePago(fecha1, fecha2, formaPago);
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

        public static DataTable mostrarListadoComisionesPagadas(DateTime fechaIni, DateTime fechaFin)
        {
            return DA_Reports.mostrarListadoComisionesPagadas(fechaIni, fechaFin);
        }

        public static DataTable mostrarPagoComisionesPorVendedores(int vendedorId)
        {
            return DA_Reports.mostrarPagoComisionesPorVendedores(vendedorId);
        }

        public static DataTable mostrarAbonosComisionesPorVendedores(DateTime fechaIni, DateTime fechaFin, int vendedorId)
        {
            return DA_Reports.mostrarAbonosComisionesPorVendedores(fechaIni, fechaFin, vendedorId);
        }

        public static DataTable mostrarReporteCaja(string fecha, string fecha2)
        {
            return DA_Reports.mostrarReporteCaja(fecha, fecha2);
        }

        public static DataTable mostrarReporteFormasPagoCaja(DateTime fecha)
        {
            return DA_Reports.mostrarReporteFormasPagoCaja(fecha);
        }

        public static DataTable mostrarPagoComisionesPorVendedoresIdDetallePago(int id)
        {
            return DA_Reports.mostrarPagoComisionesPorVendedoresIdDetallePago(id);
        }


        public static DataTable mostrarTotalComisionesPagadas()
        {
            return DA_Reports.mostrarTotalComisionesPagadas();
        }

        public static DataTable sumarTotalGastos()
        {
            return DA_Reports.sumarTotalGastos();
        }

        public static DataTable sumarTotalAbonos()
        {
            return DA_Reports.sumarTotalAbonos();
        }

        public static DataTable abonosPorFormasDePago()
        {
            return DA_Reports.abonosPorFormasDePago();
        }

        public static DataTable mostrarTotalComisionesPorPagar()
        {
            return DA_Reports.mostrarTotalComisionesPorPagar();
        }

        public static DataTable mostrarReporteTotalCaja()
        {
            return DA_Reports.mostrarReporteTotalCaja();
        }

        public static DataTable mostrarTotalAbonosClientes(int vendedorId)
        {
            return DA_Reports.mostrarTotalAbonosClientes(vendedorId);
        }

        public static DataTable reporte_boletas_entre_fechas(DateTime fechaIni, DateTime fechaFin)
        {
            return DA_Reports.reporte_boletas_entre_fechas(fechaIni,fechaFin);
        }

    }
}
