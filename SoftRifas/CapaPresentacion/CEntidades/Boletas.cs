using System;

namespace CEntidades
{
    public class Boletas
    {
        public int Id { get; set; }
        public int RifaId { get; set; }
        public string NroBoleta { get; set; }
        public decimal ValorBoleta { get; set; }
        public bool Pagada { get; set; }
        public bool Vendida { get; set; }
        public int VendedorId{ get; set; }
    }
    public class DtoMostrarBoletasDatos : Boletas
    {
       
    }

    public class DtoMostrarAbonos
    {

        public int Id { get; set; }
        public int BoletaId { get; set; }
        public string NroBoleta { get; set; }
        public int VendedorId { get; set; }
        public string Vendedor { get; set; }
        public string VendedorCC{ get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string ClienteCC { get; set; }
        public decimal ValorPorPagar { get; set; }
        public decimal Abonos { get; set; }
        public decimal Comision { get; set; }
        public DateTime FechaAbono { get; set; }
        public DateTime HoraAbono { get; set; }
        public string FormasPago { get; set; }
    }

    public class AbonosBoletas
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int VendedorId { get; set; }
        public int ClienteId { get; set; }
        public int BoletaId { get; set; }
        public string NroBoleta { get; set; }
        public decimal ValorPorPagar { get; set; }
        public decimal ValorAbono { get; set; }
        public decimal ValorComision { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string FormasPago { get; set; }

        public string Vendedor { get; set; }
        public string VendedorCC { get; set; }
        public string Cliente { get; set; }
        public string ClienteCC { get; set; }
    }

    public class AsignarBoletasVendedores : Boletas
    {
        public int BoletaId { get; set; }
    }
    public class DtoMostrarAsignarBoletasVendedores : AsignarBoletasVendedores
    {
    }

}
