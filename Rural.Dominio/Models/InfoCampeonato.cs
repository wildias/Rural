using Newtonsoft.Json;
using Rural.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class InfoCampeonato
    {
        public string IdInfoCampeonato { get; set; }
        public string IdCampeonato { get; set; }
        public string IdClube { get; set; }
        public string IdJogador { get; set; }
        public decimal? Gols { get; set; }
        public decimal? CartaoAmarelo { get; set; }
        public decimal? CartaoVermelho { get; set; }
        public bool Suspenso { get; set; }
        public Quadro Quadro { get; set; }


        [JsonIgnore]
        public virtual Campeonato IdCampeonatoNavigation { get; set; }

        [JsonIgnore]
        public virtual Clube IdClubeNavigation { get; set; }

        [JsonIgnore]
        public virtual Jogador IdJogadorNavigation { get; set; }
    }
}
