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
    public partial class frmHome : Form
    {
        RelatorioController relatorioController = new RelatorioController();
        Operador operador;

        public frmHome(Operador pessoaLogada)
        {
            InitializeComponent();
            operador = pessoaLogada;
            lblNomeOperador.Text = pessoaLogada.Nome;
            this.CarregarInformacoesRelatorio();
        }

        private void CarregarInformacoesRelatorio()
        {
            lblTotalClientes.Text = relatorioController.ObterTotalClientes().ToString();
            lblTotalChamadosEmAberto.Text = relatorioController.ObterTotalChamadosEmAberto().ToString();
            lblTotalAbertosPorMim.Text = relatorioController.ObterChamadosPorOperador(operador.IdOperador).ToString();
        }
    }
}
