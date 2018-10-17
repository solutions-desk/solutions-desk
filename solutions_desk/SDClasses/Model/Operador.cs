using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Operador : Pessoa
    {
        private int cadastro;
        private Pessoa pessoa;
        private string login;

        public Operador()
        {
            
        }

        public string Login { get; set; }
    }
}
