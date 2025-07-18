using Newtonsoft.Json;
using Rural.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class SumulaDetalhes
    {
        public string IdSumulaDetalhes { get; set; }
        public string IdSumula { get; set; }
        public string IdClube { get; set; }
        public string IdJogador { get; set; }
        public decimal? Gols { get; set; }
        public decimal? CartaoAmarelo { get; set; }
        public decimal? CartaoVermelho { get; set; }
        public Quadro Quadro { get; set; }


        [JsonIgnore]
        public virtual Sumula IdSumulaNavigation { get; set; }

        [JsonIgnore]
        public virtual Clube IdClubeNavigation { get; set; }

        [JsonIgnore]
        public virtual Jogador IdJogadorNavigation { get; set; }
    }
}
