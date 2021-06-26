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
            cargarPersonaje();
            //cargarApi();
        }

        private void cargarApi()
        {
            throw new NotImplementedException();
        }

        private void cargarPersonaje()
        {
            lblNombre.Text = unPersonaje.Nombre;
            lblApodo.Text = unPersonaje.Apodo;
            lblTipoValue.Text = unPersonaje.Tipo.ToString();
            lblEdadValue.Text = unPersonaje.Edad.ToString();
            lblNivelValue.Text = unPersonaje.Nivel.ToString();            lblSaludValue.Text = unPersonaje.Salud.ToString();            lblVelocidadValue.Text = unPersonaje.Velocidad.ToString();            lblFuerzaValue.Text = unPersonaje.Fuerza.ToString();        }
    }
}
