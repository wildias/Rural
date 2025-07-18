namespace Rural.Dialogos
{
    partial class MensagemGPC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSim = new System.Windows.Forms.Button();
            this.ButtonNao = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelMensagem = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PictureBoxIxon = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIxon)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSim
            // 
            this.ButtonSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSim.AutoSize = true;
            this.ButtonSim.BackColor = System.Drawing.Color.White;
            this.ButtonSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ButtonSim.FlatAppearance.BorderSize = 0;
            this.ButtonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSim.Font = new System.Drawing.Font("Segoe WP", 9.5F);
            this.ButtonSim.ForeColor = System.Drawing.Color.IndianRed;
            this.ButtonSim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSim.Location = new System.Drawing.Point(14, 148);
            this.ButtonSim.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSim.MinimumSize = new System.Drawing.Size(111, 37);
            this.ButtonSim.Name = "ButtonSim";
            this.ButtonSim.Size = new System.Drawing.Size(111, 37);
            this.ButtonSim.TabIndex = 1;
            this.ButtonSim.TabStop = false;
            this.ButtonSim.Text = "Sim";
            this.ButtonSim.UseVisualStyleBackColor = false;
            this.ButtonSim.Click += new System.EventHandler(this.ButtonSim_Click);
            this.ButtonSim.Enter += new System.EventHandler(this.ButtonSim_Enter);
            // 
            // ButtonNao
            // 
            this.ButtonNao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonNao.AutoSize = true;
            this.ButtonNao.BackColor = System.Drawing.Color.White;
            this.ButtonNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonNao.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ButtonNao.FlatAppearance.BorderSize = 0;
            this.ButtonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNao.Font = new System.Drawing.Font("Segoe WP", 9.5F);
            this.ButtonNao.ForeColor = System.Drawing.Color.IndianRed;
            this.ButtonNao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNao.Location = new System.Drawing.Point(166, 148);
            this.ButtonNao.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonNao.MinimumSize = new System.Drawing.Size(111, 37);
            this.ButtonNao.Name = "ButtonNao";
            this.ButtonNao.Size = new System.Drawing.Size(111, 37);
            this.ButtonNao.TabIndex = 2;
            this.ButtonNao.TabStop = false;
            this.ButtonNao.Text = "Não";
            this.ButtonNao.UseVisualStyleBackColor = false;
            this.ButtonNao.Click += new System.EventHandler(this.ButtonNao_Click);
            this.ButtonNao.Enter += new System.EventHandler(this.ButtonNao_Enter);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.BackColor = System.Drawing.Color.White;
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe WP", 9.5F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(314, 149);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.MinimumSize = new System.Drawing.Size(111, 37);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(111, 37);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.TabStop = false;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.ButtonCancel.Enter += new System.EventHandler(this.ButtonCancel_Enter);
            // 
            // LabelMensagem
            // 
            this.LabelMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMensagem.Font = new System.Drawing.Font("Segoe WP", 9F);
            this.LabelMensagem.ForeColor = System.Drawing.Color.White;
            this.LabelMensagem.Location = new System.Drawing.Point(110, 14);
            this.LabelMensagem.Name = "LabelMensagem";
            this.LabelMensagem.Size = new System.Drawing.Size(315, 122);
            this.LabelMensagem.TabIndex = 0;
            this.LabelMensagem.Text = "ERRO";
            this.LabelMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.IndianRed;
            this.PanelPrincipal.Controls.Add(this.ButtonSim);
            this.PanelPrincipal.Controls.Add(this.ButtonNao);
            this.PanelPrincipal.Controls.Add(this.PictureBoxIxon);
            this.PanelPrincipal.Controls.Add(this.ButtonCancel);
            this.PanelPrincipal.Controls.Add(this.LabelMensagem);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(433, 195);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // PictureBoxIxon
            // 
            this.PictureBoxIxon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxIxon.BackgroundImage = global::Rural.Dialogos.Properties.Resources.IconeBrancoMessageboxError;
            this.PictureBoxIxon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxIxon.Location = new System.Drawing.Point(14, 14);
            this.PictureBoxIxon.Name = "PictureBoxIxon";
            this.PictureBoxIxon.Padding = new System.Windows.Forms.Padding(23);
            this.PictureBoxIxon.Size = new System.Drawing.Size(89, 122);
            this.PictureBoxIxon.TabIndex = 2;
            this.PictureBoxIxon.TabStop = false;
            // 
            // MensagemGPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 195);
            this.Controls.Add(this.PanelPrincipal);
            this.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensagemGPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MensagemGPC_KeyDown);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIxon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButtonSim;
        public System.Windows.Forms.Button ButtonNao;
        public System.Windows.Forms.Button ButtonCancel;
        public System.Windows.Forms.Label LabelMensagem;
        public System.Windows.Forms.Panel PanelPrincipal;
        public System.Windows.Forms.PictureBox PictureBoxIxon;
    }
}

