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
    public partial class Registro : Form
    {
        ConexionUsuarios dbProyecto = new ConexionUsuarios();

        public Registro()
        {
            InitializeComponent();
        }

        private bool noVacio()
        {
            if (rbnMasculino.Checked == false && rbnFemenino.Checked == false) return false;
            string genero = (rbnMasculino.Checked ? "Masculino" : "Femenino");
            if ((txtCodigo.Text != "") && (txtCorreo.Text != "") && (txtIdentidad.Text != "") && (txtNombre.Text != "")
                 && (txtPass.Text != "") && (txtTelefono.Text != "") && (genero != "") && (cmbRol.Text != ""))
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
                    string genero = (rbnMasculino.Checked ? "Masculino" : "Femenino");
                    dbProyecto.GuardarUsuario(txtCodigo.Text, txtPass.Text, txtIdentidad.Text, txtNombre.Text,
                                                genero, txtCorreo.Text, txtTelefono.Text, cmbRol.Text);
                    MessageBox.Show("Nuevo usuario guardado con éxito!");
                }
                else { MessageBox.Show("Campo(s) Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Hide();
            form.ShowDialog();
            this.Close();            
        }
    }
}
