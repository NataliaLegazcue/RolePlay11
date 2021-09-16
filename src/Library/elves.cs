using System;
using System.Text;
using System.Collections;

namespace roleplay
{
    public class Elves
    {

        public int Hp{get;set;}
        public int Damage{get;}
        public string Name{get;}
        public string Power{get;}
        public int Defense{get;}

        public Elves(int hp, int damage, string name, string power, int defense) /*Items elemento"*/
        {
            this.Hp = hp;
            this.Damage = damage;
            this.Name = name;
            this.Power = power;
            this.Defense = defense;

            Console.WriteLine($"Se a creado el elfo {this.Name}");
            
        }

         
    }
}
