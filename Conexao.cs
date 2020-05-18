using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PROJECT_CRUD
{
    class Conexao
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source=PROJECT_CRUD.sdb"); //Conectando a base de dados

        public void conectar()
        {
            conn.Open(); //Iniciando a conexão com o banco
        }
        public void desconectar()
        {
            conn.Close(); //Finalizando a conexão com o banco
        }
    }
}
