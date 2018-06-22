using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDB;

namespace ProyectoVisual
{
    public partial class Administrador : Form
    {
        UsuariosForm uf = new UsuariosForm();
        Carreras carrera = new Carreras();
        Clases_de_Carrera clases_De_Carrera = new Clases_de_Carrera();
        Clases_de_Maestro clases_De_Maestro = new Clases_de_Maestro();
        Clases_Totales clases_Totales = new Clases_Totales();
        Solicitudes solicitudes = new Solicitudes();

        public Administrador()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uf.MdiParent = this;
            uf.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carrera.MdiParent = this;
            carrera.Show();
        }

        private void clasesdeCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clases_De_Carrera.MdiParent = this;
            clases_De_Carrera.Show();
        }

        private void clasesdeMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clases_De_Maestro.MdiParent = this;
            clases_De_Maestro.Show();
        }

        private void clasesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clases_Totales.MdiParent = this;
            clases_Totales.Show();
        }

        private void solicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            solicitudes.MdiParent = this;
            solicitudes.Show();
        }

        private void Rol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void cerrarVentanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uf.Hide();
            carrera.Hide();
            clases_De_Carrera.Hide();
            clases_De_Maestro.Hide();
            clases_Totales.Hide();
            solicitudes.Hide();
        }
    }
}
