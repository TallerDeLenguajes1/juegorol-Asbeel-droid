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

        public Personaje()
        {

        }

        public Personaje(TipoPersonaje tipo, string nombre, string apodo, DateTime fechaNacimiento, int edad, int salud, int velocidad, int destreza, int fuerza, int nivel, int armadura)
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

        private int PoderDeDisparo()
        {
            return this.Destreza * this.Fuerza * this.Nivel;
        }

        private int EfectividadDeDisparo()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        public int ValorDeAtaque()
        {
            return PoderDeDisparo() * EfectividadDeDisparo();
        }

        public int PoderDeDefensa()
        {
            return this.Armadura * this.Velocidad;
        }

        public override string ToString()
        {
            string obj = $"{this.Nombre}, {this.Apodo} --> Tipo: {this.Tipo} Edad: {this.Edad}";
            return obj;
        }

        public void DanioRecibido(Personaje enemigo)
        {
            Salud -= enemigo.ValorDeAtaque();// verificar mas tarde  :c
        }
    }
}
