namespace Rural.Telas.Cadastro.Campeonato
{
    partial class FormCadCampeonato
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
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            panelBottom = new Panel();
            btnSalvar = new Button();
            button2 = new Button();
            btnPesquisar = new Button();
            btnSair = new Button();
            panelTop = new Panel();
            pictureBoxLogoTela = new PictureBox();
            pictureBoxLogo = new PictureBox();
            panelPrincipal = new Panel();
            panelInformacoes = new Panel();
            labelDescricao = new Label();
            textBoxDescricao = new TextBox();
            groupBoxInfo = new GroupBox();
            textBoxDataInicio = new TextBox();
            textBoxDataFinal = new TextBox();
            labelDataInicio = new Label();
            labelDataFinal = new Label();
            BtnFinalizar = new Button();
            btnIniciar = new Button();
            tableLayoutPanelPrincipal.SuspendLayout();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoTela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelPrincipal.SuspendLayout();
            panelInformacoes.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.ColumnCount = 1;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Controls.Add(panelBottom, 0, 2);
            tableLayoutPanelPrincipal.Controls.Add(panelTop, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(panelPrincipal, 0, 1);
            tableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new Point(0, 0);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.RowCount = 3;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelPrincipal.Size = new Size(702, 397);
            tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnSalvar);
            panelBottom.Controls.Add(button2);
            panelBottom.Controls.Add(btnPesquisar);
            panelBottom.Controls.Add(btnSair);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(3, 320);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(5);
            panelBottom.Size = new Size(696, 74);
            panelBottom.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(34, 160, 133);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe WP", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Image = Properties.Resources.IconOk3;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(551, 11);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(137, 52);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar [F5]";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe WP", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.IconNovo11;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(408, 11);
            button2.Name = "button2";
            button2.Size = new Size(137, 52);
            button2.TabIndex = 2;
            button2.Text = "Novo [F3]";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(41, 128, 185);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe WP", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Image = Properties.Resources.IconPesquisarBranco;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(265, 11);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(137, 52);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar [F2]";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(192, 63, 66);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe WP", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Image = Properties.Resources.IconRemove11;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(9, 11);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(137, 52);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair [Esc]";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(34, 160, 133);
            panelTop.Controls.Add(pictureBoxLogoTela);
            panelTop.Controls.Add(pictureBoxLogo);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(696, 74);
            panelTop.TabIndex = 0;
            // 
            // pictureBoxLogoTela
            // 
            pictureBoxLogoTela.BackgroundImage = Properties.Resources.iconTrofeu64x64Branco;
            pictureBoxLogoTela.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxLogoTela.Location = new Point(2, 0);
            pictureBoxLogoTela.Name = "pictureBoxLogoTela";
            pictureBoxLogoTela.Size = new Size(100, 74);
            pictureBoxLogoTela.TabIndex = 1;
            pictureBoxLogoTela.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = Properties.Resources.logoFutManagerBranca;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(595, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 74);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(panelInformacoes);
            panelPrincipal.Controls.Add(groupBoxInfo);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(3, 83);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(696, 231);
            panelPrincipal.TabIndex = 2;
            // 
            // panelInformacoes
            // 
            panelInformacoes.Controls.Add(btnIniciar);
            panelInformacoes.Controls.Add(BtnFinalizar);
            panelInformacoes.Controls.Add(labelDataFinal);
            panelInformacoes.Controls.Add(labelDataInicio);
            panelInformacoes.Controls.Add(textBoxDataFinal);
            panelInformacoes.Controls.Add(textBoxDataInicio);
            panelInformacoes.Controls.Add(labelDescricao);
            panelInformacoes.Controls.Add(textBoxDescricao);
            panelInformacoes.Location = new Point(9, 6);
            panelInformacoes.Name = "panelInformacoes";
            panelInformacoes.Size = new Size(678, 125);
            panelInformacoes.TabIndex = 2;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Segoe WP", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.Location = new Point(7, 7);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(123, 17);
            labelDescricao.TabIndex = 1;
            labelDescricao.Text = "Nome Campeonato";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Font = new Font("Segoe WP", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescricao.Location = new Point(7, 27);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(649, 24);
            textBoxDescricao.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Location = new Point(9, 137);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(678, 89);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Informações Adicionais";
            // 
            // textBoxDataInicio
            // 
            textBoxDataInicio.Font = new Font("Segoe WP", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDataInicio.Location = new Point(7, 89);
            textBoxDataInicio.Name = "textBoxDataInicio";
            textBoxDataInicio.Size = new Size(154, 24);
            textBoxDataInicio.TabIndex = 2;
            // 
            // textBoxDataFinal
            // 
            textBoxDataFinal.Font = new Font("Segoe WP", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDataFinal.Location = new Point(178, 89);
            textBoxDataFinal.Name = "textBoxDataFinal";
            textBoxDataFinal.Size = new Size(154, 24);
            textBoxDataFinal.TabIndex = 3;
            // 
            // labelDataInicio
            // 
            labelDataInicio.AutoSize = true;
            labelDataInicio.Font = new Font("Segoe WP", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataInicio.Location = new Point(7, 69);
            labelDataInicio.Name = "labelDataInicio";
            labelDataInicio.Size = new Size(71, 17);
            labelDataInicio.TabIndex = 4;
            labelDataInicio.Text = "Data Inicial";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Font = new Font("Segoe WP", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataFinal.Location = new Point(178, 69);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(65, 17);
            labelDataFinal.TabIndex = 5;
            labelDataFinal.Text = "Data Final";
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.BackColor = Color.FromArgb(34, 160, 133);
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Segoe WP", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFinalizar.ForeColor = Color.White;
            BtnFinalizar.Image = Properties.Resources.IconOk3;
            BtnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFinalizar.Location = new Point(519, 82);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(137, 34);
            BtnFinalizar.TabIndex = 6;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.TextAlign = ContentAlignment.MiddleRight;
            BtnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(41, 128, 185);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe WP", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Image = Properties.Resources.IconOk3;
            btnIniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciar.Location = new Point(361, 82);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(137, 34);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextAlign = ContentAlignment.MiddleRight;
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // FormCadCampeonato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 397);
            Controls.Add(tableLayoutPanelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "FormCadCampeonato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Campeonato";
            tableLayoutPanelPrincipal.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoTela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelInformacoes.ResumeLayout(false);
            panelInformacoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelPrincipal;
        private Panel panelBottom;
        private Panel panelTop;
        private Panel panelPrincipal;
        private Button btnSair;
        private Button btnSalvar;
        private Button button2;
        private Button btnPesquisar;
        private PictureBox pictureBoxLogoTela;
        private PictureBox pictureBoxLogo;
        private GroupBox groupBoxInfo;
        private Panel panelInformacoes;
        private Label labelDescricao;
        private TextBox textBoxDescricao;
        private Label labelDataFinal;
        private Label labelDataInicio;
        private TextBox textBoxDataFinal;
        private TextBox textBoxDataInicio;
        private Button BtnFinalizar;
        private Button btnIniciar;
    }
}