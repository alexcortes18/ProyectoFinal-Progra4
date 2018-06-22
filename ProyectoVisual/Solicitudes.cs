using ConexionDB;
using System;
using System.Windows.Forms;

namespace ProyectoVisual
{
    public partial class Solicitudes : Form
    {
        ConexionSolicitudes tablaSolicitud = new ConexionSolicitudes();

        public Solicitudes()
        {
            InitializeComponent();
        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet6.Solicitudes' table. You can move, or remove it, as needed.
            this.solicitudesTableAdapter.Fill(this.proyectoDataSet6.Solicitudes);

        }

        private bool noVacio()
        {
            if ((txtCodigoSolicitud.Text != "") && (txtCodigoUsuario.Text != "") && (txtCantidadColor.Text != "") &&
                (txtCantidadNegro.Text != "") && (txtCodigoClase.Text != "") && (txtCodigoMaestro.Text != "")
                && (txtObservaciones.Text != "") && (cmbEstado.Text != "") &&
                (cmbTipo.Text != ""))
            {
                return true;
            }
            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoSolicitud.Clear();
            txtCodigoUsuario.Clear();
            txtCantidadColor.Clear();
            txtCantidadNegro.Clear();
            txtCodigoClase.Clear();
            txtCodigoMaestro.Clear();
            txtEstado.Clear();
            txtObservaciones.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    tablaSolicitud.GuardarSolicitud(txtCodigoSolicitud.Text, txtCodigoUsuario.Text, Fecha.Text,
                                                    txtCantidadColor.Text, txtCantidadNegro.Text, cmbTipo.Text,
                                                    txtCodigoClase.Text, txtCodigoMaestro.Text, cmbEstado.Text, txtObservaciones.Text);
                    MessageBox.Show("Nueva solicitud guardada con éxito!");
                    this.solicitudesTableAdapter.Fill(this.proyectoDataSet6.Solicitudes);
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
                    solicitud = tablaSolicitud.Encontrar(txtCodigoSolicitud.Text);

                    if (solicitud != null)
                    {
                        tablaSolicitud.ModificarSolicitud(txtCodigoSolicitud.Text, txtCodigoUsuario.Text, Fecha.Text,
                                                    txtCantidadColor.Text, txtCantidadNegro.Text, cmbTipo.Text,
                                                    txtCodigoClase.Text, txtCodigoMaestro.Text, cmbEstado.Text, txtObservaciones.Text);
                        MessageBox.Show("Solicitud modificada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Solicitud incorrecto o no existente!");
                    }
                    this.solicitudesTableAdapter.Fill(this.proyectoDataSet6.Solicitudes);
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
                    solicitud = tablaSolicitud.Encontrar(txtCodigoSolicitud.Text);

                    if (solicitud != null)
                    {
                        tablaSolicitud.EliminarSolcitud(txtCodigoSolicitud.Text);
                        MessageBox.Show("Solicitud Eliminada");
                    }
                    else { MessageBox.Show("No existe ese solicitud para eliminar."); }
                    this.solicitudesTableAdapter.Fill(this.proyectoDataSet6.Solicitudes);
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Solicitude solicitud = new Solicitude();
            solicitud = tablaSolicitud.Encontrar(txtCodigoSolicitud.Text);

            if (solicitud != null)
            {
                txtCodigoSolicitud.Text = solicitud.Código_de_solicitud;
                txtCodigoUsuario.Text = solicitud.Código_usuario;
                txtCantidadColor.Text = solicitud.Cantidad_a_color;
                txtCantidadNegro.Text = solicitud.Cantidad_blanco_y_negro;
                txtCodigoClase.Text = solicitud.Código_de_clase;
                txtCodigoMaestro.Text = solicitud.Código_de_maestro;
                txtEstado.Text = solicitud.Estado;
                txtObservaciones.Text = solicitud.Observaciones;
                cmbEstado.Text = solicitud.Estado;
                cmbTipo.Text = solicitud.Tipo;
            }
        }
    }
}
