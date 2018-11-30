using SDClasses.Model;
using solutions_desk.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace solutions_desk
{
    public partial class frmClienteListagem : Form
    {
        // Neste caso panel pai é o panel de acesso ao panelPrincipal em frmCliente
        Panel panelPai;

        public frmClienteListagem(int largura, int altura, Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
            this.carregaListaClientes();
            this.Width = largura - 250;
            this.Height = altura;

            panelListaClientes.Height = this.Height - 110;
            panelSeparador.Width = this.Width - 16;

        }
        public void irParaDetalheCliente()
        {
            panelPai.Controls.Clear();

            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente(panelPai);
            frmCadastroCliente.TopLevel = false;
            panelPai.Controls.Add(frmCadastroCliente);
            frmCadastroCliente.Show();
            frmCadastroCliente.BringToFront();
        }
        private void carregaListaClientes()
        {

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = new Cliente().obterListaClientes();

            int indexClientes = 1;
            var lastPositionItemCliente = new Point(20, 20);

            var index = 0;
            foreach (var cliente in listaClientes)
            {
                var itemCliente = new UCClientes(cliente);

                if (indexClientes == 1)
                {
                    itemCliente.Location = lastPositionItemCliente;
                }
                else
                {
                    if (index % 2 == 0)
                    {
                        lastPositionItemCliente.X = 20;
                        itemCliente.Location = new Point(lastPositionItemCliente.X, lastPositionItemCliente.Y + itemCliente.Height + 16);
                        lastPositionItemCliente = itemCliente.Location;

                    }
                    else
                    {
                        itemCliente.Location = new Point(lastPositionItemCliente.X + itemCliente.Width + 16, lastPositionItemCliente.Y);
                        lastPositionItemCliente = itemCliente.Location;


                    }
                }
                itemCliente.Click += delegate (object sender2, EventArgs e2)
                {
                    this.irParaDetalheCliente();

                };

                panelListaClientes.Controls.Add(itemCliente);

                indexClientes++;
                index++;
            }
        }
    }
}
