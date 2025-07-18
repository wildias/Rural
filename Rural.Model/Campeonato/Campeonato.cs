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

        public List<Campeonato> PostLista(List<Campeonato> campeonato)
        {
            try
            {
                var listaInsert = campeonato.Where(a => string.IsNullOrEmpty(a.IdCampeonato)).ToList();
                var listaUpdate = campeonato.Where(a => !string.IsNullOrEmpty(a.IdCampeonato)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdCampeonato)) acc.IdCampeonato = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdCampeonato");

                return campeonato;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Campeonato> GetLista()
        {
            try
            {
                var sql = "SELECT * FROM Campeonato";

                var resp = Conexao.Conexao.Query<Campeonato>(sql).ToList();
                return resp;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
