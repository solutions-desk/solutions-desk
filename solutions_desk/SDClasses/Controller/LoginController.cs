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

        public Operador validaLoginOperador(String login, String senha)
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

        public Cliente validaLoginCliente(String email, String senha)
        {
            Cliente cliente = new Cliente();

            if (email != "" & senha != "")
            {
                cliente.Email = email;
                cliente.Senha = senha;

                this.buscaCliente(cliente);

            }

            return cliente;

        }

        public Operador buscaUsuario(Operador operador)
        {
            

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM OPERADORES WHERE NUMCAD_OP = '" + operador.Login + "' AND SENHA_OP = " + operador.Senha;
            cmd.Connection = conexao.Conectar();
            
            try
            {
                //cnn.Open();
                //conexao.Conectar();

                dr = cmd.ExecuteReader();

                dr.Read();
                operador.Nome = dr["NOME_OP"].ToString();
                operador.IdOperador = Convert.ToInt32(dr["PK_OP"].ToString());

                conexao.Desconectar();
                return operador;
                

            }
            catch (Exception ex)
            {

                return new Operador();
            }
        }

        public Cliente buscaCliente(Cliente cliente)
        {
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM CLIENTE WHERE EMAIL_CLI = '" + cliente.Email + "' AND SENHA_CLI = " + cliente.Senha;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                cliente.Nome = dr["NOME_CLI"].ToString();

                cnn.Close();
                return cliente;


            }
            catch (Exception ex)
            {

                return new Cliente();
            }
        }
    }
}
