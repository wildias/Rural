namespace Rural.Telas.Cadastro.Clube
{
    partial class FormPesquisaClube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaClube));
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.gridControlClube = new DevExpress.XtraGrid.GridControl();
            this.gridViewClube = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelNenhum = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelNadaEncontrado = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClube)).BeginInit();
            this.panelTop.SuspendLayout();
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
            this.tableLayoutPanelPrincipal.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.gridControlClube);
            this.panelCenter.Controls.Add(this.labelNenhum);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(3, 100);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(623, 287);
            this.panelCenter.TabIndex = 1;
            // 
            // gridControlClube
            // 
            this.gridControlClube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClube.Location = new System.Drawing.Point(0, 0);
            this.gridControlClube.MainView = this.gridViewClube;
            this.gridControlClube.Name = "gridControlClube";
            this.gridControlClube.Size = new System.Drawing.Size(623, 287);
            this.gridControlClube.TabIndex = 3;
            this.gridControlClube.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClube});
            // 
            // gridViewClube
            // 
            this.gridViewClube.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridViewClube.Appearance.Row.Options.UseFont = true;
            this.gridViewClube.GridControl = this.gridControlClube;
            this.gridViewClube.Name = "gridViewClube";
            this.gridViewClube.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewClube.OptionsView.ShowGroupPanel = false;
            this.gridViewClube.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewClube_RowClick);
            // 
            // labelNenhum
            // 
            this.labelNenhum.BackColor = System.Drawing.SystemColors.Control;
            this.labelNenhum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelNenhum.ForeColor = System.Drawing.Color.Gray;
            this.labelNenhum.Location = new System.Drawing.Point(0, 0);
            this.labelNenhum.Name = "labelNenhum";
            this.labelNenhum.Size = new System.Drawing.Size(623, 287);
            this.labelNenhum.TabIndex = 8;
            this.labelNenhum.Text = "Não há informações";
            this.labelNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FormPesquisaClube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 390);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaClube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Clube";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaClube_KeyDown);
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClube)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Panel panelCenter;
        private DevExpress.XtraGrid.GridControl gridControlClube;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClube;
        private System.Windows.Forms.Label labelNenhum;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelNadaEncontrado;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtBoxDescricao;
        private System.Windows.Forms.Label labelPesquisar;
    }
}