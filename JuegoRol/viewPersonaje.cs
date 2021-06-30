using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            cargarApi();
            cargarPersonaje();
        }

        private void cargarApi()
        {
            var url = $"https://aws.random.cat/meow";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return;
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        ApiCat cat = JsonSerializer.Deserialize<ApiCat>(responseBody);
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(new Uri(cat.file), @"image35.png");
                        }
                    }

                }
            }
        }

        private void cargarPersonaje()
        {
            lblNombre.Text = unPersonaje.Nombre;
            lblApodo.Text = unPersonaje.Apodo;
            lblTipoValue.Text = unPersonaje.Tipo.ToString();
            lblEdadValue.Text = unPersonaje.Edad.ToString();
            lblNivelValue.Text = unPersonaje.Nivel.ToString();            lblSaludValue.Text = unPersonaje.Salud.ToString();            lblDestrezaValue.Text = unPersonaje.Destreza.ToString();            lblVelocidadValue.Text = unPersonaje.Velocidad.ToString();            lblArmaduraValue.Text = unPersonaje.Armadura.ToString();            lblFuerzaValue.Text = unPersonaje.Fuerza.ToString();
            catApiImg.Image = Image.FromFile("image35.png");
        }
    }
}
