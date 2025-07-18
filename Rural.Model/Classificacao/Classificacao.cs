using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Classificacao
{
    public class Classificacao : Dominio.Models.Classificacao
    {
        public Classificacao Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var classificacao = this;

                if (string.IsNullOrEmpty(classificacao.IdClassificacao)) classificacao.IdClassificacao = Conexao.GeradorCodigo.GerarCodigoID("Classificacao", "IdClassificacao");
                var resposta = Conexao.Conexao.Insert(classificacao, "Classificacao");

                return classificacao;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdClassificacao = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Classificacao Put()
        {
            try
            {
                var classificacao = this;
                var resposta = Conexao.Conexao.Update(classificacao, "Classificacao", "IdClassificacao");
                return classificacao;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Classificacao> PostLista(List<Classificacao> classificacao)
        {
            try
            {
                var listaInsert = classificacao.Where(a => string.IsNullOrEmpty(a.IdClassificacao)).ToList();
                var listaUpdate = classificacao.Where(a => !string.IsNullOrEmpty(a.IdClassificacao)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdClassificacao)) acc.IdClassificacao = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdClassificacao");

                return classificacao;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
