using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVisual
{
    public partial class Oficial : Form
    {
        UsuariosForm uf = new UsuariosForm();
        Carreras carrera = new Carreras();
        Clases_Totales clases_Totales = new Clases_Totales();
        Solicitudes solicitudes = new Solicitudes();

        public Oficial()
        {
            InitializeComponent();
        }

        private void Oficial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Inicio form1 = new Inicio();
            form1.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carrera.MdiParent = this;
            carrera.Show();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clases_Totales.MdiParent = this;
            clases_Totales.Show();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarVentanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uf.Hide();
            carrera.Hide();
            clases_Totales.Hide();
            solicitudes.Hide();
        }
    }
}
