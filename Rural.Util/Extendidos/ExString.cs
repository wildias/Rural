using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rural.Util.Extendidos
{
    public static class ExString
    {
        /// <summary>
        ///     ToUpper nas primeiras letras das palavras em todas as palavras de uma frase.
        /// </summary>
        public static string ToUpperFirst(this string str)
        {

            var st = string.Empty;

            var index = 0;

            string[] words = str.Split(' ');

            foreach (var l in words)
            {
                if (index.Equals(0))
                {
                    st += l.ToUpperFirstLetter();
                }
                else
                {
                    if (l.Length > 2)
                    {
                        st += " " + l.ToUpperFirstLetter();
                    }
                    else
                    {
                        st += " " + l.ToLower();
                    }
                }

                index++;
            }

            return st;
        }

        /// <summary>
        ///     ToUpper na primeira letra da primeira palavra.
        /// </summary>
        public static string ToUpperFirstLetter(this string str)
        {
            var st = str.ToLower();
            var primeiraLetra = st.Substring(0, 1);
            st = st.Remove(0, 1);
            st = primeiraLetra.ToUpper() + st;
            return st;
        }

        /// <summary>
        ///     Retorna o um boleano validando IsNullOrEmpty + Trim()
        /// </summary>
        public static bool IsEmpty(this string str)
        {
            return (string.IsNullOrEmpty(str?.Trim()));
        }

        /// <summary>
        ///     Remove todos os caracteres diferentes de numeros da string
        /// </summary>
        public static string ApenasNumero(this string str)
        {
            if (str.IsEmpty())
                return string.Empty;
            return Regex.Replace(str, "[^0-9]", string.Empty);
        }

        /// <summary>
        ///     Remove todos os caracteres diferentes de letras da string
        /// </summary>
        public static string ApenasLetra(this string str)
        {
            return Regex.Replace(str, "[^a-zA-Z]", string.Empty);
        }

        public static string ApenasLetrasENumerosEspaco(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            return Regex.Replace(str, "[^0-9a-zA-Z]+", " ");
        }
        public static string ApenasLetrasENumeros(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            var s1 = String.Join("", Regex.Split(s, @"[^a-zA-Z0-9]"));

            return s1;
        }
        public static bool ExisteCaracteresEspeciais(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var s1 = String.Join("", Regex.Split(s, @"[^a-zA-Z0-9]"));

            if (s1 != s)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ApenasLetrasENumerosEspacoHifenPontoBarraNormalEOutrosCaracteres(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            return Regex.Replace(str, "[^0-9a-zA-Z-./+()*]+", " ");
        }

        public static string ApenasLetras(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            return Regex.Replace(str, @"[^a-zA-Z ]+", "");
        }

        /// <summary>
        ///     Remove todos os caracteres especiais de letras da string
        /// </summary>
        public static string RemoveAccents(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }


        /// <summary>
        ///     Retorna Stream de uma string
        /// </summary>
        public static Stream ToStream(this string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        ///     Formata e retorna os name do enum separados por espaço antes de cara letra maiuscula
        /// </summary>
        public static string[] EnumToCombobox(this string[] s, string sRemover = null)
        {

            string[] s1 = new string[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                s1[i] = s[i].SepararLetrasMaiuculas();

                if (!string.IsNullOrEmpty(sRemover))
                {
                    s1[i] = s[i].Replace(sRemover, string.Empty);
                }
            }
            return s1;

        }

        /// <summary>
        ///     Formata e retorna os name do enum separados por espaço antes de cara letra maiuscula
        /// </summary>
        public static string EnumTostring(this Enum s, string sRemover = null)
        {

            //string[] s1 = new string[s.Length];

            //for (int i = 0; i < s.Length; i++)
            //{
            var a = Enum.GetName(s.GetType(), s);
            var s1 = a.SepararLetrasMaiuculas().Replace(sRemover, string.Empty);
            //}
            return s1;

        }

        /// <summary>
        /// Retorna um Dictionary formatando os valor do enum
        /// </summary>
        /// <param name="s"></param>
        /// <param name="sRemover"></param>
        /// <returns></returns>
        public static Dictionary<object, string> EnumToComboboxD(this string[] s, string sRemover = null)
        {

            var d1 = new Dictionary<object, string>();

            for (int i = 0; i < s.Length; i++)
            {
                d1.Add(s[i], s[i].SepararLetrasMaiuculas().Replace(sRemover, string.Empty).Trim());
            }

            return d1;

        }

        public static Dictionary<object, string> EnumToComboboxDPrimeiroEmBranco(this string[] s, string sRemover = null)
        {

            var d1 = new Dictionary<object, string>();
            d1.Add(null, null);

            for (int i = 0; i < s.Length; i++)
            {
                d1.Add(s[i], s[i].SepararLetrasMaiuculas().Replace(sRemover, string.Empty).Trim());
            }

            return d1;

        }

        /// <summary>
        ///     Retorna a string separada por espaço antes de cada letra maiuscula
        /// </summary>
        public static string SepararLetrasMaiuculas(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {

                var letraAtual = s[i];

                if (i > 0)
                {
                    //SE FOR UMA LETRA MAIUSCULA
                    if (!(char.IsLower(letraAtual)))
                    {
                        if (!char.IsDigit(letraAtual))
                        {
                            s = s.Remove(i, 1);
                            if (i == 0)
                            {
                                s = s.Insert(i, $"{letraAtual}");
                            }
                            else
                            {
                                s = s.Insert(i, $" {letraAtual}");
                            }

                            i++;
                        }
                    }
                }

            }

            return s;

        }

        /// <summary>
        ///     Remove todos os caracteres especiais de uma string
        /// </summary>


        /// <summary>
        /// Retorna um boleando dizendo se uma string tem algo diferente de letra e número
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ContemCaracterEspecial(this string s)
        {
            var lAntes = s.Length;

            var s1 = String.Join("", Regex.Split(s, @"[^a-zA-Z0-9]"));

            return lAntes != s1.Length;
        }

        public static bool ContainsInsensitive(this string source, string search)
        {
            return (new CultureInfo("pt-BR").CompareInfo).IndexOf(source, search, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
        }

        public static bool ToFile(this string s, string FileName)
        {
            try
            {
                StreamWriter stw = new StreamWriter(FileName);
                stw.WriteLine(s);
                stw.Close();
                return true;
            }
            catch (Exception erro)
            {
                return false;
            }

        }

    }
}
