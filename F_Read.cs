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
    public partial class F_Read : Form
    {
        public F_Read()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show(); //Volta para o Form1
            this.Close(); //Fecha o form atual "F_Read"
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            txt_codUsuarioBD.Clear();
            txt_nomeBD.Clear();
            txt_emailBD.Clear();
            txt_senhaBD.Clear();

            if (txt_email.Text == string.Empty)
            {
                MessageBox.Show("Um dos campos está vazio", "Verifique as informações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
            }
            else
            {
                
                Conexao con = new Conexao();
                    try
                    {
                        con.conectar();

                    /*SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = @"SELECT * FROM usuario WHERE email=@v1";
                    cmd.Connection = con.conn;
                    cmd.Parameters.Add(new SQLiteParameter("@v1", txt_email.Text));*/

                    string sql = "SELECT codUsuario, nome, email, senha FROM usuario WHERE email='" + txt_email.Text + "'";

                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);

                        DataTable usuario = new DataTable();
                        da.Fill(usuario);

                        if (usuario.Rows.Count < 1)
                        {
                            MessageBox.Show("Registro não encontrado", "Informativo de busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_email.Focus();
                        }
                        else
                        {
                            
                            txt_codUsuarioBD.Text = usuario.Rows[0]["codUsuario"].ToString();
                            txt_nomeBD.Text = usuario.Rows[0]["nome"].ToString();
                            txt_emailBD.Text = usuario.Rows[0]["email"].ToString();
                            txt_senhaBD.Text = usuario.Rows[0]["senha"].ToString();
                        }
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                con.desconectar();
            }
        }
    }
}
