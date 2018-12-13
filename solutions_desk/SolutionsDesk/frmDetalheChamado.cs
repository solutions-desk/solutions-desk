using SDClasses.Controller;
using SDClasses.Model;
using solutions_desk.UserControls;
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
        ChamadoController chamadoController = new ChamadoController();

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
            
            lblNomeCliente.Text = chamado.Cliente.Nome;
            lblTelefone.Text = chamado.Cliente.Telefone.Numero.ToString();
            lblEmail.Text = chamado.Cliente.Email;
            lblMensagemErro.Text = chamado.Mensagem;
            lblDescricao.Text = chamado.Descricao;

            panelChamadoAtual.Controls.Clear();
            var itemChamado = new UCchamados(chamado.Numero, chamado.Status, chamado.DataChamado, chamado.Cliente.Nome);
            itemChamado.Location = new Point(11, 11);
            itemChamado.Width = 198;
            panelChamadoAtual.Controls.Add(itemChamado);
            

            if (chamado.Comentario != "")
            {
                lblComentario.Text = chamado.Comentario;
            } else
            {
                lblComentario.Text = "Nenhum comentário adicionado para este chamado";
            }

            switch (chamado.Status)
            {
                case "encerrado":
                    lblStatusChamado.Text = "Chamado Encerrado";
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#24C06F");
                    break;

                case "tecnico":
                    lblStatusChamado.Text = "Em Processo Técnico";
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#FF9B00");
                    break;

                case "andamento":
                    lblStatusChamado.Text = "Em Andamento";
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#5842EF");
                    break;

                case "atraso":
                    lblStatusChamado.Text = "Em Atraso";
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#FF5043");
                    break;

                case "cancelado":
                    lblStatusChamado.Text = "Cancelado";
                    panelStatusChamado.BackColor = ColorTranslator.FromHtml("#CACACA");
                    break;

                case "aberto":
                    lblStatusChamado.Text = "Aberto";
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

        private void lblEncerrado_Click(object sender, EventArgs e)
        {
            panelMudarStatusChamado.Visible = false;
            var foiAtualizado = chamadoController.AtualizarStatusChamado(chamado, "encerrado", Program.idOperadorLogado);

            if (foiAtualizado)
            {
                MessageBox.Show("Chamado atualizado");
                chamado.Status = "encerrado";
                carregarInformacoesChamado(chamado);
            } else
            {
                MessageBox.Show("Não foi possível encerrar o chamado");
            }

        }

        private void lblProcessoTecnico_Click(object sender, EventArgs e)
        {
            panelMudarStatusChamado.Visible = false;
            var foiAtualizado = chamadoController.AtualizarStatusChamado(chamado, "tecnico", Program.idOperadorLogado);

            if (foiAtualizado)
            {
                MessageBox.Show("Chamado alterado para Processo Técnico");
                chamado.Status = "tecnico";
                carregarInformacoesChamado(chamado);
            }
            else
            {
                MessageBox.Show("Não foi possível alteraro status do chamado para Processo Técnico");
            }
        }

        private void lblAndamento_Click(object sender, EventArgs e)
        {
            panelMudarStatusChamado.Visible = false;
            var foiAtualizado = chamadoController.AtualizarStatusChamado(chamado, "andamento", Program.idOperadorLogado);

            if (foiAtualizado)
            {
                MessageBox.Show("Chamado alterado para em Andamento");
                chamado.Status = "andamento";
                carregarInformacoesChamado(chamado);
            }
            else
            {
                MessageBox.Show("Não foi possível alteraro status do chamado para em andamento");
            }
        }

        private void lblAtraso_Click(object sender, EventArgs e)
        {
            panelMudarStatusChamado.Visible = false;
            var foiAtualizado = chamadoController.AtualizarStatusChamado(chamado, "atraso", Program.idOperadorLogado);

            if (foiAtualizado)
            {
                MessageBox.Show("Chamado alterado para em atraso");
                chamado.Status = "atraso";
                carregarInformacoesChamado(chamado);
            }
            else
            {
                MessageBox.Show("Não foi possível alteraro status do chamado para em atraso");
            }
        }

        private void lblCancelado_Click(object sender, EventArgs e)
        {
            panelMudarStatusChamado.Visible = false;
            var foiAtualizado = chamadoController.AtualizarStatusChamado(chamado, "cancelado", Program.idOperadorLogado);

            if (foiAtualizado)
            {
                MessageBox.Show("Chamado alterado para em cancelado");
                chamado.Status = "cancelado";
                carregarInformacoesChamado(chamado);
            }
            else
            {
                MessageBox.Show("Não foi possível alteraro status do chamado para em cancelado");
            }
        }

        private void btnAdicionarComentario_Click(object sender, EventArgs e)
        {
            var isComentarioAtualizado = false;
            
            if (chamado.Comentario == "")
            {
                chamado.Comentario = txtComentario.Text;
                isComentarioAtualizado = chamadoController.AdicionarComentario(Program.idOperadorLogado, chamado);
            } else
            {
                chamado.Comentario = txtComentario.Text;
                isComentarioAtualizado = chamadoController.AtualizaComentario(Program.idOperadorLogado, chamado);
            }


            if (isComentarioAtualizado)
            {
                MessageBox.Show("Comentario adicionado");
            } else
            {
                MessageBox.Show("Não foi possível adicionar o comentário");
            }
            txtComentario.Text = "";
            this.carregarInformacoesChamado(chamado);
        }
    }
}
