using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Pessoa
    {
        private string nome;
        private string email;
        private string senha;
        private Telefone telefone;

        public Pessoa(string nome, string email, string senha) {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }
        public Pessoa()
        {
            //this("", "", "");
            this.nome = "";
            this.email = "";
            this.senha = "";
        }

        public string Nome { 
            get { return this.nome; }
            set { nome = value; }
        }

        public string Senha { get; set; }

        public string Email {
            get { return this.email; }
            set { email = value; }
        }
    }
}
