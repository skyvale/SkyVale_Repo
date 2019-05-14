using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Skylar Valerio
             * 01.21.19
             * Lists Assignment
             */


            // create a list of seven prices
            List<decimal> shoppingList = new List<decimal>() {10, 15, 20, 30, 40, 45, 50};


            // create a function and call
            decimal totalPrice = AddUpCosts(shoppingList);

            // output the total
            Console.WriteLine("The sum of the items in the list is {0}.", totalPrice.ToString("C"));

            // let the user know we're changing
            Console.WriteLine("\r\nNow we will be changing the list!");

            // remove items
            shoppingList.Remove(15);
            shoppingList.Remove(45);
            
            // insert items
            shoppingList.Insert(0, 5);

            // add together again
            totalPrice = AddUpCosts(shoppingList);

            // output
            Console.WriteLine("\r\nThe sum of the items in the list is {0}.", totalPrice.ToString("C"));



        }

        public static decimal AddUpCosts(List<decimal> s)
        {

            // create a variable for the total
            decimal total = 0;

            for (int i = 0; i < s.Count; i++)
            {

                total += s[i];

            }

            return total;
        }



    }
}
