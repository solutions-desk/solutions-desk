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
        public frmHistoricoChamado()
        {
            InitializeComponent();
        }
        private void carregaChamadosRecentes()
        {

            List<Chamado> todoChamadosRecentes = new List<Chamado>();
            todoChamadosRecentes = new Chamado().obterChamado();
            int indexChamadosRecentes = 1;
            var lastPositionItemChamado = new Point(16, 120);

            foreach (var chamado in todoChamadosRecentes)
            {
                var itemChamado = new UCchamados(chamado.Numero, "encerrado", "00/00/0000", chamado.Cliente.Nome);

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
    }
}
