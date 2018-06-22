namespace ProyectoVisual
{
    partial class Administrador
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesdeCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesdeMaestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.cerrarVentanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.verToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.carrerasToolStripMenuItem,
            this.clasesdeCarreraToolStripMenuItem,
            this.clasesdeMaestroToolStripMenuItem,
            this.clasesToolStripMenuItem1,
            this.solicitudesToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // clasesdeCarreraToolStripMenuItem
            // 
            this.clasesdeCarreraToolStripMenuItem.Name = "clasesdeCarreraToolStripMenuItem";
            this.clasesdeCarreraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clasesdeCarreraToolStripMenuItem.Text = "Clases de Carreras";
            this.clasesdeCarreraToolStripMenuItem.Click += new System.EventHandler(this.clasesdeCarreraToolStripMenuItem_Click);
            // 
            // clasesdeMaestroToolStripMenuItem
            // 
            this.clasesdeMaestroToolStripMenuItem.Name = "clasesdeMaestroToolStripMenuItem";
            this.clasesdeMaestroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clasesdeMaestroToolStripMenuItem.Text = "Clases de Maestro";
            this.clasesdeMaestroToolStripMenuItem.Click += new System.EventHandler(this.clasesdeMaestroToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "V&er";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.cascadaToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "&Ventana";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // cerrarVentanasToolStripMenuItem
            // 
            this.cerrarVentanasToolStripMenuItem.Name = "cerrarVentanasToolStripMenuItem";
            this.cerrarVentanasToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cerrarVentanasToolStripMenuItem.Text = "&Cerrar Ventanas";
            this.cerrarVentanasToolStripMenuItem.Click += new System.EventHandler(this.cerrarVentanasToolStripMenuItem_Click);
            // 
            // clasesToolStripMenuItem1
            // 
            this.clasesToolStripMenuItem1.Name = "clasesToolStripMenuItem1";
            this.clasesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clasesToolStripMenuItem1.Text = "Clases";
            this.clasesToolStripMenuItem1.Click += new System.EventHandler(this.clasesToolStripMenuItem1_Click);
            // 
            // solicitudesToolStripMenuItem1
            // 
            this.solicitudesToolStripMenuItem1.Name = "solicitudesToolStripMenuItem1";
            this.solicitudesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.solicitudesToolStripMenuItem1.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem1.Click += new System.EventHandler(this.solicitudesToolStripMenuItem1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 594);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rol_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesdeCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesdeMaestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem1;
    }
}