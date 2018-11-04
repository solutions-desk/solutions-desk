using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Cliente : Pessoa
    {
        private Pessoa pessoa;
        private Endereco endereco;
        private string cpf;
        private string cnpj;
        private string razao;
        private int idCliente;
        private string connectionString;

        public int IdCliente { get { return idCliente; } set { idCliente = value; } }

        public Cliente BuscarClientePorID(int id)
        {

            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM CLIENTE WHERE PK_CLI = " + id + ";";
            cmd.Connection = cnn;

            Cliente cliente = new Cliente();

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                cliente.IdCliente = Convert.ToInt32(dr["PK_CLI"]);
                cliente.Nome = dr["NOME_CLI"].ToString();
                cliente.Email = dr["EMAIL_CLI"].ToString();


                cnn.Close();

                return cliente;


            }
            catch (Exception ex)
            {

                return cliente;
            }
        }
    }
}
