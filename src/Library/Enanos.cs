using System;
using System.Collections;

namespace Enano
{
    public class Enanos
    {
        private int vida;
        private int danio;
        private string nombre;
        private string poder;
        private int defensa;

        public Enanos (int vida, int danio, string nombre, string poder, int defensa)
        {
            this.Vida = vida;
            this.Danio = danio;
            this.Nombre = nombre;
            this.Poder = poder;
            this.Defensa = defensa;

            Console.Writeline ("Se ha creado el Enano!")
        }

        public int Vida {
            get
            {
                return this.vida;
            }
            set 
            {
                this.vida = value;
            }
        }  
        public int Danio {
            get
            {
                return this.danio;
            }
            set 
            {
                this.danio = value;
            }
            }
        public string Nombre {
            get
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value;
            }
            }
        public string Poder {
            get
            {
                return this.poder;
            }
            set 
            {
                this.poder = value;
            }
        }
        public string Elemento {
            get
            {
                return this.elemento;
            }
            set 
            {
                this.elemento = value;
            }   
            }    
        public int Defensa {
            get
            {
                return this.defensa;
            }
            set 
            {
                this.defensa = value;
            }
            }

        }
    }
}