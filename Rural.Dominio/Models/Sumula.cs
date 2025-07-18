using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Sumula
    {
        public Sumula()
        {
            SumulaDetalhes = new HashSet<SumulaDetalhes>();
        }


        public string IdSumula {  get; set; }
        public string IdCampeonato {  get; set; }
        public string IdJogos {  get; set; }
        public string Observacao {  get; set; }
        public DateTime Data {  get; set; }


        [JsonIgnore]
        public virtual Campeonato IdCampeonatoNavigation { get; set; }

        [JsonIgnore]
        public virtual Jogos IdJogosNavigation { get; set; }

        [JsonIgnore]
        public virtual ICollection<SumulaDetalhes> SumulaDetalhes { get; set; }
    }
}
