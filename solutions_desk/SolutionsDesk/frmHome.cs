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
    public partial class frmHome : Form
    {
        public frmHome(Operador pessoaLogada)
        {
            InitializeComponent();
            lblNomeOperador.Text = pessoaLogada.Nome;
        }
    }
}
