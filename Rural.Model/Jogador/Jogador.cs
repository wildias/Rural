using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Jogador
{
    public class Jogador : Dominio.Models.Jogador
    {
        public Jogador Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var jogador = this;

                if (string.IsNullOrEmpty(jogador.IdJogador)) jogador.IdJogador = Conexao.GeradorCodigo.GerarCodigoID("Jogador", "IdJogador");
                var resposta = Conexao.Conexao.Insert(jogador, "Jogador");

                return jogador;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdJogador = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Jogador Put()
        {
            try
            {
                var jogador = this;
                var resposta = Conexao.Conexao.Update(jogador, "Jogador", "IdJogador");
                return jogador;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Jogador> PostLista(List<Jogador> jogadores)
        {
            try
            {
                var listaInsert = jogadores.Where(a => string.IsNullOrEmpty(a.IdJogador)).ToList();
                var listaUpdate = jogadores.Where(a => !string.IsNullOrEmpty(a.IdJogador)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdJogador)) acc.IdJogador = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdJogador");

                return jogadores;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
