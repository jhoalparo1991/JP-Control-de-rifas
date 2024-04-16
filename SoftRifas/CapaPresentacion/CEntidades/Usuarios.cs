using System;

namespace CEntidades
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
        public bool IsAdmin { get; set; }
    }

    public class InicioSesion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NombreCompleto  { get; set; }
        public bool IsAdmin  { get; set; }
        public DateTime Fecha  { get; set; }
    }
}
