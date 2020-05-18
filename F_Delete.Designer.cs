namespace PROJECT_CRUD
{
    partial class F_Delete
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
            this.lbl_delete = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // lbl_delete
            // 
            this.lbl_delete.AutoSize = true;
            this.lbl_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete.Location = new System.Drawing.Point(71, 9);
            this.lbl_delete.Name = "lbl_delete";
            this.lbl_delete.Size = new System.Drawing.Size(87, 30);
            this.lbl_delete.TabIndex = 1;
            this.lbl_delete.Text = "Delete";
            this.lbl_delete.Click += new System.EventHandler(this.lbl_delete_Click);
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
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(12, 256);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(210, 37);
            this.btn_excluir.TabIndex = 41;
            this.btn_excluir.Text = "Excluir cadastro";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txt_senhaBD
            // 
            this.txt_senhaBD.Location = new System.Drawing.Point(103, 219);
            this.txt_senhaBD.Name = "txt_senhaBD";
            this.txt_senhaBD.Size = new System.Drawing.Size(100, 20);
            this.txt_senhaBD.TabIndex = 40;
            // 
            // txt_emailBD
            // 
            this.txt_emailBD.Location = new System.Drawing.Point(103, 193);
            this.txt_emailBD.Name = "txt_emailBD";
            this.txt_emailBD.Size = new System.Drawing.Size(100, 20);
            this.txt_emailBD.TabIndex = 39;
            // 
            // txt_nomeBD
            // 
            this.txt_nomeBD.Location = new System.Drawing.Point(103, 167);
            this.txt_nomeBD.Name = "txt_nomeBD";
            this.txt_nomeBD.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeBD.TabIndex = 38;
            // 
            // txt_codUsuarioBD
            // 
            this.txt_codUsuarioBD.Location = new System.Drawing.Point(103, 140);
            this.txt_codUsuarioBD.Name = "txt_codUsuarioBD";
            this.txt_codUsuarioBD.ReadOnly = true;
            this.txt_codUsuarioBD.Size = new System.Drawing.Size(100, 20);
            this.txt_codUsuarioBD.TabIndex = 37;
            // 
            // lbl_codUsuario
            // 
            this.lbl_codUsuario.AutoSize = true;
            this.lbl_codUsuario.Location = new System.Drawing.Point(12, 147);
            this.lbl_codUsuario.Name = "lbl_codUsuario";
            this.lbl_codUsuario.Size = new System.Drawing.Size(85, 13);
            this.lbl_codUsuario.TabIndex = 36;
            this.lbl_codUsuario.Text = "Código Usuário: ";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(53, 226);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(44, 13);
            this.lbl_senha.TabIndex = 35;
            this.lbl_senha.Text = "Senha: ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(59, 200);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 34;
            this.lbl_email.Text = "Email: ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(56, 174);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 33;
            this.lbl_nome.Text = "Nome: ";
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(12, 94);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(210, 37);
            this.btn_pesquisa.TabIndex = 32;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // lbl_coduser
            // 
            this.lbl_coduser.AutoSize = true;
            this.lbl_coduser.Location = new System.Drawing.Point(12, 49);
            this.lbl_coduser.Name = "lbl_coduser";
            this.lbl_coduser.Size = new System.Drawing.Size(95, 13);
            this.lbl_coduser.TabIndex = 31;
            this.lbl_coduser.Text = "Código do usuário:";
            // 
            // txt_codUsuario
            // 
            this.txt_codUsuario.Location = new System.Drawing.Point(12, 68);
            this.txt_codUsuario.Name = "txt_codUsuario";
            this.txt_codUsuario.Size = new System.Drawing.Size(95, 20);
            this.txt_codUsuario.TabIndex = 30;
            // 
            // F_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 300);
            this.Controls.Add(this.btn_excluir);
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
            this.Controls.Add(this.lbl_delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_delete;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
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
    }
}