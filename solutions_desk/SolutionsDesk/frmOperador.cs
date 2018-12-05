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
    public partial class frmOperador : Form
    {
        private Panel panelPai;
        public frmOperador(Panel panelPai)
        {
            InitializeComponent();

            this.panelPai = panelPai;
            this.Width = panelPai.Width;
            this.Height = panelPai.Height;
            this.carregaListagemOperadores(this.Width, this.Height, panelPrincipal);
        }
        public void carregaListagemOperadores(int largura, int altura, Panel panelPai)
        {
            panelSelect.Location = new Point(10, 16);
            panelPrincipal.Controls.Clear();
            frmOperadorListagem frmOperadorListagem = new frmOperadorListagem(largura, altura, panelPrincipal);
            frmOperadorListagem.TopLevel = false;
            panelPrincipal.Controls.Add(frmOperadorListagem);
            frmOperadorListagem.Show();
            frmOperadorListagem.BringToFront();
        }

        private void lblCadastrarOperador_Click(object sender, EventArgs e)
        {
            this.carregaCadastroOperadores(this.Width, this.Height, panelPrincipal);
        }
        public void carregaCadastroOperadores(int largura, int altura, Panel panelPai)
        {
            panelSelect.Location = new Point(10, 47);
            panelPrincipal.Controls.Clear();
            frmOperadorCadastro frmOperadorCadastro = new frmOperadorCadastro(largura, altura, panelPrincipal);
            frmOperadorCadastro.TopLevel = false;
            panelPrincipal.Controls.Add(frmOperadorCadastro);
            frmOperadorCadastro.Show();
            frmOperadorCadastro.BringToFront();
        }

        private void lblListagemOperadores_Click(object sender, EventArgs e)
        {
            this.carregaListagemOperadores(this.Width, this.Height, panelPrincipal);
        }
    }
}
