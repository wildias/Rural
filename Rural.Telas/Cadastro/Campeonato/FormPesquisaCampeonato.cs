using Rural.Model.Campeonato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rural.Dominio.Models;
using Rural.Util.Extendidos;

namespace Rural.Telas.Cadastro.Campeonato
{
    public partial class FormPesquisaCampeonato : Form
    {
        public List<Rural.Model.Campeonato.Campeonato> _campeonatos {  get; set; }
        public Model.Campeonato.Campeonato _campeonatoSelecionado { get; set; }
        bool PodeSelecionar = true;


        public FormPesquisaCampeonato()
        {
            InitializeComponent();

            _campeonatos = new List<Rural.Model.Campeonato.Campeonato>();

            CarregarDados();

            FormatarGrid();
        }

        private void CarregarDados()
        {
            try
            {
                var camps = new Rural.Model.Campeonato.Campeonato().GetLista();

                if (camps.Count() < 1) return;

                _campeonatos = camps;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void FormatarGrid()
        {
            try
            {
                gridControlCampeonato.Visible = false;
                _campeonatos = _campeonatos.OrderByDescending(p => p.DataInicio).ToList();
                gridControlCampeonato.DataSource = gridControlCampeonato;

                if (_campeonatos.Count() > 0)
                {
                    gridControlCampeonato.Visible = true;
                    labelNenhumCampeonato.Visible = false;
                    gridViewCampeonato.Columns.Clear();

                    gridViewCampeonato.Columns.AddField("Descricao");
                    gridViewCampeonato.Columns["Descricao"].VisibleIndex = 0;
                    gridViewCampeonato.Columns["Descricao"].Caption = @"Campeonato";
                    gridViewCampeonato.Columns["Descricao"].OptionsColumn.AllowEdit = false;
                    gridViewCampeonato.Columns["Descricao"].MinWidth = 150;

                    gridViewCampeonato.Columns.AddField("DataInicio");
                    gridViewCampeonato.Columns["DataInicio"].VisibleIndex = 1;
                    gridViewCampeonato.Columns["DataInicio"].Caption = "Inicio";
                    gridViewCampeonato.Columns["DataInicio"].OptionsColumn.AllowEdit = false;
                    gridViewCampeonato.Columns["DataInicio"].MinWidth = 70;

                    gridViewCampeonato.Columns.AddField("DataFinal");
                    gridViewCampeonato.Columns["DataFinal"].VisibleIndex = 2;
                    gridViewCampeonato.Columns["DataFinal"].Caption = "Termino";
                    gridViewCampeonato.Columns["DataFinal"].OptionsColumn.AllowEdit = false;
                    gridViewCampeonato.Columns["DataFinal"].MinWidth = 70;

                    gridViewCampeonato.FontePadrao("Segoe WP", 10);
                    gridViewCampeonato.BestFitColumns();

                    gridViewCampeonato.RefreshData();
                }
                else
                {
                    gridControlCampeonato.Visible = false;
                    labelNenhumCampeonato.Visible = true;

                    gridViewCampeonato.RefreshData();
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void gridViewCampeonato_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!(e.Clicks == 2))
            {
                return;
            }

            CampeonatoSelecionado();
        }

        private void CampeonatoSelecionado()
        {
            try
            {
                if (PodeSelecionar)
                {
                    var campeonatoSelecionado = gridViewCampeonato.GetFocusedRow() as Model.Campeonato.Campeonato;

                    if (campeonatoSelecionado != null)
                    {
                        _campeonatoSelecionado = new Model.Campeonato.Campeonato
                        {
                            IdCampeonato = campeonatoSelecionado.IdCampeonato,
                            Descricao = campeonatoSelecionado.Descricao,
                            DataInicio = campeonatoSelecionado.DataInicio,
                            DataFinal = campeonatoSelecionado.DataFinal,
                            EmAndamento = campeonatoSelecionado.EmAndamento,
                            Finalizado = campeonatoSelecionado.Finalizado,
                            Campeao = campeonatoSelecionado.Campeao,
                            ViceCampeao = campeonatoSelecionado.ViceCampeao
                        };
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void gridViewCampeonato_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var linha = (Model.Campeonato.Campeonato)gridViewCampeonato.GetRow(e.RowHandle);
            if (linha == null) return;

            if (linha.EmAndamento)
            {
                e.Appearance.ForeColor = Color.Green;
            }

            if (linha.Finalizado)
            {
                e.Appearance.ForeColor = Color.Red;
            }
        }

        private void FormPesquisaCampeonato_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            CampeonatoSelecionado();
        }

        private void TxtBoxDescricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var camp = _campeonatos.Where(a => a.Descricao.Contains(TxtBoxDescricao.Text.ToUpper().Trim())).ToList().OrderByDescending(b => b.DataInicio);

                if (camp.Count() > 0)
                {
                    gridControlCampeonato.Visible = true;
                    labelNadaEncontrado.Visible = false;
                    labelNenhumCampeonato.Visible = false;
                    gridControlCampeonato.DataSource = camp;
                    PodeSelecionar = true;
                }
                else
                {
                    gridControlCampeonato.Visible = false;
                    labelNadaEncontrado.Visible = true;
                    labelNenhumCampeonato.Visible = true;
                    labelNadaEncontrado.Text = "Nada encontrado para: \"" + TxtBoxDescricao.Text + "\"";
                    PodeSelecionar = false;
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void TxtBoxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    gridViewCampeonato.Focus();
                    break;

            }
        }
    }
}
