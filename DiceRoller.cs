using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class DiceRoller
    {
        

        //constructor
        public DiceRoller()
        {
           
        }

        public int[] RollDie(int numRolls)
        {
            int[] results = new int[11];
            Random random = new Random();

            for (int i = 0; i < numRolls; i++)
            {
                
                int randomRoll = random.Next(2,13);

                results[randomRoll-2]++;
            }


            return results;
        }
    }
}
