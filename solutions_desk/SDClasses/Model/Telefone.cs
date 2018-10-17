using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDClasses.Model
{
    public class Telefone
    {
        private int ddd;
        private int numero;
        private String tipo;

        public Telefone(int ddd, int numero, String tipo)
        {
            this.ddd = ddd;
            this.numero = numero;
            this.tipo = tipo;
        }
    }
}
