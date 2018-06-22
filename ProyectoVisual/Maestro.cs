using ConexionDB;
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
    public partial class Maestro : Form
    {
        ConexionClasesMaestro tablaClasesMaestro = new ConexionClasesMaestro();
        ConexionSolicitudes tablaSolicitudes = new ConexionSolicitudes();
        string code;

        public Maestro(string codigo)
        {
            InitializeComponent();
            this.code = codigo;
            
        }

        private void Maestro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Inicio form1 = new Inicio();
            form1.Show();
        }

        private void Maestro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet7.Solicitudes' table. You can move, or remove it, as needed.
            this.solicitudesTableAdapter.Fill(this.proyectoDataSet7.Solicitudes);
        }

        private bool noVacio()
        {
            if ((txtCodigoSolicitud.Text != "")  && (txtCantidadColor.Text != "") &&
                (txtCantidadNegro.Text != "") && (txtObservaciones.Text != "") && (cmbEstado.Text != "") &&
                (cmbTipo.Text != ""))
            {
                return true;
            }
            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoSolicitud.Clear();
            txtCantidadColor.Clear();
            txtCantidadNegro.Clear();
            txtEstado.Clear();
            txtObservaciones.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    tablaSolicitudes.GuardarSolicitud(txtCodigoSolicitud.Text, code, Fecha.Text,
                                                    txtCantidadColor.Text, txtCantidadNegro.Text, cmbTipo.Text,
                                                    cmbClasesdeMaestro.Text, code, cmbEstado.Text, txtObservaciones.Text);
                    MessageBox.Show("Nueva solicitud guardada con éxito!");
                    this.solicitudesTableAdapter.Fill(this.proyectoDataSet7.Solicitudes);
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
                    Solicitude solicitud = new Solicitude();
                    solicitud = tablaSolicitudes.Encontrar(txtCodigoSolicitud.Text);

                    if (solicitud != null)
                    {
                        tablaSolicitudes.ModificarSolicitud(txtCodigoSolicitud.Text, code, Fecha.Text,
                                                    txtCantidadColor.Text, txtCantidadNegro.Text, cmbTipo.Text,
                                                    cmbClasesdeMaestro.Text, code, cmbEstado.Text, txtObservaciones.Text);
                        MessageBox.Show("Solicitud modificada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Solicitud incorrecto o no existente!");
                    }
                    this.solicitudesTableAdapter.Fill(this.proyectoDataSet7.Solicitudes);
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
                    Solicitude solicitud = new Solicitude();
                    solicitud = tablaSolicitudes.Encontrar(txtCodigoSolicitud.Text);

                    if (solicitud != null)
                    {
                        tablaSolicitudes.EliminarSolcitud(txtCodigoSolicitud.Text);
                        MessageBox.Show("Solicitud Eliminada");
                    }
                    else { MessageBox.Show("No existe ese solicitud para eliminar."); }
                    this.solicitudesTableAdapter.Fill(this.proyectoDataSet7.Solicitudes);
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbClasesdeMaestro_DropDown(object sender, EventArgs e)
        { 
            try
            {
                string clase;
                List<Clases_Maestro> clases = tablaClasesMaestro.Encontrar(code);
                foreach (var item in clases)
                {
                    clase = item.Código_de_Clase;
                    if(!cmbClasesdeMaestro.Items.Contains(clase))
                    cmbClasesdeMaestro.Items.Add(clase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbClasesdeMaestro.Items.Clear();

            Solicitude solicitud = new Solicitude();
            solicitud = tablaSolicitudes.Encontrar(txtCodigoSolicitud.Text);

            if (solicitud != null)
            {
                txtCodigoSolicitud.Text = solicitud.Código_de_solicitud;
                cmbClasesdeMaestro.Text = solicitud.Código_de_clase;
                txtCantidadColor.Text = solicitud.Cantidad_a_color;
                txtCantidadNegro.Text = solicitud.Cantidad_blanco_y_negro;
                txtEstado.Text = solicitud.Estado;
                txtObservaciones.Text = solicitud.Observaciones;
                cmbEstado.Text = solicitud.Estado;
                cmbTipo.Text = solicitud.Tipo;
            }
        }
    }
}
