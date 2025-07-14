using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Campeonato
    {
        public Campeonato()
        {
            InfoCampeonato = new HashSet<InfoCampeonato>();
        }

        public string IdCampeonato { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataInico { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool EmAndamento { get; set; }
        public bool Finalizado { get; set; }
        public string Campeao { get; set; }
        public string ViceCampeao { get; set; }


        [JsonIgnore]
        public virtual ICollection<InfoCampeonato> InfoCampeonato { get; set; }
    }
}
