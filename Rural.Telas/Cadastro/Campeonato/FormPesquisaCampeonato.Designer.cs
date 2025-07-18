using System.Drawing;
using System.Windows.Forms;

namespace Rural.Telas.Cadastro.Campeonato
{
    partial class FormPesquisaCampeonato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelNadaEncontrado = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.gridControlCampeonato = new DevExpress.XtraGrid.GridControl();
            this.gridViewCampeonato = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelNenhumCampeonato = new System.Windows.Forms.Label();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCampeonato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelCenter, 0, 1);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 2;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(629, 390);
            this.tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.gridControlCampeonato);
            this.panelCenter.Controls.Add(this.labelNenhumCampeonato);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(3, 100);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(623, 287);
            this.panelCenter.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelNadaEncontrado);
            this.panelTop.Controls.Add(this.BtnPesquisar);
            this.panelTop.Controls.Add(this.TxtBoxDescricao);
            this.panelTop.Controls.Add(this.labelPesquisar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(623, 91);
            this.panelTop.TabIndex = 0;
            // 
            // labelNadaEncontrado
            // 
            this.labelNadaEncontrado.AutoSize = true;
            this.labelNadaEncontrado.Font = new System.Drawing.Font("Segoe WP", 13.25F);
            this.labelNadaEncontrado.ForeColor = System.Drawing.Color.IndianRed;
            this.labelNadaEncontrado.Location = new System.Drawing.Point(8, 65);
            this.labelNadaEncontrado.Name = "labelNadaEncontrado";
            this.labelNadaEncontrado.Size = new System.Drawing.Size(192, 24);
            this.labelNadaEncontrado.TabIndex = 9;
            this.labelNadaEncontrado.Text = "Nada encontrado para:";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe WP", 9F);
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Image = global::Rural.Telas.Properties.Resources.IconOk3;
            this.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisar.Location = new System.Drawing.Point(513, 24);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(104, 39);
            this.BtnPesquisar.TabIndex = 8;
            this.BtnPesquisar.Text = "Selecionar";
            this.BtnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxDescricao.Font = new System.Drawing.Font("Segoe WP", 17F);
            this.TxtBoxDescricao.Location = new System.Drawing.Point(8, 25);
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.Size = new System.Drawing.Size(496, 38);
            this.TxtBoxDescricao.TabIndex = 1;
            this.TxtBoxDescricao.TextChanged += new System.EventHandler(this.TxtBoxDescricao_TextChanged);
            this.TxtBoxDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxDescricao_KeyDown);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Segoe WP", 11.25F);
            this.labelPesquisar.Location = new System.Drawing.Point(8, 5);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(71, 20);
            this.labelPesquisar.TabIndex = 0;
            this.labelPesquisar.Text = "Pesquisar";
            // 
            // gridControlCampeonato
            // 
            this.gridControlCampeonato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCampeonato.Location = new System.Drawing.Point(0, 0);
            this.gridControlCampeonato.MainView = this.gridViewCampeonato;
            this.gridControlCampeonato.Name = "gridControlCampeonato";
            this.gridControlCampeonato.Size = new System.Drawing.Size(623, 287);
            this.gridControlCampeonato.TabIndex = 3;
            this.gridControlCampeonato.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCampeonato});
            // 
            // gridViewCampeonato
            // 
            this.gridViewCampeonato.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridViewCampeonato.Appearance.Row.Options.UseFont = true;
            this.gridViewCampeonato.GridControl = this.gridControlCampeonato;
            this.gridViewCampeonato.Name = "gridViewCampeonato";
            this.gridViewCampeonato.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCampeonato.OptionsView.ShowGroupPanel = false;
            this.gridViewCampeonato.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCampeonato_RowClick);
            this.gridViewCampeonato.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCampeonato_RowCellStyle);
            // 
            // labelNenhumCampeonato
            // 
            this.labelNenhumCampeonato.BackColor = System.Drawing.SystemColors.Control;
            this.labelNenhumCampeonato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNenhumCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelNenhumCampeonato.ForeColor = System.Drawing.Color.Gray;
            this.labelNenhumCampeonato.Location = new System.Drawing.Point(0, 0);
            this.labelNenhumCampeonato.Name = "labelNenhumCampeonato";
            this.labelNenhumCampeonato.Size = new System.Drawing.Size(623, 287);
            this.labelNenhumCampeonato.TabIndex = 8;
            this.labelNenhumCampeonato.Text = "Não há informações";
            this.labelNenhumCampeonato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPesquisaCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 390);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaCampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Campeonato";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaCampeonato_KeyDown);
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCampeonato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCampeonato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelPrincipal;
        private Panel panelCenter;
        private Panel panelTop;
        private TextBox TxtBoxDescricao;
        private Label labelPesquisar;
        private Button BtnPesquisar;
        private Label labelNadaEncontrado;
        private DevExpress.XtraGrid.GridControl gridControlCampeonato;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCampeonato;
        private Label labelNenhumCampeonato;
    }
}