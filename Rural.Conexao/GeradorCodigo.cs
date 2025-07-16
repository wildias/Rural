using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Conexao
{
    public static class GeradorCodigo
    {
        public static object strCodigoId = "RIGHT(replace(CAST(CAST(CRYPT_GEN_RANDOM(60) AS UNIQUEIDENTIFIER) AS VARCHAR(50)),'-',''), 10)";


        public static string GerarCodigoID(string Tabela = null, string Campo = null, bool PularMaisUm = false)
        {
            try
            {
                var guidn = Guid.NewGuid();
                return guidn.ToString().Replace("-", "").ToUpper().Substring(0, 10);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
