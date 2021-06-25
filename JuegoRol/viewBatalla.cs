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
            int i = 0;
            LinkedListNode<Personaje> nodo = elAdmi.ListaPersonajes.First;
            while (nodo != null)
            {
                lstPersonajesEnBatalla.Items.Insert(i, nodo.Value.ToString());
                nodo = nodo.Next;
            }
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            elAdmi.dueloAMuerteConCuchillos();
        }
    }
}
