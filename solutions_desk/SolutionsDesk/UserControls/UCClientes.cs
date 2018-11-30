using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDClasses.Model;

namespace solutions_desk.UserControls
{
    public partial class UCClientes : UserControl
    {
        public UCClientes(Cliente cliente)
        {
            InitializeComponent();
            lblNomeCliente.Text = cliente.Nome;
            lblCadastradoEm.Text = cliente.DataCadastro;
            lblIdCliente.Text = cliente.IdCliente.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblCadastradoEm_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblIdCliente_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
