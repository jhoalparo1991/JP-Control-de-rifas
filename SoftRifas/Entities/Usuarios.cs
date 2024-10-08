using System;

namespace Entities
{
    public class Usuarios
    {

        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Clave { get; set; }
        public decimal Comision { get; set; }
        public bool Activo { get; set; }
    }

    public class UsuariosPermisos
    {
        public bool Vendedores { get; set; }
        public bool Clientes { get; set; }
        public bool Rifas { get; set; }
        public bool Boletas { get; set; }
        public bool PagoComisiones { get; set; }
        public bool Reportes { get; set; }
        public bool Egresos { get; set; }
        public bool CrearTipoEgreso { get; set; }
        public bool BorrarEgreso { get; set; }
        public bool EditarEgreso { get; set; }
        public bool CrearEgreso { get; set; }
        public bool ImprimirEgreso { get; set; }
        public bool CrearCopiaSeguridad { get; set; }
        public bool RegistrarAbono { get; set; }
        public bool BorrarAbono { get; set; }
        public bool CambiarFpAbono { get; set; }
        public bool CambiarClienteAbono { get; set; }
    }

    public class InicioSesion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NombreCompleto  { get; set; }
        public bool Activo  { get; set; }
        public DateTime Fecha  { get; set; }
    }
}
