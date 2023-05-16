using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{

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
                Console.WriteLine($"{ContainsCharmander.Name} has been released from the pokeball !");
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
                Console.WriteLine($"{ContainsCharmander.Name} has returned to the Pokeball.");
            }

            else
            {
                Console.WriteLine("There is no Charmander to return.");
            }
        }
    }
}
