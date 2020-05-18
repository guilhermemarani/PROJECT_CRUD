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
    public partial class F_Create : Form
    {
        public F_Create()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show(); //Volta para o form "Form1"
            this.Close();  //Fecha o form atual "F_Create"
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text == string.Empty || txt_senha.Text == string.Empty || txt_email.Text == string.Empty) //if para não deixar campos em branco
            {
                MessageBox.Show("Um dos campos está vazio", "Verifique as informações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Clear();
                txt_senha.Clear();
                txt_nome.Focus();
            }
            else
            {
                Conexao con = new Conexao(); // Criando objeto para conexão ao BD

                try
                {

                    con.conectar(); // Conectando a base de dados

                    string sql = "INSERT INTO usuario(nome, senha, email) VALUES('" + txt_nome.Text + "', '" + txt_senha.Text + "', '" + txt_email.Text + "')";
                    
                    SQLiteCommand cmd = new SQLiteCommand(sql, con.conn); // criando objeto para os comandos no banco de dados.

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro efetuado com sucesso", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_nome.Clear();
                    txt_email.Clear();
                    txt_senha.Clear();

                }catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.desconectar(); //Desconectando da base de dados.
            }
        }
    }
}
