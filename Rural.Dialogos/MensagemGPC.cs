using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Rural.Dialogos
{
    public partial class MensagemGPC : Form
    {
        Color CorPanelPrincipal;
        string _mensagem = string.Empty;
        string _mensagemDetalhada = string.Empty;

        public MensagemGPC(string Mensagem, string Titulo = "Aviso", MessageBoxButtons TipoBotao = MessageBoxButtons.OK, MessageBoxIcon TipoIcone = MessageBoxIcon.Information, MessageBoxDefaultButton FocoBotao = MessageBoxDefaultButton.Button1, int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar", string DetalheErro = null)
        {
            InitializeComponent();

            TelaEspera.TelaEspera.Fechar();

            _mensagem = Mensagem;
            _mensagemDetalhada = DetalheErro;

            ButtonSim.Text = TextBtn1;
            ButtonNao.Text = TextBtn2;
            ButtonCancel.Text = TextBtn3;

            if (!this.IsDisposed)
            {
                ExibirBotoes(TipoBotao);
                ExibirIcone(TipoIcone);
                DefiniFoco(FocoBotao);
            }

            LabelMensagem.Font = new Font("Segoe WP", FontTamanho);
            LabelMensagem.Text = Mensagem;
            this.Text = Titulo;

            //if (!string.IsNullOrEmpty(DetalheErro))
            //{
            //    linkLabelDetalheErro.Visible = true;
            //    linkLabelDetalheErro.Tag = false;
            // }

            AjustarTamanhoTela(Mensagem);

        }

        private void ExibirIcone(MessageBoxIcon TipoIcone)
        {
            switch (TipoIcone)
            {
                case MessageBoxIcon.Error:
                    PictureBoxIxon.BackgroundImage = Properties.Resources.IconeBrancoMessageboxError;
                    AlterarIcone(Properties.Resources.IconMessageboxErro);
                    CorPanelPrincipal = Color.FromArgb(205, 92, 92);
                    break;

                case MessageBoxIcon.Information:
                    PictureBoxIxon.BackgroundImage = Properties.Resources.IconeBrancoMessageboxInfo;
                    AlterarIcone(Properties.Resources.IconeBrancoMessageboxInfo_Cinza);
                    CorPanelPrincipal = Color.FromArgb(77, 90, 99);
                    break;

                case MessageBoxIcon.Warning:
                    PictureBoxIxon.BackgroundImage = Properties.Resources.IconeBrancoMessageboxWarning;
                    AlterarIcone(Properties.Resources.IconMessageboxWarning);
                    CorPanelPrincipal = Color.FromArgb(243, 156, 18);
                    break;

                case MessageBoxIcon.Question:
                    PictureBoxIxon.BackgroundImage = Properties.Resources.IconeBrancoMessageboxQuestion;
                    AlterarIcone(Properties.Resources.IconMessageboxQuestion);
                    CorPanelPrincipal = Color.FromArgb(51, 145, 212);
                    break;

                //USADO POIS NÃO EXISTE DEFINIÇÃO SUCESS NO MESSAGE BOX
                case MessageBoxIcon.None:
                    PictureBoxIxon.BackgroundImage = Properties.Resources.IconeBrancoMessageboxSucesso;
                    AlterarIcone(Properties.Resources.IconMessageboxSuccess);
                    CorPanelPrincipal = Color.FromArgb(53, 166, 92);
                    break;
            }

            PanelPrincipal.BackColor = CorPanelPrincipal;
            ButtonSim.ForeColor = CorPanelPrincipal;
        }

        private void ExibirBotoes(MessageBoxButtons TipoBotao)
        {
            switch (TipoBotao)
            {
                case MessageBoxButtons.OK:

                    ButtonNao.Visible = false;
                    ButtonCancel.Visible = false;
                    ButtonSim.Visible = true;

                    ButtonSim.DialogResult = DialogResult.OK;
                    ButtonSim.Text = "Ok";
                    break;
                case MessageBoxButtons.YesNo:

                    ButtonNao.Visible = true;
                    ButtonCancel.Visible = false;
                    ButtonSim.Visible = true;
                    ButtonSim.DialogResult = DialogResult.Yes;
                    break;
                case MessageBoxButtons.YesNoCancel:

                    ButtonNao.Visible = true;
                    ButtonCancel.Visible = true;
                    ButtonSim.Visible = true;
                    ButtonSim.DialogResult = DialogResult.Yes;

                    break;
            }
        }

        private void AjustarTamanhoTela(string Mensagem)
        {
            try
            {

                string[] quebra = { "\n", "\r" };
                var MsgInfo = Mensagem.Split(quebra, StringSplitOptions.RemoveEmptyEntries);

                //ACRESCENTAR 23 * (A CONTAGEM DE QUEBRAS DE LINHA -9) NA ALTURA
                if (MsgInfo.Length > 9)
                {
                    var dif = MsgInfo.Length - 9;
                    Height += dif * 23;
                }

                //ACRESCENTAR 5 * (A LARGURA DA MAIOR FRASE - 34) NA LARGURA
                var max = 34;
                foreach (var ms in MsgInfo)
                {
                    if (ms.Length > max)
                    {
                        max = ms.Length;
                    }
                }

                if (max > 34)
                {
                    var dif = max - 34;
                    Width += dif * 5;
                }

                if (Width > 800)
                {
                    Width = 800;

                    //REVALIDAR, CASO ALGUMA QUEBRA DE LINHA TENHA SIDO CRIADA APÓS LIMITAR A LARGURA
                    var MsgInfo800 = LabelMensagem.Text.Split(quebra, StringSplitOptions.RemoveEmptyEntries);

                    //ACRESCENTAR 23 * (A CONTAGEM DE QUEBRAS DE LINHA -9) NA ALTURA
                    if (MsgInfo.Length > 9)
                    {
                        var dif = MsgInfo.Length - 9;
                        //239 É A ALTURA ORIGINAL
                        Height = (239 + (dif * 23));
                    }
                }

                //LIMITAR A ALTURA A 500
                if (Height > 500) Height = 500;

            }
            catch (Exception erro)
            {
                //LogPdv.Instance.Error($"[REDIMENCIONAR MSGBOX] {erro}");
            }

        }

        private void DefiniFoco(MessageBoxDefaultButton focoBotao)
        {
            switch (focoBotao)
            {
                case MessageBoxDefaultButton.Button1:
                    ButtonSim.TabStop = true;
                    break;
                case MessageBoxDefaultButton.Button2:
                    ButtonNao.TabStop = true;
                    break;
                case MessageBoxDefaultButton.Button3:
                    ButtonCancel.TabStop = true;
                    break;
            }
        }

        private void ButtonSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void ButtonNao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonSim_Enter(object sender, EventArgs e)
        {
            ButtonSim.BackColor = Color.White;
            ButtonNao.BackColor = CorPanelPrincipal;
            ButtonCancel.BackColor = CorPanelPrincipal;

            ButtonSim.ForeColor = CorPanelPrincipal;
            ButtonNao.ForeColor = Color.White;
            ButtonCancel.ForeColor = Color.White;
        }

        private void ButtonNao_Enter(object sender, EventArgs e)
        {
            ButtonSim.BackColor = CorPanelPrincipal;
            ButtonNao.BackColor = Color.White;
            ButtonCancel.BackColor = CorPanelPrincipal;

            ButtonSim.ForeColor = Color.White;
            ButtonNao.ForeColor = CorPanelPrincipal;
            ButtonCancel.ForeColor = Color.White;
        }

        private void ButtonCancel_Enter(object sender, EventArgs e)
        {
            ButtonSim.BackColor = CorPanelPrincipal;
            ButtonNao.BackColor = CorPanelPrincipal;
            ButtonCancel.BackColor = Color.White;

            ButtonSim.ForeColor = Color.White;
            ButtonNao.ForeColor = Color.White;
            ButtonCancel.ForeColor = CorPanelPrincipal;
        }

        private void MensagemGPC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape) Close();

                if (e.Control & e.KeyCode == Keys.C)
                {
                    //TelaEspera.TelaEspera.Exibir();

                    //TelaEspera.TelaEspera.DefinirMensagem("Copiando...", "");

                    Thread.Sleep(200);

                    Clipboard.SetText(LabelMensagem.Text);

                    //TelaEspera.TelaEspera.Fechar();
                }
                else if (e.KeyCode == Keys.C)
                {
                    if (ButtonCancel.Visible) ButtonCancel_Click(sender, e);
                }
                else if (e.KeyCode == Keys.S)
                {
                    if (ButtonSim.Visible) ButtonSim_Click(sender, e);
                }
                else if (e.KeyCode == Keys.N)
                {
                    if (ButtonNao.Visible) ButtonNao_Click(sender, e);
                }
            }
            catch (Exception)
            {


            }
        }
        private void AlterarIcone(Bitmap ico)
        {
            Bitmap myBitmap = new Bitmap(ico);

            // Get an Hicon for myBitmap.
            IntPtr Hicon = myBitmap.GetHicon();

            // Create a new icon from the handle. 
            Icon newIcon = Icon.FromHandle(Hicon);

            // Set the form Icon attribute to the new icon.
            this.Icon = newIcon;
        }
    }
}
