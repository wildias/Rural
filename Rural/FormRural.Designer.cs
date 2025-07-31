using DevExpress.XtraEditors;

namespace Rural
{
    partial class FormRural
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRural));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.xtraTabControlPrincipal = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabInicio = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageCadastros = new DevExpress.XtraTab.XtraTabPage();
            this.tileControlCadastrosMenu = new DevExpress.XtraEditors.TileControl();
            this.tileGroupCadastros = new DevExpress.XtraEditors.TileGroup();
            this.tileItemCampeonato = new DevExpress.XtraEditors.TileItem();
            this.tileItemClube = new DevExpress.XtraEditors.TileItem();
            this.tileItemJogador = new DevExpress.XtraEditors.TileItem();
            this.tileItemEstadio = new DevExpress.XtraEditors.TileItem();
            this.xtraTabPageMovimentacoes = new DevExpress.XtraTab.XtraTabPage();
            this.tileControlRelatorioMenu = new DevExpress.XtraEditors.TileControl();
            this.tileGroupMovimentacoes = new DevExpress.XtraEditors.TileGroup();
            this.tileItemEntrada = new DevExpress.XtraEditors.TileItem();
            this.panelRodaPe = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPrincipal)).BeginInit();
            this.xtraTabControlPrincipal.SuspendLayout();
            this.xtraTabPageCadastros.SuspendLayout();
            this.xtraTabPageMovimentacoes.SuspendLayout();
            this.panelRodaPe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.panelPrincipal.Controls.Add(this.xtraTabControlPrincipal);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(984, 458);
            this.panelPrincipal.TabIndex = 1;
            // 
            // xtraTabControlPrincipal
            // 
            this.xtraTabControlPrincipal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.xtraTabControlPrincipal.Appearance.Options.UseBackColor = true;
            this.xtraTabControlPrincipal.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.xtraTabControlPrincipal.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabControlPrincipal.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabControlPrincipal.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControlPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControlPrincipal.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlPrincipal.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlPrincipal.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.xtraTabControlPrincipal.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.xtraTabControlPrincipal.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControlPrincipal.Name = "xtraTabControlPrincipal";
            this.xtraTabControlPrincipal.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabControlPrincipal.SelectedTabPage = this.xtraTabInicio;
            this.xtraTabControlPrincipal.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControlPrincipal.Size = new System.Drawing.Size(984, 458);
            this.xtraTabControlPrincipal.TabIndex = 11;
            this.xtraTabControlPrincipal.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabInicio,
            this.xtraTabPageCadastros,
            this.xtraTabPageMovimentacoes});
            this.xtraTabControlPrincipal.TabPageWidth = 110;
            // 
            // xtraTabInicio
            // 
            this.xtraTabInicio.Appearance.Header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabInicio.Appearance.Header.Options.UseBorderColor = true;
            this.xtraTabInicio.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control;
            this.xtraTabInicio.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xtraTabInicio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabInicio.ImageOptions.Image")));
            this.xtraTabInicio.Name = "xtraTabInicio";
            this.xtraTabInicio.Size = new System.Drawing.Size(984, 378);
            this.xtraTabInicio.Text = "Inicio";
            // 
            // xtraTabPageCadastros
            // 
            this.xtraTabPageCadastros.Appearance.Header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageCadastros.Appearance.Header.Options.UseBorderColor = true;
            this.xtraTabPageCadastros.Appearance.HeaderActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageCadastros.Appearance.HeaderActive.Options.UseBorderColor = true;
            this.xtraTabPageCadastros.Appearance.HeaderDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageCadastros.Appearance.HeaderDisabled.Options.UseBorderColor = true;
            this.xtraTabPageCadastros.Appearance.HeaderHotTracked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageCadastros.Appearance.HeaderHotTracked.Options.UseBorderColor = true;
            this.xtraTabPageCadastros.Appearance.PageClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageCadastros.Appearance.PageClient.Options.UseBorderColor = true;
            this.xtraTabPageCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xtraTabPageCadastros.Controls.Add(this.tileControlCadastrosMenu);
            this.xtraTabPageCadastros.ImageOptions.Image = global::Rural.Properties.Resources.IconeCadastros;
            this.xtraTabPageCadastros.Name = "xtraTabPageCadastros";
            this.xtraTabPageCadastros.Size = new System.Drawing.Size(984, 378);
            // 
            // tileControlCadastrosMenu
            // 
            this.tileControlCadastrosMenu.AllowDrag = false;
            this.tileControlCadastrosMenu.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileControlCadastrosMenu.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileControlCadastrosMenu.AppearanceItem.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tileControlCadastrosMenu.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileControlCadastrosMenu.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControlCadastrosMenu.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileControlCadastrosMenu.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControlCadastrosMenu.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileControlCadastrosMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tileControlCadastrosMenu.ColumnCount = 4;
            this.tileControlCadastrosMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControlCadastrosMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControlCadastrosMenu.Groups.Add(this.tileGroupCadastros);
            this.tileControlCadastrosMenu.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControlCadastrosMenu.Location = new System.Drawing.Point(0, 0);
            this.tileControlCadastrosMenu.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.tileControlCadastrosMenu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.tileControlCadastrosMenu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tileControlCadastrosMenu.MaxId = 34;
            this.tileControlCadastrosMenu.Name = "tileControlCadastrosMenu";
            this.tileControlCadastrosMenu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControlCadastrosMenu.Padding = new System.Windows.Forms.Padding(8);
            this.tileControlCadastrosMenu.SelectionColor = System.Drawing.Color.Empty;
            this.tileControlCadastrosMenu.Size = new System.Drawing.Size(984, 378);
            this.tileControlCadastrosMenu.TabIndex = 3;
            this.tileControlCadastrosMenu.Text = "menu";
            this.tileControlCadastrosMenu.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroupCadastros
            // 
            this.tileGroupCadastros.Items.Add(this.tileItemCampeonato);
            this.tileGroupCadastros.Items.Add(this.tileItemClube);
            this.tileGroupCadastros.Items.Add(this.tileItemJogador);
            this.tileGroupCadastros.Items.Add(this.tileItemEstadio);
            this.tileGroupCadastros.Name = "tileGroupCadastros";
            // 
            // tileItemCampeonato
            // 
            this.tileItemCampeonato.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileItemCampeonato.AppearanceItem.Normal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItemCampeonato.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileItemCampeonato.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemCampeonato.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemCampeonato.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement1.ImageOptions.Image = global::Rural.Properties.Resources.iconTrofeu64x64;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Campeonato";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItemCampeonato.Elements.Add(tileItemElement1);
            this.tileItemCampeonato.Id = 14;
            this.tileItemCampeonato.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemCampeonato.Name = "tileItemCampeonato";
            this.tileItemCampeonato.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItemCampeonato_ItemClick);
            // 
            // tileItemClube
            // 
            this.tileItemClube.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileItemClube.AppearanceItem.Normal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItemClube.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileItemClube.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemClube.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemClube.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement2.ImageOptions.Image = global::Rural.Properties.Resources.iconEscudo64x64;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Clube";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItemClube.Elements.Add(tileItemElement2);
            this.tileItemClube.Id = 15;
            this.tileItemClube.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemClube.Name = "tileItemClube";
            // 
            // tileItemJogador
            // 
            this.tileItemJogador.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileItemJogador.AppearanceItem.Normal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItemJogador.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileItemJogador.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemJogador.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemJogador.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement3.ImageOptions.Image = global::Rural.Properties.Resources.iconJogador64x64;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Jogador";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItemJogador.Elements.Add(tileItemElement3);
            this.tileItemJogador.Id = 16;
            this.tileItemJogador.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemJogador.Name = "tileItemJogador";
            // 
            // tileItemEstadio
            // 
            this.tileItemEstadio.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileItemEstadio.AppearanceItem.Normal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItemEstadio.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileItemEstadio.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemEstadio.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemEstadio.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement4.ImageOptions.Image = global::Rural.Properties.Resources.iconTrofeu64x64;
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Estádio";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItemEstadio.Elements.Add(tileItemElement4);
            this.tileItemEstadio.Id = 17;
            this.tileItemEstadio.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemEstadio.Name = "tileItemEstadio";
            // 
            // xtraTabPageMovimentacoes
            // 
            this.xtraTabPageMovimentacoes.Appearance.Header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageMovimentacoes.Appearance.Header.Options.UseBorderColor = true;
            this.xtraTabPageMovimentacoes.Appearance.HeaderActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageMovimentacoes.Appearance.HeaderActive.Options.UseBorderColor = true;
            this.xtraTabPageMovimentacoes.Appearance.HeaderDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageMovimentacoes.Appearance.HeaderDisabled.Options.UseBorderColor = true;
            this.xtraTabPageMovimentacoes.Appearance.HeaderHotTracked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xtraTabPageMovimentacoes.Appearance.HeaderHotTracked.Options.UseBorderColor = true;
            this.xtraTabPageMovimentacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xtraTabPageMovimentacoes.Controls.Add(this.tileControlRelatorioMenu);
            this.xtraTabPageMovimentacoes.ImageOptions.Image = global::Rural.Properties.Resources.IconeRelatorio;
            this.xtraTabPageMovimentacoes.Name = "xtraTabPageMovimentacoes";
            this.xtraTabPageMovimentacoes.Size = new System.Drawing.Size(984, 378);
            // 
            // tileControlRelatorioMenu
            // 
            this.tileControlRelatorioMenu.AllowDrag = false;
            this.tileControlRelatorioMenu.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileControlRelatorioMenu.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileControlRelatorioMenu.AppearanceItem.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tileControlRelatorioMenu.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileControlRelatorioMenu.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControlRelatorioMenu.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileControlRelatorioMenu.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControlRelatorioMenu.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileControlRelatorioMenu.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileControlRelatorioMenu.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileControlRelatorioMenu.AppearanceItem.Selected.Options.UseImage = true;
            this.tileControlRelatorioMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tileControlRelatorioMenu.ColumnCount = 4;
            this.tileControlRelatorioMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControlRelatorioMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControlRelatorioMenu.Groups.Add(this.tileGroupMovimentacoes);
            this.tileControlRelatorioMenu.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControlRelatorioMenu.Location = new System.Drawing.Point(0, 0);
            this.tileControlRelatorioMenu.LookAndFeel.SkinName = "DevExpress Style";
            this.tileControlRelatorioMenu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.tileControlRelatorioMenu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tileControlRelatorioMenu.MaxId = 34;
            this.tileControlRelatorioMenu.Name = "tileControlRelatorioMenu";
            this.tileControlRelatorioMenu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControlRelatorioMenu.Padding = new System.Windows.Forms.Padding(8);
            this.tileControlRelatorioMenu.SelectionColor = System.Drawing.Color.Empty;
            this.tileControlRelatorioMenu.Size = new System.Drawing.Size(984, 378);
            this.tileControlRelatorioMenu.TabIndex = 3;
            this.tileControlRelatorioMenu.Text = "tileControl2";
            this.tileControlRelatorioMenu.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroupMovimentacoes
            // 
            this.tileGroupMovimentacoes.Items.Add(this.tileItemEntrada);
            this.tileGroupMovimentacoes.Name = "tileGroupMovimentacoes";
            // 
            // tileItemEntrada
            // 
            this.tileItemEntrada.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tileItemEntrada.AppearanceItem.Normal.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tileItemEntrada.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileItemEntrada.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemEntrada.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemEntrada.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemEntrada.Elements.Add(tileItemElement5);
            this.tileItemEntrada.Id = 14;
            this.tileItemEntrada.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemEntrada.Name = "tileItemEntrada";
            // 
            // panelRodaPe
            // 
            this.panelRodaPe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelRodaPe.Controls.Add(this.pictureBoxLogo);
            this.panelRodaPe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodaPe.Location = new System.Drawing.Point(0, 458);
            this.panelRodaPe.Name = "panelRodaPe";
            this.panelRodaPe.Size = new System.Drawing.Size(984, 114);
            this.panelRodaPe.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Rural.Properties.Resources.logoFutManagerBranca;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(843, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(138, 113);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormRural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 572);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelRodaPe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRural";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUT MANAGER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPrincipal)).EndInit();
            this.xtraTabControlPrincipal.ResumeLayout(false);
            this.xtraTabPageCadastros.ResumeLayout(false);
            this.xtraTabPageMovimentacoes.ResumeLayout(false);
            this.panelRodaPe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlPrincipal;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCadastros;
        private DevExpress.XtraEditors.TileControl tileControlCadastrosMenu;
        private DevExpress.XtraEditors.TileGroup tileGroupCadastros;
        private DevExpress.XtraEditors.TileItem tileItemCampeonato;
        private DevExpress.XtraEditors.TileItem tileItemClube;
        private DevExpress.XtraEditors.TileItem tileItemJogador;
        private DevExpress.XtraEditors.TileItem tileItemEstadio;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMovimentacoes;
        private DevExpress.XtraEditors.TileControl tileControlRelatorioMenu;
        private DevExpress.XtraEditors.TileGroup tileGroupMovimentacoes;
        private DevExpress.XtraEditors.TileItem tileItemEntrada;
        private DevExpress.XtraTab.XtraTabPage xtraTabInicio;
        private System.Windows.Forms.Panel panelRodaPe;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}