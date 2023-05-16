using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

        static void Main(string[] args)
        {
            Charmander charmander_stats = new Charmander("Charmy", "Fire", "Water"); //Object | hier word in de object een waarde gegeven aan de class.               

            Console.WriteLine($"Pick a name for your Trainer !");

            string Get_Trainer_Name = Console.ReadLine();
            Trainer Trainer_Name = new Trainer(Get_Trainer_Name);
            Console.WriteLine("Your first trainer name:" + Trainer_Name.Trainer_Name);


            //Trainer First_Trainer_Name = new Trainer("");
            //First_Trainer_Name.Trainer_Name = Console.ReadLine();

            Console.WriteLine("Pick a name for your Charmander !");
            charmander_stats.Name = Console.ReadLine();

            Console.WriteLine("Pokemon name:" + charmander_stats.Name + " | Strength: " + charmander_stats.Strength + " | Weakness: " + charmander_stats.Weakness);

            //Dit zorgt ervoor dat er een nieuw object gemaakt wordt voor Pokeball Class en die wordt gebruikt om de pokeball eruit te roepen.
            Charmander charmander = new Charmander(charmander_stats.Name, "Fire", "Water");
            Pokeball pokeball = new Pokeball(charmander);

            pokeball.Throw();

            Console.WriteLine("Charmander will now do its battle cry 10 times:");


            while (true)
            {
                for (int i = 0; i < 10; i++) // Charmander schreeuwt zijn naam hier 10x achter elkaar met een forloop.
                {
                    charmander_stats.BattleCry();
                }

                Console.WriteLine($"Would you like to change your pokemon called: {charmander_stats.Name} another name ? y / n ");
                charmander_stats.Name = Console.ReadLine(); //Naam word hier opgevraag voor je pokemon hoe je het wilt benoemen.

                if (charmander_stats.Name == "y") // als de gebruik ja zegt dan kan diegene de naam veranderen.
                {
                    Console.WriteLine($"What namechange would you like {charmander_stats.Name} to have ? y / n");
                    charmander_stats.Name = Console.ReadLine();
                    Console.WriteLine("Pokemon name:" + charmander_stats.Name + " | Strength: " + charmander_stats.Strength + " | Weakness: " + charmander_stats.Weakness);
                }

                else if (charmander_stats.Name == "n") // mocht de gebruik nee typen dan sluit de game af met een dankjewel voor het spelen.
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    //Hier wordt de pokeball terug geroepen.
                    pokeball.ReturnCharmander();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n':");
                }
            }
        }
    }

    //---------------------------Pokeball Class---------------------------
    public class Pokeball
    {
        //Dit field slaat Charmander op in de Pokeball als er tenminsten een charmander in zit ofn iet.
        public Charmander ContainsCharmander { get; private set; }
        //IsOpen field staat ervoor of de Pokeball op dit moment open staat.
        public bool IsOpen { get; private set; }

        //Een constructor voor de Pokeball class, het kan initializeren met Charmander class
        public Pokeball(Charmander containsCharmander = null)
        {
            ContainsCharmander = containsCharmander;
            IsOpen = false;
        }

        //Method om de pokeball te gooien, wat daarna de pokeball opent and de Charmander released.
        //Hier wordt de pokeball geopent met een charmander / pokemon
        public void Throw()
        {
            IsOpen = true;
            if (ContainsCharmander != null)
            {
                Console.WriteLine($"{ContainsCharmander.Name} has been released!");
            }

            else
            { 
                Console.WriteLine("The Pokeball is empty."); 
            }
        }

        //Method om de charmander terug te laten keren. De pokeball gaat sluiten.
        public void ReturnCharmander()
        {
            if (IsOpen && ContainsCharmander != null)
            {
                Console.WriteLine($"{ContainsCharmander.Name} has been returned to the Pokeball.");
            }

            else
            {
                Console.WriteLine("There is no Charmander to return.");
            }
        }
    }

    //---------------------------Trainer Class---------------------------
    public class Trainer
    {

        //field 
        public string Trainer_Name { get; set;}
        public List<Pokeball> Belt { get; private set; }

        //Trainer Constructor
        //Wat hier staat is gwn dat je elke keer een nieuwe object aan maakt en die dan in je list toevoegt 
        //object van pokeball en een object van charmender, worden beide toegevoegd aan Belt
        public Trainer(string trainer_name)
        {
            Trainer_Name = trainer_name;
            Belt = new List<Pokeball>();

            for (int i = 0; i < 6; i++)
            {
                Belt.Add(new Pokeball(new Charmander($"Charmander {i + 1}", "Fire", "Water")));
            }
        }

        public void ThrowPokeBall()
        {
            if(Belt.Count > 0)
            {
                Pokeball thrownPokeball = Belt[0];
                Belt.RemoveAt(0);
                thrownPokeball.Throw();
            }

            else
            {
                Console.WriteLine("There are no Pokeballs left on the belt.");
            }
        }

        public void ReturnPokemon(Pokeball pokeball)
        {
            pokeball.ReturnCharmander();
            Belt.Add(pokeball);
        }
    }
}
