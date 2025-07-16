using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Clube
{
    public class Clube : Dominio.Models.Clube
    {
        public Clube Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var clube = this;

                if (string.IsNullOrEmpty(clube.IdClube)) clube.IdClube = Conexao.GeradorCodigo.GerarCodigoID("Clube", "IdClube");
                var resposta = Conexao.Conexao.Insert(clube, "Clube");

                return clube;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdClube = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Clube Put()
        {
            try
            {
                var clube = this;
                var resposta = Conexao.Conexao.Update(clube, "Clube", "IdClube");
                return clube;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Clube> PostLista(List<Clube> clubes)
        {
            try
            {
                var listaInsert = clubes.Where(a => string.IsNullOrEmpty(a.IdClube)).ToList();
                var listaUpdate = clubes.Where(a => !string.IsNullOrEmpty(a.IdClube)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdClube)) acc.IdClube = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdClube");

                return clubes;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
