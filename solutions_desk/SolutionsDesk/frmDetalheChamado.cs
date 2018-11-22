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
    public partial class frmDetalheChamado : Form
    {
        private Form formVoltar;
        private Panel panelPai;
        private Chamado chamado;

        public frmDetalheChamado(Chamado chamado, Panel panelPai, Form formVoltar)
        {
            InitializeComponent();
            this.formVoltar = formVoltar;
            this.panelPai = panelPai;

            this.Width = panelPai.Width;
            this.Height = panelPai.Height;
            this.chamado = chamado;
            this.carregarInformacoesChamado(chamado);
            //label1.Text = chamado.Cliente.Nome;
            //label2.Text = chamado.Numero.ToString();
        }
        public void carregarInformacoesChamado(Chamado chamado)
        {
            lblNumeroChamado.Text = chamado.Numero.ToString();
            lblStatusChamado.Text = chamado.Status;
            lblNomeCliente.Text = chamado.Cliente.Nome;
            lblTelefone.Text = chamado.Cliente.Telefone.Numero.ToString();
            lblEmail.Text = chamado.Cliente.Email;
            

            switch (chamado.Status)
            {
                case "encerrado":
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#24C06F");
                    break;

                case "tecnico":
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#FF9B00");
                    break;

                case "andamento":
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#5842EF");
                    break;

                case "atraso":
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#FF5043");
                    break;

                case "cancelado":
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#CACACA");
                    break;

                case "aberto":
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            //frmDetalheChamado frmDetalheChamado = new frmDetalheChamado(chamado);

            formVoltar.TopLevel = false;
            panelPai.Controls.Add(formVoltar);
            formVoltar.Show();
            formVoltar.BringToFront();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEditarStatus_Click(object sender, EventArgs e)
        {
            panelMudarStatusChamado.Visible = true;
            
        }

        private void lblEncerrado_MouseEnter(object sender, EventArgs e)
        {
            lblEncerrado.BackColor = ColorTranslator.FromHtml("#F1F1F1");
        }

        private void lblEncerrado_MouseLeave(object sender, EventArgs e)
        {
            lblEncerrado.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void frmDetalheChamado_Click(object sender, EventArgs e)
        {
            //panelMudarStatusChamado.Visible = false;
        }

        private void lblProcessoTecnico_MouseEnter(object sender, EventArgs e)
        {
            lblProcessoTecnico.BackColor = ColorTranslator.FromHtml("#F1F1F1");
        }

        private void lblProcessoTecnico_MouseLeave(object sender, EventArgs e)
        {
            lblProcessoTecnico.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }
        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                panelMudarStatusChamado.Visible = false;
        }

        private void frmDetalheChamado_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {                
                //if (ctrl is GroupBox || ctrl is Panel || ctrl is Label)
                if (ctrl.Name != "panelMudarStatusChamado" && ctrl.Name != "lblEditarStatus")
                        ctrl.MouseClick += mouseClick;

            }
        }

        private void lblAndamento_MouseEnter(object sender, EventArgs e)
        {
            lblAndamento.BackColor = ColorTranslator.FromHtml("#F1F1F1");
        }

        private void lblAndamento_MouseLeave(object sender, EventArgs e)
        {
            lblAndamento.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void lblAtraso_MouseEnter(object sender, EventArgs e)
        {
            lblAtraso.BackColor = ColorTranslator.FromHtml("#F1F1F1");
        }

        private void lblAtraso_MouseLeave(object sender, EventArgs e)
        {
            lblAtraso.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void lblCancelado_MouseEnter(object sender, EventArgs e)
        {
            lblCancelado.BackColor = ColorTranslator.FromHtml("#F1F1F1");
        }

        private void lblCancelado_MouseLeave(object sender, EventArgs e)
        {
            lblCancelado.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void lblAbrirChamado_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            //frmDetalheChamado frmDetalheChamado = new frmDetalheChamado(chamado);

            formVoltar.TopLevel = false;
            panelPai.Controls.Add(formVoltar);
            formVoltar.Show();
            formVoltar.BringToFront();  
        }
    }
}
