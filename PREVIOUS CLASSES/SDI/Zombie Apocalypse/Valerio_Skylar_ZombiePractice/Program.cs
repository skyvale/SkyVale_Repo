using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_ZombiePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * Skylar Valerio
             * 01.16.19
             * Zombie Madness - Practice Problem
            */


            // How many zombies will there be at the end of 8 days?


            // Givens:
            // - start with 1 zombie
            // - 1 zombie can bite 4 people a day
            // - 8 days total


            // how many zombies do we currently have
            int numZombies = 1;

            // number of people a zombie can bite per day
            int numBites = 4;

            // how many days total
            int days = 8;

            // greet user and explain the program
            Console.WriteLine("Oh, wow. There's a zombie attack at Full Sail...\r\nLet's figure out how many zombies we'll be dealing with at the end of 8 days.");


            // create a loop to cycle through each day
            // use a FOR loop because you know how many times you want it to run (8 days)
            for(int i = 1; i <= days; i++)
            {

                // this what will happen each day
                // first, the zombie(s) go bite people
                int newZombies = numZombies * numBites;

                // bitten people (newZombies) will become zombies and join the zombie horde
                numZombies += newZombies;

                // end of day - report to the public
                Console.WriteLine("\r\nThere are " + numZombies + " zombies at the end of day " + i + ".");



            }


            Console.WriteLine("----------------------------------------------------------------");


            Console.WriteLine("\r\nHow many days will it take to get to a million zombies?");

            // recreate the variables to make it easier
            // number of the current day- start with the first day
            int numDays = 1;

            // number of current zombies
            int zombieHorde = 1;

            // now we need a WHILE loop because we don't know how many days it's going to take
            while (zombieHorde <= 1000000)
            {

                // this will happen each day

                // creating new zombies
                int bittenPeople = zombieHorde * numBites;

                // add the bitten people into the zombie horde
                zombieHorde += bittenPeople;

                // report to the public
                Console.WriteLine("\r\nOn day "+ numDays +" there are "+ zombieHorde +" zombies.");

                // conditionals
                // should we continue to a new day?

                if (zombieHorde >= 1000000)
                {
                    // if we have enough zombies, do not go to the next day
                    break;

                }

                // end of the day, we increase the day number
                numDays++;

            }

            Console.WriteLine("--------");
            Console.WriteLine("\r\nEnding value of numDays is "+ numDays +".");

        }
    }
}
