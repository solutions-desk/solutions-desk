using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Controller
{
    public class OperadorController
    {
        private string connectionString;

        public bool AdicionarOperador(Operador operador)
        {
            var adicionado = operador.AdicionarOperador(operador);

            if (adicionado)
            {
                return true;
            }
            return false;

        }
    }
}
