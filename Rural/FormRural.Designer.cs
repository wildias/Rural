namespace Rural
{
    partial class FormRural
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnRelatorios = new Button();
            btnCadastro = new Button();
            btnInicio = new Button();
            pictureBoxLogo = new PictureBox();
            panelCenter = new Panel();
            btnEstadio = new Button();
            btnJogador = new Button();
            btnClube = new Button();
            btnCampeonato = new Button();
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            panelBottom = new Panel();
            labelInformativa = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelCenter.SuspendLayout();
            tableLayoutPanelPrincipal.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(34, 160, 133);
            panelTop.Controls.Add(btnRelatorios);
            panelTop.Controls.Add(btnCadastro);
            panelTop.Controls.Add(btnInicio);
            panelTop.Controls.Add(pictureBoxLogo);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(917, 94);
            panelTop.TabIndex = 0;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.FromArgb(34, 160, 133);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Image = Properties.Resources.IconeRelatorio;
            btnRelatorios.Location = new Point(206, 0);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(101, 94);
            btnRelatorios.TabIndex = 3;
            btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(34, 160, 133);
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Image = Properties.Resources.IconeCadastros;
            btnCadastro.Location = new Point(103, 0);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(101, 94);
            btnCadastro.TabIndex = 2;
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(34, 160, 133);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = Properties.Resources.IconeInicio;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(101, 94);
            btnInicio.TabIndex = 1;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.logoFutManagerBranca;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(813, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(99, 88);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(btnEstadio);
            panelCenter.Controls.Add(btnJogador);
            panelCenter.Controls.Add(btnClube);
            panelCenter.Controls.Add(btnCampeonato);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(3, 103);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(917, 359);
            panelCenter.TabIndex = 1;
            // 
            // btnEstadio
            // 
            btnEstadio.BackColor = SystemColors.Control;
            btnEstadio.FlatStyle = FlatStyle.Flat;
            btnEstadio.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstadio.ForeColor = Color.Black;
            btnEstadio.Image = Properties.Resources.iconEstadio64x64;
            btnEstadio.Location = new Point(393, 4);
            btnEstadio.Name = "btnEstadio";
            btnEstadio.Size = new Size(124, 123);
            btnEstadio.TabIndex = 6;
            btnEstadio.Text = "Estádio";
            btnEstadio.TextAlign = ContentAlignment.BottomCenter;
            btnEstadio.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEstadio.UseVisualStyleBackColor = false;
            btnEstadio.Visible = false;
            // 
            // btnJogador
            // 
            btnJogador.BackColor = SystemColors.Control;
            btnJogador.FlatStyle = FlatStyle.Flat;
            btnJogador.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogador.ForeColor = Color.Black;
            btnJogador.Image = Properties.Resources.iconJogador64x64;
            btnJogador.Location = new Point(263, 4);
            btnJogador.Name = "btnJogador";
            btnJogador.Size = new Size(124, 123);
            btnJogador.TabIndex = 5;
            btnJogador.Text = "Jogador";
            btnJogador.TextAlign = ContentAlignment.BottomCenter;
            btnJogador.TextImageRelation = TextImageRelation.ImageAboveText;
            btnJogador.UseVisualStyleBackColor = false;
            btnJogador.Visible = false;
            // 
            // btnClube
            // 
            btnClube.BackColor = SystemColors.Control;
            btnClube.FlatStyle = FlatStyle.Flat;
            btnClube.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClube.ForeColor = Color.Black;
            btnClube.Image = Properties.Resources.iconEscudo64x64;
            btnClube.Location = new Point(133, 4);
            btnClube.Name = "btnClube";
            btnClube.Size = new Size(124, 123);
            btnClube.TabIndex = 4;
            btnClube.Text = "Clube";
            btnClube.TextAlign = ContentAlignment.BottomCenter;
            btnClube.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClube.UseVisualStyleBackColor = false;
            btnClube.Visible = false;
            // 
            // btnCampeonato
            // 
            btnCampeonato.BackColor = SystemColors.Control;
            btnCampeonato.FlatStyle = FlatStyle.Flat;
            btnCampeonato.Font = new Font("Segoe WP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCampeonato.ForeColor = Color.Black;
            btnCampeonato.Image = Properties.Resources.iconTrofeu64x64;
            btnCampeonato.Location = new Point(3, 4);
            btnCampeonato.Name = "btnCampeonato";
            btnCampeonato.Size = new Size(124, 123);
            btnCampeonato.TabIndex = 3;
            btnCampeonato.Text = "Campeonato";
            btnCampeonato.TextAlign = ContentAlignment.BottomCenter;
            btnCampeonato.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCampeonato.UseVisualStyleBackColor = false;
            btnCampeonato.Visible = false;
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.ColumnCount = 1;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Controls.Add(panelCenter, 0, 1);
            tableLayoutPanelPrincipal.Controls.Add(panelTop, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(panelBottom, 0, 2);
            tableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new Point(0, 0);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.RowCount = 3;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelPrincipal.Size = new Size(923, 545);
            tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(15, 15, 15);
            panelBottom.Controls.Add(labelInformativa);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(3, 468);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(917, 74);
            panelBottom.TabIndex = 2;
            // 
            // labelInformativa
            // 
            labelInformativa.AutoSize = true;
            labelInformativa.Font = new Font("Segoe WP", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInformativa.ForeColor = Color.White;
            labelInformativa.Location = new Point(245, 20);
            labelInformativa.Name = "labelInformativa";
            labelInformativa.Size = new Size(382, 36);
            labelInformativa.TabIndex = 0;
            labelInformativa.Text = "Campeonato em Andamento";
            // 
            // FormRural
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(tableLayoutPanelPrincipal);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormRural";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fut Manager";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelCenter.ResumeLayout(false);
            tableLayoutPanelPrincipal.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureBoxLogo;
        private Panel panelCenter;
        private TableLayoutPanel tableLayoutPanelPrincipal;
        private Button btnInicio;
        private Button btnCadastro;
        private Button btnRelatorios;
        private Panel panelBottom;
        private Button btnEstadio;
        private Button btnJogador;
        private Button btnClube;
        private Button btnCampeonato;
        private Label labelInformativa;
    }
}
