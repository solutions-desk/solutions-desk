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
    public partial class frmCliente : Form
    {
        private Panel panelPai;
        public frmCliente(Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
            this.Width = panelPai.Width;
            this.Height = panelPai.Height;
            this.carregaListagemClientes(this.Width, this.Height, panelPrincipal);

            panelSelect.Location = new Point(10, 16);
        }

        public void carregaListagemClientes(int largura, int altura, Panel panelPai)
        {
            panelSelect.Location = new Point(10, 16);
            panelPrincipal.Controls.Clear();
            frmClienteListagem frmClienteListagem = new frmClienteListagem(largura, altura, panelPrincipal);
            frmClienteListagem.TopLevel = false;
            panelPrincipal.Controls.Add(frmClienteListagem);
            frmClienteListagem.Show();
            frmClienteListagem.BringToFront();
        }
        public void CarregarCadastroCliente()
        {
            panelSelect.Location = new Point(10, 52);
            panelPrincipal.Controls.Clear();
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente(panelPrincipal);
            frmCadastroCliente.TopLevel = false;
            panelPrincipal.Controls.Add(frmCadastroCliente);
            frmCadastroCliente.Show();
            frmCadastroCliente.BringToFront();
        }

        private void lblListagemClientes_Click(object sender, EventArgs e)
        {
            panelSelect.Location = new Point(10, 16);
            this.carregaListagemClientes(this.Width, this.Height, panelPrincipal);
        }

        private void lblCadastrarClientes_Click(object sender, EventArgs e)
        {
            panelSelect.Location = new Point(10, 52);
            this.CarregarCadastroCliente();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelSelect.Location = new Point(10, 52);
            this.CarregarCadastroCliente();
        }

        private void lblIconeListaClientes_Click(object sender, EventArgs e)
        {
            panelSelect.Location = new Point(10, 16);
            this.carregaListagemClientes(this.Width, this.Height, panelPrincipal);
        }

        private void panelSelect_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
