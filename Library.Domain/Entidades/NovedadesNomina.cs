using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Entidades
{
    public class NovedadesNomina
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoNovedad { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Naturaleza { get; set; }
        public int Valor { get; set; }
        public string Observacion { get; set; }
    }
}
