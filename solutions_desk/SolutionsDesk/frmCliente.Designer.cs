namespace solutions_desk
{
    partial class frmCliente
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
            this.lblCadastrarClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIconeListaClientes = new System.Windows.Forms.Label();
            this.lblListagemClientes = new System.Windows.Forms.Label();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcesso
            // 
            this.panelAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panelAcesso.Controls.Add(this.lblCadastrarClientes);
            this.panelAcesso.Controls.Add(this.label2);
            this.panelAcesso.Controls.Add(this.lblIconeListaClientes);
            this.panelAcesso.Controls.Add(this.lblListagemClientes);
            this.panelAcesso.Controls.Add(this.panelSelect);
            this.panelAcesso.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAcesso.Location = new System.Drawing.Point(0, 0);
            this.panelAcesso.Name = "panelAcesso";
            this.panelAcesso.Size = new System.Drawing.Size(250, 450);
            this.panelAcesso.TabIndex = 2;
            // 
            // lblCadastrarClientes
            // 
            this.lblCadastrarClientes.AutoSize = true;
            this.lblCadastrarClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrarClientes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCadastrarClientes.Location = new System.Drawing.Point(56, 60);
            this.lblCadastrarClientes.Name = "lblCadastrarClientes";
            this.lblCadastrarClientes.Size = new System.Drawing.Size(136, 19);
            this.lblCadastrarClientes.TabIndex = 1;
            this.lblCadastrarClientes.Text = "Cadastrar clientes";
            this.lblCadastrarClientes.Click += new System.EventHandler(this.lblCadastrarClientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Material Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "person_add";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIconeListaClientes
            // 
            this.lblIconeListaClientes.AutoSize = true;
            this.lblIconeListaClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblIconeListaClientes.Font = new System.Drawing.Font("Material Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblIconeListaClientes.Location = new System.Drawing.Point(20, 21);
            this.lblIconeListaClientes.Name = "lblIconeListaClientes";
            this.lblIconeListaClientes.Size = new System.Drawing.Size(34, 24);
            this.lblIconeListaClientes.TabIndex = 2;
            this.lblIconeListaClientes.Text = "list";
            this.lblIconeListaClientes.Click += new System.EventHandler(this.lblIconeListaClientes_Click);
            // 
            // lblListagemClientes
            // 
            this.lblListagemClientes.AutoSize = true;
            this.lblListagemClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblListagemClientes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblListagemClientes.Location = new System.Drawing.Point(56, 24);
            this.lblListagemClientes.Name = "lblListagemClientes";
            this.lblListagemClientes.Size = new System.Drawing.Size(119, 19);
            this.lblListagemClientes.TabIndex = 0;
            this.lblListagemClientes.Text = "Listade clientes";
            this.lblListagemClientes.Click += new System.EventHandler(this.lblListagemClientes_Click);
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.panelSelect.Location = new System.Drawing.Point(12, 16);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(227, 36);
            this.panelSelect.TabIndex = 4;
            this.panelSelect.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSelect_Paint);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(250, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(550, 450);
            this.panelPrincipal.TabIndex = 3;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.panelAcesso.ResumeLayout(false);
            this.panelAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAcesso;
        private System.Windows.Forms.Label lblListagemClientes;
        private System.Windows.Forms.Label lblIconeListaClientes;
        private System.Windows.Forms.Label lblCadastrarClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelSelect;
    }
}