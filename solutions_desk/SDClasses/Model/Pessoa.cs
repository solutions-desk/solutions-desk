using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Pessoa
    {
        private String nome;
        private String email;
        private String senha;
        private Telefone telefone;

        public Pessoa(String nome, String email, String senha) {
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

        public String Nome { 
            get { 
                return this.nome;
            }
            set { nome = value; }
        }

        public String Senha { get; set; }
        public String Email { get; set; }
    }
}
