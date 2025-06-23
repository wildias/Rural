using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Campeonato
    {
        public int idCampeonato { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInico { get; set; }
        public DateTime? DataFinal { get; set; }
    }
}
