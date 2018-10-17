
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDClasses;
using SDClasses.Controller;
using SDClasses.Model;

namespace solutions_desk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INICIANDO A TELA PRINCIPAL
            // this.Hide();
            // var telaPrincipal = new frmPrincipal();
            // telaPrincipal.Show();

            // BANCO DE DADOS
            // BancoSQL banco = new BancoSQL();
            // lblResultado.Text = banco.Conexao(txtUsuario.Text);
            
            Operador operador = new Operador();

            LoginController loginController = new LoginController();

            operador = loginController.validaLogin(txtUsuario.Text, txtSenha.Text);

            if (operador.Nome != "")
            {
                lblEsperando.Text = operador.Nome;
                this.Hide();
                var telaPrincipal = new frmPrincipal(this, operador);
                telaPrincipal.Show();
            }
            else
            {
                lblEsperando.Text = "Usuário não encontrado";
            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            PrivateFontCollection materialFont = new PrivateFontCollection();

            int fontLength = Properties.Resources.MaterialIcons.Length;

            byte[] fontData = Properties.Resources.MaterialIcons;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontData, 0, data, fontLength);

            materialFont.AddMemoryFont(data, fontLength);


            Font fontIconsDefault = new Font(materialFont.Families[0], 18);
            label7.Font = new Font(materialFont.Families[0], 24);
            label7.Text = "home";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblEsperando_Click(object sender, EventArgs e)
        {

        }

        public void resetForm()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            //txtUsuario.PlaceHolderText = "Digite seu e-mail";
            //txtSenha.PlaceHolderText = "****";
        }
    }
}
