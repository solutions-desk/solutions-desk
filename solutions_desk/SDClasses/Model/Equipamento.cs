using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Equipamento
    {
        private int idEquipamento;
        private int idCliente;
        private string identificacaoEquipamento;
        private string dataVenda;
        private string modelo;
        private string marca;

        public int IdCliente { get { return idCliente; } set {idCliente = value; } }
        public int IdEquipamento { get { return idEquipamento; } set { idEquipamento = value; } }
        public string DataVenda { get { return dataVenda; } set { dataVenda = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public string Marca { get { return marca; } set { marca= value; } }


        public string IdentificacaoEquipamento {
            get { return identificacaoEquipamento; }
            set { identificacaoEquipamento = value; }
        }
        public Equipamento ObterEquipamento(string textoIdentificacao)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            //cmd.CommandText = "SELECT * FROM EQUIPAMENTOS WHERE IDENTIFICACAO_EQUIP = '" + textoIdentificacao + 
            cmd.CommandText =
                "SELECT " +
                    "PK_EQUIP, " +
                    "IDENTIFICACAO_EQUIP AS IDENTIFICACAO, " +
                    "DATA_VENDA_EQUIP AS DATA_VENDA, " +
                    "PK_CLI AS ID_CLIENTE, " +
                    "DESC_MODELO AS MODELO, " +
                    "DESC_MARCA AS MARCA " +
                "FROM EQUIPAMENTOS " +
                    "INNER JOIN MODELOS ON EQUIPAMENTOS.PK_MODELO = MODELOS.PK_MODELO " +
                    "INNER JOIN MARCAS ON EQUIPAMENTOS.PK_MARCA = MARCAS.PK_MARCA " +
                "WHERE EQUIPAMENTOS.IDENTIFICACAO_EQUIP = '" + textoIdentificacao + "'";

            cmd.Connection = conexao.Conectar();

            Equipamento equipamento = new Equipamento();

            try
            {
                

                dr = cmd.ExecuteReader();

                dr.Read();
                
                equipamento.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                equipamento.IdentificacaoEquipamento = dr["IDENTIFICACAO"].ToString();
                equipamento.Marca = dr["MARCA"].ToString();
                equipamento.Modelo= dr["MODELO"].ToString();
                equipamento.IdEquipamento = Convert.ToInt32(dr["PK_EQUIP"]);


                conexao.Desconectar();

                return equipamento;


            }
            catch (Exception ex)
            {

                return equipamento;
            }
        }
        public Equipamento ObterEquipamentoByIdCliente(int idCliente)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            //cmd.CommandText = "SELECT * FROM EQUIPAMENTOS WHERE IDENTIFICACAO_EQUIP = '" + textoIdentificacao + 
            cmd.CommandText =
                "SELECT " +
                    "PK_EQUIP, " +
                    "IDENTIFICACAO_EQUIP AS IDENTIFICACAO, " +
                    "DATA_VENDA_EQUIP AS DATA_VENDA, " +
                    "PK_CLI AS ID_CLIENTE, " +
                    "DESC_MODELO AS MODELO, " +
                    "DESC_MARCA AS MARCA " +
                "FROM EQUIPAMENTOS " +
                    "INNER JOIN MODELOS ON EQUIPAMENTOS.PK_MODELO = MODELOS.PK_MODELO " +
                    "INNER JOIN MARCAS ON EQUIPAMENTOS.PK_MARCA = MARCAS.PK_MARCA " +
                "WHERE EQUIPAMENTOS.PK_CLI = " + idCliente + "";

            cmd.Connection = conexao.Conectar();

            Equipamento equipamento = new Equipamento();

            try
            {


                dr = cmd.ExecuteReader();

                dr.Read();
                
                equipamento.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                equipamento.IdentificacaoEquipamento = dr["IDENTIFICACAO"].ToString();
                equipamento.Marca = dr["MARCA"].ToString();
                equipamento.Modelo = dr["MODELO"].ToString();
                equipamento.IdEquipamento = Convert.ToInt32(dr["PK_EQUIP"]);


                conexao.Desconectar();

                return equipamento;


            }
            catch (Exception ex)
            {

                return equipamento;
            }
        }
    }
}
