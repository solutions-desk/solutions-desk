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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListaDeChamados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListaDeChamados
            // 
            this.panelListaDeChamados.BackColor = System.Drawing.Color.White;
            this.panelListaDeChamados.Controls.Add(this.label1);
            this.panelListaDeChamados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListaDeChamados.Location = new System.Drawing.Point(0, 0);
            this.panelListaDeChamados.Name = "panelListaDeChamados";
            this.panelListaDeChamados.Size = new System.Drawing.Size(857, 422);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(657, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 51);
            this.panel1.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(120, 18);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(18, 19);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(91, 18);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(18, 19);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(162)))));
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "keyboard_arrow_left";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(62, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(18, 19);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Material Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(162)))));
            this.label2.Location = new System.Drawing.Point(149, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "keyboard_arrow_right";
            // 
            // frmHistoricoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListaDeChamados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoricoChamado";
            this.Text = "frmHistoricoChamado";
            this.Load += new System.EventHandler(this.frmHistoricoChamado_Load);
            this.panelListaDeChamados.ResumeLayout(false);
            this.panelListaDeChamados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListaDeChamados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
    }
}