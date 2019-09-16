using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylarValerio_CE02
{
    class Validation
    {



        // validates string inputs
        public static string ValidateString(string userInput)
        {

            while (string.IsNullOrWhiteSpace(userInput))
            {

                Console.WriteLine("\r\nInvalid response. Please don't leave this blank.");

                userInput = Console.ReadLine();

            }

            return userInput;
            
        }



        // validates int inputs
        public static int ValidateInt (string userInput)
        {
            int checkedInput;

            while (!int.TryParse(userInput, out checkedInput))
            {
                Console.WriteLine("\r\nInvalid response. Please input a number.");

                userInput = Console.ReadLine();

            }

            return checkedInput;

        }



        // validates decimal inputs
        public static decimal ValidateDeci (string userInput)
        {
            decimal checkedInput;

            while (!decimal.TryParse(userInput, out checkedInput))
            {

                Console.WriteLine("\r\nInvalid response. Please input a number.");

                userInput = Console.ReadLine();

            }

            return checkedInput;

        }








    }
}
