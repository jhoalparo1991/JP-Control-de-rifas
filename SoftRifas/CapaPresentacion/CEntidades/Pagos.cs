using System;

namespace CapaPresentacion.CEntidades
{
    public class Pagos
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Identificador { get; set; }
        public DateTime FechaPago { get; set; }
        public string PeriodoPagado { get; set; }
        public DateTime HoraPago { get; set; }
        public decimal ValorPagos { get; set; }
        public string Descripcion { get; set; }
    }

    public class DtoMostrarDetallePagos
    {
        public int Id { get; set; }
        public int PagoId { get; set; }
        public int VendedorId { get; set; }
        public string Vendedor { get; set; }
        public decimal ValorPagado{ get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaPago { get; set; }
        public string PeriodoPago { get; set; }
        public bool Pagado{ get; set; }
    }
}
