using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solutions_desk
{
    public partial class frmDetalheChamado : Form
    {
        public frmDetalheChamado(Chamado chamado)
        {
            InitializeComponent();
            label1.Text = chamado.Cliente.Nome;
            label2.Text = chamado.Numero.ToString();
        }

        
    }
}
