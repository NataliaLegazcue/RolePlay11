using System;
using System.Collections;

namespace roleplay
{
    public class Enano
    {
        public string Name{get;}
        public int Defense{get;set;}
        public int Hp{get;set;}
        public string Power{get;}
        public int Damage{get;set;}
        bool Pocket=false;
        public int HpMax{get;}

        public Enano (string name, int defense, int hpmax, string power, int damage)
        {
            this.Name = name;
            this.Defense = defense;
            this.Hp = hpmax;
            this.Power = power;
            this.Damage = damage;
            this.HpMax = hpmax;

            Console.WriteLine("Se ha creado el Enano!");
        }

        public void AddItem(Item item)
        {
            if (!Pocket)
            {
                this.Damage += item.Damage;
                this.Hp     += item.Hp;
                this.Defense+= item.Defense;
                Console.WriteLine($"Gracias a recibir el item {item.Name}, {this.Name} a aumentado sus estadisticas");
                Console.WriteLine ($"Sus estadisticas son...");
                Console.WriteLine ($"Vida = {this.Hp}");
                Console.WriteLine ($"Daño = {this.Damage}");
                Console.WriteLine ($"Defensa = {this.Defense}");
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
                Console.WriteLine ($"Sus estadisticas son...");
                Console.WriteLine ($"Vida = {this.Hp}");
                Console.WriteLine ($"Daño = {this.Damage}");
                Console.WriteLine ($"Defensa = {this.Defense}");
                Pocket=false;
            }
            else
            {
                Console.WriteLine("El personaje no tiene un item equipado");
            }
        }
    }
}