using System;
using System.Collections;

namespace roleplay
{
    public class Items
        {
        private string Itemname {get;set;}
        private int Itemdmg     {get;set;}
        private int Itemdf      {get;set;}
        private int Itemhp      {get;set;}
        
        public Items(string itemname, int itemdmg, int itemdf, int itemhp)
        {
            this.Itemname =    itemname;
            this.Itemdmg  =    itemdmg;
            this.Itemdf   =    itemdf;
            this.Itemhp   =    itemhp;
            //Console.WriteLine($"El item {this.Itemname}, da {this.Itemdf} de defensa, da {this.Itemhp} de vida y {this.Itemdmg} de daño");

        }

    }

}
