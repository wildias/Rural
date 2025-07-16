namespace Rural
{
    public partial class FormRural : Form
    {
        public FormRural()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            btnCampeonato.Visible = true;
            btnClube.Visible = true;
            btnJogador.Visible = true;
            btnEstadio.Visible = true;
        }
    }
}
