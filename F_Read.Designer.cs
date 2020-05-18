namespace PROJECT_CRUD
{
    partial class F_Read
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
            this.lbl_read = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_emailPesquisa = new System.Windows.Forms.Label();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_codUsuario = new System.Windows.Forms.Label();
            this.txt_codUsuarioBD = new System.Windows.Forms.TextBox();
            this.txt_nomeBD = new System.Windows.Forms.TextBox();
            this.txt_emailBD = new System.Windows.Forms.TextBox();
            this.txt_senhaBD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_read
            // 
            this.lbl_read.AutoSize = true;
            this.lbl_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_read.Location = new System.Drawing.Point(82, 9);
            this.lbl_read.Name = "lbl_read";
            this.lbl_read.Size = new System.Drawing.Size(74, 30);
            this.lbl_read.TabIndex = 1;
            this.lbl_read.Text = "Read";
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
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(13, 64);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(210, 20);
            this.txt_email.TabIndex = 7;
            // 
            // lbl_emailPesquisa
            // 
            this.lbl_emailPesquisa.AutoSize = true;
            this.lbl_emailPesquisa.Location = new System.Drawing.Point(13, 45);
            this.lbl_emailPesquisa.Name = "lbl_emailPesquisa";
            this.lbl_emailPesquisa.Size = new System.Drawing.Size(35, 13);
            this.lbl_emailPesquisa.TabIndex = 8;
            this.lbl_emailPesquisa.Text = "Email:";
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(13, 103);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(210, 37);
            this.btn_pesquisa.TabIndex = 9;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(59, 193);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "Nome: ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(62, 219);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "Email: ";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(56, 245);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(44, 13);
            this.lbl_senha.TabIndex = 12;
            this.lbl_senha.Text = "Senha: ";
            // 
            // lbl_codUsuario
            // 
            this.lbl_codUsuario.AutoSize = true;
            this.lbl_codUsuario.Location = new System.Drawing.Point(15, 166);
            this.lbl_codUsuario.Name = "lbl_codUsuario";
            this.lbl_codUsuario.Size = new System.Drawing.Size(85, 13);
            this.lbl_codUsuario.TabIndex = 13;
            this.lbl_codUsuario.Text = "Código Usuário: ";
            // 
            // txt_codUsuarioBD
            // 
            this.txt_codUsuarioBD.Enabled = false;
            this.txt_codUsuarioBD.Location = new System.Drawing.Point(106, 159);
            this.txt_codUsuarioBD.Name = "txt_codUsuarioBD";
            this.txt_codUsuarioBD.Size = new System.Drawing.Size(100, 20);
            this.txt_codUsuarioBD.TabIndex = 14;
            // 
            // txt_nomeBD
            // 
            this.txt_nomeBD.Enabled = false;
            this.txt_nomeBD.Location = new System.Drawing.Point(106, 186);
            this.txt_nomeBD.Name = "txt_nomeBD";
            this.txt_nomeBD.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeBD.TabIndex = 15;
            // 
            // txt_emailBD
            // 
            this.txt_emailBD.Enabled = false;
            this.txt_emailBD.Location = new System.Drawing.Point(106, 212);
            this.txt_emailBD.Name = "txt_emailBD";
            this.txt_emailBD.Size = new System.Drawing.Size(100, 20);
            this.txt_emailBD.TabIndex = 16;
            // 
            // txt_senhaBD
            // 
            this.txt_senhaBD.Enabled = false;
            this.txt_senhaBD.Location = new System.Drawing.Point(106, 238);
            this.txt_senhaBD.Name = "txt_senhaBD";
            this.txt_senhaBD.Size = new System.Drawing.Size(100, 20);
            this.txt_senhaBD.TabIndex = 17;
            // 
            // F_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 300);
            this.Controls.Add(this.txt_senhaBD);
            this.Controls.Add(this.txt_emailBD);
            this.Controls.Add(this.txt_nomeBD);
            this.Controls.Add(this.txt_codUsuarioBD);
            this.Controls.Add(this.lbl_codUsuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.lbl_emailPesquisa);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Read";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_read;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_emailPesquisa;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_codUsuario;
        private System.Windows.Forms.TextBox txt_codUsuarioBD;
        private System.Windows.Forms.TextBox txt_nomeBD;
        private System.Windows.Forms.TextBox txt_emailBD;
        private System.Windows.Forms.TextBox txt_senhaBD;
    }
}