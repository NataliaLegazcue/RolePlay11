using System;
using System.Collections;

namespace roleplay
{
    public class Game{

        public void AtackElvesToWizard(Elves elfo, Wizard mago)
        {
            if(mago.Defensa < elfo.Damage){

                int daño = elfo.Damage - mago.Defensa;
                mago.Salud = mago.Salud - daño ;
                Console.WriteLine($"{mago.Name} a recibido {daño} daño...");
            }
            else{
            Console.WriteLine($"{mago.Name} no a recibido daño ...");
            }
       
        }

        



    }

}