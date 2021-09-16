using System;

namespace Program
{
    public class Wizard{
        
        public int Daño{get;}
        public int Salud{get; set;}
        public string Name{get; set;}
        public int Defensa{get; set;}
        public string Poder{get; set;}
        
        public Wizard(string name, string poder, int daño, int salud, int defensa)
        {
            this.Name = name;
            this.Poder = poder;
            this.Daño = daño;
            this.Salud = salud;
            this.Defensa = defensa;

           Console.WriteLine($"Se a creado el hechicero {this.Name}");
        }

        
    } 
}