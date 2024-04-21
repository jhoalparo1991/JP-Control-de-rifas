using System;

namespace Entities
{
    public class Gastos
    {

        public int Id { get; set; }
        public int TipoGastoId { get; set; }
        public int UsuarioId { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }

    }


    public class DtoMostarGastos : Gastos
    {

        public string Codigo { get; set; }
        public string TipoGasto { get; set; }

    }
}
