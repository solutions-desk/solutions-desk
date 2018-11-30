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
        private string tipo;

        public Telefone()
        {

        }
        public Telefone(int ddd, int numero, string tipo)
        {
            this.ddd = ddd;
            this.numero = numero;
            this.tipo = tipo;
        }

        public int Ddd { get { return ddd; } set { ddd = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
    }
}
