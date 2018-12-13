using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        private string dataComentario;
        private Cliente cliente;
        private string connectionString;
        private string dataChamado;
        private string status;
        private int quantidade;

        public Chamado()
        {
           
        }
        public Chamado(int numero, string marca, string modelo, string mensagem, string descricao, string dataChamado, string status, Cliente cliente)
        {

            if (numero != null && numero != 0)
            {
                this.numero = numero;
            }
            this.marca = marca;
            this.modelo = modelo;
            this.mensagem = mensagem;
            this.descricao = descricao;
            if (dataChamado != null )
            {
                this.dataChamado = dataChamado;
            }
            this.status = status;
            this.cliente = cliente;
        }
        public Chamado(int numero, string marca, string modelo, string mensagem, string descricao, string dataChamado, string status, Cliente cliente, int quantidade)
        {
            if (numero != null && numero != 0)
            {
                this.numero = numero;
            }
            this.marca = marca;
            this.modelo = modelo;
            this.mensagem = mensagem;
            this.descricao = descricao;
            if (dataChamado != null)
            {
                this.dataChamado = dataChamado;
            }
            this.status = status;
            this.cliente = cliente;
            this.quantidade = quantidade;
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
        public string DataComentario
        {
            get { return this.dataComentario; }
            set { this.dataComentario = value; }
        }
        public string DataChamado
        {
            get { return dataChamado; }
            set { dataChamado = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.Cliente = value; }
        }
        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public List<Chamado> obterChamado(int total = 10)
        {
            List<Chamado> chamadosRecentes = new List<Chamado>();

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText =
                 "SELECT " +
                    "TOP(" + total + ") " +
                    "QTD = COUNT(1) OVER()," +
                    "CHAMADOS.PK_CHAM AS 'ID_CHAMADO', " +
                    "NUMERO_CHAM AS 'NUMERO', " +
                    "MENS_CHAM AS 'MENSAGEM', " +
                    "DESC_CHAM AS 'DESCRICAO', " +
                    "IDENTIFICACAO_EQUIP AS 'NUMERO_EQUIPAMENTO', " +
                    "DATA_CHAM AS 'CRIADO_EM', " +
                    "DATA_VENDA_EQUIP AS 'VENDIDO_EM', " +
                    "DESC_MARCA AS 'MARCA', " +
                    "DESC_MODELO AS 'MODELO', " +
                    "EQUIPAMENTOS.PK_CLI AS 'ID_CLIENTE', " +
                    "STS_OP_CHAM AS 'STATUS_CHAMADO', " +
                    "PK_OP_CHAM AS 'ID_OPERADOR', " +
                    "DESC_COM AS COMENTARIO, " +
                    "DATA_COM AS DATA_COMENTARIO, " +
                    "PK_OP_COM AS ID_OPERADOR_COMENTARIO " +
                "FROM CHAMADOS " +
                    "INNER JOIN EQUIPAMENTOS ON CHAMADOS.PK_EQUIP = EQUIPAMENTOS.PK_EQUIP " +
                    "INNER JOIN MARCAS ON EQUIPAMENTOS.PK_MARCA = MARCAS.PK_MARCA " +
                    "INNER JOIN MODELOS ON EQUIPAMENTOS.PK_MODELO = MODELOS.PK_MODELO " +
                    "INNER JOIN OPERADORCHAMADOS ON CHAMADOS.PK_CHAM = OPERADORCHAMADOS.PK_CHAM " +
                    "LEFT JOIN COMENTARIOS ON COMENTARIOS.PK_CHAM = CHAMADOS.PK_CHAM " +
                "ORDER BY CHAMADOS.PK_CHAM DESC; ";
                    //"OFFSET 0 ROWS -- QUANTIDADE " +
                    //"FETCH NEXT 9 ROWS ONLY; --PAGINAÇÃO;";


            cmd.Connection = conexao.Conectar();

            try
            {

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cliente clienteChamado = new Cliente().BuscarClientePorID(Convert.ToInt16(dr["ID_CLIENTE"]));
                    Chamado paraAdicionarChamado = new Chamado(
                            Convert.ToInt32(dr["NUMERO"]),
                            dr["MARCA"].ToString(),
                            dr["MODELO"].ToString(),
                            dr["MENSAGEM"].ToString(),
                            dr["DESCRICAO"].ToString(),
                            dr["CRIADO_EM"].ToString(),
                            dr["STATUS_CHAMADO"].ToString(),
                            clienteChamado,
                            Convert.ToInt32(dr["QTD"])
                        );

                    paraAdicionarChamado.Comentario = dr["COMENTARIO"].ToString();
                    paraAdicionarChamado.DataComentario = dr["DATA_COMENTARIO"].ToString();

                    chamadosRecentes.Add(paraAdicionarChamado);
                }


                conexao.Desconectar();

                return chamadosRecentes;


            }
            catch (Exception ex)
            {

                return chamadosRecentes;
            }
        }

        public List<Chamado> obterChamadoTakeSkip(int take = 10, int skip = 0)
        {
            List<Chamado> chamadosRecentes = new List<Chamado>();

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText =
                 "SELECT " +
                    "QTD = COUNT(1) OVER()," +
                    "CHAMADOS.PK_CHAM AS 'ID_CHAMADO', " +
                    "NUMERO_CHAM AS 'NUMERO', " +
                    "MENS_CHAM AS 'MENSAGEM', " +
                    "DESC_CHAM AS 'DESCRICAO', " +
                    "IDENTIFICACAO_EQUIP AS 'NUMERO_EQUIPAMENTO', " +
                    "DATA_CHAM AS 'CRIADO_EM', " +
                    "DATA_VENDA_EQUIP AS 'VENDIDO_EM', " +
                    "DESC_MARCA AS 'MARCA', " +
                    "DESC_MODELO AS 'MODELO', " +
                    "EQUIPAMENTOS.PK_CLI AS 'ID_CLIENTE', " +
                    "STS_OP_CHAM AS 'STATUS_CHAMADO', " +
                    "PK_OP_CHAM AS 'ID_OPERADOR' " +
                "FROM CHAMADOS " +
                    "INNER JOIN EQUIPAMENTOS ON CHAMADOS.PK_EQUIP = EQUIPAMENTOS.PK_EQUIP " +
                    "INNER JOIN MARCAS ON EQUIPAMENTOS.PK_MARCA = MARCAS.PK_MARCA " +
                    "INNER JOIN MODELOS ON EQUIPAMENTOS.PK_MODELO = MODELOS.PK_MODELO " +
                    "INNER JOIN OPERADORCHAMADOS ON CHAMADOS.PK_CHAM = OPERADORCHAMADOS.PK_CHAM " +
                "ORDER BY CHAMADOS.PK_CHAM DESC " +
                    "OFFSET "+ take +" ROWS -- QUANTIDADE " +
                    "FETCH NEXT 9 ROWS ONLY; --PAGINAÇÃO;";


            cmd.Connection = conexao.Conectar();

            try
            {

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
                            dr["CRIADO_EM"].ToString(),
                            dr["STATUS_CHAMADO"].ToString(),
                            clienteChamado,
                            Convert.ToInt32(dr["QTD"])
                        )
                    );
                }


                conexao.Desconectar();

                return chamadosRecentes;


            }
            catch (Exception ex)
            {

                return chamadosRecentes;
            }
        }

        public bool AbrirChamado(int idOperador, Chamado chamado)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            
            Equipamento equip = new Equipamento();
            var idEquipamento = equip.ObterEquipamentoByIdCliente(chamado.Cliente.IdCliente);

            cmd.CommandText =
                "DECLARE @ultimoId INT; " +
                "DECLARE @ultimoNumeroChamado INT; " +
                "SELECT @ultimoNumeroChamado = ISNULL((SELECT TOP 1 NUMERO_CHAM FROM CHAMADOS ORDER BY PK_CHAM DESC) + 1, 1); " +
                "INSERT INTO CHAMADOS VALUES(@ultimoNumeroChamado, '" + chamado.Mensagem + "', '" + chamado.Descricao + "', null, GETDATE(), " + chamado.Cliente.IdCliente + ", " + idEquipamento.IdEquipamento + "); " +
                "SELECT @ultimoId = (SELECT SCOPE_IDENTITY()); " +
                "INSERT INTO OPERADORCHAMADOS VALUES('aberto', " + idOperador + ", @ultimoId);";
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
                conexao.Desconectar();
                return false;
            }
        }
        
        public bool AtualizarStatusChamado(Chamado chamado, string status, int idOperador)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE OC SET STS_OP_CHAM = '" + status + "', PK_OP = " + idOperador + " FROM OPERADORCHAMADOS OC INNER JOIN CHAMADOS CH ON OC.PK_CHAM = CH.PK_CHAM WHERE CH.NUMERO_CHAM = " + chamado.Numero + ";";
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
                conexao.Desconectar();
                return false;
            }
        }

        public int ObterChamadoPorNumero(int numeroChamado)
        {

            int retornoNumeroChamado;

            Conexao conexao = new Conexao();
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            cmd.CommandText = "SELECT PK_CHAM AS ID_CHAMADO FROM CHAMADOS WHERE NUMERO_CHAM = " + numeroChamado + ";";
          
            cmd.Connection = conexao.Conectar();

            try
            {

                dr = cmd.ExecuteReader();
                dr.Read();


                retornoNumeroChamado = Convert.ToInt32(dr["ID_CHAMADO"]);

                conexao.Desconectar();

                return retornoNumeroChamado;


            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public bool AdicionarComentario(int idOperador, Chamado chamado)
        {
            int numeroChamado = ObterChamadoPorNumero(chamado.numero);

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO COMENTARIOS VALUES ('" + chamado.Comentario + "', GETDATE(), " + idOperador + " ," + numeroChamado + ")";
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
                conexao.Desconectar();
                return false;
            }
        }
        public bool AtualizaComentario(int idOperador, Chamado chamado)
        {
            int numeroChamado = ObterChamadoPorNumero(chamado.numero);

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "INSERT INTO COMENTARIOS VALUES ('" + chamado.Comentario + "', GETDATE(), " + idOperador + " ," + numeroChamado + ")";
            cmd.CommandText = "UPDATE COMENTARIOS SET DESC_COM = '" + chamado.Comentario + "', PK_OP_COM = " + idOperador + " WHERE PK_CHAM = " + numeroChamado + ";";
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
                conexao.Desconectar();
                return false;
            }
        }
    }
}
