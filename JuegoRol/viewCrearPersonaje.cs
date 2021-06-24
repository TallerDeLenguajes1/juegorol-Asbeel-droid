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
        CrearPersonaje newPersonaje;
        Personaje unDistinto;
        LinkedList<Personaje> listaPersonajes;
        public viewCrearPersonaje()
        {
            InitializeComponent();
            newPersonaje = new CrearPersonaje();
            unDistinto = newPersonaje.CrearPersonajeRandom();
            listaPersonajes = new LinkedList<Personaje>();
            
            this.cboTipo.DataSource = Enum.GetValues(typeof(TipoPersonaje)); //usamos el enum para llenar el combobox uwu
        }

        private void btnCrearPersonajeRandom_Click(object sender, EventArgs e)
        {
            this.unDistinto = newPersonaje.CrearPersonajeRandom();// Creamos un distinto uwu y luego lo sugerimos en pantalla
            //this.cboTipo.SelectedValue = unDistinto.Tipo;
            this.txtNombre.Text = unDistinto.Nombre;
            this.txtApodo.Text = unDistinto.Apodo;
            this.dateTimeFechaNacimiento.Value = unDistinto.FechaNacimiento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApodo.Text != "")
            {
                listaPersonajes.AddFirst(unDistinto);
                actualizarLista();
            }
        }

        private void actualizarLista()
        {
            this.lstPersonajes.Items.Insert(0, listaPersonajes.First.Value.ToString());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApodo.Text = "";
            txtNombre.Text = "";
        }

        private void lstPersonajes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BorrarPersonaje();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarPersonaje();
        }

        private void BorrarPersonaje()
        {
            int indice = lstPersonajes.SelectedIndex;
            LinkedListNode<Personaje> nodo = listaPersonajes.First;

            if (indice != -1)// Si hacemos doble click sobre la listbox y no hay elemento seleccionado, el método SelectedIndex devuelve -1
            {
                lstPersonajes.Items.RemoveAt(indice);//remuevo en pantalla
          
                for (int i = 0; i < indice; i++)//remuevo en memoria
                    nodo = nodo.Next;
                listaPersonajes.Remove(nodo);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("proximamente ?)");
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstPersonajes.Items.Clear();
            listaPersonajes.Clear();

        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            if (lstPersonajes.Items.Count > 1)
            {
                Hide();
                viewBatalla unaBatallaAIniciado = new viewBatalla(this.listaPersonajes);
                //ShowDialog();
                Show();
               
            }
            else
            {
                MessageBox.Show("Debe haber por lo menos 2 personajes para iniciar una batalla.", "Error");
            }
        }
    }
}
