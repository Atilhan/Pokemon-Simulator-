using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pokemon_Battle_Simulator
{
    //---------------------------Program Class---------------------------
    public class Program
    {
        static void Main(string[] args)
        {
            Charmander charmander_stats = new Charmander("Charmy", "Fire", "Water"); //Object | here word in de object een waarde gegeven aan de class.               

            Console.WriteLine($"Pick a name for your Trainer !");
            string Get_Trainer_Name = Console.ReadLine();
            Trainer Trainer_Name = new Trainer(Get_Trainer_Name);
            Console.WriteLine("Your first trainer name: " + Trainer_Name.Trainer_Name);

            Console.WriteLine("Pick a name for your second Trainer ! ");
            string Get_Second_Trainer_Name = Console.ReadLine();
            Trainer Second_Trainer_Name = new Trainer(Get_Second_Trainer_Name);
            Console.WriteLine("Your second trainer name: " + Second_Trainer_Name.Trainer_Name);

            Console.WriteLine("Pick a name for your Charmander !");
            charmander_stats.Name = Console.ReadLine();
            Console.WriteLine("Pokemon name:" + charmander_stats.Name + " | Strength: " + charmander_stats.Strength + " | Weakness: " + charmander_stats.Weakness);
            Charmander charmander = new Charmander(charmander_stats.Name, "Fire", "Water");
            Pokeball pokeball = new Pokeball(charmander);

            pokeball.Throw();

            Console.WriteLine("Charmander will now do its battle cry 10 times:");

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    charmander_stats.BattleCry();
                }

                Console.WriteLine($"Would you like to change your pokemon called: {charmander_stats.Name} another name ? y / n ");
                charmander_stats.Name = Console.ReadLine();

                if (charmander_stats.Name == "y")
                {
                    Console.WriteLine($"What namechange would you like {charmander_stats.Name} to have ? y / n");
                    charmander_stats.Name = Console.ReadLine();
                    Console.WriteLine("Pokemon name:" + charmander_stats.Name + " | Strength: " + charmander_stats.Strength + " | Weakness: " + charmander_stats.Weakness);
                }

                else if (charmander_stats.Name == "n")
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
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
}
