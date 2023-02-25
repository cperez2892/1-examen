namespace CarlosPerez
{
    partial class Form2
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
            this.Examen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.programa1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programa2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programa3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Examen
            // 
            this.Examen.AutoSize = true;
            this.Examen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examen.Location = new System.Drawing.Point(128, 140);
            this.Examen.Name = "Examen";
            this.Examen.Size = new System.Drawing.Size(341, 31);
            this.Examen.TabIndex = 0;
            this.Examen.Text = "Examen Programacion III";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta: 20121009564";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programa1ToolStripMenuItem,
            this.programa2ToolStripMenuItem,
            this.programa3ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // programa1ToolStripMenuItem
            // 
            this.programa1ToolStripMenuItem.Name = "programa1ToolStripMenuItem";
            this.programa1ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programa1ToolStripMenuItem.Text = "Intereses";
            // 
            // programa2ToolStripMenuItem
            // 
            this.programa2ToolStripMenuItem.Name = "programa2ToolStripMenuItem";
            this.programa2ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.programa2ToolStripMenuItem.Text = "Facturacion";
            // 
            // programa3ToolStripMenuItem
            // 
            this.programa3ToolStripMenuItem.Name = "programa3ToolStripMenuItem";
            this.programa3ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.programa3ToolStripMenuItem.Text = "Multiplos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Examen);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Examen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem programa1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programa2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programa3ToolStripMenuItem;
    }
}