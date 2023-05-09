using System.Xml.Linq;

//namespace Pokemon_Simulator
//{

//    public class Charmander
//    {
//        public string Name { get; set; }
//        public string Strength { get; set; } = "Fire";
//        public string Weakness { get; set; } = "Water";

//        public Charmander(string name,string strength,string weakness )
//        {
//            Name = name;
//            Strength = strength;
//            Weakness = weakness;
//        }

//        public void BattleCry()
//        {
//            Console.WriteLine($"{Name} yells its own name: {Name.ToUpper()}!");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Charmander charmander = new Charmander("Charmy", "Wind", "Stone");
//            Console.WriteLine(charmander.Name + " " + charmander.Strength + " " + charmander.Weakness);

//            charmander.Name = "Charm"; charmander.Strength = "Fireball"; charmander.Weakness = "Stefano";
//            Console.WriteLine("Name: " + charmander.Name + " | Strength: " + charmander.Strength + " | Weakness: " + charmander.Weakness);

//        }
//    }
//}

namespace Pokemon_Battle_Simulator
{
    //hier word een class gemaakt, een class kan je zien als een soort blueprint van je code, hiermee bepaal je hoe je object word onderhoudt.
    public class Charmander
    {
        //Hier onder worden "Fields" gemaakt. Het slaat informatie op in de class en die gebruikt kan worden in een object.
        //Een "Field" is een variable die toebehoort aan een class of een object.
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }

        //Hier onder word een constructor gemaakt, een constructor kan je zien als een special method. Een constructor word meestal aangebouwd als je je object eraan roept / erbij bouwt.
        public Charmander(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        //Hier word een functie gemaakt of tewel een function method. Hiermee kan je actie of gedrag van een object bepalen.
        public void BattleCry()
        {
            Console.WriteLine($"{Name} yells its own name: {Name.ToUpper()}!"); // Bij het roepen van zijn naam word alles met de hoofdletter getyped.
        }
    }
    class Program
    {
        //Een object is een deel van een klasse, het heeft zijn eigen structuur met zijn eigen velden methodes.
        //Hier word een Main Methode gemaakt met daarin een object van "Charmander" class en word daarmee waardes aangehecht binnen de objects.
        static void Main(string[] args)
        {
            Charmander charmander_stats = new Charmander("Charmy", "Fire", "Water"); //Object | hier word in de object een waarde gegeven aan de class.

            Console.WriteLine("Pick a name for your Charmander !");
            charmander_stats.Name = Console.ReadLine();

            Console.WriteLine("Pokemon name:" + charmander_stats.Name + " | Strength: " + charmander_stats.Strength + " | Weakness: " + charmander_stats.Weakness);

            Console.WriteLine("Charmander will now do its battle cry 10 times:");


            while (true)
            {
                for (int i = 0; i < 10; i++) // Charmander schreeuwt zijn naam hier 10x achter elkaar met een forloop.
                {
                    charmander_stats.BattleCry();
                }

                Console.WriteLine($"Would you like to change your pokemon called: {charmander_stats.Name} another name ? y / n ");
                charmander_stats.Name = Console.ReadLine(); //Naam word hier opgevraag voor je pokemon hoe je het wilt benoemen.

                if(charmander_stats.Name == "y") // als de gebruik ja zegt dan kan diegene de naam veranderen.
                {
                    Console.WriteLine($"What namechange would you like {charmander_stats.Name} to have ? y / n");
                    charmander_stats.Name = Console.ReadLine();
                    Console.WriteLine("Pokemon name:" + charmander_stats.Name + " | Strength: " + charmander_stats.Strength + " | Weakness: " + charmander_stats.Weakness);
                }

                else if (charmander_stats.Name == "n") // mocht de gebruik nee typen dan sluit de game af met een dankjewel voor het spelen.
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n':");
                }
            }
        }
    }
}