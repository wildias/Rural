using Rural.Dialogos;
using Rural.Dominio.Enum;
using Rural.ErroProvider;
using Rural.Util.Extendidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rural.Telas.Cadastro.Campeonato
{
    public partial class FormCadCampeonato : Form
    {
        private Model.Campeonato.Campeonato _campeonato;


        public FormCadCampeonato()
        {
            InitializeComponent();

            Estilo.Estilo.BtnFechar(btnSair);
            Estilo.Estilo.BtnSalvar(btnSalvar);
            Estilo.Estilo.BtnPesquisar(btnPesquisar);
            Estilo.Estilo.BtnNovo(btnNovo);

            CarregarDadosTela();
        }

        private void FormCadCampeonato_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarSalvar())
            {
                Salvar();
                ReiniciarFormulario();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void FormCadCampeonato_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F5:
                    btnSalvar_Click(sender, e);
                    break;
                case Keys.F3:
                    Novo();
                    break;
                case Keys.F2:
                    Pesquisar();
                    break;

            }
        }

        private void Pesquisar()
        {
            try
            {
                using (var form = new FormPesquisaCampeonato())
                {
                    form.Abrir();

                    if (form._campeonatoSelecionado == null) return;

                    ParseClasseForm(form._campeonatoSelecionado);

                    _campeonato = form._campeonatoSelecionado;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void Novo()
        {
            try
            {
                if (textBoxDescricao.Text.Length > 0 || comboBoxModelo.SelectedIndex > 0)
                {
                    if (MessageBoxRural.Pergunta("Descartar alterações?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ReiniciarFormulario();
                    }
                }
                else
                {
                    ReiniciarFormulario();
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void Salvar()
        {
            try
            {
                TelaEspera.TelaEspera.Exibir();
                TelaEspera.TelaEspera.DefinirMensagem("Aguarde...", "");

                var modelo = (Modelo)comboBoxModelo.SelectedValue;

                if (string.IsNullOrEmpty(_campeonato?.IdCampeonato))
                {
                    _campeonato = new Model.Campeonato.Campeonato()
                    {
                        IdCampeonato = null,
                        Descricao = textBoxDescricao.Text.Trim(),
                        DataCadastro = DateTime.Now,
                        EmAndamento = false,
                        Finalizado = false,
                        Tipo = modelo,
                    };

                    _campeonato.Post();

                    MessageBoxRural.Sucesso("Campeonato salvo com sucesso.", "Fut Manager");
                }
                else
                {
                    if (_campeonato.EmAndamento || _campeonato.Finalizado)
                    {
                        MessageBoxRural.Atencao("Não é possível realizar alterações em campeonatos que já estão em andamento ou que foram finalizados.", "Fut Manager");
                        TelaEspera.TelaEspera.Fechar();
                        return;
                    }

                    _campeonato.Descricao = textBoxDescricao.Text.Trim();
                    _campeonato.Tipo = modelo;

                    _campeonato.Put();

                    MessageBoxRural.Sucesso("Campeonato atualizado com sucesso.", "Fut Manager");
                }

                TelaEspera.TelaEspera.Fechar();
            }
            catch (Exception e)
            {
                TelaEspera.TelaEspera.Fechar();
                throw e;
            }
        }

        private void ReiniciarFormulario()
        {
            try
            {
                _campeonato = null;
                textBoxDescricao.Clear();
                dateEditInicio.EditValue = null;
                dateEditFinal.EditValue = null;
                dateEditCadastro.EditValue = null;
                comboBoxModelo.SelectedIndex = 0;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void CarregarDadosTela()
        {
            try
            {
                CarregarComboBoxModelo();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void CarregarComboBoxModelo()
        {
            try
            {
                var modelo = ExEnum.GetCombo<Modelo>() ?? new List<KeyValuePair<string, Enum>>();
                modelo.Insert(0, new KeyValuePair<string, Enum>("", null));
                comboBoxModelo.DataSource = modelo;
                comboBoxModelo.DisplayMember = "Key";
                comboBoxModelo.ValueMember = "Value";
                comboBoxModelo.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private bool ValidarSalvar()
        {
            try
            {
                bool validar = true;
                Control foco = null;
                ErroProvider.ErroProvider.Limpar(Controls);

                if(ErroProvider.ErroProvider.ValidarVazio(textBoxDescricao, labelDescricao))
                {
                    validar = false;
                    if (foco == null) foco = textBoxDescricao;
                }

                if (ErroProvider.ErroProvider.ValidarVazio(comboBoxModelo, labelModeloCamp))
                {
                    validar = false;
                    if (foco == null) foco = comboBoxModelo;
                }

                return validar;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void ParseClasseForm(Model.Campeonato.Campeonato campeonatoSelecionado)
        {
            try
            {
                textBoxDescricao.Text = campeonatoSelecionado.Descricao;
                comboBoxModelo.SelectedValue = campeonatoSelecionado.Tipo;
                dateEditCadastro.EditValue = campeonatoSelecionado.DataCadastro;

                if (campeonatoSelecionado.DataInicio != null)
                {
                    dateEditInicio.EditValue = campeonatoSelecionado.DataInicio;
                }

                if (campeonatoSelecionado.DataFinal != null)
                {
                    dateEditFinal.EditValue = campeonatoSelecionado.DataFinal;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
