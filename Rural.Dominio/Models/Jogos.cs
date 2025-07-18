using Newtonsoft.Json;
using Rural.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Jogos
    {
        public Jogos() 
        {
            Sumula = new HashSet<Sumula>();
        }


        public string IdJogos { get; set; }
        public string IdCampeonato { get; set; }
        public int Rodada { get; set; }
        public string IdClubeCasa { get; set; }
        public string IdClubeVisitante { get; set; }
        public Quadro Quadro { get; set; }
        public int PlacarCasar {  get; set; }
        public int PlacarVisitante {  get; set; }
        public DateTime? Data {  get; set; }


        [JsonIgnore]
        public virtual Campeonato IdCampeonatoNavigation { get; set; }

        [JsonIgnore]
        public virtual ICollection<Sumula> Sumula { get; set; }
    }
}
