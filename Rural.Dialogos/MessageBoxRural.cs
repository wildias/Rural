using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rural.Dialogos
{
    public static class MessageBoxRural
    {
        public static DialogResult Show(string Mensagem, string Titulo = "", MessageBoxButtons TipoBotao = MessageBoxButtons.OK, MessageBoxIcon TipoIcone = MessageBoxIcon.Information, MessageBoxDefaultButton FocoBotao = MessageBoxDefaultButton.Button1, int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar")
        {
            var resp = new MensagemGPC(Mensagem, Titulo, TipoBotao, TipoIcone, FocoBotao, FontTamanho, TextBtn1, TextBtn2, TextBtn3);
            var retorno = resp.ShowDialog();
            if (!resp.IsDisposed)
            {
                resp.Dispose();
            }
            return retorno;

        }

        /// <summary>
        /// Messagebox Question, Com Sim ou Não e foco no Não
        /// </summary>
        /// <param name="Mensagem"></param>
        /// <param name="Titulo"></param>
        /// <param name="TipoBotao"></param>
        /// <param name="FocoBotao"></param>
        /// <param name="FontTamanho"></param>
        /// <param name="TextBtn1"></param>
        /// <param name="TextBtn2"></param>
        /// <param name="TextBtn3"></param>
        /// <returns></returns>
        public static DialogResult Pergunta(string Mensagem, string Titulo = "", MessageBoxButtons TipoBotao = MessageBoxButtons.YesNo, MessageBoxDefaultButton FocoBotao = MessageBoxDefaultButton.Button2, int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar")
        {

            var resp = new MensagemGPC(Mensagem, Titulo, TipoBotao, MessageBoxIcon.Question, FocoBotao, FontTamanho, TextBtn1, TextBtn2, TextBtn3);
            var retorno = resp.ShowDialog();
            if (!resp.IsDisposed)
            {
                resp.Dispose();
            }
            return retorno;

        }

        /// <summary>
        /// Messagebox de Sucesso (Verde) com o botão OK
        /// </summary>
        /// <param name="Mensagem"></param>
        /// <param name="Titulo"></param>
        /// <param name="FontTamanho"></param>
        /// <param name="TextBtn1"></param>
        /// <param name="TextBtn2"></param>
        /// <param name="TextBtn3"></param>
        /// <returns></returns>
        public static DialogResult Sucesso(string Mensagem, string Titulo = "Sucesso", int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar")
        {

            var resp = new MensagemGPC(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, FontTamanho, TextBtn1, TextBtn2, TextBtn3);
            var retorno = resp.ShowDialog();
            if (!resp.IsDisposed)
            {
                resp.Dispose();
            }
            return retorno;
        }

        public static DialogResult Atencao(string Mensagem, string Titulo = "", int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar", string DetalheErro = null)
        {

            var resp = new MensagemGPC(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, FontTamanho, TextBtn1, TextBtn2, TextBtn3, DetalheErro);
            var retorno = resp.ShowDialog();
            if (!resp.IsDisposed)
            {
                resp.Dispose();
            }
            return retorno;
        }

        public static DialogResult Info(string Mensagem, string Titulo = "Informacao", int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar")
        {

            var resp = new MensagemGPC(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, FontTamanho, TextBtn1, TextBtn2, TextBtn3);
            var retorno = resp.ShowDialog();
            if (!resp.IsDisposed)
            {
                resp.Dispose();
            }
            return retorno;
        }

        public static DialogResult Erro(string Mensagem, string Titulo = "Erro", int FontTamanho = 10, string TextBtn1 = "Sim", string TextBtn2 = "Não", string TextBtn3 = "Cancelar", string DetalheErro = null)
        {

            var resp = new MensagemGPC(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, FontTamanho, TextBtn1, TextBtn2, TextBtn3, DetalheErro);
            var retorno = resp.ShowDialog();
            if (!resp.IsDisposed)
            {
                resp.Dispose();
            }
            return retorno;
        }
    }
}
