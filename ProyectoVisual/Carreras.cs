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
    public partial class Carreras : Form
    {
        ConexionCarreras tablaCarreras = new ConexionCarreras();

        public Carreras()
        {
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet1.Carreras' table. You can move, or remove it, as needed.
            this.carrerasTableAdapter.Fill(this.proyectoDataSet1.Carreras);

        }
        
        private void Limipiar()
        {
            try
            {
                txtCodigoCarrera.Clear();
                txtNombre.Clear();
                txtCantidadClases.Clear();
                txtCantidadMaestros.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool noVacio()
        {
            if ((txtCodigoCarrera.Text != "") && (txtCantidadClases.Text != "") && 
                (txtCantidadMaestros.Text != "") && (txtNombre.Text != ""))
            {
                return true;
            }
            return false;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                Limipiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    tablaCarreras.GuardarCarrera(txtCodigoCarrera.Text, txtNombre.Text, Convert.ToInt32(txtCantidadClases.Text),
                                                Convert.ToInt32(txtCantidadMaestros.Text));
                    MessageBox.Show("Nuevo carrera guardada con éxito!");
                    this.carrerasTableAdapter.Fill(this.proyectoDataSet1.Carreras);
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
                    Carrera user = new Carrera();
                    user = tablaCarreras.Encontrar(txtCodigoCarrera.Text);

                    if (user != null && user.Código_de_carrera != "")
                    {
                        tablaCarreras.ModificarCarrera(txtCodigoCarrera.Text, txtNombre.Text, Convert.ToInt32(txtCantidadClases),
                                                        Convert.ToInt32(txtCantidadMaestros.Text));
                        MessageBox.Show("Usuario modificado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Usuario incorrecto o no existente!");
                    }
                    this.carrerasTableAdapter.Fill(this.proyectoDataSet1.Carreras);
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

        }
    }
}
