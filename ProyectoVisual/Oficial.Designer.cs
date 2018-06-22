namespace ProyectoVisual
{
    partial class Oficial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrerasToolStripMenuItem,
            this.clasesToolStripMenuItem,
            this.maestrosToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.cerrarVentanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.clasesToolStripMenuItem.Text = "Clases";
            this.clasesToolStripMenuItem.Click += new System.EventHandler(this.clasesToolStripMenuItem_Click);
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrosToolStripMenuItem.Text = "Maestros";
            this.maestrosToolStripMenuItem.Click += new System.EventHandler(this.maestrosToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesToolStripMenuItem_Click);
            // 
            // cerrarVentanasToolStripMenuItem
            // 
            this.cerrarVentanasToolStripMenuItem.Name = "cerrarVentanasToolStripMenuItem";
            this.cerrarVentanasToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cerrarVentanasToolStripMenuItem.Text = "Cerrar Ventanas";
            this.cerrarVentanasToolStripMenuItem.Click += new System.EventHandler(this.cerrarVentanasToolStripMenuItem_Click);
            // 
            // Oficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 598);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Oficial";
            this.Text = "Oficial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Oficial_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanasToolStripMenuItem;
    }
}