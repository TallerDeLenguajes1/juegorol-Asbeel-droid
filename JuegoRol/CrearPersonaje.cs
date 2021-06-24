using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRol
{
    class CrearPersonaje
    {
        Random random = new Random();
        Personaje newPersonaje = new Personaje();

        public Personaje CrearPersonajeRandom()
        {

            Array valueTipo = Enum.GetValues(typeof(TipoPersonaje));
            newPersonaje.Tipo = (TipoPersonaje)valueTipo.GetValue(random.Next(valueTipo.Length)); // elije un valor aleatorio del enum TipoPersonaje

            string[] nombre = { "Diana", "Leona", "Mundo", "Teemo", "Meliodas" };
            newPersonaje.Nombre = nombre[random.Next(5)];

            string[] apodos = { " el Fachero", "el Orito", "el Flamer", "el de Hierro", "el Hamster" };
            newPersonaje.Apodo = apodos[random.Next(5)];

            int aniosMenos = random.Next(0, 267);// !!! es 300 pero el minimo del datepicker es 1754, 267 años atras
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
