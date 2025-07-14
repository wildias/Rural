using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Jogador
    {
        public Jogador()
        {
            InfoCampeonato = new HashSet<InfoCampeonato>();
        }

        public string IdJogador { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataNascimento { get; set; }
        public long? Documento { get; set; }
        public string IdClube { get; set; }
        public string Imagem { get; set; }


        [JsonIgnore]
        public virtual Clube IdClubeNavigation { get; set; }

        [JsonIgnore]
        public virtual ICollection<InfoCampeonato> InfoCampeonato { get; set; }
    }
}
