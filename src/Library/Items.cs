using System;
using System.Collections;

namespace roleplay
{
    public class Items
        {
        private string Itemname {get;}
        private int Itemdmg     {get;}
        private int Itemdf      {get;}
        private int Itemhp      {get;}
        
        public Items(string itemname, int itemdmg, int itemdf, int itemhp)
        {
            this.Itemname =    itemname;
            this.Itemdmg  =    itemdmg;
            this.Itemdf   =    itemdf;
            this.Itemhp   =    itemhp;

            Console.WriteLine($"Se a creado el objeto {this.Itemname}");
            

        }

    }

}
