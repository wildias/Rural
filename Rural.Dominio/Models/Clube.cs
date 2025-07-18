using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Clube
    {
        public Clube()
        {
            Classificacao = new HashSet<Classificacao>();
            InfoCampeonato = new HashSet<InfoCampeonato>();
            Jogador = new HashSet<Jogador>();
            SumulaDetalhes = new HashSet<SumulaDetalhes>();
        }

        public string IdClube {  get; set; }
        public string Descricao { get; set; }
        public string Tecnico { get; set; }
        public string Auxiliar { get; set; }
        public string Massagista { get; set; }
        public string IdEstadio { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCadastro { get; set; }


        [JsonIgnore]
        public virtual Estadio IdEstadioNavigation { get; set; }

        [JsonIgnore]
        public virtual ICollection<Classificacao> Classificacao { get; set; }

        [JsonIgnore]
        public virtual ICollection<InfoCampeonato> InfoCampeonato { get; set; }

        [JsonIgnore]
        public virtual ICollection<Jogador> Jogador { get; set; }

        [JsonIgnore]
        public virtual ICollection<SumulaDetalhes> SumulaDetalhes { get; set; }
    }
}
