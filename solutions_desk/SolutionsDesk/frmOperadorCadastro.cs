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
    public partial class frmOperadorCadastro : Form
    {
        Panel panelPai;

        public frmOperadorCadastro(int largura, int altura, Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
           
            //this.carregaListaClientes();
            this.Width = largura - 250;
            this.Height = altura;
        }
    }
}
