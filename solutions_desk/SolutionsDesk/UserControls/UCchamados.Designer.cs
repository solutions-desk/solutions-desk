namespace solutions_desk.UserControls
{
    partial class UCchamados
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
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNumeroChamado = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblAbertoEm = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(8, 70);
            this.panelStatus.TabIndex = 0;
            this.panelStatus.Click += new System.EventHandler(this.panelStatus_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 10);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(22, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Nº:";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblNumeroChamado
            // 
            this.lblNumeroChamado.AutoSize = true;
            this.lblNumeroChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroChamado.Location = new System.Drawing.Point(37, 10);
            this.lblNumeroChamado.Name = "lblNumeroChamado";
            this.lblNumeroChamado.Size = new System.Drawing.Size(14, 13);
            this.lblNumeroChamado.TabIndex = 2;
            this.lblNumeroChamado.Text = "0";
            this.lblNumeroChamado.Click += new System.EventHandler(this.lblNumeroChamado_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(55, 28);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(96, 13);
            this.lblNomeCliente.TabIndex = 4;
            this.lblNomeCliente.Text = "Nome do fulano";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblAbertoEm
            // 
            this.lblAbertoEm.AutoSize = true;
            this.lblAbertoEm.Location = new System.Drawing.Point(17, 45);
            this.lblAbertoEm.Name = "lblAbertoEm";
            this.lblAbertoEm.Size = new System.Drawing.Size(58, 13);
            this.lblAbertoEm.TabIndex = 5;
            this.lblAbertoEm.Text = "Aberto em:";
            this.lblAbertoEm.Click += new System.EventHandler(this.lblAbertoEm_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(73, 45);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(75, 13);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "00/00/0000";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // UCchamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblAbertoEm);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNumeroChamado);
            this.Controls.Add(this.panelStatus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCchamados";
            this.Size = new System.Drawing.Size(214, 68);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCchamados_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNumeroChamado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblAbertoEm;
        private System.Windows.Forms.Label lblData;
    }
}
