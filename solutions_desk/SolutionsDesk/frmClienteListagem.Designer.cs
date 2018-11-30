namespace solutions_desk
{
    partial class frmClienteListagem
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
            this.lblListagem = new System.Windows.Forms.Label();
            this.panelListaClientes = new System.Windows.Forms.Panel();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.placeHolderTextBox1 = new solutions_desk.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblListagem.Location = new System.Drawing.Point(12, 18);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(263, 41);
            this.lblListagem.TabIndex = 0;
            this.lblListagem.Text = "Lista de clientes";
            // 
            // panelListaClientes
            // 
            this.panelListaClientes.BackColor = System.Drawing.Color.White;
            this.panelListaClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListaClientes.Location = new System.Drawing.Point(0, 118);
            this.panelListaClientes.Name = "panelListaClientes";
            this.panelListaClientes.Size = new System.Drawing.Size(800, 332);
            this.panelListaClientes.TabIndex = 1;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Material Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(162)))));
            this.lblPesquisar.Location = new System.Drawing.Point(355, 64);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(34, 24);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "search";
            // 
            // panelSeparador
            // 
            this.panelSeparador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panelSeparador.Location = new System.Drawing.Point(9, 108);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(776, 1);
            this.panelSeparador.TabIndex = 4;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.IsSenha = false;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(19, 63);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Pesquisar clientes";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(330, 26);
            this.placeHolderTextBox1.TabIndex = 2;
            this.placeHolderTextBox1.Text = "Pesquisar clientes";
            // 
            // frmClienteListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSeparador);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.panelListaClientes);
            this.Controls.Add(this.lblListagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienteListagem";
            this.Text = "frmClienteListagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.Panel panelListaClientes;
        private PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Panel panelSeparador;
    }
}