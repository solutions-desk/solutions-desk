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
    public class ChamadoController
    {
        private string connectionString;

        public List<string> ObterMarcas()
        {
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM MARCA;";
            cmd.Connection = cnn;

            List<string> marcas = new List<string>();

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                marcas.Add(dr["DESC_MARCA"].ToString());

                cnn.Close();

                return marcas;


            }
            catch (Exception ex)
            {

                return marcas;
            }
        }
        public List<string> ObterModelos()
        {
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM MODELO;";
            cmd.Connection = cnn;

            List<string> modelos = new List<string>();

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                modelos.Add(dr["DESC_MODELO"].ToString());

                cnn.Close();

                return modelos;


            }
            catch (Exception ex)
            {

                return modelos;
            }
        }
        public Equipamento ObterEquipamento(string textoIdentificacao)
        {
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            
            cmd.CommandText = "SELECT * FROM EQUIPAMENTOS WHERE IDENTIFICACAO_EQUIP = '" + textoIdentificacao + "';";
            cmd.Connection = cnn;

            Equipamento equipamento = new Equipamento();

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                equipamento.IdCliente = Convert.ToInt32(dr["PK_CLI"]);
                equipamento.IdentificacaoEquipamento = dr["IDENTIFICACAO_EQUIP"].ToString();


                cnn.Close();

                return equipamento;


            }
            catch (Exception ex)
            {

                return equipamento;
            }
        }
    }
}
