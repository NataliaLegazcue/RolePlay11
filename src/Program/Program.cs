using System;

namespace roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Elves Legolas = new Elves(100,100,"Legolas","Flechazo entre ceja y ceja",100);
            Console.WriteLine(Legolas.Hp);
            Legolas.Hp = 50;
        }
    }
}
