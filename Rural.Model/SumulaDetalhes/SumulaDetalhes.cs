using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.SumulaDetalhes
{
    public class SumulaDetalhes : Dominio.Models.SumulaDetalhes
    {
        public SumulaDetalhes Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var sumulaDetalhes = this;

                if (string.IsNullOrEmpty(sumulaDetalhes.IdSumulaDetalhes)) sumulaDetalhes.IdJogador = Conexao.GeradorCodigo.GerarCodigoID("SumulaDetalhes", "IdSumulaDetalhes");
                var resposta = Conexao.Conexao.Insert(sumulaDetalhes, "SumulaDetalhes");

                return sumulaDetalhes;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdSumulaDetalhes = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public SumulaDetalhes Put()
        {
            try
            {
                var jogador = this;
                var resposta = Conexao.Conexao.Update(jogador, "SumulaDetalhes", "IdSumulaDetalhes");
                return jogador;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<SumulaDetalhes> PostLista(List<SumulaDetalhes> sumulaDetalhes)
        {
            try
            {
                var listaInsert = sumulaDetalhes.Where(a => string.IsNullOrEmpty(a.IdSumulaDetalhes)).ToList();
                var listaUpdate = sumulaDetalhes.Where(a => !string.IsNullOrEmpty(a.IdSumulaDetalhes)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdSumulaDetalhes)) acc.IdSumulaDetalhes = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdSumulaDetalhes");

                return sumulaDetalhes;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
