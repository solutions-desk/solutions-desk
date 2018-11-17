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
        private Telefone telefone;

        public int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public Telefone Telefone { get { return telefone; } set { telefone = value; } }

        public Cliente BuscarClientePorID(int idClienteBusca)
        {

            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            //cmd.CommandText = "SELECT * FROM CLIENTES WHERE PK_CLI = " + id + ";";
            cmd.CommandText = 
                "SELECT " +
                    "PK_CLI AS ID_CLIENTE, " +
                    "NOME_CLI AS NOME, " +
                    "EMAIL_CLI AS EMAIL, " +
                    "DATA_CLI AS DATA, " +
                    "NUM_TELCLI AS TELEFONE, " +
                    "DDD_TELCLI AS DDD, " +
                    "TIPO_TELCLI AS TIPO " +
                "FROM CLIENTES " +
                    "INNER JOIN TELEFONECLIENTES ON CLIENTES.PK_TELCLI = TELEFONECLIENTES.PK_TEL_CLI " +
                "WHERE PK_CLI = " + idClienteBusca + " ";
            cmd.Connection = cnn;

            Cliente cliente = new Cliente();

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                cliente.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                cliente.Nome = dr["NOME"].ToString();
                cliente.Email = dr["EMAIL"].ToString();
                cliente.Telefone = new Telefone(Convert.ToInt32(dr["DDD"]), Convert.ToInt32(dr["TELEFONE"]), dr["TIPO"].ToString());                

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
