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
    public partial class Clases_de_Maestro : Form
    {
        ConexionClasesMaestro tablaClasesMaestro = new ConexionClasesMaestro();
        private string code;

        public Clases_de_Maestro()
        {
            InitializeComponent();
        }

        private void Clases_de_Maestro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet3.Clases_Maestro' table. You can move, or remove it, as needed.
            this.clases_MaestroTableAdapter.Fill(this.proyectoDataSet3.Clases_Maestro);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoClase.Clear();
            txtCodigoUsuario.Clear();
        }

        private bool noVacio()
        {
            if ((txtCodigoClase.Text != "") && (txtCodigoUsuario.Text != ""))
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
                    if (tablaClasesMaestro.validarMaestro(txtCodigoUsuario.Text))
                    {
                        tablaClasesMaestro.GuardarClasesMaestro(txtCodigoUsuario.Text, txtCodigoClase.Text);
                        MessageBox.Show("Nueva clases guardada con éxito!");
                        this.clases_MaestroTableAdapter.Fill(this.proyectoDataSet3.Clases_Maestro);
                    }
                    else { MessageBox.Show("Codigo de Maestro no valido"); }
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
                    Clases_Maestro clases = new Clases_Maestro();
                    clases = tablaClasesMaestro.Encontrar(txtCodigoUsuario.Text, cmbClasesdeMaestro.Text);

                    if (clases != null)
                    {
                        tablaClasesMaestro.ModificarClasesMaestro(txtCodigoUsuario.Text, txtCodigoClase.Text, cmbClasesdeMaestro.Text);
                        MessageBox.Show("Usuario/Clase modificado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Usuario/Clase incorrecto o no existente!");
                    }
                    this.clases_MaestroTableAdapter.Fill(this.proyectoDataSet3.Clases_Maestro);
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
                    Clases_Maestro clases = new Clases_Maestro();
                    clases = tablaClasesMaestro.Encontrar(txtCodigoUsuario.Text, cmbClasesdeMaestro.Text);

                    if (clases != null)
                    {
                        tablaClasesMaestro.EliminarClasesMaestro(txtCodigoUsuario.Text,txtCodigoClase.Text);
                        MessageBox.Show("Usuario Eliminado");
                    }
                    else { MessageBox.Show("No existe ese usuario para eliminar."); }
                    this.clases_MaestroTableAdapter.Fill(this.proyectoDataSet3.Clases_Maestro);
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void cmbClasesdeMaestro_DropDown_1(object sender, EventArgs e)
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

        private void cmbClasesdeMaestro_DropDownClosed_1(object sender, EventArgs e)
        {
            txtCodigoClase.Text = cmbClasesdeMaestro.Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbClasesdeMaestro.Items.Clear();
            code = txtCodigoUsuario.Text;
        }
    }
}
