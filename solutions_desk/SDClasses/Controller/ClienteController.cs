using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SDClasses.Model;
using SDClasses;

namespace SDClasses.Controller
{
    public class ClienteController
    {
        public bool AdicionarCliente(Cliente cliente)
        {
            var adicionado = cliente.AdicionarCliente(cliente);

            if (adicionado)
            {
                return true;
            }
            return false;
        }
        public List<string> ObterEstados()
        {
            Cliente cliente = new Cliente();

            return cliente.ObterEstados();
        }
    }
}
