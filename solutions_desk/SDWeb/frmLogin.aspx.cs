using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDClasses.Model;
using SDClasses.Controller;

namespace SDWeb
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            Cliente cliente = new Cliente();

            LoginController loginController = new LoginController();

            cliente = loginController.validaLoginCliente(txtUsuario.Text, txtSenha.Text);

            if (cliente.Nome != "")
            {
                lblNomeCliente.Text = cliente.Nome;
                //lblEsperando.Text = operador.Nome;
                //this.Hide();
                //var telaPrincipal = new frmPrincipal(this, operador);
                //telaPrincipal.Show();
            }
            else
            {
                lblNomeCliente.Text = "Deu ruim";
                //lblEsperando.Text = "Usuário não encontrado";
            }

        }
    }
}