using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rural.Util.Extendidos
{
    public static class ExForm
    {
        /// <summary>
        ///     Abre a janela com ShowDialog e executa o Dispose ao Fechar
        /// </summary>
        public static void Abrir(this Form tela, Form pai)
        {
            try
            {
                if (tela.IsDisposed || tela.Disposing) return;

                tela.ShowDialog(pai);

                tela.Dispose();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static void Abrir(this Form tela)
        {
            try
            {
                if (tela.IsDisposed || tela.Disposing) return;

                tela.ShowInTaskbar = true;

                tela.BringToFront();

                tela.Activate();

                tela.ShowDialog();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public static void ProximoControl(this Form tela, object sender, KeyEventArgs e)
        {
            tela.SelectNextControl(tela.ActiveControl, !e.Shift, true, true, true);
        }

        public static Control BuscarComponente(this Form tela, string busca, List<string> ignorarNames = null)
        {
            try
            {
                return BuscarComponente(tela.Controls, busca, ignorarNames);
            }
            catch
            {
                return null;
            }
        }

        private static Control BuscarComponente(Control.ControlCollection controls, string busca, List<string> ignorarNames = null)
        {
            try
            {

                Control retorno = null;
                List<Control.ControlCollection> proximos = new List<Control.ControlCollection>();

                foreach (Control c in controls)
                {
                    if (!ignorarNames.Contains(c.Name))
                    {
                        if (c.Text.ContainsInsensitive(busca))
                        {
                            retorno = c;
                            break;
                        }
                        else if (busca.Contains(" "))
                        {
                            var splitBusca = busca.Split(' ');

                            var match = true;

                            foreach (var s in splitBusca)
                            {
                                if (match)
                                {
                                    match = c.Text.ContainsInsensitive(s);
                                }
                            }

                            if (match)
                            {
                                retorno = c;
                            }
                        }
                    }


                    if (c.Controls?.Count > 0)
                    {
                        proximos.Add(c.Controls);
                    }
                }

                if (retorno == null)
                {
                    if (proximos?.Count > 0)
                    {
                        foreach (var c in proximos)
                        {
                            retorno = BuscarComponente(c, busca, ignorarNames);

                            if (retorno != null) break;
                        }

                        return retorno;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return retorno;
                }


            }
            catch
            {
                return null;
            }
        }

        public static void AplicarCasasDecimaisNumericUpDown(this Control.ControlCollection controls, int casasDecimais)
        {
            List<Control.ControlCollection> proximos = new List<Control.ControlCollection>();

            foreach (Control c in controls)
            {

                foreach (NumericUpDown item in controls.OfType<NumericUpDown>())
                {
                    item.DecimalPlaces = casasDecimais;
                }

                if (c.Controls?.Count > 0)
                {
                    if (c.Controls?.Count > 0)
                    {
                        proximos.Add(c.Controls);
                    }

                    foreach (var item in proximos)
                    {
                        AplicarCasasDecimaisNumericUpDown(item, casasDecimais);
                    }
                }
            }
        }

        public static void SetPlaceholder(this TextBox textBox, string placeholder)
        {
            // Criar uma Label para servir como placeholder
            System.Windows.Forms.Label placeholderLabel = new System.Windows.Forms.Label();
            placeholderLabel.Text = placeholder;
            placeholderLabel.ForeColor = Color.FromArgb(180, 180, 180);
            placeholderLabel.BackColor = Color.Transparent; // Para que a Label não cubra o TextBox
            placeholderLabel.Font = new Font("Microsoft Sans Serif", 12);
            placeholderLabel.AutoSize = false;
            placeholderLabel.Size = new Size(textBox.ClientSize.Width - 4, textBox.ClientSize.Height); // Ajuste para caber dentro do TextBox
            placeholderLabel.Location = new Point(2, 2); // Definir a localização para dentro do TextBox
            placeholderLabel.TextAlign = ContentAlignment.MiddleLeft;
            placeholderLabel.Padding = new Padding(0, 0, 0, 0);

            // Configurar para que o placeholder fique dentro do TextBox
            placeholderLabel.Parent = textBox;
            placeholderLabel.BringToFront();

            // Evento Click para focar no TextBox ao clicar na Label
            placeholderLabel.Click += (sender, e) =>
            {
                placeholderLabel.Visible = false;
                textBox.Focus();
            };

            // Eventos para esconder e mostrar o placeholder
            textBox.Enter += (sender, e) =>
            {
                placeholderLabel.Visible = false;
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    placeholderLabel.Visible = true;
                }
            };

            // Também ocultar o placeholder ao digitar diretamente
            textBox.TextChanged += (sender, e) =>
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    placeholderLabel.Visible = false;
                }
                else if (!textBox.Focused)
                {
                    placeholderLabel.Visible = true;
                }
            };
        }
    }
}
