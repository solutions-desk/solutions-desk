using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Operador : Pessoa
    {
        private int idOperador;
        private int cadastro;
        private Pessoa pessoa;
        private string login;
        private string connectionString;

        public int IdOperador
        {
            get { return idOperador; }
            set { idOperador = value; }
        }

        public string Login { get; set; }
        public int Cadastro
        {
            get { return cadastro; }
            set { cadastro = value; }
        }

        public Operador()
        {
   
        }
        public Operador(string nome, int cadastro, string senha)
        {
            this.Nome = nome;
            this.cadastro = cadastro;
            this.Senha = senha;
        }
        public bool AdicionarOperador(Operador operador)
        {
            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            string commandText = "INSERT INTO OPERADORES VALUES ('" + operador.Nome + "', " + operador.Cadastro + ", '" + operador.Senha + "', 'O', GETDATE(), 1);";

            cmd.CommandText = commandText;

            cmd.Connection = conexao.Conectar();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    conexao.Desconectar();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
