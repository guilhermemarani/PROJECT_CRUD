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
    public partial class F_Delete : Form
    {
        public F_Delete()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show(); // Volta para o Form1
            this.Close(); //Fecha o form atual "F_Delete"
        }

        private void lbl_delete_Click(object sender, EventArgs e)
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

                    string sql = "SELECT * FROM usuario WHERE codUsuario='" +txt_codUsuario.Text+ "'";

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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(txt_codUsuarioBD.Text == string.Empty)
            {
                MessageBox.Show("Não existe nenhuma pesquisa ativa", "Informativo de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_codUsuario.Focus();
            }
            else
            {
                Conexao con = new Conexao();

                try
                {
                    con.conectar();

                    string sql = "DELETE FROM usuario WHERE codUsuario='" +txt_codUsuarioBD.Text+ "'";

                    SQLiteCommand cmd = new SQLiteCommand(sql, con.conn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro excluido com sucesso!", "Exclusão de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_codUsuarioBD.Clear();
                    txt_nomeBD.Clear();
                    txt_emailBD.Clear();
                    txt_senhaBD.Clear();
                    txt_codUsuario.Clear();
                    txt_codUsuario.Focus();

                    con.desconectar();

                }catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
