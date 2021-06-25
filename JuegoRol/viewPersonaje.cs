using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class viewPersonaje : Form
    {
        Personaje unPersonaje;
        public viewPersonaje(Personaje unPersonaje)
        {
            InitializeComponent();
            this.unPersonaje = unPersonaje;
            cargar();
        }

        private void cargar()
        {
            //aqui se cargan los lbl :D y la API
        }
    }
}
