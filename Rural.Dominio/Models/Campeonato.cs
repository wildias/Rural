using Newtonsoft.Json;
using Rural.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Campeonato
    {
        public Campeonato()
        {
            Classificacao = new HashSet<Classificacao>();
            InfoCampeonato = new HashSet<InfoCampeonato>();
            Jogos = new HashSet<Jogos>();
            Sumula = new HashSet<Sumula>();
        }

        public string IdCampeonato { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool EmAndamento { get; set; }
        public bool Finalizado { get; set; }
        public Modelo Tipo { get; set; }
        public DateTime DataCadastro { get; set; }


        [JsonIgnore]
        public virtual ICollection<Classificacao> Classificacao { get; set; }

        [JsonIgnore]
        public virtual ICollection<InfoCampeonato> InfoCampeonato { get; set; }

        [JsonIgnore]
        public virtual ICollection<Jogos> Jogos { get; set; }

        [JsonIgnore]
        public virtual ICollection<Sumula> Sumula { get; set; }
    }
}
