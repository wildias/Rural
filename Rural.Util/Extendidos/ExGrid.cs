using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Rural.Util.Extendidos
{
    public static class ExGrid
    {
        private static int linhaSinalizar;
        private static int contagemSinalizacao;
        private static Color corInicial;
        private static bool sinalizar;

        /// <summary>
        ///     Visible false em todas as colunas do gridview
        /// </summary>
        public static void OcultarColunas(this GridView gridView)
        {
            gridView.OptionsCustomization.AllowFilter = false;
            gridView.OptionsMenu.EnableColumnMenu = false;
            //gridView.OptionsBehavior.Editable = true;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].Visible = false;

            }
        }

        /// <summary>
        /// Column.OptionsColumn.AllowEdit = false em todas as colunas
        /// </summary>
        /// <param name="gridView">Grid Afetado</param>
        /// <param name="bloquearMovimento">Bloquear também a movimentação das colunas</param>
        public static void BloquearEdicao(this GridView gridView, bool bloquearMovimento = true)
        {
            if (gridView == null) return;
            gridView.OptionsCustomization.AllowFilter = false;
            //gridView.OptionsBehavior.Editable = true;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = false;
                if (bloquearMovimento) gridView.Columns[i].OptionsColumn.AllowMove = false;

            }
        }

        /// <summary>
        ///     Columns[i].AppearanceCell.Font para a fonte enviada em todas as colunas
        /// </summary>
        public static void FontePadrao(this GridView gridView, Font fonte)
        {

            gridView.RowHeight = Convert.ToInt32(fonte.Size) * 2;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].AppearanceCell.Font = fonte;
            }

        }

        /// <summary>
        ///     Columns[i].AppearanceCell.Font para a fonte enviada em todas as colunas
        /// </summary>
        public static void FontePadrao(this GridView gridView, string NomeFonte, int tamanho, FontStyle style = FontStyle.Regular)
        {

            gridView.RowHeight = tamanho * 2;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].AppearanceCell.Font = new Font(NomeFonte, tamanho);
            }

        }

        /// <summary>
        ///     Adiciona RepositoryItemButtonEdit com o evento e icone enviados
        /// </summary>
        public static void AddButtonHandler(this GridControl gridControl, GridView gridView, EventHandler evento, ButtonPredefines icone, string text = null, int wid = 30, string toolTip = null, Image image = null)
        {
            gridView.AddButton(evento, icone, text, wid, toolTip, image);
        }

        public static void AddButton(this GridView gridView, EventHandler evento, ButtonPredefines icone, string text = null, int wid = 30, string toolTip = null, Image image = null)
        {

            try
            {
                var button = new RepositoryItemButtonEdit();

                button.TextEditStyle = TextEditStyles.HideTextEditor;
                button.ButtonsStyle = BorderStyles.UltraFlat;

                button.Buttons[0].Kind = icone;
                button.Buttons[0].Image = image;
                button.Buttons[0].Caption = text;
                button.Buttons[0].ToolTip = toolTip;
                gridView.GridControl.RepositoryItems.Add(button);

                var ColRemover = new GridColumn();

                ColRemover.ColumnEdit = button;
                ColRemover.ColumnEdit.Click += evento;
                ColRemover.OptionsColumn.AllowEdit = true;
                ColRemover.Width = wid;
                ColRemover.ToolTip = toolTip;
                ColRemover.FieldName = evento.Method.Name;
                ColRemover.Name = evento.Method.Name;
                ColRemover.FieldName = evento.Method.Name;
                ColRemover.Visible = true;
                ColRemover.VisibleIndex = gridView.Columns.Count + 1;
                ColRemover.Caption = " ";

                gridView.Columns.Add(ColRemover);
            }
            catch (Exception erro)
            {
                

            }
        }

        /// <summary>
        ///     Cria e aplica o efeito zebra no grid
        /// </summary>
        public static void EfeitoZebra(this GridView gridView)
        {
            gridView.OptionsCustomization.AllowFilter = false;

            gridView.Appearance.FocusedRow.BackColor = Estilo.Estilo.CinzaEscuro;
            gridView.Appearance.FocusedRow.ForeColor = Color.White;


            gridView.Appearance.OddRow.BackColor = Color.White;
            gridView.OptionsView.EnableAppearanceOddRow = true;
            gridView.Appearance.EvenRow.BackColor = Color.FromArgb(236, 240, 241);
            gridView.OptionsView.EnableAppearanceEvenRow = true;
        }

        /// <summary>
        ///     Adicionar um editrow com as definicoes enviadas
        /// </summary>
        public static BaseRow AddEditRow(this VGridControl grid, string titulo, object valor, bool editavel)
        {
            try
            {

                var nameRow = titulo;

                var edtRow = new EditorRow();

                edtRow.Properties.AllowEdit = editavel;

                edtRow.Name = nameRow;

                edtRow.Properties.Caption = titulo;

                edtRow.Properties.Value = valor;

                edtRow.Appearance.Font = new System.Drawing.Font("Segoe WP", 12);

                grid.Rows.Add(edtRow);

                return edtRow;

            }
            catch (Exception erro)
            {
                
                return null;
            }
        }



        public static void BloquearEdicao(this VGridControl vGrid, bool estado)
        {
            try
            {
                for (int i = 0; i < vGrid.Rows.Count; i++)
                {
                    vGrid.Rows[i].Properties.AllowEdit = estado;
                }
            }
            catch (Exception erro)
            {
               
            }
        }


        public static void OcultarLinhas(this VGridControl vGrid)
        {
            try
            {
                for (int i = 0; i < vGrid.Rows.Count; i++)
                {
                    vGrid.Rows[i].Visible = false;

                }
            }
            catch (Exception erro)
            {
            }
        }

        public static void FormatarDuasCasasDecimais(this VGridControl vGrid)
        {
            try
            {
                for (int i = 0; i < vGrid.Rows.Count; i++)
                {
                    vGrid.Rows[i].Properties.Format.FormatType = FormatType.Numeric;
                    vGrid.Rows[i].Properties.Format.FormatString = "N2";

                }
            }
            catch (Exception erro)
            {
                
            }
        }

        /// <summary>
        ///     Adiciona RepositoryItemButtonEdit com o evento e icone enviados
        /// </summary>
        public static void AddButton(this GridControl gridControl, GridView gridView, EventHandler evento, ButtonPredefines icone, string text = null, int wid = 30)
        {

            try
            {
                var button = new RepositoryItemButtonEdit();

                button.TextEditStyle = TextEditStyles.HideTextEditor;
                button.ButtonsStyle = BorderStyles.UltraFlat;

                button.Buttons[0].Kind = icone;

                button.Buttons[0].Caption = text;
                gridControl.RepositoryItems.Add(button);

                var ColRemover = new GridColumn();

                ColRemover.ColumnEdit = button;
                ColRemover.ColumnEdit.Click += evento;
                ColRemover.OptionsColumn.AllowEdit = true;
                ColRemover.Width = wid;
                ColRemover.Caption = string.Empty;
                ColRemover.Name = evento.Method.Name;
                ColRemover.Visible = true;
                ColRemover.VisibleIndex = gridView.Columns.Count + 1;

                gridView.Columns.Add(ColRemover);
            }
            catch (Exception erro)
            {
                

            }
        }

        public static void AddToggle(this GridControl gridControl, GridView gridView, string nome, string caption)
        {

            try
            {
                var toggle = new RepositoryItemToggleSwitch();

                toggle.LookAndFeel.UseDefaultLookAndFeel = false;
                toggle.LookAndFeel.SkinName = "Office 2016 Black";
                toggle.ReadOnly = false;
                toggle.ShowText = false;

                gridControl.RepositoryItems.Add(toggle);

                var colToggle = new GridColumn();

                colToggle.ColumnEdit = toggle;
                colToggle.OptionsColumn.AllowEdit = true;
                colToggle.Name = nome;
                colToggle.Width = 40;
                colToggle.Caption = caption;
                colToggle.Visible = true;
                colToggle.VisibleIndex = gridView.Columns.Count + 1;

                gridView.Columns.Add(colToggle);
            }
            catch (Exception erro)
            {
                

            }
        }

        public static void RemoveRowFromGridControl(this DevExpress.XtraGrid.GridControl gridControl, int rowIndex)
        {
            // Supondo que o GridControl esteja vinculado a uma DataTable
            DataTable dt = gridControl.DataSource as DataTable;

            if (dt != null && rowIndex >= 0 && rowIndex < dt.Rows.Count)
            {
                dt.Rows.RemoveAt(rowIndex);
            }

            // Reconfigurar o DataSource se necessário
            gridControl.DataSource = dt;
            gridControl.RefreshDataSource();
        }

        public static void RemoveRowsWithNullKeyProperty(this GridView gridView, string key)
        {
            for (int i = gridView.RowCount - 1; i >= 0; i--)
            {
                // Obter o valor da coluna IdInventarioProduto para a linha atual
                object value = gridView.GetRowCellValue(i, key);

                // Se o valor for null ou DBNull (para fontes de dados baseadas em database), remova a linha
                if (value == null || value == DBNull.Value)
                {
                    gridView.DeleteRow(i);
                }
            }
        }


        public static void SinalizarLinha(this GridView grid, int linha)
        {

            try
            {

                linhaSinalizar = linha;

                contagemSinalizacao = 0;

                corInicial = Color.Empty;

                sinalizar = true;

                grid.FocusedRowHandle = linha;

                grid.RowCellStyle += Grid_RowCellStyleSinalizar;

                var t = new Timer();

                t.Interval = 1;

                t.Tick += (sender, e) =>
                {
                    t.Interval = 100;

                    if (contagemSinalizacao.Equals(5))
                    {
                        t.Stop();
                        grid.RowCellStyle -= Grid_RowCellStyleSinalizar;
                    }
                    else
                    {
                        sinalizar = !sinalizar;
                        grid.RefreshData();
                        contagemSinalizacao++;
                    }

                };

                t.Start();

            }
            catch (Exception erro)
            {
                
            }
        }

        private static void Grid_RowCellStyleSinalizar(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle.Equals(linhaSinalizar))
            {
                if (corInicial.Equals(Color.Empty)) corInicial = e.Appearance.BackColor;

                if (sinalizar)
                {
                    e.Appearance.BackColor = Color.LightGray;
                }
                else
                {
                    e.Appearance.BackColor = corInicial;
                }

            }
        }

        /// <summary>
        /// Retorna as linhas que não estão selecionadas no grid.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static List<int> GetUnselectedRows(this GridView grid)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < grid.DataRowCount; i++)
            {
                if (!grid.IsRowSelected(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        //public static string ApenasNumero(this string str)
        //{
        //    if (str.IsEmpty()) return null;
        //    return Regex.Replace(str, "[^0-9]", string.Empty);
        //}

    }
}
