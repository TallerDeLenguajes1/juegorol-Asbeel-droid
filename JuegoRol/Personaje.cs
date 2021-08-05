using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRol
{
    public enum TipoPersonaje
    {
        Humano,
        Elfo,
        Orco,
        Hobbit,
    }
    public class Personaje
    {
        const int MDP = 50000;
        private TipoPersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int salud;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;
        private string pokemon;

        public Personaje()
        {

        }

        public Personaje(TipoPersonaje tipo, string nombre, string apodo, DateTime fechaNacimiento, int edad, int salud, int velocidad, int destreza, int fuerza, int nivel, int armadura, string pokemon)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Apodo = apodo;
            this.FechaNacimiento = fechaNacimiento;
            this.Edad = edad;
            this.Salud = salud;
            this.Velocidad = velocidad;
            this.destreza = destreza;
            this.Fuerza = fuerza;
            this.Nivel = nivel;
            this.Armadura = armadura;
            this.Pokemon = pokemon;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        internal TipoPersonaje Tipo { get => tipo; set => tipo = value; }
        public string Pokemon { get => pokemon; set => pokemon = value; }

        private int PoderDeDisparo()
        {
            return this.Destreza * this.Fuerza * this.Nivel;
        }

        private int EfectividadDeDisparo()
        {
            Random random = new Random();
            return (random.Next(1, 101));
        }

        private int ValorDeAtaque()
        {
            return PoderDeDisparo() * EfectividadDeDisparo();
        }

        public int PoderDeDefensa()
        {
            return this.Armadura * this.Velocidad;
        }

        public int DanioProvocado(Personaje enemigo)
        {
            return (ValorDeAtaque() * EfectividadDeDisparo() - enemigo.PoderDeDefensa()) * 100 / MDP;
        }

        public void ActualizarSalud(int danio)
        {
            Salud -= danio;
            if (Salud < 0) Salud = 0;
        }

        public override string ToString()
        {
            string obj = $"{this.Nombre}, {this.Apodo} --> Tipo: {this.Tipo} || Edad: {this.Edad} || Pokemon: {this.Pokemon}";
            return obj;
        }
    }
}
