using System.Drawing;
using System.Windows.Forms;

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
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxLogoTela = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelInformacoes = new System.Windows.Forms.Panel();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelPrincipal, 0, 1);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 3;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(602, 291);
            this.tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnSalvar);
            this.panelBottom.Controls.Add(this.btnNovo);
            this.panelBottom.Controls.Add(this.btnPesquisar);
            this.panelBottom.Controls.Add(this.btnSair);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 225);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(4);
            this.panelBottom.Size = new System.Drawing.Size(596, 63);
            this.panelBottom.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe WP", 11.25F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::Rural.Telas.Properties.Resources.IconOk3;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(472, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 45);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar [F5]";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe WP", 11.25F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = global::Rural.Telas.Properties.Resources.IconNovo11;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(350, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 45);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo [F3]";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe WP", 11.25F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Rural.Telas.Properties.Resources.IconPesquisarBranco;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(214, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 45);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar [F2]";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe WP", 11.25F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::Rural.Telas.Properties.Resources.IconRemove11;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(8, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 45);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair [Esc]";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelTop.Controls.Add(this.pictureBoxLogoTela);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(596, 63);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBoxLogoTela
            // 
            this.pictureBoxLogoTela.BackgroundImage = global::Rural.Telas.Properties.Resources.iconTrofeu64x64Branco;
            this.pictureBoxLogoTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogoTela.Location = new System.Drawing.Point(2, 0);
            this.pictureBoxLogoTela.Name = "pictureBoxLogoTela";
            this.pictureBoxLogoTela.Size = new System.Drawing.Size(86, 64);
            this.pictureBoxLogoTela.TabIndex = 1;
            this.pictureBoxLogoTela.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Rural.Telas.Properties.Resources.logoFutManagerBranca;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(510, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(86, 64);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelInformacoes);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(3, 72);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(596, 147);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelInformacoes
            // 
            this.panelInformacoes.Controls.Add(this.labelDataFinal);
            this.panelInformacoes.Controls.Add(this.labelDataInicio);
            this.panelInformacoes.Controls.Add(this.labelDescricao);
            this.panelInformacoes.Controls.Add(this.textBoxDescricao);
            this.panelInformacoes.Location = new System.Drawing.Point(8, 5);
            this.panelInformacoes.Name = "panelInformacoes";
            this.panelInformacoes.Size = new System.Drawing.Size(581, 126);
            this.panelInformacoes.TabIndex = 2;
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Font = new System.Drawing.Font("Segoe WP", 9.75F);
            this.labelDataFinal.Location = new System.Drawing.Point(153, 60);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(65, 17);
            this.labelDataFinal.TabIndex = 5;
            this.labelDataFinal.Text = "Data Final";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Font = new System.Drawing.Font("Segoe WP", 9.75F);
            this.labelDataInicio.Location = new System.Drawing.Point(6, 60);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(71, 17);
            this.labelDataInicio.TabIndex = 4;
            this.labelDataInicio.Text = "Data Inicial";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Segoe WP", 9.75F);
            this.labelDescricao.Location = new System.Drawing.Point(6, 6);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(123, 17);
            this.labelDescricao.TabIndex = 1;
            this.labelDescricao.Text = "Nome Campeonato";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Segoe WP", 9.25F);
            this.textBoxDescricao.Location = new System.Drawing.Point(6, 23);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(557, 24);
            this.textBoxDescricao.TabIndex = 0;
            // 
            // FormCadCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 291);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormCadCampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Campeonato";
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelInformacoes.ResumeLayout(false);
            this.panelInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelPrincipal;
        private Panel panelBottom;
        private Panel panelTop;
        private Panel panelPrincipal;
        private Button btnSair;
        private Button btnSalvar;
        private Button btnNovo;
        private Button btnPesquisar;
        private PictureBox pictureBoxLogoTela;
        private PictureBox pictureBoxLogo;
        private Panel panelInformacoes;
        private Label labelDescricao;
        private TextBox textBoxDescricao;
        private Label labelDataFinal;
        private Label labelDataInicio;
    }
}