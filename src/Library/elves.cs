using System;
using System.Text;
using System.Collections;

namespace roleplay
{
    public class Elves
    {
        public string Name{get;}
        public int Defense{get;set;}
        public int Hp{get;set;}
        public string Power{get;}
        public int Damage{get;set;}
        bool Pocket=false;
        
        public Elves(string name, int defense, int hp, string power, int damage)
        {
            this.Name    = name;
            this.Defense = defense;
            this.Hp      = hp;
            this.Power   = power;
            this.Damage  = damage;

            Console.WriteLine($"Se a creado el elfo {this.Name}");
            
        }
        public void AddItem(Item item)
        {
            if (!Pocket)
            {
                this.Damage += item.Damage;
                this.Hp     += item.Hp;
                this.Defense+= item.Defense;
                Console.WriteLine($"Gracias a recibir el item {item.Name}, {this.Name} a aumentado sus estadisticas");
                Console.WriteLine ($"Sus estadisticas son vida = {this.Hp}");
                Console.WriteLine ($"Sus estadisticas son daño = {this.Damage}");
                Console.WriteLine ($"Sus estadisticas son defensa = {this.Defense}");
                Pocket=true;
            }
            else
            {
                Console.WriteLine("El personaje tiene un item equipado");
            }
        }
        public void RemoveItem(Item item)
        {
            if (Pocket)
            {
                this.Damage -= item.Damage;
                this.Hp     -= item.Hp;
                this.Defense-= item.Defense;
                Console.WriteLine($"Se le elimino el item {item.Name}, {this.Name} a perdido estadisticas");
                Console.WriteLine ($"Sus estadisticas son vida = {this.Hp}");
                Console.WriteLine ($"Sus estadisticas son daño = {this.Damage}");
                Console.WriteLine ($"Sus estadisticas son defensa = {this.Defense}");
                Pocket=false;
            }
            else
            {
                Console.WriteLine("El personaje no tiene un item equipado");
            }
        }


         
    }
}
