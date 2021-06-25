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
        Control elAdmiDeBatalla;
        public viewBatalla(Control elAdmin)
        {
            InitializeComponent();
            this.elAdmiDeBatalla = elAdmin;//Es el mismo :B
            cargar();// carga la list
        }

        private void cargar()
        {
            LinkedListNode<Personaje> nodo = elAdmiDeBatalla.ListaPersonajes.First;
            for (int i = 0; i < elAdmiDeBatalla.ListaPersonajes.Count; i++)
            {
                nodo = nodo.Previous;
                lstPersonajesEnBatalla.Items.Insert(0, nodo.Value.ToString());
            }
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            elAdmiDeBatalla.dueloAMuerteConCuchillos();
        }
    }
}
