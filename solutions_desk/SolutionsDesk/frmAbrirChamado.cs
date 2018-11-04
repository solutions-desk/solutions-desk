using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDClasses.Controller;
using SDClasses.Model;
using solutions_desk.UserControls;

namespace solutions_desk
{
    public partial class frmAbrirChamado : Form
    {
        private ChamadoController chamadoController = new ChamadoController();
        private Cliente clienteAtual = new Cliente();

        public frmAbrirChamado(int largura, int altura)
        {
            InitializeComponent();

            this.Width = largura;
            this.Height = altura;

            this.carregarMarcas();
            this.carregarModelos();
            this.carregaChamadosRecentes();

            
        }
        private void carregaChamadosRecentes()
        {

            List<Chamado> todoChamadosRecentes = new List<Chamado>();
            todoChamadosRecentes = new Chamado().obterChamado();
            int indexChamadosRecentes = 1;
            var lastPositionItemChamado = new Point(16, 120);

            foreach(var chamado in todoChamadosRecentes)
            {   
                var itemChamado = new UCchamados(chamado.Numero, "encerrado", "00/00/0000", chamado.Cliente.Nome );

                if (indexChamadosRecentes == 1)
                {
                    itemChamado.Location = new Point(16, 120);
                }
                else
                {
                    itemChamado.Location = new Point(16, lastPositionItemChamado.Y + itemChamado.Height + 16);
                    lastPositionItemChamado = itemChamado.Location;

                }


                panelAcesso.Controls.Add(itemChamado);
                

                indexChamadosRecentes++;

            }

        }
        private void carregarMarcas()
        {
            List<string> marcas = new List<string>();
            
            marcas = chamadoController.ObterMarcas();

            for (var i = 0; i < marcas.Count; i++)
            {
                comboMarcas.Items.Add(marcas[i]);
            }
            comboMarcas.SelectedIndex = 0;

        }

        private void carregarModelos()
        {
            List<string> modelos = new List<string>();

            modelos = chamadoController.ObterModelos();

            for (var i = 0; i < modelos.Count; i++)
            {
                comboModelos.Items.Add(modelos[i]);
            }
            comboModelos.SelectedIndex = 0;
        }

        private void frmAbrirChamado_Load(object sender, EventArgs e)
        {


        }
        

        private void btnAbriChamado_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            
            //Chamado chamado = new Chamado(
            //    comboMarcas.Text,
            //    comboModelos.Text,
            //    txtMensagemErro.Text,
            //    txtDescricao.Text,
            //    cliente
            //);

        }

        private void txtIdentificacao_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacao.Text.Length < 10)
            {
                MessageBox.Show("A identificação precisa ter pelo menos 10 caracteres", "Ops!");
            } else
            {
                var equipamento = chamadoController.ObterEquipamento(txtIdentificacao.Text);
                if (equipamento.IdentificacaoEquipamento != null)
                {
                    clienteAtual = clienteAtual.BuscarClientePorID(equipamento.IdCliente);
                } else
                {
                    MessageBox.Show("Nenhum equipamento foi encontrado com a identificacao: " + txtIdentificacao.Text + "", "Ops!");
                }
                
                
            }
            
        }
    }
}
