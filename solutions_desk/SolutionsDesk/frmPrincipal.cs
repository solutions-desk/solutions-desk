using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace solutions_desk
{
    public partial class frmPrincipal : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private frmLogin telaLogin;
        private Pessoa pessoa;

        public frmPrincipal(frmLogin login, Pessoa pessoaLogada)
        {
            InitializeComponent();
            this.telaLogin = login;
            pessoa = pessoaLogada;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMenu1_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmAbrirChamado a = new frmAbrirChamado();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();

            panelMenu1.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //=======================

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call2;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void lblMenu1_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmAbrirChamado frmAbrirChamado = new frmAbrirChamado();
            frmAbrirChamado.TopLevel = false;
            panelPai.Controls.Add(frmAbrirChamado);
            frmAbrirChamado.Show();
            frmAbrirChamado.BringToFront();

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#084AA2");
            lblSair.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            //panelMenu1.BackColor = ColorTranslator.FromHtml("#4682B4");
            //panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            
            //lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            //lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            //lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            //lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            //lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            //lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            //lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            //panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call2;
            //panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            //panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            //panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            //panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            //panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            //panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            //panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void panelMenu2_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmEmail a = new frmEmail();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email2;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void lblMenu2_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmEmail a = new frmEmail();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email2;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void panelMenu3_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmTicket a = new frmTicket();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket2;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void lblMenu3_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmTicket a = new frmTicket();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            
            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket2;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void panelMenu4_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmRelatorios a = new frmRelatorios();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios2;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void lblMenu4_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmRelatorios a = new frmRelatorios();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios2;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void lblMenu5_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule2;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void panelMenu5_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule2;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void lblMenu6_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmCatraca a = new frmCatraca();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#4682B4");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca2;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void panelMenu6_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmCatraca a = new frmCatraca();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#4682B4");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca2;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            

            panelPai.Controls.Clear();
            frmHome a = new frmHome();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void panelConfig1_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmTags a = new frmTags();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags2;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmTags a = new frmTags();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#4682B4");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#333333");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags2;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao1;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmConfig a = new frmConfig();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#4682B4");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao2;
        }

        private void panelConfig2_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmConfig a = new frmConfig();
            a.TopLevel = false;
            panelPai.Controls.Add(a);
            a.Show();
            a.BringToFront();
            

            panelMenu1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelMenu6.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            panelConfig1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            panelConfig2.BackColor = ColorTranslator.FromHtml("#4682B4");

            //COLORS

            lblAbrirChamadoIcone.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu2.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu3.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu4.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu5.ForeColor = ColorTranslator.FromHtml("#333333");
            lblMenu6.ForeColor = ColorTranslator.FromHtml("#333333");

            lblconfig1.ForeColor = ColorTranslator.FromHtml("#333333");
            lblconfig2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            panelMenu1.BackgroundImage = solutions_desk.Properties.Resources.call1;
            panelMenu2.BackgroundImage = solutions_desk.Properties.Resources.email1;
            panelMenu3.BackgroundImage = solutions_desk.Properties.Resources.ticket1;
            panelMenu4.BackgroundImage = solutions_desk.Properties.Resources.relatorios1;
            panelMenu5.BackgroundImage = solutions_desk.Properties.Resources.griaule1;
            panelMenu6.BackgroundImage = solutions_desk.Properties.Resources.catraca1;

            panelConfig1.BackgroundImage = solutions_desk.Properties.Resources.tags1;
            panelConfig2.BackgroundImage = solutions_desk.Properties.Resources.configuracao2;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.organizarMenu();


            lblNomeUsuarioLogado.Text = this.pessoa.Nome;


        }

        public void organizarMenu()
        {
            PrivateFontCollection materialFont = new PrivateFontCollection();

            int fontLength = Properties.Resources.MaterialIcons.Length;

            byte[] fontData = Properties.Resources.MaterialIcons;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontData, 0, data, fontLength);

            materialFont.AddMemoryFont(data, fontLength);


            Font fontIconsDefault = new Font(materialFont.Families[0], 18);
            //lblIcone.Font = new Font(materialFont.Families[0], 24);
            //lblIcone.Text = "delete";
            


        }

        private void btnCloseForm_MouseEnter(object sender, EventArgs e)
        {
            btnCloseForm.Image = solutions_desk.Properties.Resources.fechar2;
        }

        private void btnCloseForm_MouseLeave(object sender, EventArgs e)
        {
            btnCloseForm.Image = solutions_desk.Properties.Resources.fechar1;
        }

        private void btnMinimizeForm_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizeForm.Image = solutions_desk.Properties.Resources.minimizar2;
        }

        private void btnMinimizeForm_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizeForm.Image = solutions_desk.Properties.Resources.minimizar1;
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelMenu1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void presetFormanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.telaLogin.resetForm();
            this.telaLogin.Show();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPai_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
