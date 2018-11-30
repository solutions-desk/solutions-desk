namespace solutions_desk
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelPai = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblAbrirChamado = new System.Windows.Forms.Label();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.lblHistoricoChamado = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.panelSelecionado = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNomeUsuarioLogado = new System.Windows.Forms.Label();
            this.btnMinimizeForm = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.panelPai.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPai
            // 
            this.panelPai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPai.Controls.Add(this.label1);
            this.panelPai.Location = new System.Drawing.Point(66, 30);
            this.panelPai.Name = "panelPai";
            this.panelPai.Size = new System.Drawing.Size(913, 499);
            this.panelPai.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARREGANDO...";
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.panelMenu.Controls.Add(this.lblOperador);
            this.panelMenu.Controls.Add(this.lblAbrirChamado);
            this.panelMenu.Controls.Add(this.lblConfiguracoes);
            this.panelMenu.Controls.Add(this.lblPerfil);
            this.panelMenu.Controls.Add(this.lblListaClientes);
            this.panelMenu.Controls.Add(this.lblHistoricoChamado);
            this.panelMenu.Controls.Add(this.lblSair);
            this.panelMenu.Controls.Add(this.panelSelecionado);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Location = new System.Drawing.Point(0, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(65, 530);
            this.panelMenu.TabIndex = 15;
            // 
            // lblAbrirChamado
            // 
            this.lblAbrirChamado.AutoSize = true;
            this.lblAbrirChamado.BackColor = System.Drawing.Color.White;
            this.lblAbrirChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbrirChamado.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirChamado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.lblAbrirChamado.Location = new System.Drawing.Point(15, 103);
            this.lblAbrirChamado.Name = "lblAbrirChamado";
            this.lblAbrirChamado.Size = new System.Drawing.Size(34, 24);
            this.lblAbrirChamado.TabIndex = 14;
            this.lblAbrirChamado.Text = "record_voice_over";
            this.lblAbrirChamado.Click += new System.EventHandler(this.lblAbrirChamado_Click);
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.lblConfiguracoes.Location = new System.Drawing.Point(15, 435);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(34, 24);
            this.lblConfiguracoes.TabIndex = 13;
            this.lblConfiguracoes.Text = "settings";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPerfil.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.White;
            this.lblPerfil.Location = new System.Drawing.Point(15, 383);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(34, 24);
            this.lblPerfil.TabIndex = 12;
            this.lblPerfil.Text = "person";
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaClientes.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.ForeColor = System.Drawing.Color.White;
            this.lblListaClientes.Location = new System.Drawing.Point(15, 259);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(34, 24);
            this.lblListaClientes.TabIndex = 11;
            this.lblListaClientes.Text = "group";
            this.lblListaClientes.Click += new System.EventHandler(this.lblListaClientes_Click);
            // 
            // lblHistoricoChamado
            // 
            this.lblHistoricoChamado.AutoSize = true;
            this.lblHistoricoChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistoricoChamado.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoChamado.ForeColor = System.Drawing.Color.White;
            this.lblHistoricoChamado.Location = new System.Drawing.Point(15, 207);
            this.lblHistoricoChamado.Name = "lblHistoricoChamado";
            this.lblHistoricoChamado.Size = new System.Drawing.Size(34, 24);
            this.lblHistoricoChamado.TabIndex = 0;
            this.lblHistoricoChamado.Text = "assignment";
            this.lblHistoricoChamado.Click += new System.EventHandler(this.lblHistoricoChamado_Click);
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(15, 487);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(34, 24);
            this.lblSair.TabIndex = 0;
            this.lblSair.Text = "exit_to_app";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // panelSelecionado
            // 
            this.panelSelecionado.BackgroundImage = global::solutions_desk.Properties.Resources.icone_selecionado;
            this.panelSelecionado.Location = new System.Drawing.Point(8, 91);
            this.panelSelecionado.Name = "panelSelecionado";
            this.panelSelecionado.Size = new System.Drawing.Size(49, 49);
            this.panelSelecionado.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 85);
            this.panel3.TabIndex = 9;
            // 
            // lblNomeUsuarioLogado
            // 
            this.lblNomeUsuarioLogado.AutoSize = true;
            this.lblNomeUsuarioLogado.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuarioLogado.Location = new System.Drawing.Point(71, 6);
            this.lblNomeUsuarioLogado.Name = "lblNomeUsuarioLogado";
            this.lblNomeUsuarioLogado.Size = new System.Drawing.Size(110, 18);
            this.lblNomeUsuarioLogado.TabIndex = 16;
            this.lblNomeUsuarioLogado.Text = "Solutions Desk";
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMinimizeForm.Image = global::solutions_desk.Properties.Resources.minimizar1;
            this.btnMinimizeForm.Location = new System.Drawing.Point(924, 4);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizeForm.TabIndex = 10;
            this.btnMinimizeForm.Click += new System.EventHandler(this.btnMinimizeForm_Click);
            this.btnMinimizeForm.MouseEnter += new System.EventHandler(this.btnMinimizeForm_MouseEnter);
            this.btnMinimizeForm.MouseLeave += new System.EventHandler(this.btnMinimizeForm_MouseLeave);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCloseForm.Image = global::solutions_desk.Properties.Resources.fechar1;
            this.btnCloseForm.Location = new System.Drawing.Point(952, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(24, 24);
            this.btnCloseForm.TabIndex = 9;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            this.btnCloseForm.MouseEnter += new System.EventHandler(this.btnCloseForm_MouseEnter);
            this.btnCloseForm.MouseLeave += new System.EventHandler(this.btnCloseForm_MouseLeave);
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogo.BackgroundImage = global::solutions_desk.Properties.Resources.logo;
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogo.Location = new System.Drawing.Point(10, 27);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(44, 30);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOperador.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.White;
            this.lblOperador.Location = new System.Drawing.Point(15, 155);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(34, 24);
            this.lblOperador.TabIndex = 16;
            this.lblOperador.Text = "assignment_ind";
            this.lblOperador.Click += new System.EventHandler(this.lblOperador_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 531);
            this.Controls.Add(this.lblNomeUsuarioLogado);
            this.Controls.Add(this.btnMinimizeForm);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.panelPai);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SD - PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseUp);
            this.panelPai.ResumeLayout(false);
            this.panelPai.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panelPai;
        private System.Windows.Forms.Label btnCloseForm;
        private System.Windows.Forms.Label btnMinimizeForm;
        private System.Windows.Forms.Label lblHistoricoChamado;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNomeUsuarioLogado;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Label lblAbrirChamado;
        private System.Windows.Forms.Panel panelSelecionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperador;
    }
}

