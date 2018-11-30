namespace solutions_desk.UserControls
{
    partial class UCClientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadastradoEm = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.White;
            this.lblNomeCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(60, 10);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(95, 17);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome Cliente";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastrado em:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCadastradoEm
            // 
            this.lblCadastradoEm.AutoSize = true;
            this.lblCadastradoEm.BackColor = System.Drawing.Color.White;
            this.lblCadastradoEm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCadastradoEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblCadastradoEm.Location = new System.Drawing.Point(102, 35);
            this.lblCadastradoEm.Name = "lblCadastradoEm";
            this.lblCadastradoEm.Size = new System.Drawing.Size(71, 14);
            this.lblCadastradoEm.TabIndex = 3;
            this.lblCadastradoEm.Text = "00/00/0000";
            this.lblCadastradoEm.Click += new System.EventHandler(this.lblCadastradoEm_Click);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblIdCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIdCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblIdCliente.Location = new System.Drawing.Point(225, 0);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(10);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblIdCliente.Size = new System.Drawing.Size(55, 14);
            this.lblIdCliente.TabIndex = 4;
            this.lblIdCliente.Text = "1234";
            this.lblIdCliente.Click += new System.EventHandler(this.lblIdCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 58);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // UCClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblCadastradoEm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UCClientes";
            this.Size = new System.Drawing.Size(280, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadastradoEm;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Panel panel1;
    }
}
