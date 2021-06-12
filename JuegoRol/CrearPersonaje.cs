using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRol
{
    class CrearPersonaje
    {
        Random random = new Random();
        uint botNumero;

        public CrearPersonaje()
        {
            this.botNumero = 1;
        }

        public uint BotNumero { get => botNumero; set => botNumero = value; }

        public Personaje CrearPersonajeRandom()
        {
            Personaje newPersonaje = new Personaje();

            Array valueTipo = Enum.GetValues(typeof(TipoPersonaje));
            newPersonaje.Tipo = (TipoPersonaje)valueTipo.GetValue(random.Next(valueTipo.Length)); // elije un valor aleatorio del enum TipoPersonaje

            newPersonaje.Nombre = $"Bot {this.BotNumero}";
            BotNumero++;

            string[] apodos = { "Fachero", "Orito", "El Flamer", "Hierro", "El Hamster" };
            newPersonaje.Apodo = apodos[random.Next(5)];

            int aniosMenos = random.Next(0, 300);
            newPersonaje.FechaNacimiento = DateTime.Now.AddYears(-aniosMenos);// a la fecha de hoy le resto entre 1 y 300


            newPersonaje.Edad = DateTime.Now.Year - newPersonaje.FechaNacimiento.Year;

            newPersonaje.Salud = 100;

            newPersonaje.Velocidad = random.Next(1, 11);
            newPersonaje.Destreza = random.Next(1, 6);
            newPersonaje.Fuerza = random.Next(1, 11);
            newPersonaje.Nivel = 1;
            newPersonaje.Armadura = random.Next(1, 11);

            return newPersonaje;
        }
    }
}
