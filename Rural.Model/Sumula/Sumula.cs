using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Sumula
{
    public class Sumula : Dominio.Models.Sumula
    {
        public Sumula Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var sumula = this;

                if (string.IsNullOrEmpty(sumula.IdSumula)) sumula.IdSumula = Conexao.GeradorCodigo.GerarCodigoID("Sumula", "IdSumula");
                var resposta = Conexao.Conexao.Insert(sumula, "Sumula");

                return sumula;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdSumula = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Sumula Put()
        {
            try
            {
                var sumula = this;
                var resposta = Conexao.Conexao.Update(sumula, "Sumula", "IdSumula");
                return sumula;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Sumula> PostLista(List<Sumula> sumula)
        {
            try
            {
                var listaInsert = sumula.Where(a => string.IsNullOrEmpty(a.IdSumula)).ToList();
                var listaUpdate = sumula.Where(a => !string.IsNullOrEmpty(a.IdSumula)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdSumula)) acc.IdSumula = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdSumula");

                return sumula;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
