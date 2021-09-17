using System;
using System.Collections;


namespace roleplay
{
    public class Game{

        public void Atack(dynamic personaje, dynamic personaje2)
        {
            Console.WriteLine($"{personaje.Name} a realizado su ataque {personaje.Power}");

            if(personaje2.Defense < personaje.Damage)
            {
                int damage = personaje.Damage - personaje2.Defense;
                personaje2.Hp = personaje2.Hp - damage ;
                Console.WriteLine($"{personaje2.Name} a recibido {damage} daño...");

                if(personaje2.Hp > 0){

                    Console.WriteLine($"{personaje2.Name} tiene {personaje2.Hp} vida restante");
                }else{
                    Console.WriteLine($"{personaje2.Name} a muerto a mano de {personaje.Name}");
                }
            }
            else
            {
            Console.WriteLine($"{personaje2.Name} no a recibido daño ...");
            }
        }

        public void Heal(Elves personaje, dynamic personaje2)
        {
            Console.WriteLine($"{personaje.Name} a realizado un hechizo de curacion");
            int curacion = personaje.Damage;
            
            if (curacion + personaje2.Hp < personaje2.HpMax){
                personaje2.Hp += curacion;
                Console.WriteLine($"A curado a {personaje2.Name} y su vida actual es {personaje2.Hp}");
            }
            else {
                if (curacion+ personaje2.Hp >= personaje2.HpMax){
                personaje2.Hp = personaje2.HpMax;
                Console.WriteLine($"A curado a {personaje2.Name} y tiene su vida completa");
                }
            }
            
        }

        public void AtackWithSpell(Wizard wizard, dynamic personaje)
        {
            Console.WriteLine($"{wizard.Name} abrio el libro {wizard.Book.Name}");
            int contador = 0;
            Console.WriteLine($"Cual hechizo le gustaria realizar...?");
            foreach(Spell spell in wizard.Book.Spells){
                Console.WriteLine($"{contador} - {spell.Name}");
                contador+=1;
            }
            int num = Convert.ToInt32(Console.ReadLine());
            dynamic hechizo = wizard.Book.Spells[num];
            int daño = hechizo.Power;

            if(personaje.Defense < daño)
            {
                int daño2 = daño - personaje.Defense;
                personaje.Hp = personaje.Hp - daño ;
                Console.WriteLine($"{personaje.Name} a recibido {daño} daño...");

                if(personaje.Hp > 0){

                    Console.WriteLine($"{personaje.Name} tiene {personaje.Hp} vida restante");
                }else{
                    Console.WriteLine($"{personaje.Name} a muerto a mano de {wizard.Name}");
                }
            }
            else
            {
            Console.WriteLine($"{personaje.Name} no a recibido daño ...");
            }
        }







        /*public void AtackElvesToElves(Elves elfo, Elves elfo2)
        {
            Console.WriteLine($"{elfo.Name} a realizado su ataque {elfo.Power}");

            if(elfo2.Defense < elfo.Damage)
            {
                int daño = elfo.Damage - elfo2.Defense;
                elfo2.Hp = elfo2.Hp - daño ;
                Console.WriteLine($"{elfo2.Name} a recibido {daño} daño...");
            }
            else
            {
            Console.WriteLine($"{elfo2.Name} no a recibido daño ...");
            }

        }

        public void AtackElvesToEnano(Elves elfo, Enanos enano)
        {
            Console.WriteLine($"{elfo.Name} a realizado su ataque {elfo.Power}");

            if(elfo2.Defense < elfo.Damage)
            {
                int daño = elfo.Damage - elfo2.Defense;
                elfo2.Hp = elfo2.Hp - daño ;
                Console.WriteLine($"{elfo2.Name} a recibido {daño} daño...");
            }
            else
            {
            Console.WriteLine($"{elfo2.Name} no a recibido daño ...");
            }

        }*/


        



    }

}