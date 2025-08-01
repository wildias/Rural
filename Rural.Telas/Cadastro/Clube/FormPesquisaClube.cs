using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rural.Util.Extendidos;

namespace Rural.Telas.Cadastro.Clube
{
    public partial class FormPesquisaClube : Form
    {
        public List<Model.Clube.Clube> _clubes { get; set; }
        public Model.Clube.Clube _clubeSelecionado { get; set; }

        bool PodeSelecionar = true;


        public FormPesquisaClube()
        {
            InitializeComponent();

            _clubes = new List<Model.Clube.Clube>();

            CarregarDados();

            FormatarGrid();
        }

        private void CarregarDados()
        {
            try
            {
                var clubes = new Model.Clube.Clube().GetLista();

                if (clubes.Count() < 1) return;

                _clubes = clubes;
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
                gridControlClube.Visible = false;
                _clubes = _clubes.OrderBy(p => p.Descricao).ToList();
                gridControlClube.DataSource = _clubes;

                if (_clubes.Count() > 0)
                {
                    gridControlClube.Visible = true;
                    labelNenhum.Visible = false;
                    gridViewClube.Columns.Clear();

                    gridViewClube.Columns.AddField("Descricao");
                    gridViewClube.Columns["Descricao"].VisibleIndex = 0;
                    gridViewClube.Columns["Descricao"].Caption = @"Clube";
                    gridViewClube.Columns["Descricao"].OptionsColumn.AllowEdit = false;
                    gridViewClube.Columns["Descricao"].MinWidth = 150;

                    gridViewClube.FontePadrao("Segoe WP", 10);
                    gridViewClube.BestFitColumns();

                    gridViewClube.RefreshData();
                }
                else
                {
                    gridControlClube.Visible = false;
                    labelNenhum.Visible = true;

                    gridViewClube.RefreshData();
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void gridViewClube_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!(e.Clicks == 2))
            {
                return;
            }

            ClubeSelecionado();
        }

        private void ClubeSelecionado()
        {
            try
            {
                if (PodeSelecionar)
                {
                    var clubeSelecionado = gridViewClube.GetFocusedRow() as Model.Clube.Clube;

                    if (_clubeSelecionado != null)
                    {
                        _clubeSelecionado = new Model.Clube.Clube
                        {
                            IdClube = clubeSelecionado.IdClube,
                            Descricao = clubeSelecionado.Descricao,
                            Tecnico = clubeSelecionado.Tecnico,
                            Auxiliar = clubeSelecionado.Auxiliar,
                            Massagista = clubeSelecionado.Massagista,
                            IdEstadio = clubeSelecionado.IdEstadio,
                            Imagem = clubeSelecionado.Imagem,
                            DataCadastro = clubeSelecionado.DataCadastro
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

        private void FormPesquisaClube_KeyDown(object sender, KeyEventArgs e)
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
            ClubeSelecionado();
        }

        private void TxtBoxDescricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var clube = _clubes.Where(a => a.Descricao.Contains(TxtBoxDescricao.Text.ToUpper().Trim())).ToList().OrderBy(b => b.Descricao);

                if (clube.Count() > 0)
                {
                    gridControlClube.Visible = true;
                    labelNadaEncontrado.Visible = false;
                    labelNenhum.Visible = false;
                    gridControlClube.DataSource = clube;
                    PodeSelecionar = true;
                }
                else
                {
                    gridControlClube.Visible = false;
                    labelNadaEncontrado.Visible = true;
                    labelNenhum.Visible = true;
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
                    gridViewClube.Focus();
                    break;

            }
        }
    }
}
