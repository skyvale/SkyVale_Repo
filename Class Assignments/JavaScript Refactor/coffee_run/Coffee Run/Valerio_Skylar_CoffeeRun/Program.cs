using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_CoffeeRun
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * Skylar Valerio
             * 01.17.19
             * Coffee Run Assignment
            */


            // greet the user and explain what the program does
            Console.WriteLine("Hello! This program will help you keep track of your coffee orders.");

            // aesthetic line breaker
            Console.WriteLine("------------\r\n");

            // declare the caffeine array
            //string[] caffeineArray = new string[10];
            //caffeineArray[0] = "coffee";
            //caffeineArray[1] = "cappucino";
            //caffeineArray[2] = "latte";
            //caffeineArray[3] = "cappucino";
            //caffeineArray[4] = "latte";
            //caffeineArray[5] = "coffee";
            //caffeineArray[6] = "cappucino";
            //caffeineArray[7] = "coffee";
            //caffeineArray[8] = "decaf";
            //caffeineArray[9] = "cappucino";

            //// declare the second caffeine array
            string[] caffeineArray = new string[10];
            caffeineArray[0] = "coffee";
            caffeineArray[1] = "cappucino";
            caffeineArray[2] = "latte";
            caffeineArray[3] = "decaf";
            caffeineArray[4] = "decaf";
            caffeineArray[5] = "cappucino";
            caffeineArray[6] = "cappucino";
            caffeineArray[7] = "coffee";
            caffeineArray[8] = "decaf";

            // declaring some variables for counting
            int numberCoffee = 0;
            int numberLatte = 0;
            int numberCappu = 0;
            int numberDecaf = 0;
        

            // loop through the array to determine how many of each drink there is
            for (int i = 0; i < caffeineArray.Length; i++)
            {
                if (caffeineArray[i] == "coffee")
                {
                    // if element is present, +1 to the count
                    numberCoffee++;

                }
                else if (caffeineArray[i] == "cappucino") 
                {
                    numberCappu++;

                }
                else if (caffeineArray[i] == "latte")
                {
                    numberLatte++;

                }
                else if (caffeineArray[i] == "decaf")
                {
                    numberDecaf++;

                }
            }


            // print to console the number of each element
            Console.WriteLine("Order " + numberCoffee + " number of Coffee");
            Console.WriteLine("Order " + numberCappu + " number of Cappucino");
            Console.WriteLine("Order " + numberLatte + " number of Latte");
            Console.WriteLine("Order " + numberDecaf + " number of Decaf");

            // another aesthetic line break
            Console.WriteLine("\r\n------------");

            // thank the user and finish the program
            Console.WriteLine("Thank you for using this coffee program. Good-bye!");

            // yet another aesthetic line break because I like them
            Console.WriteLine();

            /*
             *= TESTS =
             * 
             * - Test 1 -
             * Order 3 number of Coffee
             * Order 4 number of Cappucino
             * Order 2 number of Latte
             * Order 1 number of Decaf
             * CORRECT
             * 
             * - Test 2 -
             * Order 2 number of Coffee
             * Order 3 number of Cappucino
             * Order 1 number of Latte
             * Order 3 number of Decaf
             * CORRECT
             * 
             */



        }
    }
}
