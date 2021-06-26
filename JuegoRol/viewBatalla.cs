using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class viewBatalla : Form
    {
        Control elAdmi;
        public viewBatalla(viewCrearPersonaje vista)
        {
            InitializeComponent();
            this.elAdmi = vista.elAdmin;
            cargar();// cargar lstParticipantes
        }

        private void cargar()
        {
            //int i = 0;
            LinkedListNode<Personaje> nodo = elAdmi.ListaPersonajes.First;
            while (nodo != null)
            {
                lstPersonajesEnBatalla.Items.Add(nodo.Value.ToString());
                nodo = nodo.Next;
            }
            elAdmi.contrincante();//prepara unPeleadorMas
            cargarEnfrentamiento();
        }

        private void cargarEnfrentamiento()
        {
            lblNombre1.Text = elAdmi.UnDistinto.Nombre.ToString();
            lblApodo1.Text = elAdmi.UnDistinto.Apodo.ToString();
            lblTipo1.Text = elAdmi.UnDistinto.Tipo.ToString();
            lblNivel1.Text = elAdmi.UnDistinto.Nivel.ToString();
            lblNombre2.Text = elAdmi.UnPeleadorMas.Nombre.ToString();
            lblApodo2.Text = elAdmi.UnPeleadorMas.Apodo.ToString();
            lblTipo2.Text = elAdmi.UnPeleadorMas.Tipo.ToString();
            lblNivel2.Text = elAdmi.UnPeleadorMas.Nivel.ToString();
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            bool ganoDistinto;

            do
            {
                ganoDistinto = elAdmi.dueloAMuerteConCuchillos();//
                if (ganoDistinto)
                {
                    lstPersonajesEnBatalla.Items.RemoveAt(1);
                    MessageBox.Show("Ganador ---> "+ lstPersonajesEnBatalla.Items[0]);
                }
                else
                {
                    lstPersonajesEnBatalla.Items.RemoveAt(0);
                    MessageBox.Show("Ganador ---> " + lstPersonajesEnBatalla.Items[0]);
                }
            cargarEnfrentamiento();

            } while (lstPersonajesEnBatalla.Items.Count > 1);

            this.Dispose();
            //Abrir ventana con el Ganador con un boton que diga jugar otra ronda
            //--> ojo el ganador sigue en la lista --> borrar o que siga participando
        }
    }
}
