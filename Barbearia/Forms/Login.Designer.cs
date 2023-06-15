namespace LoginForm
{
    partial class LoginSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSistema));
            this.label1 = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblUtilizador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.linkLabelRecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.LblTexto = new System.Windows.Forms.Label();
            this.BtnContate = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUtilizador1 = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.usuariosTableAdapter1 = new Barbearia.DataBase.BdoDataSetTableAdapters.UsuariosTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.White;
            this.LblLogin.Location = new System.Drawing.Point(171, 127);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(118, 46);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "Login";
            // 
            // LblUtilizador
            // 
            this.LblUtilizador.AutoSize = true;
            this.LblUtilizador.BackColor = System.Drawing.Color.Transparent;
            this.LblUtilizador.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUtilizador.ForeColor = System.Drawing.Color.White;
            this.LblUtilizador.Location = new System.Drawing.Point(159, 204);
            this.LblUtilizador.Name = "LblUtilizador";
            this.LblUtilizador.Size = new System.Drawing.Size(143, 35);
            this.LblUtilizador.TabIndex = 2;
            this.LblUtilizador.Text = "Utilizador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(181, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(140, 350);
            this.BtnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(171, 44);
            this.BtnEntrar.TabIndex = 6;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // linkLabelRecuperarSenha
            // 
            this.linkLabelRecuperarSenha.AutoSize = true;
            this.linkLabelRecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRecuperarSenha.LinkColor = System.Drawing.Color.White;
            this.linkLabelRecuperarSenha.Location = new System.Drawing.Point(165, 405);
            this.linkLabelRecuperarSenha.Name = "linkLabelRecuperarSenha";
            this.linkLabelRecuperarSenha.Size = new System.Drawing.Size(113, 16);
            this.linkLabelRecuperarSenha.TabIndex = 7;
            this.linkLabelRecuperarSenha.TabStop = true;
            this.linkLabelRecuperarSenha.Text = "Recuperar Senha";
            this.linkLabelRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecuperarSenha_LinkClicked);
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.LblCadastro.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.ForeColor = System.Drawing.Color.White;
            this.LblCadastro.Location = new System.Drawing.Point(568, 127);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(226, 46);
            this.LblCadastro.TabIndex = 8;
            this.LblCadastro.Text = "Cadastre-se";
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.BackColor = System.Drawing.Color.Transparent;
            this.LblTexto.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.Color.White;
            this.LblTexto.Location = new System.Drawing.Point(557, 215);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(251, 63);
            this.LblTexto.TabIndex = 9;
            this.LblTexto.Text = "Se quer utilizar nosso sistema, \r\nclique no botão a baixo e entre\r\n em contato co" +
    "nosco.";
            // 
            // BtnContate
            // 
            this.BtnContate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnContate.FlatAppearance.BorderSize = 0;
            this.BtnContate.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContate.ForeColor = System.Drawing.Color.White;
            this.BtnContate.Location = new System.Drawing.Point(603, 350);
            this.BtnContate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnContate.Name = "BtnContate";
            this.BtnContate.Size = new System.Drawing.Size(171, 44);
            this.BtnContate.TabIndex = 10;
            this.BtnContate.Text = "Contate-nos";
            this.BtnContate.UseVisualStyleBackColor = false;
            this.BtnContate.Click += new System.EventHandler(this.BtnContate_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(140, 311);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(171, 22);
            this.textBoxSenha.TabIndex = 5;
            // 
            // textBoxUtilizador1
            // 
            this.textBoxUtilizador1.Location = new System.Drawing.Point(140, 247);
            this.textBoxUtilizador1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUtilizador1.Name = "textBoxUtilizador1";
            this.textBoxUtilizador1.Size = new System.Drawing.Size(171, 22);
            this.textBoxUtilizador1.TabIndex = 11;
            this.textBoxUtilizador1.TextChanged += new System.EventHandler(this.textBoxUtilizador1_TextChanged);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(360, 473);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(171, 44);
            this.BtnSair.TabIndex = 12;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // LoginSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 550);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.textBoxUtilizador1);
            this.Controls.Add(this.BtnContate);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.linkLabelRecuperarSenha);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblUtilizador);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblUtilizador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.LinkLabel linkLabelRecuperarSenha;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Button BtnContate;

        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUtilizador1;
        private System.Windows.Forms.Button BtnSair;
        private Barbearia.DataBase.BdoDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
    }
}

