using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rural.Util.Extendidos
{
    public static class ExEnum
    {
        public static List<KeyValuePair<string, Enum>> GetCombo<T>()
        {
            try
            {

                var ret = Enum.GetValues(typeof(T)).Cast<Enum>().Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value

                }).OrderBy(item => item.value).ToList();

                var retDic = new Dictionary<string, Enum>();

                ret.ForEach(n => retDic.Add(n.Description, n.value));

                return retDic.ToList();

            }
            catch
            {
                return null;
            }
        }

        public static string Descricao_Enum(this Enum value)
        {
            // variables  
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            // return  
            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }

        public static Enum GetEnumValueFromDescription<TEnum>(string description) where TEnum : Enum
        {
            foreach (var field in typeof(TEnum).GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                    {
                        return (Enum)field.GetValue(null);
                    }
                }
            }
            throw new ArgumentException($"Não foi encontrado nenhum valor no Enum {typeof(TEnum)} com a descrição '{description}'.");
        }

        public static void PreencherCombobox<T>(this ComboBox comboBox)
        {
            try
            {
                var ret = Enum.GetValues(typeof(T)).Cast<Enum>().Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value

                }).OrderBy(item => item.value).ToList();

                var retDic = new Dictionary<string, Enum>();

                ret.ForEach(n => retDic.Add(n.Description, n.value));

                comboBox.DataSource = retDic.ToList();
                comboBox.DisplayMember = "Key";
                comboBox.ValueMember = "Value";
            }
            catch
            {

            }
        }

        public static T ObterValorSelecionado<T>(this ComboBox comboBox)
        {
            return (T)comboBox.SelectedValue;
        }
    }
}
