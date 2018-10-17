using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses
{
    public class BancoSQL
    {
        private string connectionString;
        
        public string Conexao(string idConsulta)
        {
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM CLIENTE where PK_CLI = " + idConsulta;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                return dr["NOME_CLI"].ToString();

                cnn.Close();

            }
            catch (Exception ex)
            {
                return "" + ex.InnerException;
            }
        }


        public Pessoa BuscarUsuario(String email, String senha)
        {
            
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM CLIENTE WHERE EMAIL_CLI = " + email + ", SENHA_CLI = " + senha;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                Pessoa pessoa = new Pessoa();
                pessoa.Email = dr["EMAIL_CLI"].ToString();
                pessoa.Nome = dr["NOME_CLI"].ToString();

                return pessoa;

                cnn.Close();

            }
            catch (Exception ex)
            {

                return new Pessoa();
            }
        }
    }
}
