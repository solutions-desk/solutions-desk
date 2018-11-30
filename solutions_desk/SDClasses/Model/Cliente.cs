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
        private Telefone telefone;
        private string cpf;
        private string cnpj;
        private string razao;
        private int idCliente;
        private string connectionString;

        public int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public Endereco Endereco { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        public Cliente() {}

        public Cliente(
                string nome,
                string email,
                string cpf,
                string cnpj,
                int ddd,
                int numeroTelefone,
                int numero,
                string cidade,
                string enderecoCliente,
                string bairro,
                string cep,
                string pais,
                string uf,
                string dataCadastro
            )
        {
            this.Nome = nome;
            this.Email = email;
            this.telefone = new Telefone(ddd, numeroTelefone, "C");
            
            //this.pessoa.Telefone.Ddd = ddd;
            //this.pessoa.Telefone.Numero = numero;

            //this.Telefone.Ddd = ddd;
            //this.Telefone.Numero = telefone;
            this.cpf = cpf != null ? cpf : null;
            this.cnpj = cnpj != null ? cnpj : null;

            this.endereco = new Endereco(cep, cidade, bairro, enderecoCliente, numero, pais, uf);

            //this.endereco.Logradouro = endereco;
            //this.endereco.Numero = numero;
            //this.endereco.Cidade = cidade;
            //this.endereco.Bairro = bairro;
            //this.endereco.Cep = cep;
            //this.endereco.Pais = pais;
            //this.endereco.Uf = uf;

            this.DataCadastro = dataCadastro;


        }

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

        public List<Cliente> obterListaClientes(int total = 10)
        {
            List<Cliente> listaClientes = new List<Cliente>();

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText =
                "SELECT " +
                    "CLI.PK_CLI ID_CLIENTE, " +
                    "CLI.NOME_CLI NOME, " +
                    "CLI.CPF_CLI CPF, " +
                    "CLI.CNPJ_CLI CNPJ, " +
                    "CLI.EMAIL_CLI EMAIL, " +
                    "CLI.DATA_CLI DATA_CADASTRO, " +
                    "PERFIL.TIPO_PERCLI TIPO_PERFIL, " +
                    "TEL.DDD_TELCLI DDD, " +
                    "TEL.NUM_TELCLI TELEFONE, " +
                    "ENDE.LOGRADOURO_ENDCLI LOGRADOURO, " +
                    "ENDE.CIDADE_ENDCLI CIDADE, " +
                    "ENDE.NUM_ENDCLI NUMERO, " +
                    "ENDE.BAIRRO_ENDCLI BAIRRO, " +
                    "ENDE.CEP_ENDCLI CEP, " +
                    "PAIS.NOME_PAISEND PAIS, " +
                    "UF.NOME_UFEND UF " +
                "FROM CLIENTES CLI " +
                    "INNER JOIN PERFILCLIENTES PERFIL ON CLI.PK_PERCLI = PERFIL.PK_PERCLI " +
                    "INNER JOIN TELEFONECLIENTES TEL ON CLI.PK_TELCLI = TEL.PK_TEL_CLI " +
                    "INNER JOIN ENDERECOCLIENTES ENDE ON CLI.PK_ENDCLI = ENDE.PK_ENDCLI " +
                    "INNER JOIN PAISENDERECOS PAIS ON ENDE.PK_PAISEND= PAIS.PK_PAISEND " +
                    "INNER JOIN UFENDERECOS UF ON ENDE.PK_UFEND = UF.PK_UFEND;";


            cmd.Connection = conexao.Conectar();

            try
            {

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaClientes.Add(new Cliente(
                        dr["NOME"].ToString(),
                        dr["EMAIL"].ToString(),
                        dr["CPF"].ToString(),
                        dr["CNPJ"].ToString(),
                        Convert.ToInt32(dr["DDD"]),
                        Convert.ToInt32(dr["TELEFONE"]),
                        Convert.ToInt32(dr["NUMERO"]),
                        dr["CIDADE"].ToString(),
                        dr["LOGRADOURO"].ToString(),
                        dr["BAIRRO"].ToString(),
                        dr["CEP"].ToString(),
                        dr["PAIS"].ToString(),
                        dr["UF"].ToString(),
                        dr["DATA_CADASTRO"].ToString()
                    ));
                }

                conexao.Desconectar();

                return listaClientes;
            }
            catch (Exception ex)
            {
                return listaClientes;
            }
        }
        
        public bool AdicionarCliente(Cliente cliente)
        {

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            string cnpjFormatado = cliente.Cnpj != null ? cliente.Cnpj : "NULL";
            string comandoFoda =
                "DECLARE @IdEstado INT; " +
                "DECLARE @IdEndereco INT; " +
                "DECLARE @IdTelefone INT; " +

                "SET @IdEstado = (SELECT PK_UFEND FROM UFENDERECOS WHERE NOME_UFEND = '" + cliente.Endereco.Uf + "'); " +

                "INSERT INTO ENDERECOCLIENTES VALUES('" + cliente.Endereco.Logradouro + "', '" + cliente.Endereco.Cidade + "', '" + cliente.Endereco.Numero + "', '" + cliente.Endereco.Bairro + "', " + Convert.ToInt64(cliente.Endereco.Cep) + ", 1, @IdEstado); " +
                "SELECT @IDENDERECO = (SELECT SCOPE_IDENTITY()); " +

                "INSERT INTO TELEFONECLIENTES VALUES('C', " + cliente.Telefone.Ddd + ", " + cliente.Telefone.Numero + "); " +
                "SET @IdTelefone = (SELECT SCOPE_IDENTITY()); " +

                "INSERT INTO CLIENTES VALUES('" + cliente.Nome + "', " + Convert.ToInt64(cliente.Cpf) + ", " + cnpjFormatado + ", '" + cliente.Email + "', '" + cliente.Senha + "', GETDATE(), 1, @IdTelefone, @IDENDERECO);";

            cmd.CommandText = comandoFoda;

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

        public List<string> ObterEstados()
        {
            List<string> estados = new List<string>();

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText = "SELECT * FROM UFENDERECOS;";


            cmd.Connection = conexao.Conectar();

            try
            {

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    estados.Add(dr["NOME_UFEND"].ToString());
                }

                conexao.Desconectar();

                return estados;
            }
            catch (Exception ex)
            {
                return estados;
            }
        }
            
        public int ObterTotalClientes()
        {
            Int32 count = 0;

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText = "SELECT COUNT(*) FROM CLIENTES;";

            cmd.Connection = conexao.Conectar();

            try
            {

                count = (Int32)cmd.ExecuteScalar();
                conexao.Desconectar();

                return count;
            }
            catch (Exception ex)
            {
                return count;
            }
        }
        public int ObterTotalChamadosEmAberto()
        {
            Int32 count = 0;

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = 
                "SELECT COUNT(*) FROM OPERADORCHAMADOS OP " + 
                "INNER JOIN CHAMADOS CH ON OP.PK_CHAM = CH.PK_CHAM WHERE STS_OP_CHAM = 'aberto'";

            cmd.Connection = conexao.Conectar();

            try
            {
                count = (Int32)cmd.ExecuteScalar();
                conexao.Desconectar();

                return count;
            }
            catch (Exception ex)
            {
                return count;
            }
        }
        public int ObterChamadosPorOperador(int idOperador)
        {
            Int32 count = 0;

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT COUNT(*) FROM OPERADORCHAMADOS WHERE PK_OP = " + idOperador + " AND ISNULL(PK_CHAM, 0) <> 0";

            cmd.Connection = conexao.Conectar();

            try
            {
                count = (Int32)cmd.ExecuteScalar();
                conexao.Desconectar();

                return count;
            }
            catch (Exception ex)
            {
                return count;
            }
        }
        

    }
}

