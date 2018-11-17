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

            cmd.CommandText = "SELECT * FROM MARCAS;";
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

            cmd.CommandText = "SELECT * FROM MODELOS;";
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
        

        public Equipamento ObterEquipamento(string identificacao)
        {
            Equipamento equip = new Equipamento();

            return equip.ObterEquipamento(identificacao);
            
        }

        public bool AbrirChamado(int idOperador, Chamado chamado)
        {
           
            if (idOperador != 0 && idOperador != null)
            {
                var retornoAberturaChamado = chamado.AbrirChamado(idOperador, chamado);

                if (retornoAberturaChamado)
                {
                    return true;
                }

            }
            return false;
            
        }
    }
}
