using System;

namespace Entities
{
    public class Rifas
    {

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int NroInicial { get; set; }
        public int NroFinal { get; set; }
        public bool Activa { get; set; }
        public decimal ValorRifa { get; set; }

    }
}
