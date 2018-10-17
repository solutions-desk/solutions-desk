using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solutions_desk
{
    public partial class frmAbrirChamado : Form
    {
        public frmAbrirChamado()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtAcademia.Enabled = true;
            txtAssunto.Enabled = true;
            txtContato.Enabled = true;
            txtObervacao.Enabled = true;

            btnIncluir.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            /*
            //AQUIAQUI
            */
        }
    }
}
