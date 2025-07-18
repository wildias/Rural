using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Jogos
{
    public class Jogos : Dominio.Models.Jogos
    {
        public Jogos Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var jogo = this;

                if (string.IsNullOrEmpty(jogo.IdJogos)) jogo.IdJogos = Conexao.GeradorCodigo.GerarCodigoID("Jogos", "IdJogos");
                var resposta = Conexao.Conexao.Insert(jogo, "Jogos");

                return jogo;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdJogos = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Jogos Put()
        {
            try
            {
                var jogo = this;
                var resposta = Conexao.Conexao.Update(jogo, "Jogos", "IdJogos");
                return jogo;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Jogos> PostLista(List<Jogos> jogos)
        {
            try
            {
                var listaInsert = jogos.Where(a => string.IsNullOrEmpty(a.IdJogos)).ToList();
                var listaUpdate = jogos.Where(a => !string.IsNullOrEmpty(a.IdJogos)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdJogos)) acc.IdJogos = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdJogos");

                return jogos;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
