using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_GroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Skylar Valerio
             * 01.09.19
             * Grocery Calculator Assignment
            */

            // First, explain to the user what the program does
            Console.WriteLine("This is your personal grocery calculator!");

            // This is just to make it look prettier.
            Console.WriteLine("--------------------------------------------------");



            // Ask the user for the price of an apple
            Console.WriteLine("What is the price of an apple?");

            // Get their response for the apple price
            string applePriceString = Console.ReadLine();

            // Convert the apple price string to a decimal
            decimal applePrice = decimal.Parse(applePriceString);

            // Ask the user for the amount of apple
            Console.WriteLine("How many apples did you buy?");

            // Get their response for the apple amount
            string appleAmountString = Console.ReadLine();

            // Convert the apple amount string to decimal
            decimal appleAmount = decimal.Parse(appleAmountString);

            //The total price for the amount of apples
            decimal apples = applePrice * appleAmount;



            // Ask the user for the price of a steak
            Console.WriteLine("What is the price of a steak?");

            // Get their response for the steak price
            string steakPriceString = Console.ReadLine();

            // Convert the steak string to a decimal
            decimal steakPrice = decimal.Parse(steakPriceString);

            // Ask the user for the amount of steak
            Console.WriteLine("How many steaks did you buy?");

            // Get their response for the steak amount
            string steakAmountString = Console.ReadLine();

            // Convert the steak amount string to a decimal
            decimal steakAmount = decimal.Parse(steakAmountString);

            // The total price for the amount of steaks
            decimal steaks = steakPrice * steakAmount;




            // Ask the user for the price of an ice cream
            Console.WriteLine("What is the price of an ice cream?");

            // Get their response for the ice cream price
            string iceCreamPriceString = Console.ReadLine();

            // Convert the ice cream string to a decimal
            decimal iceCreamPrice = decimal.Parse(iceCreamPriceString);

            // Ask the user for the amount of ice creams
            Console.WriteLine("How many ice creams did you buy?");

            // Get their response for the ice cream amount
            string iceCreamAmountString = Console.ReadLine();

            // Convert the ice cream amount string to a decimal
            decimal iceCreamAmount = decimal.Parse(iceCreamAmountString);

            // The total price for the all the ice creams
            decimal iceCreams = iceCreamAmount * iceCreamPrice;



            // Ask the user for the sales tax % of their area
            Console.WriteLine("What is the sales tax % in your area?");

            // Get their response for the sales tax
            string salesTaxString = Console.ReadLine();

            // Convert the sales tax string to a decimal
            decimal salesTax = decimal.Parse(salesTaxString);

            // Convert the sales tax to the actual sales tax
            decimal actualTax = salesTax * 0.01M;


            // The total price for everything
            decimal totalPrice = apples + steaks + iceCreams;

            // Finding what the total amount of tax will be
            decimal taxAmount = totalPrice * actualTax;

            // The total price + sales tax
            decimal finalPrice = taxAmount + totalPrice;
            



            // The total amount + price for the apples
            Console.WriteLine("\r\nThe total price for your "+ appleAmount +" apples is "+ apples.ToString("C") +"!");

            // The total amount + price for the steaks
            Console.WriteLine("\r\nThe total price for your "+ steakAmount +" steaks is "+ steaks.ToString("C") +"!");

            // The total amount + price for the ice creams
            Console.WriteLine("\r\nThe total price for your "+ iceCreamAmount +" ice creams is "+ iceCreams.ToString("C") +"!");

            // The total price of everything
            Console.WriteLine("\r\nThe total price of everything before tax is "+ totalPrice.ToString("C") +"!");

            // The total price with sales tax
            Console.WriteLine("\r\nThe total price of everything after tax is "+ finalPrice.ToString("C") +"!");


            /*
             * TEST 1 --
             * Apple Cost | $0.50
             * Apple Amount | 3
             * Steak Cost | $15.25
             * Steak Amount | 2
             * Ice Cream Cost | $5.75
             * Ice Cream Amount | 1
             * Sales Tax | 7%
             * 
             * RESULTS
             * Total Cost of Apples | $1.50
             * Total Cost of Steaks | $30.50
             * Total Cost of Ice Creams | $5.75
             * Total Cost of Everything | $37.75
             * Total Cost with Tax | $40.39
             * 
             * -- TEST CORRECT
             * 
             * 
             * 
             * TEST 2 --
             * 
             * Apple Cost | $0.75
             * Apple Amount | 6
             * Steak Cost | $13.24
             * Steak Amount | 4
             * Ice Cream Cost | $3.75
             * Ice Cream Amount | 2
             * Sales Tax | 9%
             * 
             * RESULTS
             * Total Cost of Apples | $4.50
             * Total Cost of Steaks | $52.96
             * Total Cost of Ice Creams | $7.50
             * Total Cost of Everything | $64.96
             * Total Cost with Tax | $70.81
             * 
             * -- TEST CORRECT
             * 
             */










        }
    }
}
