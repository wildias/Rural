using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Model.InfoCampeonato
{
    public class InfoCampeonato : Dominio.Models.InfoCampeonato
    {
        public InfoCampeonato Post()
        {
        VoltarGerarCodigoNovo:
            try
            {
                var infoCampeonato = this;

                if (string.IsNullOrEmpty(infoCampeonato.IdInfoCampeonato)) infoCampeonato.IdInfoCampeonato = Conexao.GeradorCodigo.GerarCodigoID("InfoCampeonato", "IdInfoCampeonato");
                var resposta = Conexao.Conexao.Insert(infoCampeonato, "InfoCampeonato");

                return infoCampeonato;
            }
            catch (Exception erro)
            {
                if (erro.Message != null && erro.Message.Contains("PK_"))
                {
                    IdInfoCampeonato = null;
                    goto VoltarGerarCodigoNovo;
                }
                else
                {
                    throw erro;
                }
            }
        }

        public InfoCampeonato Put()
        {
            try
            {
                var infoCampeonato = this;
                var resposta = Conexao.Conexao.Update(infoCampeonato, "InfoCampeonato", "IdInfoCampeonato");
                return infoCampeonato;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<InfoCampeonato> PostLista(List<InfoCampeonato> infoCampeonato)
        {
            try
            {
                var listaInsert = infoCampeonato.Where(a => string.IsNullOrEmpty(a.IdInfoCampeonato)).ToList();
                var listaUpdate = infoCampeonato.Where(a => !string.IsNullOrEmpty(a.IdInfoCampeonato)).ToList();

                listaInsert.ForEach(acc =>
                {
                    if (string.IsNullOrEmpty(acc.IdInfoCampeonato)) acc.IdInfoCampeonato = Conexao.GeradorCodigo.GerarCodigoID();
                });

                /*var resposta = */
                Conexao.Conexao.InsertListaZCore(listaInsert.ToArray());
                Conexao.Conexao.AtualizarListaZCore(listaUpdate.ToArray(), "IdInfoCampeonato");

                return infoCampeonato;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
