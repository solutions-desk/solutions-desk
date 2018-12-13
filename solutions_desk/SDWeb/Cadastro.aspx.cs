using SDClasses.Controller;
using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDWeb
{
    public partial class Cadastro : System.Web.UI.Page
    {
        ClienteController clienteController = new ClienteController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void entrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            

            var cepFormatado = txtCep.Value.Replace("-", "");
            cliente.Nome = txtNome.Value;
            cliente.Cpf = (txtCPF.Value.Replace("-", "")).Replace(".", "");
            cliente.Telefone = new Telefone(11, Convert.ToInt32(txtTelefone.Value.Replace("-", "")), "C");
            cliente.Email = txtEmail.Value;
            cliente.Endereco = new Endereco(cepFormatado, txtCidade.Value, txtBairro.Value, txtEndereco.Value, Convert.ToInt32(txtNumero.Value), "Brasil", txtUF.Value);
            cliente.Senha = txtSenha.Value;
            var clienteAdicionado = clienteController.AdicionarCliente(cliente);

            var vish = clienteAdicionado;
        }
    }
}