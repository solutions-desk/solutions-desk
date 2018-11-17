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

            cmd.CommandText = "SELECT * FROM CLIENTE";
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
        
    }
}
