namespace PROJECT_CRUD
{
    partial class F_Update
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
            this.lbl_update = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_senhaBD = new System.Windows.Forms.TextBox();
            this.txt_emailBD = new System.Windows.Forms.TextBox();
            this.txt_nomeBD = new System.Windows.Forms.TextBox();
            this.txt_codUsuarioBD = new System.Windows.Forms.TextBox();
            this.lbl_codUsuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.lbl_coduser = new System.Windows.Forms.Label();
            this.txt_codUsuario = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_update
            // 
            this.lbl_update.AutoSize = true;
            this.lbl_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update.Location = new System.Drawing.Point(74, 9);
            this.lbl_update.Name = "lbl_update";
            this.lbl_update.Size = new System.Drawing.Size(95, 30);
            this.lbl_update.TabIndex = 1;
            this.lbl_update.Text = "Update";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(202, 9);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(21, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "X";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txt_senhaBD
            // 
            this.txt_senhaBD.Location = new System.Drawing.Point(103, 214);
            this.txt_senhaBD.Name = "txt_senhaBD";
            this.txt_senhaBD.Size = new System.Drawing.Size(100, 20);
            this.txt_senhaBD.TabIndex = 28;
            this.txt_senhaBD.TextChanged += new System.EventHandler(this.txt_senhaBD_TextChanged);
            // 
            // txt_emailBD
            // 
            this.txt_emailBD.Location = new System.Drawing.Point(103, 188);
            this.txt_emailBD.Name = "txt_emailBD";
            this.txt_emailBD.Size = new System.Drawing.Size(100, 20);
            this.txt_emailBD.TabIndex = 27;
            this.txt_emailBD.TextChanged += new System.EventHandler(this.txt_emailBD_TextChanged);
            // 
            // txt_nomeBD
            // 
            this.txt_nomeBD.Location = new System.Drawing.Point(103, 162);
            this.txt_nomeBD.Name = "txt_nomeBD";
            this.txt_nomeBD.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeBD.TabIndex = 26;
            this.txt_nomeBD.TextChanged += new System.EventHandler(this.txt_nomeBD_TextChanged);
            // 
            // txt_codUsuarioBD
            // 
            this.txt_codUsuarioBD.Location = new System.Drawing.Point(103, 135);
            this.txt_codUsuarioBD.Name = "txt_codUsuarioBD";
            this.txt_codUsuarioBD.ReadOnly = true;
            this.txt_codUsuarioBD.Size = new System.Drawing.Size(100, 20);
            this.txt_codUsuarioBD.TabIndex = 25;
            this.txt_codUsuarioBD.TextChanged += new System.EventHandler(this.txt_codUsuarioBD_TextChanged);
            // 
            // lbl_codUsuario
            // 
            this.lbl_codUsuario.AutoSize = true;
            this.lbl_codUsuario.Location = new System.Drawing.Point(12, 142);
            this.lbl_codUsuario.Name = "lbl_codUsuario";
            this.lbl_codUsuario.Size = new System.Drawing.Size(85, 13);
            this.lbl_codUsuario.TabIndex = 24;
            this.lbl_codUsuario.Text = "Código Usuário: ";
            this.lbl_codUsuario.Click += new System.EventHandler(this.lbl_codUsuario_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(53, 221);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(44, 13);
            this.lbl_senha.TabIndex = 23;
            this.lbl_senha.Text = "Senha: ";
            this.lbl_senha.Click += new System.EventHandler(this.lbl_senha_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(59, 195);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 22;
            this.lbl_email.Text = "Email: ";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(56, 169);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome: ";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(12, 89);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(210, 37);
            this.btn_pesquisa.TabIndex = 20;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // lbl_coduser
            // 
            this.lbl_coduser.AutoSize = true;
            this.lbl_coduser.Location = new System.Drawing.Point(12, 44);
            this.lbl_coduser.Name = "lbl_coduser";
            this.lbl_coduser.Size = new System.Drawing.Size(95, 13);
            this.lbl_coduser.TabIndex = 19;
            this.lbl_coduser.Text = "Código do usuário:";
            this.lbl_coduser.Click += new System.EventHandler(this.lbl_emailPesquisa_Click);
            // 
            // txt_codUsuario
            // 
            this.txt_codUsuario.Location = new System.Drawing.Point(12, 63);
            this.txt_codUsuario.Name = "txt_codUsuario";
            this.txt_codUsuario.Size = new System.Drawing.Size(95, 20);
            this.txt_codUsuario.TabIndex = 18;
            this.txt_codUsuario.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 251);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(210, 37);
            this.btn_salvar.TabIndex = 29;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // F_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 300);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_senhaBD);
            this.Controls.Add(this.txt_emailBD);
            this.Controls.Add(this.txt_nomeBD);
            this.Controls.Add(this.txt_codUsuarioBD);
            this.Controls.Add(this.lbl_codUsuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.lbl_coduser);
            this.Controls.Add(this.txt_codUsuario);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_update;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_senhaBD;
        private System.Windows.Forms.TextBox txt_emailBD;
        private System.Windows.Forms.TextBox txt_nomeBD;
        private System.Windows.Forms.TextBox txt_codUsuarioBD;
        private System.Windows.Forms.Label lbl_codUsuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Label lbl_coduser;
        private System.Windows.Forms.TextBox txt_codUsuario;
        private System.Windows.Forms.Button btn_salvar;
    }
}