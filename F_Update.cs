using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PROJECT_CRUD
{
    public partial class F_Update : Form
    {
        public F_Update()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show(); //Volta para o Form1 
            this.Close(); // Fecha o form atual "F_Update"
        }

        private void lbl_emailPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void txt_emailBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nomeBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codUsuarioBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_codUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            txt_codUsuarioBD.Clear();
            txt_nomeBD.Clear();
            txt_emailBD.Clear();
            txt_senhaBD.Clear();

            if(txt_codUsuario.Text == string.Empty)
            {
                MessageBox.Show("O campo código do usuario está em branco", "Verifique as informações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_codUsuario.Focus();
            }
            else
            {
                Conexao con = new Conexao();

                try
                {
                    con.conectar();

                    string sql = "SELECT codUsuario, nome, email, senha FROM usuario WHERE codUsuario='" + txt_codUsuario.Text + "'";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);

                    DataTable usuario = new DataTable();

                    da.Fill(usuario);

                    if(usuario.Rows.Count < 1)
                    {
                        MessageBox.Show("Registro não encontrado", "Informativo de busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codUsuario.Focus();
                    }
                    else
                    {
                        txt_codUsuarioBD.Text = usuario.Rows[0]["codUsuario"].ToString();
                        txt_nomeBD.Text = usuario.Rows[0]["nome"].ToString();
                        txt_emailBD.Text = usuario.Rows[0]["email"].ToString();
                        txt_senhaBD.Text = usuario.Rows[0]["senha"].ToString();
                    }

                }catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.desconectar();
            }
        }

        private void txt_senhaBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(txt_nomeBD.Text == string.Empty || txt_emailBD.Text == string.Empty || txt_senhaBD.Text == string.Empty)
            {
                MessageBox.Show("Um dos campos para atualizar dados está vazio, refaça a pesquisa.", "Verifique as informações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_codUsuario.Focus();
            }
            else
            {
                Conexao con = new Conexao();

                try
                {
                    con.conectar();

                    string sql = "UPDATE usuario SET nome='" + txt_nomeBD.Text + "', email='" + txt_emailBD.Text + "', senha='" + txt_senhaBD.Text + "' WHERE codUsuario='" + txt_codUsuarioBD.Text + "'";

                    SQLiteCommand cmd = new SQLiteCommand(sql, con.conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro efetuado com sucesso", "Registro de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_codUsuario.Clear();
                    txt_codUsuarioBD.Clear();
                    txt_nomeBD.Clear();
                    txt_emailBD.Clear();
                    txt_senhaBD.Clear();
                    txt_codUsuario.Focus();

                    con.desconectar();
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
