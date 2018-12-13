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
    public partial class frmOperadorCadastro : Form
    {
        Panel panelPai;
        OperadorController operadorController = new OperadorController();

        public frmOperadorCadastro(int largura, int altura, Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
           
            //this.carregaListaClientes();
            this.Width = largura - 250;
            this.Height = altura;
        }

        private void frmOperadorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var isCadastrado = operadorController.AdicionarOperador(
                new Operador(txtNome.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtSenha.Text)
            );

            if (isCadastrado)
            {
                MessageBox.Show("Operador cadastrado!");
            } else
            {
                MessageBox.Show("Não foi possível cadastrar o operador!");
            }
        }
    }
}
