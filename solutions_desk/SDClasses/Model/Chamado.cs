using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Chamado
    {
        private int numero;
        private string marca;
        private string modelo;
        private string mensagem;
        private string descricao;
        private string comentario;
        private Cliente cliente;
        private string connectionString;

        public Chamado()
        {
           
        }
        public Chamado(int numero, string marca, string modelo, string mensagem, string descricao, Cliente cliente)
        {
            this.numero = numero;
            this.marca = marca;
            this.modelo = modelo;
            this.mensagem = mensagem;
            this.descricao = descricao;
            this.cliente = cliente;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string Marca
        {
            get { return this.marca; }
            set { this.marca= value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        public string Mensagem
        {
            get { return this.mensagem; }
            set { this.mensagem= value; }
        }
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public string Comentario
        {
            get { return this.comentario; }
            set { this.comentario = value; }
        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.Cliente = value; }
        }

        public List<Chamado> obterChamado()
        {
            List<Chamado> chamadosRecentes = new List<Chamado>();
            
            connectionString = @"Data Source=DESKTOP-QTSN2HH;Initial Catalog=HELPDESK;Integrated Security=TRUE";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText =
            "SELECT " +
                "TOP(3) " +
                "PK_CHAM AS 'ID_CHAMADO', " +
                    "NUMERO_CHAM AS 'NUMERO'," +
                    "MENS_CHAM AS 'MENSAGEM', " +
                    "DESC_CHAM AS 'DESCRICAO', " +
                    "PK_CLI AS 'ID_CLIENTE', " +
                    "DESC_MARCA AS 'MARCA', " +
                    "DESC_MODELO AS 'MODELO' " +
                "FROM CHAMADO " +
                    "INNER JOIN MARCA ON CHAMADO.PK_MARCA = MARCA.PK_MARCA " +
                    "INNER JOIN MODELO ON CHAMADO.PK_MODELO = MODELO.PK_MODELO " +
                "ORDER BY PK_CHAM DESC";

            cmd.Connection = cnn;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cliente clienteChamado = new Cliente().BuscarClientePorID(Convert.ToInt16(dr["ID_CLIENTE"]));

                    chamadosRecentes.Add(
                        new Chamado(
                            Convert.ToInt32(dr["NUMERO"]),
                            dr["MARCA"].ToString(),
                            dr["MODELO"].ToString(),
                            dr["MENSAGEM"].ToString(),
                            dr["DESCRICAO"].ToString(),
                            clienteChamado
                        )
                    );
                }


                cnn.Close();

                return chamadosRecentes;


            }
            catch (Exception ex)
            {

                return chamadosRecentes;
            }
        }
    }
}
