using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Controller
{
    public class RelatorioController
    {
        Cliente cliente = new Cliente();

        public int ObterTotalClientes()
        {
            return cliente.ObterTotalClientes();
        }
        public int ObterTotalChamadosEmAberto()
        {
            return cliente.ObterTotalChamadosEmAberto();
        }
        public int ObterChamadosPorOperador(int idOperador)
        {
            return cliente.ObterChamadosPorOperador(idOperador);
        }


    }
}
