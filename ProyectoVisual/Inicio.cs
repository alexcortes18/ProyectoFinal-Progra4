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
    public partial class Inicio : Form
    {
        ConexionUsuarios dbProyecto = new ConexionUsuarios();

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.ShowDialog();
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = dbProyecto.Encontrar(txtCodigoUsuario.Text);
                string nombre = user.Nombre_Completo;

                switch (dbProyecto.RoldeUsuario(txtCodigoUsuario.Text, txtContraseña.Text))
                {
                    case "Administrador":
                        MessageBox.Show("Credenciales correctas. ¡Bienvenido Administrador "+ nombre+ "!");
                        Administrador admin = new Administrador();
                        admin.WindowState = FormWindowState.Maximized;
                        admin.ShowDialog();
                        this.Close();
                        break;
                    case "Maestro":
                        MessageBox.Show("Credenciales correctas. ¡Bienvenido Maestro " + nombre + "!");
                        Maestro maestro = new Maestro(txtCodigoUsuario.Text);
                        //maestro.WindowState = FormWindowState.Maximized;
                        maestro.ShowDialog();
                        this.Close(); 
                        break;
                    case "Oficial Academico":
                        MessageBox.Show("Credenciales correctas. ¡Bienvenido Oficial Académico " + nombre + "!");
                        Oficial oficial = new Oficial();
                        oficial.WindowState = FormWindowState.Maximized;
                        oficial.ShowDialog();
                        //this.Close();
                        break;
                    case "":
                        MessageBox.Show("Codigo o password Invalido! \n Intentelo otra vez.");
                        Limpiar();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtCodigoUsuario.Clear();
            txtContraseña.Clear();
            txtCodigoUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
