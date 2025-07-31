using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rural.Util.Extendidos
{
    public static class ExDecimal
    {
        public static decimal Truncar(this decimal valor)
        {
            var valorSplit = valor.ToString().Split(',');
            var val = valorSplit[0];
            var dig = (valorSplit.Length > 1) ? valorSplit[1] : "000";
            if (dig.Length == 1)
            {
                dig += "000";
            }
            var valorNovoStr = val + "," + dig.Substring(0, 2);
            return decimal.Parse(valorNovoStr);
        }

        public static decimal Truncar(this decimal? valor)
        {
            var valorSplit = valor.ToString().Split(',');
            var val = valorSplit[0];
            var dig = (valorSplit.Length > 1) ? valorSplit[1] : "000";
            if (dig.Length == 1)
            {
                dig += "000";
            }
            var valorNovoStr = val + "," + dig.Substring(0, 2);
            return decimal.Parse(valorNovoStr);
        }
    }
}
