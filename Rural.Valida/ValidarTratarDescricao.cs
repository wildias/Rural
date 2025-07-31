using Rural.Util.Extendidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Valida
{
    public static class ValidarTratarDescricao
    {
        public static string ValidarDescricao(this string valorAnalisar)
        {
            try
            {
                var retorno = valorAnalisar?.RemoveAccents()?.ApenasLetras()?.Trim();
                return retorno.Trim();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
