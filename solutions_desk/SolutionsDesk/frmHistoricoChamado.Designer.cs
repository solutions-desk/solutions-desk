namespace solutions_desk
{
    partial class frmHistoricoChamado
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
            this.panelListaDeChamados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListaDeChamados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListaDeChamados
            // 
            this.panelListaDeChamados.BackColor = System.Drawing.Color.White;
            this.panelListaDeChamados.Controls.Add(this.label1);
            this.panelListaDeChamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListaDeChamados.Location = new System.Drawing.Point(0, 0);
            this.panelListaDeChamados.Name = "panelListaDeChamados";
            this.panelListaDeChamados.Size = new System.Drawing.Size(857, 473);
            this.panelListaDeChamados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historico de chamados";
            // 
            // frmHistoricoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 473);
            this.Controls.Add(this.panelListaDeChamados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoricoChamado";
            this.Text = "frmHistoricoChamado";
            this.Load += new System.EventHandler(this.frmHistoricoChamado_Load);
            this.panelListaDeChamados.ResumeLayout(false);
            this.panelListaDeChamados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListaDeChamados;
        private System.Windows.Forms.Label label1;
    }
}