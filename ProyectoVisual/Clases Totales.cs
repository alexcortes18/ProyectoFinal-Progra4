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
    public partial class Clases_Totales : Form
    {
        ConexionClasesTotales tablaClases = new ConexionClasesTotales();

        public Clases_Totales()
        {
            InitializeComponent();
        }

        private void Clases_Totales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet5.Clases' table. You can move, or remove it, as needed.
            this.clasesTableAdapter.Fill(this.proyectoDataSet5.Clases);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            txtCodigoClase.Clear();
            txtDescripcionClase.Clear();
        }

        private bool noVacio()
        {
            if ((txtCodigoClase.Text != "") && (txtDescripcionClase.Text != "") && (cmbTipo.Text != ""))
            {
                return true;
            }
            return false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    tablaClases.GuardarClases(txtCodigoClase.Text, txtDescripcionClase.Text, cmbTipo.Text);
                    MessageBox.Show("Nueva clase guardada con éxito!");
                    this.clasesTableAdapter.Fill(this.proyectoDataSet5.Clases);
                }
                else { MessageBox.Show("Campo(s) Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    Clase clases = new Clase();
                    clases = tablaClases.Encontrar(txtCodigoClase.Text);

                    if (clases != null)
                    {
                        tablaClases.ModificarClases(txtCodigoClase.Text, txtDescripcionClase.Text, cmbTipo.Text);
                        MessageBox.Show("Usuario/Clase modificado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Clase incorrecto o no existente!");
                    }
                    this.clasesTableAdapter.Fill(this.proyectoDataSet5.Clases);
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    Clase clases = new Clase();
                    clases = tablaClases.Encontrar(txtCodigoClase.Text);

                    if (clases != null)
                    {
                        tablaClases.EliminarClases(txtCodigoClase.Text);
                        MessageBox.Show("Clase Eliminada");
                    }
                    else { MessageBox.Show("No existe ese clase para eliminar."); }
                    this.clasesTableAdapter.Fill(this.proyectoDataSet5.Clases);
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
