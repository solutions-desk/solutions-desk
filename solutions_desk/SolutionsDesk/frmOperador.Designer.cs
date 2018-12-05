namespace solutions_desk
{
    partial class frmOperador
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
            this.panelAcesso = new System.Windows.Forms.Panel();
            this.lblCadastrarOperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIconeListaClientes = new System.Windows.Forms.Label();
            this.lblListagemOperadores = new System.Windows.Forms.Label();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAcesso.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcesso
            // 
            this.panelAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panelAcesso.Controls.Add(this.lblCadastrarOperador);
            this.panelAcesso.Controls.Add(this.label2);
            this.panelAcesso.Controls.Add(this.lblIconeListaClientes);
            this.panelAcesso.Controls.Add(this.lblListagemOperadores);
            this.panelAcesso.Controls.Add(this.panelSelect);
            this.panelAcesso.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAcesso.Location = new System.Drawing.Point(0, 0);
            this.panelAcesso.Name = "panelAcesso";
            this.panelAcesso.Size = new System.Drawing.Size(250, 450);
            this.panelAcesso.TabIndex = 1;
            // 
            // lblCadastrarOperador
            // 
            this.lblCadastrarOperador.AutoSize = true;
            this.lblCadastrarOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrarOperador.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCadastrarOperador.Location = new System.Drawing.Point(60, 56);
            this.lblCadastrarOperador.Name = "lblCadastrarOperador";
            this.lblCadastrarOperador.Size = new System.Drawing.Size(145, 19);
            this.lblCadastrarOperador.TabIndex = 6;
            this.lblCadastrarOperador.Text = "Cadastrar operador";
            this.lblCadastrarOperador.Click += new System.EventHandler(this.lblCadastrarOperador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Material Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "person_add";
            // 
            // lblIconeListaClientes
            // 
            this.lblIconeListaClientes.AutoSize = true;
            this.lblIconeListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.lblIconeListaClientes.Font = new System.Drawing.Font("Material Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblIconeListaClientes.Location = new System.Drawing.Point(24, 22);
            this.lblIconeListaClientes.Name = "lblIconeListaClientes";
            this.lblIconeListaClientes.Size = new System.Drawing.Size(34, 24);
            this.lblIconeListaClientes.TabIndex = 7;
            this.lblIconeListaClientes.Text = "list";
            // 
            // lblListagemOperadores
            // 
            this.lblListagemOperadores.AutoSize = true;
            this.lblListagemOperadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.lblListagemOperadores.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblListagemOperadores.Location = new System.Drawing.Point(60, 25);
            this.lblListagemOperadores.Name = "lblListagemOperadores";
            this.lblListagemOperadores.Size = new System.Drawing.Size(144, 19);
            this.lblListagemOperadores.TabIndex = 5;
            this.lblListagemOperadores.Text = "Listade operadores";
            this.lblListagemOperadores.Click += new System.EventHandler(this.lblListagemOperadores_Click);
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.panelSelect.Location = new System.Drawing.Point(12, 47);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(227, 36);
            this.panelSelect.TabIndex = 9;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(250, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(550, 450);
            this.panelPrincipal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perfil operador";
            // 
            // frmOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperador";
            this.Text = "frmOperador";
            this.panelAcesso.ResumeLayout(false);
            this.panelAcesso.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAcesso;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastrarOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIconeListaClientes;
        private System.Windows.Forms.Label lblListagemOperadores;
        private System.Windows.Forms.Panel panelSelect;
    }
}