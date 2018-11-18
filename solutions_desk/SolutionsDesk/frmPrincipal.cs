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
        private Operador pessoaLogada;

        public Operador PessoaLogada
        {
            get { return pessoaLogada; }
        }
        public frmPrincipal(frmLogin login, Operador pessoaLogada)
        {
            InitializeComponent();
            this.telaLogin = login;
            this.pessoaLogada = pessoaLogada;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.organizarMenu();
            //lblNomeUsuarioLogado.Text = this.pessoaLogada.Nome;
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

      

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.telaLogin.resetForm();
            this.telaLogin.Show();
            
        }
        private void lblAbrirChamadoIcone_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmAbrirChamado frmAbrirChamado = new frmAbrirChamado(panelPai.Width, panelPai.Height, pessoaLogada);
            frmAbrirChamado.TopLevel = false;
            panelPai.Controls.Add(frmAbrirChamado);
            frmAbrirChamado.Show();
            frmAbrirChamado.BringToFront();

            //panelPai.Controls.Clear();
            //frmHistoricoChamado frmHistoricoChamado = new frmHistoricoChamado();
            //frmHistoricoChamado.TopLevel = false;
            //panelPai.Controls.Add(frmHistoricoChamado);
            //frmHistoricoChamado.Show();
            //frmHistoricoChamado.BringToFront();
        }

        private void lblAbrirChamado_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmAbrirChamado frmAbrirChamado = new frmAbrirChamado(panelPai.Width, panelPai.Height, pessoaLogada);
            frmAbrirChamado.TopLevel = false;
            panelPai.Controls.Add(frmAbrirChamado);
            frmAbrirChamado.Show();
            frmAbrirChamado.BringToFront();
        }

        private void lblHistoricoChamado_Click(object sender, EventArgs e)
        {
            panelPai.Controls.Clear();
            frmHistoricoChamado frmHistoricoChamado = new frmHistoricoChamado(panelPai);
            frmHistoricoChamado.TopLevel = false;
            panelPai.Controls.Add(frmHistoricoChamado);
            frmHistoricoChamado.Show();
            frmHistoricoChamado.BringToFront();
        }
    }
}
