using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fechar a aplicação por completo
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            F_Create f_create = new F_Create();
            f_create.ShowDialog(); //abre o form F_Create e deixa o Form1 bloqueado para uso
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            F_Read f_read = new F_Read();
            f_read.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            F_Update f_update = new F_Update();
            f_update.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            F_Delete f_delete = new F_Delete();
            f_delete.ShowDialog();
        }
    }
}
