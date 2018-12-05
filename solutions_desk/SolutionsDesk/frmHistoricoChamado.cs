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
    public partial class frmHistoricoChamado : Form
    {
        private Panel panelPai;

        public frmHistoricoChamado(Panel panelPai)
        {
            InitializeComponent();
            this.carregaChamados();
            this.panelPai = panelPai;
            this.Width = panelPai.Width;
            this.Height = panelPai.Height;


        }
        private void carregaChamados()
        {
            var qtdChamados = 0;
            var qtdPaginas = 0;
            var paginaAtual = 1;

            List<Chamado> todosChamados = new List<Chamado>();
            todosChamados = new Chamado().obterChamadoTakeSkip();

            if (todosChamados.Count > 0)
            {
                qtdChamados = todosChamados[0].Quantidade;
                qtdPaginas = qtdChamados / 9; 







            }



            int indexChamadosRecentes = 1;
            var lastPositionItemChamado = new Point(100, 120);
            
            var index = 0;
            foreach (var chamado in todosChamados)
            {
                var itemChamado = new UCchamados(chamado.Numero, chamado.Status, chamado.DataChamado, chamado.Cliente.Nome);

                if (indexChamadosRecentes == 1)
                {
                    itemChamado.Location = lastPositionItemChamado;
                }
                else
                {
                    if (index % 3 == 0)
                    {
                        lastPositionItemChamado.X = 100;
                        itemChamado.Location = new Point(lastPositionItemChamado.X, lastPositionItemChamado.Y + itemChamado.Height + 16);
                        lastPositionItemChamado = itemChamado.Location;

                    } else
                    {
                        itemChamado.Location = new Point(lastPositionItemChamado.X + itemChamado.Width + 16, lastPositionItemChamado.Y);
                        lastPositionItemChamado = itemChamado.Location;

                        
                    }
                }
                itemChamado.Click += delegate (object sender2, EventArgs e2)
                {
                    this.ClickItemChamado(chamado);
                };
                panelListaDeChamados.Controls.Add(itemChamado);

                indexChamadosRecentes++;
                index++;
            }
        }

        public void ClickItemChamado(Chamado chamado)
        {
            panelPai.Controls.Clear();
            frmDetalheChamado frmDetalheChamado = new frmDetalheChamado(chamado, panelPai, this);
            frmDetalheChamado.TopLevel = false;
            panelPai.Controls.Add(frmDetalheChamado);
            frmDetalheChamado.Show();
            frmDetalheChamado.BringToFront();
        }

        private void frmHistoricoChamado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
