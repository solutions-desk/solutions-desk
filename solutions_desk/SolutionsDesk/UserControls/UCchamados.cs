using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDClasses.Model;

namespace solutions_desk.UserControls
{
    public partial class UCchamados : UserControl
    {
        private string Status;

        public UCchamados(int numero, string status, string data, string cliente )
        {
            InitializeComponent();
            setaStatus(status);

            lblNumeroChamado.Text = numero.ToString();
            setaStatus(status);
            lblData.Text = data;
            lblNomeCliente.Text = cliente;


        }
        private void setaStatus(string statusRecebido)
        {
            switch (statusRecebido)
            {
                case "encerrado":
                    panelStatus.BackColor = ColorTranslator.FromHtml("#24C06F");
                break;

                case "tecnico":
                    panelStatus.BackColor = ColorTranslator.FromHtml("#FF9B00");
                break;

                case "andamento":
                    panelStatus.BackColor = ColorTranslator.FromHtml("#5842EF");
                break;

                case "atraso":
                    panelStatus.BackColor = ColorTranslator.FromHtml("#FF5043");
                break;

                case "cancelado":
                    panelStatus.BackColor = ColorTranslator.FromHtml("#CACACA");
                break;

                case "aberto":
                    panelStatus.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                break;

            }
        }
        public string NomeCliente
        {
            get { return lblCliente.Text; }
            set { lblNomeCliente.Text = value; }
        }

        public string status
        {
            get { return this.Status; }
            set { this.Status = value; }
        }

        public int NumeroChamado
        {
            get { return Convert.ToInt32(lblNumeroChamado.Text); }
            set { lblNumeroChamado.Text = value.ToString(); }
        }

        public string DataCriacao
        {
            get { return lblData.Text; }
            set { lblData.Text = value; }
        }

        private void UCchamados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblNumeroChamado_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblAbertoEm_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblData_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void panelStatus_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
