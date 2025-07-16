using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraSplashScreen;

namespace Rural.TelaEspera
{
    public partial class TelaEspera
    {

        /// <summary>
        /// Abre o Wait Form e define a primeira mensagem
        /// </summary>
        /// <param name="msgInicial"></param>
        public static void Exibir(string titulo = null, string descricao = null, bool cronometrar = false)
        {
            //FecharWaitFormSeVisivel();

            if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
            {
                //SplashScreenManager.ShowForm(typeof(WaitFormPDV));
                SplashScreenManager.ShowForm(new WaitForm(), typeof(WaitForm), true, true, false, SplashFormStartPosition.Default, new Point(0, 0), ParentFormState.Locked);
                //SplashScreenManager.Default.ActiveSplashFormTypeInfo = new TypeInfo("Modal",Mode.Layer);

                if (!string.IsNullOrEmpty(titulo)) DefinirMensagem(titulo, descricao);

            }

        }

        /// <summary>
        /// Verifica se a tela de espera está aberta e fecha
        /// </summary>
        public static void Fechar()
        {
            FecharWaitFormSeVisivel();
        }

        /// <summary>
        /// Aplica o texto no wait form já aberto
        /// </summary>
        /// <param name="titulo">Usar no máximo 23 Caracteres</param>
        /// <param name="descricao">Usar no máximo 42 Caracteres</param>
        public static void DefinirMensagem(string titulo, string descricao = null)
        {
            if (SplashScreenManager.Default != null)
            {
                //SplashScreenManager.ShowForm(new WaitFormPDV(), typeof(WaitFormPDV), true, true, false, SplashFormStartPosition.Default, new Point(0, 0), ParentFormState.Unlocked);

                SplashScreenManager.Default.SetWaitFormCaption(titulo);
                SplashScreenManager.Default.SetWaitFormDescription(descricao);
            }

        }

        private static void FecharWaitFormSeVisivel()
        {
            try
            {
                if (!SplashScreenManager.FormInPendingState && SplashScreenManager.Default != null && (SplashScreenManager.Default?.IsSplashFormVisible ?? false))
                {
                    SplashScreenManager.CloseForm(false);
                }
            }
            catch (System.Exception)
            {

            }
        }
    }
}
