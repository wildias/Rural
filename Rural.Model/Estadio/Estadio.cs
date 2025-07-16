using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.Estadio
{
    public class Estadio : Dominio.Models.Estadio
    {
        public Estadio Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var estadio = this;

                if (string.IsNullOrEmpty(estadio.IdEstadio)) estadio.IdEstadio = Conexao.GeradorCodigo.GerarCodigoID("Estadio", "IdEstadio");
                var resposta = Conexao.Conexao.Insert(estadio, "Estadio");

                return estadio;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdEstadio = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public Estadio Put()
        {
            try
            {
                var estadio = this;
                var resposta = Conexao.Conexao.Update(estadio, "Estadio", "IdEstadio");
                return estadio;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Estadio> PostLista(List<Estadio> estadios)
        {
            try
            {
                var listaInsert = estadios.Where(a => string.IsNullOrEmpty(a.IdEstadio)).ToList();
                var listaUpdate = estadios.Where(a => !string.IsNullOrEmpty(a.IdEstadio)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdEstadio)) acc.IdEstadio = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdEstadio");

                return estadios;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
