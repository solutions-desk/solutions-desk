using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SDClasses.Model;
using SDClasses;

namespace SDClasses.Controller
{
    public class LoginController
    {
        private string connectionString;

        public Operador validaLogin(String login, String senha)
        {
            Operador operador = new Operador();
            
            if (login != "" & senha != "" )
            {
                operador.Login = login;
                operador.Senha = senha;

                this.buscaUsuario(operador);
                
            }

            return operador;
            
        }

        public Operador buscaUsuario(Operador operador)
        {
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM OPERADOR WHERE NUMCAD_OP = '" + operador.Login + "' AND SENHA_OP = " + operador.Senha;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                operador.Nome = dr["NOME_OP"].ToString();

                return operador;

                cnn.Close();

            }
            catch (Exception ex)
            {

                return new Operador();
            }
        }
    }
}
