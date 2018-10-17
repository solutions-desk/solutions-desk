using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDClasses.Model;

namespace SDClasses.Controller
{
    public class PessoaController
    {
        private Pessoa pessoa;

        public PessoaController(Pessoa pessoa)
        {
            this.pessoa = pessoa;            
        }

        public void inserirPessoa(Pessoa pessoa)
        {
            this.pessoa = pessoa;

            
        }
    }
}
