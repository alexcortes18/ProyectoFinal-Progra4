﻿using System;
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
    public partial class Clases_de_Carrera : Form
    {
        ConexionClasesCarrera tablaClasesCarrera = new ConexionClasesCarrera();
        private string code;

        public Clases_de_Carrera()
        {
            InitializeComponent();
        }

        private void Clases_de_Carrera_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet4.Clases_Carrera' table. You can move, or remove it, as needed.
            this.clases_CarreraTableAdapter.Fill(this.proyectoDataSet4.Clases_Carrera);

        }

        private bool noVacio()
        {
            if ((txtCodigoClase.Text != "") && (txtCodigoCarera.Text != ""))
            {
                return true;
            }
            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoClase.Clear();
            txtCodigoCarera.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    Clases_Carrera clases = new Clases_Carrera();
                    clases = tablaClasesCarrera.EncontrarCarrera(txtCodigoCarera.Text, cmbClasesCarrera.Text);

                    if (clases != null)
                    {
                        tablaClasesCarrera.EliminarClasesCarrera(txtCodigoCarera.Text, txtCodigoClase.Text);
                        MessageBox.Show("Usuario Eliminado");
                        this.clases_CarreraTableAdapter.Fill(this.proyectoDataSet4.Clases_Carrera);
                    }
                    else { MessageBox.Show("No existe ese usuario para eliminar."); }
                    
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (noVacio())
                {
                    tablaClasesCarrera.GuardarClasesCarrera(txtCodigoCarera.Text, txtCodigoClase.Text);
                    MessageBox.Show("Nueva clases guardada con éxito!");
                    this.clases_CarreraTableAdapter.Fill(this.proyectoDataSet4.Clases_Carrera);
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
                    Clases_Carrera clases = new Clases_Carrera();
                    clases = tablaClasesCarrera.EncontrarCarrera(txtCodigoCarera.Text, cmbClasesCarrera.Text);

                    if (clases != null)
                    {
                        tablaClasesCarrera.ModificarClasesMaestro(txtCodigoCarera.Text, txtCodigoClase.Text, cmbClasesCarrera.Text);
                        MessageBox.Show("Usuario/Clase modificado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Usuario/Clase incorrecto o no existente!");
                    }
                    this.clases_CarreraTableAdapter.Fill(this.proyectoDataSet4.Clases_Carrera);
                }
                else { MessageBox.Show("Campo Vacío. Intente otra vez."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            cmbClasesCarrera.Items.Clear();
            code = txtCodigoCarera.Text;
        }

        private void cmbClasesdeMaestro_DropDownClosed(object sender, EventArgs e)
        {
            txtCodigoClase.Text = cmbClasesCarrera.Text;
        }

        private void cmbClasesdeMaestro_DropDown(object sender, EventArgs e)
        {
            try
            {
                string clase;
                List<Clases_Carrera> clases = tablaClasesCarrera.EncontrarCarrera(code);
                foreach (var item in clases)
                {
                    clase = item.Código_de_Clase;
                    if (!cmbClasesCarrera.Items.Contains(clase))
                        cmbClasesCarrera.Items.Add(clase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
