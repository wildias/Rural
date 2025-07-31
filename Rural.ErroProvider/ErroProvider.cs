using DevExpress.XtraEditors;
using Rural.Estilo;
using Rural.Valida;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rural.ErroProvider
{
    public static class ErroProvider
    {
        public static ErrorProvider erroProvider = new ErrorProvider();

        public static void Exibir(Control label, string msg = "Preencha este campo")
        {
            erroProvider.SetIconAlignment(label, ErrorIconAlignment.MiddleRight);
            erroProvider.SetIconPadding(label, 2);
            erroProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            erroProvider.SetError(label, msg);
            label.ForeColor = Estilo.Estilo.VermelhoEscuro;
        }

        public static void Remover(Control label)
        {
            erroProvider.SetError(label, null);

            if (label.ForeColor == Estilo.Estilo.VermelhoEscuro)
            {
                label.ForeColor = Color.Black;
            }

        }


        public static bool ValidarVazio(Control edit, Control label, string msg = "Preencha este campo")
        {
            if (string.IsNullOrEmpty(edit?.Text?.Trim()))
            {

                Exibir(label, msg);

                return true;

            }
            else
            {


                Remover(label);

                return false;

            }

        }

        public static bool ValidaCNPJVazio(Control edit, Control label, string msg = "Preencha este campo")
        {
            if (string.IsNullOrEmpty(ValidaCPFCNPJ.RetiraMascara(edit.Text)))
            {
                Exibir(label, msg);
                return true;

            }
            else
            {

                Remover(label);

                return false;

            }


        }

        public static bool ValidarMaskVazio(Control edit, Control label, string msg = "Preencha este campo")
        {
            if (string.IsNullOrEmpty(ValidaCPFCNPJ.RetiraMascara(edit.Text)))
            {
                Exibir(label, msg);

                return true;

            }
            else
            {

                Remover(label);

                return false;

            }


        }


        /// <summary>
        /// Percorre os elementos enviados, restaurando a cor padrão e removendo o erro provider
        /// </summary>
        /// <param name="controls"></param>
        public static void Limpar(Control.ControlCollection controls)
        {

            foreach (Control ctrl in controls)
            {
                if (ctrl.Controls.Count > 0)
                {
                    Limpar(ctrl.Controls);
                }

                Remover(ctrl);
            }
        }

        /// <summary>
        /// PercorrE os controls da tela, limpando ou removendo o erro provider se necessário
        /// </summary>
        /// <param name="controls"></param>
        public static void Resetar(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                Reset(ctrl);

                if (ctrl.Controls.Count > 0)
                {
                    foreach (Control ctrl2 in ctrl.Controls)
                    {
                        Reset(ctrl2);

                        if (ctrl2.Controls.Count > 0)
                        {
                            foreach (Control ctrl3 in ctrl2.Controls)
                            {
                                Reset(ctrl3);

                                if (ctrl3.Controls.Count > 0)
                                {
                                    foreach (Control ctrl4 in ctrl3.Controls)
                                    {
                                        Reset(ctrl4);

                                        if (ctrl4.Controls.Count > 0)
                                        {
                                            foreach (Control ctrl5 in ctrl4.Controls)
                                            {
                                                Reset(ctrl5);

                                                if (ctrl5.Controls.Count > 0)
                                                {
                                                    foreach (Control ctrl6 in ctrl5.Controls)
                                                    {
                                                        Reset(ctrl6);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void Reset(Control ctrl)
        {

            try
            {
                var nome = ctrl.GetType().Name;

                switch (ctrl.GetType().Name)
                {
                    case "TextBox":
                        var text = (TextBox)ctrl;
                        text.Clear();
                        break;
                    case "MaskedTextBox":
                        var maskText = (MaskedTextBox)ctrl;
                        maskText.Clear();
                        break;
                    case "ComboBox":
                        var combo = (System.Windows.Forms.ComboBox)ctrl;
                        combo.SelectedIndex = -1;
                        break;
                    case "Label":
                        Remover(ctrl);
                        break;
                    case "GroupBox":
                        Remover(ctrl);
                        break;
                    case "NumericUpDown":
                        var num = (NumericUpDown)ctrl;
                        num.Value = 0;
                        break;
                    case "DateTimePicker":
                        var data = (DateTimePicker)ctrl;
                        data.Text = string.Empty;
                        break;
                    case "ToggleSwitch":
                        var toggle = (ToggleSwitch)ctrl;
                        toggle.IsOn = false;
                        break;
                    case "ColorPickEdit":
                        var cor = (ColorPickEdit)ctrl;
                        cor.Color = Color.Empty;
                        break;
                    case "RichTextBox":
                        var rich = (RichTextBox)ctrl;
                        rich.Text = string.Empty;
                        break;

                }

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
