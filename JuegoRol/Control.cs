using System;
using System.Collections.Generic;
using System.IO;//libreria para guardar archivos
using System.Net;
using System.Text;
using System.Text.Json;//libreria de json para comunicacion
using System.Text.Json.Serialization;

namespace JuegoRol
{
    public class Control
    {
        private Personaje unDistinto;
        private Personaje unPeleadorMas;//
        private LinkedList<Personaje> listaPersonajes;
        Random random = new Random();

        public Control()
        {
            this.listaPersonajes = new LinkedList<Personaje>();
            this.unPeleadorMas = new Personaje(); 
        }

        public Personaje UnDistinto { get => unDistinto; }
        public Personaje UnPeleadorMas { get => unPeleadorMas; }
        public LinkedList<Personaje> ListaPersonajes { get => listaPersonajes; }

        public void crearPersonajeRandom()
        {
            this.unDistinto = new Personaje();

            Array valueTipo = Enum.GetValues(typeof(TipoPersonaje));
            unDistinto.Tipo = (TipoPersonaje)valueTipo.GetValue(random.Next(valueTipo.Length)); // elije un valor aleatorio del enum TipoPersonaje

            string[] nombre = { "Diana", "Leona", "Mundo", "Teemo", "Meliodas" };
            unDistinto.Nombre = nombre[random.Next(5)];

            string[] apodos = { " el Fachero", "el Orito", "el Flamer", "el de Hierro", "el Hamster" };
            unDistinto.Apodo = apodos[random.Next(5)];

            int aniosMenos = random.Next(0, 267);// !!! es 300 pero el minimo del datepicker es 1754, 267 años atras
            unDistinto.FechaNacimiento = DateTime.Now.AddYears(-aniosMenos);// a la fecha de hoy le resto entre 1 y 300


            unDistinto.Edad = DateTime.Now.Year - unDistinto.FechaNacimiento.Year;

            unDistinto.Salud = 100;

            unDistinto.Velocidad = random.Next(1, 11);
            unDistinto.Destreza = random.Next(1, 6);
            unDistinto.Fuerza = random.Next(1, 11);
            unDistinto.Nivel = 1;
            unDistinto.Armadura = random.Next(1, 11);

            unDistinto.Pokemon = cargarPokeName(random.Next(1, 151));

        }

        internal void contrincante()
        {
            if(ListaPersonajes.Count > 1)
                this.unPeleadorMas = ListaPersonajes.First.Next.Value;
        }

        public string guardarPersonaje()
        {
            //LinkedListNode<Personaje> nodo = new LinkedListNode<Personaje>(UnDistinto);
            listaPersonajes.AddFirst(unDistinto);

            return listaPersonajes.First.Value.ToString();
            //return unDistinto.ToString();
        }

        public void borrarPersonaje(int indice)
        {
            LinkedListNode<Personaje> nodo = listaPersonajes.First;

            if (indice != -1)// Si hacemos doble click sobre la listbox y no hay elemento seleccionado, el método SelectedIndex devuelve -1
            {
                for (int i = 0; i < indice; i++)//remuevo en memoria
                    nodo = nodo.Next;
                listaPersonajes.Remove(nodo);
            }
        }

        public void limpiarLista()
        {
            listaPersonajes.Clear();
        }
        //-----------------------------------------------Metodos de vista Batalla
        //public string dueloAMuerteConCuchillos()//lucha con todos los participantes
        //{
        //    do
        //    {
        //        if (duelo())//inicia el duelo y el if se pregunta quien gano
        //            listaPersonajes.Remove(unPeleadorMas);//Gano unDistinto -> remuevo unPeleadorMas
        //        else
        //            listaPersonajes.Remove(unDistinto);//Gano unPeleadorMas -> remuevo unDistinto
        //    } while (listaPersonajes.Count > 1);

        //    return listaPersonajes.First.Value.ToString();
        //}

        public bool dueloAMuerteConCuchillos()//
        {
            bool ganoUnDisinto = duelo();//inicia el duelo 
            if (ganoUnDisinto)// true si gano unDistinto
            {
                listaPersonajes.Remove(unPeleadorMas);//Gano unDistinto -> remuevo unPeleadorMas
                contrincante();//prepara al siguiente contrincante
            }
            else
            {
                listaPersonajes.Remove(unDistinto);//Gano unPeleadorMas -> remuevo unDistinto
                unDistinto = ListaPersonajes.First.Value;
                contrincante();//prepara al siguiente contrincante
            }
            if (isGanador())
            {
                guardarGanadorJson("GanadorJson", ".json", ListaPersonajes.First.Value);
                //guardarGanadorCSV("Ganador", ".csv", ListaPersonajes.First.Value);
            }

            return ganoUnDisinto;
        }

        private string crearArchivoJson(Personaje personaje)
        {
            return  JsonSerializer.Serialize(personaje);
        }
        private void guardarGanadorJson(string nombreArchivo, string formato, Personaje personaje)
        {
            FileStream miArchivoJson = new FileStream(nombreArchivo + formato, FileMode.Create);
            using (StreamWriter strWriter = new StreamWriter(miArchivoJson))
            {
                strWriter.WriteLine("{0}", crearArchivoJson(personaje));

                strWriter.Close();
            }
        }

        //private void guardarGanadorCSV(string nombreArchivo, string formato, Personaje personaje)
        //{
        //    FileStream miArchivo = new FileStream(nombreArchivo+formato,FileMode.Create);
        //    using (StreamWriter strWriter = new StreamWriter(miArchivo))
        //    {
        //        strWriter.WriteLine("{0};{1};{2}",personaje.Nombre,personaje.Apodo,personaje.Salud);
        //        strWriter.Close();
        //    }
        //}

        private bool isGanador()
        {
            return ListaPersonajes.Count == 1 ;
        }

        private bool duelo()// devuelve true si el ganador fue unDistinto
        {
            int attack = 0;
            int b;

            while (UnDistinto.Salud > 0 && UnPeleadorMas.Salud > 0 && attack < 6)
            {
                b = random.Next(0, 2);
                bool quienInicia = b==1 ? true : false; //condition? consequent : alternative
                if (quienInicia)
                {
                    b = UnDistinto.DanioProvocado(UnPeleadorMas);//Inicia unPeleadorMas
                    UnPeleadorMas.ActualizarSalud(b);
                }
                else
                {
                    b = UnPeleadorMas.DanioProvocado(UnDistinto);//Inicia unDistinto
                    UnDistinto.ActualizarSalud(b);
                }
                    
                attack++;
            }
            
            return (UnDistinto.Salud > UnPeleadorMas.Salud);
        }

        //Leer json
        public string leerJson()
        {
            Personaje personajeJson;
            string rutaDeArchivo = @"GanadorJson.json";

            try
            {
                using (StreamReader leerJson = File.OpenText(rutaDeArchivo))
                {
                    var Json = leerJson.ReadToEnd();
                    personajeJson = JsonSerializer.Deserialize<Personaje>(Json);
                    listaPersonajes.AddFirst(personajeJson);
                }
                return listaPersonajes.First.Value.ToString();
            }
            catch (FileNotFoundException)
            {
                return "";
            }
        }


        //=========================POKEAPI
        //1° se agrega el atributo Pokemon a la clase Personaje 
        //

        private string cargarPokeName(int idPoke)
        {
            string pokeRandom = "-";

            string url = $"https://pokeapi.co/api/v2/pokemon-form/" + idPoke + "/";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader != null)
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            PokemonRandom poke = JsonSerializer.Deserialize<PokemonRandom>(responseBody);

                            pokeRandom = poke.name;

                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(new Uri(poke.sprites.front_default), pokeRandom + ".png");
                            }
                        }
                    }
                }
            }
            return pokeRandom;
        }
    }
}
