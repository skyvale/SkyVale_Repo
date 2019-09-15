using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ValidatingPrompts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Skylar Valerio
             * 01.11.19
             * Using Conditionals to Validate User Prompts
             */



            // ask the user for their name
            Console.WriteLine("Hello, please type in your name and hit enter!");

            // capture the user's response
            string userName = Console.ReadLine();

            // test to see if the user left it blank
            // used when we ask the user a question that will NOT be converted to a number
            
            // string.IsNullOrWhiteSpace(insert variable to test)
            // it will return a boolean value, true or false
            // if it is null or whitespace, it will say it is true

            // use a conditional to validate
            if(string.IsNullOrWhiteSpace(userName)) {
                // this conditional will run IF the user leaves the userName blank
                Console.WriteLine("\r\nPlease do not leave this blank.");

                // re-ask the question
                Console.WriteLine("Now, please type in your name and hit enter.");

                // re-catch the user's response
                // since you already assigned a box (userName) you don't have to assign it again
                userName = Console.ReadLine();

            }    
          
           


            // welcome the user
            Console.WriteLine("\r\nWelcome to the program, " + userName);


            // ask the user for their favourite whole number
            Console.WriteLine("\r\nPlease enter in your favourite whole number!");

            // catch the response
            // create a string variable to catch it, not an integer
            string faveNumberString = Console.ReadLine();

            // in the past we used .Parse to convert the string to number data
            //int faveNumber = int.Parse(faveNumberString);
            // DO NOT USE PARSE ANYMORE

            // -- TRY PARSE --
            // instead, we'll be using something called TryParse
            // use this antime we convert a user prompt to a number
            // it will return boolean values
            // it returns a boolean of true if the conversion works and a boolean false if the conversion fails

            // dateType.TryParse(variableToTest, out variableThatIsConverted);

            // if it can convert, it will store the value into the variableThatIsConverted
            // if it CANNOT convert, it will store a value of 0 into the variableThatIsConverted

            //create a variable that will hold the converted value
            int faveNumber;

         

            // create a conditional for validation
            // we added ! so that, if it successfully converts to an int, it will return as false and not run
            if (!(int.TryParse(faveNumberString, out faveNumber)) ) {
                // this will run if the user's input cannot be convered to the number dataType
                // tell the user the mistake
                Console.WriteLine("\r\nPlease only type in WHOLE numbers.");

                // re-ask the question
                Console.WriteLine("Please enter your favourite whole number.");

                // re-catch the user response
                faveNumberString = Console.ReadLine();

                // only for conditionals, add this line
                // reconvert the variable
                int.TryParse(faveNumberString, out faveNumber);
                

            }

            Console.WriteLine(faveNumber);

            // create a second variable to hold the number x2
            int faveTimesTwo = faveNumber * 2;

            // output the number
            Console.WriteLine("\r\nYour favorite number times two is "+ faveTimesTwo +"!");


            // validate for specific answers
            // relational operator
            // ==  !=

            // ask the user a yes or no question
            Console.WriteLine("Is it cold outside?\r\nPlease enter yes or no.");

            // catch the response
            string coldOutside = Console.ReadLine();

            // test for yes
            // then add in the test for no
            // when validating, try and capture the NOT CORRECT answers
            // in order to test all cases, convert temporarily to all lowercase

            // use .ToLower() = temporarily changes the case of the whole text string

            if (coldOutside.ToLower() != "yes" && coldOutside.ToLower() != "no") {
                // tell the user what the mistake was
                Console.WriteLine("\r\nPlease only type in yes or no.");

                // re-ask the question
                Console.WriteLine("Is it cold outside? Yes or no.");

                // re-catch the results
                coldOutside = Console.ReadLine();


            }

            //results
            Console.WriteLine("You said "+ coldOutside +" to the question, is it cold outside.");

        }
    }
}
