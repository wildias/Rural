using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Campeonato
{
    public class Campeonato : Dominio.Models.Campeonato
    {
        public Campeonato Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var campeonato = this;

                if (string.IsNullOrEmpty(campeonato.IdCampeonato)) campeonato.IdCampeonato = Conexao.GeradorCodigo.GerarCodigoID("Campeonato", "IdCampeonato");
                var resposta = Conexao.Conexao.Insert(campeonato, "Campeonato");

                return campeonato;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdCampeonato = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Campeonato Put()
        {
            try
            {
                var campeonato = this;
                var resposta = Conexao.Conexao.Update(campeonato, "Campeonato", "IdCampeonato");
                return campeonato;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
