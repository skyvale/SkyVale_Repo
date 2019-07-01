using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Skylar Valerio
             * 01.09.19
             * MadLibs Assignment
            */

            // Welcome the user and explain what the program does
            Console.WriteLine("Welcome to the MadLibs! Please answer the following questions:");



            // Ask for the name
            Console.WriteLine("\r\nType a NAME");

            // Get the users response for the name
            string name = Console.ReadLine();



            // Ask for the adjective
            Console.WriteLine("\r\nType an ADJECTIVE");

            // Get the users response for the adjective
            string adjective = Console.ReadLine();



            // Ask for the animal
            Console.WriteLine("\r\nType an ANIMAL");

            // Get the users response for the animal
            string animal = Console.ReadLine();



            // Ask for the food item
            Console.WriteLine("\r\nType a FOOD ITEM");

            // Get the users response for the food item
            string foodItem = Console.ReadLine();



            // Ask for the year
            Console.WriteLine("\r\nType a YEAR NUMBER");

            // Get the users response for the year
            string yearString = Console.ReadLine();

            // Convert the year string to a year int because it is not a decimal
            int year = int.Parse(yearString);



            // Ask for the cost
            Console.WriteLine("\r\nType a COST");

            // Get the users response for the cost
            string costString = Console.ReadLine();

            // Convert the cost string to a cost double because it is a decimal
            double cost = double.Parse(costString);



            // Ask for the random number
            Console.WriteLine("\r\nType a RANDOM NUMBER");

            // Get the users response for the random number
            string numberString = Console.ReadLine();

            // Convert the random number string to a double because maybe they put a decimal as the random number who knows
            double number = double.Parse(numberString);




            // Just me testing to see if the numbers actually worked
            //Console.WriteLine(year + 10);
            //Console.WriteLine(cost + 10);
            //Console.WriteLine(number + 10);
            // They work...
            




            // Now it is time to insert everything into the MadLibs story

            Console.Write("\r\nYou were walking through the woods one day when you saw them-- " + name + ".\r\nThey looked "+ adjective +" and when they turned around, you saw they were devouring " + foodItem + ".\r\nBehind them, they had a pile of " + number + " more " + foodItem + ".\r\nIt probably cost them at least $" + cost + ", especially since it was " + year + ".\r\n"); 





        }
    }
}
