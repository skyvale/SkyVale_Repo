using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
v
            /*
              Skylar Valerio
              01.13.19
              Arrays Assignment
              */

            /* 
              -Use the 2 arrays below
              -Do Not Re-Declare or Re-Define the elements inside of it.
            */


            //This is the Declare and Definition of the 2 Starting Number Arrays
            //Notice the differet ways to create an array.
            //Both are correct!

            int[] firstArray = new int[4];
            firstArray[0] = 34;
            firstArray[1] = 20;
            firstArray[2] = 91;
            firstArray[3] = 49;

            double[] secondArray = new double[4] { 42, 120.30, 210.20, 32.50 };


            /*
              -Find the total sum of each of the 2 individual arrays  
              -Store each sum in a variable and output that variable to console
              -Be sure to double check them with a calculator.
              -Do not assume the computer will give you the correct output!
              */


            // add together the sum of the first array
            int firstTotal = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];

            // add together the sum of the second array
            double secondTotal = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];

            // print out the sums for both arrays
            Console.WriteLine("The sum of the first array is " + firstTotal + "!");
            Console.WriteLine("The sum of the second array is " + secondTotal + "!");


            /* TEST
             * -----------
             * checked with calculator
             * first sum is 194
             * second sum is 405
             * it works correctly







            //-----------------------------------------------------------------------------------------------------


            /*
              -Find the average value of each of the 2 individual arrays
              -Store each average in a variable and output that variable to console
              -Be sure to double check them with a calculator.
              -Do not assume the computer will give you the correct output!
              -You should be using the total variable created early!
              */

            // adding a spacer between the two programs
            Console.WriteLine("------------\r\n");


            // finding the average value of the first array
            double firstAverage = firstTotal / 4D;

            // finding the average value of the second array
            double secondAverage = secondTotal / 4D;

            // output the averages to the console
            Console.WriteLine("The average value for the first array is " + firstAverage + "!");
            Console.WriteLine("The average value foe the second array is " + secondAverage + "!\r\n");


            /* TEST
             * -----------
             * the average for the first is 48.5
             * the average fo the second is 101.25
             * it works correctly






            //-----------------------------------------------------------------------------------------------------

            /*
               Create a 3rd number array.  
               The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your new array at the index#0 spot.
                    -This would make the first element of this array = 42+ 34 = 76
                -Repeat this for each index #.
                -Do not add them by hand, the computer must add them.
                -Do not use the numbers themselves, use the array elements.
                -After you have the completed new array, output each element one at a time to the Console.
             */

            // adding a spacer between the two programs
            Console.WriteLine("------------\r\n");


            // declare the third array
            double[] thirdArray = new double[4];

            // finding the value of each element in the new array
            thirdArray[0] = firstArray[0] + secondArray[0];
            thirdArray[1] = firstArray[1] + secondArray[1];
            thirdArray[2] = firstArray[2] + secondArray[2];
            thirdArray[3] = firstArray[3] + secondArray[3];

            // outputting each element in the third array to the console
            Console.WriteLine("The first element in the third array is " + thirdArray[0] + "!");
            Console.WriteLine("The second element in the third array is " + thirdArray[1] + "!");
            Console.WriteLine("The third element in the third array is " + thirdArray[2] + "!");
            Console.WriteLine("The fourth element in the third array is " + thirdArray[3] + "!");


            /* TEST
             * --------
             * The third array's values should be: {76, 140.3, 301.2, 81.5}
             * checked with a calculator
             * it works correctly
            */







            //-----------------------------------------------------------------------------------------------------


            /*
               Given the array of strings below named MixedUp.  
               You must create a string variable that puts the items in the correct order to make a complete sentence 
               that is a famous phrase by Rick Cook.
                -Use each element in the array, do not re-write the strings themselves.
                - Do Not Re-Declare or Re-Define the elements inside of it.
                -Concatenate them in the correct order to form a sentence.
                -Store this new sentence string inside of a string variable you create.
                -Output this new string variable to the console.
             */



            // adding a spacer between the two programs
            Console.WriteLine("------------\r\n");

            // Declare and Define The String Array
            string[] MixedUp = new string[] { "universe is winning.", "erse trying to produce bigger an", "between software engineers striving to build bigger ", "d better idiots. So far, the ", "Programming today is a race ", "and better idiot-proof programs, and the univ" };

            /* [4] Programming today is a race
             * [2] Between software engineers striving to build bigger
             * [5] and better idiot-proof programs, and the univ
             * [1] erse is trying to produce bigger an
             * [3] d better idiots. So far the
             * [0] universe is winning
             * 
            */

            // output the unscrambled sentence
            Console.WriteLine(MixedUp[4] + MixedUp[2] + MixedUp[5] + MixedUp[1] + MixedUp[3] +MixedUp[0]);




        }
    }
}
