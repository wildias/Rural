using Newtonsoft.Json;
using Rural.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Classificacao
    {
        public string IdClassificacao { get; set; }
        public string IdCampeonato { get; set; }
        public string IdClube { get; set; }
        public decimal? Vitoria { get; set; }
        public decimal? Empate { get; set; }
        public decimal? Derrota { get; set; }
        public decimal? SaldoGols { get; set; }
        public decimal? GolsPro { get; set; }
        public decimal? GolsContra { get; set; }
        public decimal? CartaoAmarelo { get; set; }
        public decimal? CartaoVermelho { get; set; }
        public Quadro Quadro { get; set; }
        public DateTime UltimaAtualizacao { get; set; }


        [JsonIgnore]
        public virtual Campeonato IdCampeonatoNavigation { get; set; }

        [JsonIgnore]
        public virtual Clube IdClubeNavigation { get; set; }
    }
}
