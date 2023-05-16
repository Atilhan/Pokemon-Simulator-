using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    //---------------------------Trainer Class---------------------------
    public class Trainer
    {

        //field 
        public string Trainer_Name { get; set; }
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
            if (Belt.Count > 0)
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
