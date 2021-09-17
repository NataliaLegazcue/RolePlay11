using System;
using System.Collections;

namespace roleplay
{
    public class Book
    {
        public string Name{get;}
        public ArrayList Spells = new ArrayList();

       public void AddSpell(Spell spell)
       {
           this.Spells.Add(spell);
           Console.WriteLine($"Se agrego {this.Name}");
       }

       public Book(string name)
       {
           this.Name=name;

           Console.WriteLine($"Se creo el libro {this.Name}");
       }

       public void ShowBook()
       {
           foreach(Spell spell in this.Spells){
               Console.WriteLine(spell.Name);
           }
       }


    } 
}