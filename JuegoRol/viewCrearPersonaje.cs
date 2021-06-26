using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class viewCrearPersonaje : Form
    {
        public Control elAdmin;
        public viewCrearPersonaje()
        {
            InitializeComponent();
            elAdmin = new Control();
            this.cboTipo.DataSource = Enum.GetValues(typeof(TipoPersonaje)); //usamos el enum para llenar el combobox uwu
        }

        private void btnCrearPersonajeRandom_Click(object sender, EventArgs e)
        {
            elAdmin.crearPersonajeRandom();
            this.cboTipo.SelectedIndex = (int)elAdmin.UnDistinto.Tipo;
            this.txtNombre.Text = elAdmin.UnDistinto.Nombre;
            this.txtApodo.Text = elAdmin.UnDistinto.Apodo;
            this.dateTimeFechaNacimiento.Value = elAdmin.UnDistinto.FechaNacimiento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string identidadPersonaje;
            if (txtNombre.Text != "" && txtApodo.Text != "")
            {
                identidadPersonaje = elAdmin.guardarPersonaje();
                lstPersonajes.Items.Add(identidadPersonaje);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApodo.Text = "";
            txtNombre.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = lstPersonajes.SelectedIndex;
            elAdmin.borrarPersonaje(indice);//remuevo en memoria
            lstPersonajes.Items.RemoveAt(indice);//remuevo en pantalla
        }

        private void lstPersonajes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnBorrar.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("proximamente ?)");
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstPersonajes.Items.Clear();
            elAdmin.limpiarLista();
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            if (lstPersonajes.Items.Count > 1)
            {
                Hide();
                viewBatalla unaBatallaAIniciado = new viewBatalla(this);
                unaBatallaAIniciado.ShowDialog();
                viewPersonaje ganador = new viewPersonaje(elAdmin.ListaPersonajes.First.Value);
                ganador.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Debe haber por lo menos 2 personajes para iniciar una batalla.", "Error");
            }
        }
    }
}
