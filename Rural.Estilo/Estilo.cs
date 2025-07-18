using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rural.Estilo
{
    public static class Estilo
    {
        #region Cores
        public static Color VerdeTurquesaClaro { get { return Color.FromArgb(26, 188, 156); } }
        public static Color VerdeTurquesaEscuro { get { return Color.FromArgb(22, 160, 133); } }
        public static Color AmareloClaro { get { return Color.FromArgb(241, 196, 15); } }
        public static Color AmareloEscuro { get { return Color.FromArgb(243, 156, 18); } }
        public static Color VerdeClaro { get { return Color.FromArgb(46, 204, 113); } }
        public static Color VerdeEscuro { get { return Color.FromArgb(39, 174, 96); } }
        public static Color LaranjaClaro { get { return Color.FromArgb(230, 126, 34); } }
        public static Color LaranjaEscuro { get { return Color.FromArgb(211, 84, 0); } }
        public static Color AzulClaro { get { return Color.FromArgb(52, 152, 219); } }
        public static Color AzulEscuro { get { return Color.FromArgb(41, 128, 185); } }
        public static Color VermelhoClaro { get { return Color.FromArgb(231, 76, 60); } }
        public static Color VermelhoEscuro { get { return Color.FromArgb(192, 57, 43); } }
        public static Color RoxoClaro { get { return Color.FromArgb(155, 89, 182); } }
        public static Color RoxoEscuro { get { return Color.FromArgb(142, 68, 173); } }
        public static Color BrancoClaro { get { return Color.FromArgb(236, 240, 241); } }
        public static Color BrancoEscuro { get { return Color.FromArgb(189, 195, 199); } }
        public static Color PretoClaro { get { return Color.FromArgb(52, 73, 94); } }
        public static Color PretoEscuro { get { return Color.FromArgb(44, 62, 80); } }
        public static Color CinzaClaro { get { return Color.FromArgb(149, 165, 166); } }
        public static Color CinzaEscuro { get { return Color.FromArgb(127, 140, 141); } }

        /// <summary>
        /// Uma lista com todas as Flat Colors usadas no sistema
        /// </summary>
        public static List<Color> ListaDeCores
        {
            get
            {
                var retorno = new List<Color>();

                retorno.Add(VerdeTurquesaClaro);
                retorno.Add(VerdeTurquesaEscuro);
                retorno.Add(AmareloClaro);
                retorno.Add(AmareloEscuro);
                retorno.Add(VerdeClaro);
                retorno.Add(VerdeEscuro);
                retorno.Add(LaranjaClaro);
                retorno.Add(LaranjaEscuro);
                retorno.Add(AzulClaro);
                retorno.Add(AzulEscuro);
                retorno.Add(VermelhoClaro);
                retorno.Add(VermelhoEscuro);
                retorno.Add(RoxoClaro);
                retorno.Add(RoxoEscuro);
                retorno.Add(BrancoClaro);
                retorno.Add(BrancoEscuro);
                retorno.Add(PretoClaro);
                retorno.Add(PretoEscuro);
                retorno.Add(CinzaClaro);
                retorno.Add(CinzaEscuro);

                return retorno;
            }

        }

        #endregion

        /// <summary>
        /// Desativa o control e deixa o BackColor dele em rgb(189, 195, 199) (Cinza)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnDesativado(this Control btn)
        {
            btn.BackColor = CinzaClaro;

            btn.Enabled = false;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(192, 57, 43) (Vermelho)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnFechar(this Control btn)
        {
            btn.BackColor = VermelhoClaro;

            btn.Enabled = true; btn.Cursor = Cursors.Default;

        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(192, 57, 43) (Vermelho)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnCancelar(this Control btn)
        {
            btn.BackColor = VermelhoClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(39, 174, 96) (Verde)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnSalvar(this Control btn)
        {
            btn.BackColor = VerdeClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(243, 156, 18) (Amarelo)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnNovo(this Control btn)
        {
            btn.BackColor = AmareloEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(41, 128, 185) (Azul)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnPesquisar(this Control btn)
        {
            btn.BackColor = AzulClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(41, 128, 185) (Azul)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnSelecionar(this Control btn)
        {
            btn.BackColor = AzulEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(142, 68, 173) (Roxo)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnDuplicar(this Control btn)
        {
            btn.BackColor = RoxoClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(26, 188, 156) (Verde Bebê)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnImportar(this Control btn)
        {
            btn.BackColor = VerdeTurquesaClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(26, 188, 156) (Verde Escuro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnVerdeEscuro(this Control btn)
        {
            btn.BackColor = VerdeEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(230, 126, 34) (Laranja)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnLaranjaClaro(this Control btn)
        {
            btn.BackColor = LaranjaClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(142, 68, 173) (Roxo Escuro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnRoxoEscuro(this Control btn)
        {
            btn.BackColor = RoxoEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(243, 156, 18) (Laranja)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnAmareloEscuro(this Control btn)
        {
            btn.BackColor = AmareloEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;

        }

        public static void BtnVerdeClaro(this Control btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#22A085");
            btn.Enabled = true;
            btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(241, 196, 15) (Amarelo)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnAmareloClaro(this Control btn)
        {
            btn.BackColor = AmareloClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;

        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(41, 128, 185) (Azul Escuro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnAzulEscuro(this Control btn)
        {
            btn.BackColor = AzulEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(41, 128, 185) (Azul Escuro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnAzulClaro(this Control btn)
        {
            btn.BackColor = AzulClaro;
            btn.Enabled = true;
            btn.Cursor = Cursors.Default;
        }
        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(52,73,94) (Preto)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnPretoClaro(this Control btn)
        {
            btn.BackColor = PretoClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(236, 240, 241) (Cinza Claro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnBrancoClaro(Button btn)
        {
            btn.BackColor = BrancoClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Alterar a imagem de fundo do botão para um X cinza
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnImageRemover(this Button btn)
        {
            try
            {
                //btn.BackgroundImage = RCAGPC.Estilo.Properties.Resources.IconRemoverGridCinza;
                btn.BackgroundImageLayout = ImageLayout.Center;

            }
            catch (Exception erro)
            {
               
            }
        }

        /// <summary>
        /// Alterar a imagem de fundo do botão para uma lupa azul
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnImageBuscar(this Button btn)
        {
            try
            {
                //btn.BackgroundImage = RCAGPC.Estilo.Properties.Resources.IconPesquisarTextBox;
                btn.BackgroundImageLayout = ImageLayout.Center;
            }
            catch (Exception erro)
            {
                
            }
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(26, 188, 156) (Turquesa Claro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnTurquesaClaro(Button btn)
        {
            btn.BackColor = VerdeTurquesaClaro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Ativa o control e deixa o BackColor dele em rgb(22, 160, 133) (Turquesa Escuro)
        /// </summary>
        /// <param name="btn"></param>
        public static void BtnTurquesaEscuro(Button btn)
        {
            btn.BackColor = VerdeTurquesaEscuro;
            btn.Enabled = true; btn.Cursor = Cursors.Default;
        }

    }
}
