using SDClasses.Controller;
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
    public partial class frmCadastroCliente : Form
    {
        Panel panelPai;
        ClienteController clienteController = new ClienteController();
        public frmCadastroCliente(Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
            this.Width = panelPai.Width;
            this.Height= panelPai.Height;
            this.carregarListaEstados();
        }
        
        private void carregarListaEstados()
        {
            List<string> estados = clienteController.ObterEstados();

            foreach(var estado in estados)
            {
                txtUF.Items.Add(estado);

            } 
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            var cepFormatado = txtCep.Text.Replace("-", "");
            cliente.Nome = txtNome.Text;
            cliente.Cpf = (txtCPF.Text.Replace("-", "")).Replace(".", "");
            cliente.Telefone = new Telefone(11, Convert.ToInt32(txtTelefone.Text.Replace("-", "")), "C");
            cliente.Email = txtEmail.Text;
            cliente.Endereco = new Endereco(cepFormatado, txtCidade.Text, txtBairro.Text, txtEndereco.Text, Convert.ToInt32(txtNumero.Text), "Brasil", txtUF.Text);
            cliente.Senha = txtSenha.Text;
            var clienteAdicionado = clienteController.AdicionarCliente(cliente);

            if (clienteAdicionado)
            {
                MessageBox.Show(null, "Cliente adicionado com sucesso, você ser", "Sucesso");
            } else
            {
                MessageBox.Show(null, "Não foi possível adicionar o cliente", "Erro");
            }


        }
    }
}
