﻿using System;
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

        //method to roll the dice
        public int[] RollDie(int numRolls)
        {
            int[] results = new int[11];
            //random class
            Random random = new Random();

            //roll the desired amount of time
            for (int i = 0; i < numRolls; i++)
            {
                
                int randomRoll1 = random.Next(1,7);
                int randomRoll2 = random.Next(1, 7);
                int randomRoll = randomRoll1 + randomRoll2;

                //assign rolls to correct storage location in the array
                results[randomRoll-2]++;
            }

            //return results array
            return results;
        }
    }
}
