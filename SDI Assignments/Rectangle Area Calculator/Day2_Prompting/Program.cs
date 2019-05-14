using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Prompting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Skylar Valerio
             * 01.09.19
             * In Class - User Prompting
             */

            // Console.ReadLine(); -- reads the next line on the console AND return the text string back to your code, ONCE the user hits enter

            // ONLY RETURNS TEXT STRING VARIABLES

            // Ask the user for their name

            // Greet the user and ask the question
            Console.WriteLine("Hello, please tell me your name.\r\nPress return when done.");

            // Listen for the user's response and CATCH it in a string variable
            string userName = Console.ReadLine();

            // Use the name and welcome them to the program
            Console.WriteLine("Welcome " + userName + " to our program.");

            // Let's create a rectangular area calculator!
            // Based on user inputs

            // Width * Height = Area of a rectangle

            // Explain to the user what your program does
            Console.WriteLine("\r\nWe are going to calculate the area of a rectangle based on your measurements.");

            // Ask the users input for the base
            Console.WriteLine("What is the width of your rectangle?\r\nPress return when done.");

            // Catch the users response
            string widthString = Console.ReadLine();

            // Convert the captured string into a number datatype by using the parse command
            // Parse command -- looks throught the string and attempts to convert it to the data type. 
            // If it cannot, your whole program will explode
            //dataType.Parse(insert variable to convert);
            double width = double.Parse(widthString);

            // Test to see if it worked
            // DO NOT DO THIS IN YOUR HOMEWORK
            // Console.WriteLine(width * 2);

            // Give the user feedback and prompt for the height
            Console.WriteLine("\r\nGot it! You typed in a width of "+ width +"!\r\n Please type in the height of your rectangle.");

            // Capture the users response
            string heightString = Console.ReadLine();

            // Convert the string to a double
            double height = double.Parse(heightString);

            // Create a variable to hold the area of the rectangle
            // Do the math
            double area = width * height;

            // Final outputs
            Console.WriteLine("\r\nThe area of a rectangle with a base of "+ width +" and a height of "+ height +" is "+ area +"! ");

            // Congratulate the user and say good-bye
            Console.WriteLine("\r\nThank you for the rectangle area calculator!");

            /* Test Values
             * 
             * Name = Skylar
             * Width = 5
             * Height = 7
             * Area = 35
             * This is correct!
             * 
             * Name = Poop
             * Width = 12.75
             * Height = 3.45
             * Area = 43.9875
             * This is correct! - checked with calc
             * 
             */
        



            




             


        }
    }
}
