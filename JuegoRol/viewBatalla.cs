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
        LinkedList<Personaje> listaPersonajes;
        public viewBatalla(LinkedList<Personaje> listaP)
        {
            InitializeComponent();
            this.listaPersonajes = listaP;
        }
    }
}
