using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Endereco
    {
        private string cep;
        private string cidade;
        private string bairro;
        private string logradouro;
        private int numero;
        private string pais;
        private string uf;

        public Endereco()
        {

        }
        public Endereco(string cep, string cidade, string bairro, string logradouro, int numero, string pais, string uf)
        {
            this.cep = cep;
            this.cidade = cidade;
            this.bairro = bairro;
            this.logradouro = logradouro;
            this.numero = numero;
            this.pais = pais;
            this.uf = uf;

        }

        public string Cep { get { return cep; } set { cep = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public string Uf { get { return uf; } set { uf = value; } }
    }

}
