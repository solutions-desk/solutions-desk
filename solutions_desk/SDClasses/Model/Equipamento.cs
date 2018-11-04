using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Equipamento
    {
        private int idCliente;
        private string identificacaoEquipamento;

        public int IdCliente { get { return idCliente; } set {idCliente = value; } }

        public string IdentificacaoEquipamento {
            get { return identificacaoEquipamento; }
            set { identificacaoEquipamento = value; }
        }
    }
}
