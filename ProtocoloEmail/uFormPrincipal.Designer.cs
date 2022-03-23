namespace ProtocoloEmail
{
    partial class email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(email));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnviarEmail = new System.Windows.Forms.CheckBox();
            this.TextBoxEmailDest = new System.Windows.Forms.TextBox();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.LabelEmailDest = new System.Windows.Forms.Label();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.LabelMensagem = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.TextBoxMensagem = new System.Windows.Forms.TextBox();
            this.TextBoxAssunto = new System.Windows.Forms.TextBox();
            this.LabelAssunto = new System.Windows.Forms.Label();
            this.TextBoxEmailRem = new System.Windows.Forms.TextBox();
            this.LabelEmailRem = new System.Windows.Forms.Label();
            this.Remetente = new System.Windows.Forms.Label();
            this.TextBoxRequisicoes = new System.Windows.Forms.TextBox();
            this.LabelRequisicoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uMenu = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruçõesDeUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.uMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.checkBoxEnviarEmail);
            this.groupBox1.Controls.Add(this.TextBoxEmailDest);
            this.groupBox1.Controls.Add(this.TextBoxSenha);
            this.groupBox1.Controls.Add(this.LabelEmailDest);
            this.groupBox1.Controls.Add(this.BotaoEnviar);
            this.groupBox1.Controls.Add(this.LabelMensagem);
            this.groupBox1.Controls.Add(this.LabelSenha);
            this.groupBox1.Controls.Add(this.TextBoxMensagem);
            this.groupBox1.Controls.Add(this.TextBoxAssunto);
            this.groupBox1.Controls.Add(this.LabelAssunto);
            this.groupBox1.Controls.Add(this.TextBoxEmailRem);
            this.groupBox1.Controls.Add(this.LabelEmailRem);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(28, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(397, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxEnviarEmail
            // 
            this.checkBoxEnviarEmail.AutoSize = true;
            this.checkBoxEnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.checkBoxEnviarEmail.Location = new System.Drawing.Point(29, 254);
            this.checkBoxEnviarEmail.Name = "checkBoxEnviarEmail";
            this.checkBoxEnviarEmail.Size = new System.Drawing.Size(337, 24);
            this.checkBoxEnviarEmail.TabIndex = 5;
            this.checkBoxEnviarEmail.Text = "Enviar o e-mail de forma real ao destinatário";
            this.checkBoxEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // TextBoxEmailDest
            // 
            this.TextBoxEmailDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.TextBoxEmailDest.ForeColor = System.Drawing.Color.White;
            this.TextBoxEmailDest.Location = new System.Drawing.Point(9, 160);
            this.TextBoxEmailDest.Name = "TextBoxEmailDest";
            this.TextBoxEmailDest.Size = new System.Drawing.Size(385, 20);
            this.TextBoxEmailDest.TabIndex = 3;
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.TextBoxSenha.ForeColor = System.Drawing.Color.White;
            this.TextBoxSenha.Location = new System.Drawing.Point(6, 105);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(385, 20);
            this.TextBoxSenha.TabIndex = 2;
            this.TextBoxSenha.UseSystemPasswordChar = true;
            // 
            // LabelEmailDest
            // 
            this.LabelEmailDest.AutoSize = true;
            this.LabelEmailDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailDest.ForeColor = System.Drawing.Color.White;
            this.LabelEmailDest.Location = new System.Drawing.Point(127, 137);
            this.LabelEmailDest.Name = "LabelEmailDest";
            this.LabelEmailDest.Size = new System.Drawing.Size(140, 20);
            this.LabelEmailDest.TabIndex = 10;
            this.LabelEmailDest.Text = "E-mail destinatário";
            // 
            // BotaoEnviar
            // 
            this.BotaoEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.BotaoEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEnviar.ForeColor = System.Drawing.Color.White;
            this.BotaoEnviar.Location = new System.Drawing.Point(128, 511);
            this.BotaoEnviar.Name = "BotaoEnviar";
            this.BotaoEnviar.Size = new System.Drawing.Size(135, 41);
            this.BotaoEnviar.TabIndex = 99;
            this.BotaoEnviar.Text = "Enviar";
            this.BotaoEnviar.UseVisualStyleBackColor = false;
            this.BotaoEnviar.Click += new System.EventHandler(this.BotaoEnviar_Click);
            // 
            // LabelMensagem
            // 
            this.LabelMensagem.AutoSize = true;
            this.LabelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensagem.ForeColor = System.Drawing.Color.White;
            this.LabelMensagem.Location = new System.Drawing.Point(148, 290);
            this.LabelMensagem.Name = "LabelMensagem";
            this.LabelMensagem.Size = new System.Drawing.Size(88, 20);
            this.LabelMensagem.TabIndex = 8;
            this.LabelMensagem.Text = "Mensagem";
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.ForeColor = System.Drawing.Color.White;
            this.LabelSenha.Location = new System.Drawing.Point(99, 80);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(201, 20);
            this.LabelSenha.TabIndex = 10;
            this.LabelSenha.Text = "Senha do e-mail remetente";
            // 
            // TextBoxMensagem
            // 
            this.TextBoxMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.TextBoxMensagem.ForeColor = System.Drawing.Color.White;
            this.TextBoxMensagem.Location = new System.Drawing.Point(6, 313);
            this.TextBoxMensagem.Multiline = true;
            this.TextBoxMensagem.Name = "TextBoxMensagem";
            this.TextBoxMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMensagem.Size = new System.Drawing.Size(385, 189);
            this.TextBoxMensagem.TabIndex = 6;
            // 
            // TextBoxAssunto
            // 
            this.TextBoxAssunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.TextBoxAssunto.ForeColor = System.Drawing.Color.White;
            this.TextBoxAssunto.Location = new System.Drawing.Point(6, 215);
            this.TextBoxAssunto.Name = "TextBoxAssunto";
            this.TextBoxAssunto.Size = new System.Drawing.Size(385, 20);
            this.TextBoxAssunto.TabIndex = 4;
            // 
            // LabelAssunto
            // 
            this.LabelAssunto.AutoSize = true;
            this.LabelAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAssunto.ForeColor = System.Drawing.Color.White;
            this.LabelAssunto.Location = new System.Drawing.Point(159, 192);
            this.LabelAssunto.Name = "LabelAssunto";
            this.LabelAssunto.Size = new System.Drawing.Size(68, 20);
            this.LabelAssunto.TabIndex = 2;
            this.LabelAssunto.Text = "Assunto";
            // 
            // TextBoxEmailRem
            // 
            this.TextBoxEmailRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.TextBoxEmailRem.ForeColor = System.Drawing.Color.White;
            this.TextBoxEmailRem.Location = new System.Drawing.Point(6, 52);
            this.TextBoxEmailRem.Name = "TextBoxEmailRem";
            this.TextBoxEmailRem.Size = new System.Drawing.Size(385, 20);
            this.TextBoxEmailRem.TabIndex = 1;
            // 
            // LabelEmailRem
            // 
            this.LabelEmailRem.AutoSize = true;
            this.LabelEmailRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailRem.ForeColor = System.Drawing.Color.White;
            this.LabelEmailRem.Location = new System.Drawing.Point(129, 27);
            this.LabelEmailRem.Name = "LabelEmailRem";
            this.LabelEmailRem.Size = new System.Drawing.Size(130, 20);
            this.LabelEmailRem.TabIndex = 0;
            this.LabelEmailRem.Text = "E-mail remetente";
            // 
            // Remetente
            // 
            this.Remetente.AutoSize = true;
            this.Remetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remetente.ForeColor = System.Drawing.Color.White;
            this.Remetente.Location = new System.Drawing.Point(122, 43);
            this.Remetente.Name = "Remetente";
            this.Remetente.Size = new System.Drawing.Size(195, 29);
            this.Remetente.TabIndex = 1;
            this.Remetente.Text = "Dados do envio";
            // 
            // TextBoxRequisicoes
            // 
            this.TextBoxRequisicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.TextBoxRequisicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRequisicoes.ForeColor = System.Drawing.Color.White;
            this.TextBoxRequisicoes.Location = new System.Drawing.Point(462, 86);
            this.TextBoxRequisicoes.Multiline = true;
            this.TextBoxRequisicoes.Name = "TextBoxRequisicoes";
            this.TextBoxRequisicoes.ReadOnly = true;
            this.TextBoxRequisicoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxRequisicoes.Size = new System.Drawing.Size(452, 551);
            this.TextBoxRequisicoes.TabIndex = 99999;
            this.TextBoxRequisicoes.TabStop = false;
            this.TextBoxRequisicoes.TextChanged += new System.EventHandler(this.TextBoxRequisicoes_TextChanged);
            // 
            // LabelRequisicoes
            // 
            this.LabelRequisicoes.AutoSize = true;
            this.LabelRequisicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRequisicoes.ForeColor = System.Drawing.Color.White;
            this.LabelRequisicoes.Location = new System.Drawing.Point(546, 48);
            this.LabelRequisicoes.Name = "LabelRequisicoes";
            this.LabelRequisicoes.Size = new System.Drawing.Size(276, 29);
            this.LabelRequisicoes.TabIndex = 5;
            this.LabelRequisicoes.Text = "Requisições protocolo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(463, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Snd: Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(807, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rcv: Receiver";
            // 
            // uMenu
            // 
            this.uMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.uMenu.Location = new System.Drawing.Point(0, 0);
            this.uMenu.Name = "uMenu";
            this.uMenu.Size = new System.Drawing.Size(943, 24);
            this.uMenu.TabIndex = 15;
            this.uMenu.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruçõesDeUsoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // instruçõesDeUsoToolStripMenuItem
            // 
            this.instruçõesDeUsoToolStripMenuItem.Name = "instruçõesDeUsoToolStripMenuItem";
            this.instruçõesDeUsoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.instruçõesDeUsoToolStripMenuItem.Text = "Instruções de uso";
            this.instruçõesDeUsoToolStripMenuItem.Click += new System.EventHandler(this.instruçõesDeUsoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(943, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelRequisicoes);
            this.Controls.Add(this.TextBoxRequisicoes);
            this.Controls.Add(this.Remetente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.uMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "email";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.uMenu.ResumeLayout(false);
            this.uMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Remetente;
        private System.Windows.Forms.TextBox TextBoxRequisicoes;
        private System.Windows.Forms.Label LabelRequisicoes;
        private System.Windows.Forms.Label LabelEmailRem;
        private System.Windows.Forms.TextBox TextBoxAssunto;
        private System.Windows.Forms.Label LabelAssunto;
        private System.Windows.Forms.TextBox TextBoxEmailRem;
        private System.Windows.Forms.Button BotaoEnviar;
        private System.Windows.Forms.Label LabelMensagem;
        private System.Windows.Forms.TextBox TextBoxMensagem;
        private System.Windows.Forms.TextBox TextBoxEmailDest;
        private System.Windows.Forms.Label LabelEmailDest;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.CheckBox checkBoxEnviarEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip uMenu;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruçõesDeUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

