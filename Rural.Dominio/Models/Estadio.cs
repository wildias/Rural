using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Models
{
    public class Estadio
    {
        public Estadio()
        {
            Clube = new HashSet<Clube>();
        }

        public string IdEstadio { get; set; }
        public string Descricao { get; set; }
        public string Localidade { get; set; }
        public DateTime DataCadastro { get; set; }


        [JsonIgnore]
        public virtual ICollection<Clube> Clube { get; set; }
    }
}
