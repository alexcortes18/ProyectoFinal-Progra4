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
    public partial class UsuariosForm : Form
    {
        ConexionUsuarios tablaUsuarios = new ConexionUsuarios();

        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.proyectoDataSet.Usuario);
        }
        private bool noVacio()
        {
           if (rbnMasculino.Checked == false && rbnFemenino.Checked == false) return false;
           string genero = (rbnMasculino.Checked ? "Masculino" : "Femenino");
           if ((txtCodigo.Text!= "") && (txtCorreo.Text != "") && (txtIdentidad.Text != "") && (txtNombre.Text != "")
                && (txtPass.Text != "") && (txtTelefono.Text != "") && (genero != "") && (cmbRol.Text != ""))
            {
                return true;
            }
            return false;
        }

        private void Limipiar()
        {
            txtCodigo.Clear();
            txtCorreo.Clear();
            txtIdentidad.Clear();
            txtNombre.Clear();
            txtPass.Clear();
            txtTelefono.Clear();
            cmbRol.SelectedIndex = 0;
            rbnMasculino.Checked = true;
            //focus
            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
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
                    string genero = (rbnMasculino.Checked ? "Masculino" : "Femenino");
                    tablaUsuarios.GuardarUsuario(txtCodigo.Text, txtPass.Text, txtIdentidad.Text, txtNombre.Text,
                                                genero, txtCorreo.Text, txtTelefono.Text, cmbRol.Text);
                    MessageBox.Show("Nuevo usuario guardado con éxito!");
                    this.usuarioTableAdapter.Fill(this.proyectoDataSet.Usuario);
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
                    Usuario user = new Usuario();
                    user = tablaUsuarios.Encontrar(txtCodigo.Text);

                    if (user != null && user.Código != "")
                    {
                        string genero = (rbnMasculino.Checked ? "Masculino" : "Femenino");
                        tablaUsuarios.ModificarUsuario(txtCodigo.Text, txtPass.Text, txtIdentidad.Text, txtNombre.Text,
                                                    genero, txtCorreo.Text, txtTelefono.Text, cmbRol.Text);
                        MessageBox.Show("Usuario modificado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Usuario incorrecto o no existente!");
                    }
                    this.usuarioTableAdapter.Fill(this.proyectoDataSet.Usuario);
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
                    Usuario user = new Usuario();
                    user = tablaUsuarios.Encontrar(txtCodigo.Text);

                    if (user != null)
                    {
                        tablaUsuarios.EliminarUsuario(txtCodigo.Text);
                        MessageBox.Show("Usuario Eliminado");
                    }
                    else { MessageBox.Show("No existe ese usuario para eliminar."); }
                    this.usuarioTableAdapter.Fill(this.proyectoDataSet.Usuario);
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
