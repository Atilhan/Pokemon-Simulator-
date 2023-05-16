using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    //---------------------------Charmander Class---------------------------
    public class Charmander
    {
        //Hier onder worden "Fields" gemaakt. Het slaat informatie op in de class en die gebruikt kan worden in een object.
        //Een "Field" is een variable die toebehoort aan een class of een object.
        public string Name { get; set; }
        public string Strength { get; set; } = "Fire";
        public string Weakness { get; set; } = "Water";

        //Hier onder word een constructor gemaakt, een constructor kan je zien als een special method. Een constructor word meestal aangebouwd als je je object eraan roept / erbij bouwt.
        public Charmander(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public void BattleCry()
        {
            Console.WriteLine($"{Name} yells its own name: {Name.ToUpper()}!"); // Bij het roepen van zijn naam word alles met de hoofdletter getyped.
        }
    }
}
