using System;

namespace roleplay
{
    class Program
    {
        static void Main(string[] args)
        {

            Elves Legolas = new Elves("Legolas",100,100,"Flechazo entre ceja y ceja",100);
            Wizard Richard = new Wizard("Richard",100,100,"Flechazo de hielo entre ceja y ceja",100);
            Item Tanga = new Item ("Tanga",100,100,100);
            Legolas.AddItem(Tanga);
            Legolas.RemoveItem(Tanga);
        }
    }
}
