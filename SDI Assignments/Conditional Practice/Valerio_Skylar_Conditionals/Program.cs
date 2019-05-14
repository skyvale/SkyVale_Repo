using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Skylar_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Skylar Valerio
             * 01.11.19
             * Conditionals
             * 
            */

            //-------------------------------------------------------------------------------------------------------------

            //-- PROBLEM 1 | HIT THE JACKPOT! --



            // ask the user how much they won
            Console.WriteLine("Congratulations on winning the lottery!\r\nHow much money did you win?");

            // check the user response
            string moneyString = Console.ReadLine();

            // create a container for tryparse
            decimal money;

            // validate their response
            if (!(decimal.TryParse(moneyString, out money))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease type the amount of money in numbers.");

                // re-ask the question
                Console.WriteLine("How much money did you make?");

                // re-capture the user response
                moneyString = Console.ReadLine();

                // re-convert the response
                decimal.TryParse(moneyString, out money);


            }

            // convert their response
            decimal.TryParse(moneyString, out money);


            // tell the user their money options
            Console.Write("\r\nYou have two options to receive your money.\r\nYour first option is a lump sum one-time payment-- you can get your money now, but they will take 15% of your winnings.\r\nYour second option is to take 20 annual payments of your prize, but you will receive 100% of the money.");
            Console.WriteLine("\r\nPlease type 'L' for lump sum or type 'A' for annual.");

            // check the user response
            string moneyOption = Console.ReadLine();


            // validate their response
            if (moneyOption.ToUpper() != "L" && moneyOption.ToUpper() != "A") {
                // tell user the mistake
                Console.Write("\r\nPlease respond with either 'L' or 'A'.");

                // re-ask the question
                Console.WriteLine("\r\nWould you like to do lump sum or annual payments?");

                // re-capture the user response
                moneyOption = Console.ReadLine();


            }

            // if they chose L (lump sum)
            if (moneyOption.ToUpper() == "L") {

                // calculate the total money they will get after the 15% is taken
                decimal moneyTotal = (money * 0.85M);

                // inform the user their winnings
                Console.WriteLine("\r\nYour winnings of " + money.ToString("C") + " as a one-time lump sum payment is " + moneyTotal.ToString("C") + "!");

            }


            //if they chose A (annual)
            if (moneyOption.ToUpper() == "A") {

                // calculate how much money they will receive annually
                decimal moneyAnnually = (money / 20M);

                // inform the user of their winnings
                Console.WriteLine("\r\nYour winnings of " + money.ToString("C") + " will be paid to you in 20 payments of " + moneyAnnually.ToString("C") + "!");

            }

            /*
             * = ERROR TESTING =
             * ------------------
             * 
             * - TEST 1 -
             * Winnings | 20,000
             * Option A
             * Results: "Your winnings of $20,000.00 will be paid to you in 20 payments of $1,000.00!"
             * CORRECT
             * 
             * - TEST 2 -
             * Winnings | 100,000.50
             * Option L
             * Results: "Your winnings of $100,000.50 as a one-time lump sum payment is $85,000.43!"
             * CORRECT
             * 
             * - TEST 3 -
             * Winnings | 65,000,000.99
             * Option a
             * Results | "Your winnings of $65,000,000.99 will be paid to you in 20 payments of $3,250,000.05!"
             * CORRECT
             * 
             * - TEST 4 -
             * Winnings | 0.80
             * option l
             * Results | "Your winnings of $0.80 as a one-time lump sum payment is $0.68!"
             * CORRECT
             * 
             * ...
             * ALL TESTS ARE CORRECT
             * 
             */



            //-------------------------------------------------------------------------------------------------------------


            //-- PROBLEM 2 | LETS MAKE A DEAL --


            // using this to make an bigger gap between this code and my previous, so that it is   a e s t h e t i c
            Console.WriteLine();
            Console.Write("-----------------");
            Console.WriteLine();

            // explain what the program does
            Console.WriteLine("What's a better deal? Buying in bulk or one by one? Let's find out!");

            // ask the user the number of items in the bulk pack
            Console.WriteLine("\r\nHow many items are in the bulk pack?");

            // check the user response
            string itemNumString = Console.ReadLine();

            // create a container for tryparse
            int itemNum;

            // validate the user response
            if (!(int.TryParse(itemNumString, out itemNum))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease write a number for the amount of items.");

                //re-ask the question
                Console.WriteLine("How many items are in the bulk pack?");

                //re-check the user response
                itemNumString = Console.ReadLine();

                // convert the response
                int.TryParse(itemNumString, out itemNum);


            }



            // ask the user the cost of the bulk pack
            Console.WriteLine("What is the cost of the bulk pack?");

            // check the user response
            string costBulkString = Console.ReadLine();

            // create a container
            decimal costBulk;

            // validate the user response
            if (!(decimal.TryParse(costBulkString, out costBulk))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease type a numerical monetary value.");

                // re-ask the question
                Console.WriteLine("What is the cost of the bulk pack?");

                // re-check the user response
                costBulkString = Console.ReadLine();

                // convert the response to decimal
                decimal.TryParse(costBulkString, out costBulk);

            }


            // ask the user the cost of the single item
            Console.WriteLine("What is the cost of the single item?");

            // check the user response
            string costSingleString = Console.ReadLine();

            // create a container
            decimal costSingle;

            // validate the user response
            if (!(decimal.TryParse(costSingleString, out costSingle))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease type a numerical monetary value.");

                // re-ask the question
                Console.WriteLine("What is the cost of the single item?");

                // re-check the user response
                costSingleString = Console.ReadLine();

                // convert the response to decimal
                decimal.TryParse(costSingleString, out costSingle);


            }


            // ask the user the coupon value
            Console.WriteLine("What is the coupon discount?");

            // check the user response
            string couponString = Console.ReadLine();

            // create a container
            decimal coupon;

            // validate the user response
            if (!(decimal.TryParse(couponString, out coupon))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease type the amount of money you get off the coupon.");

                // re-ask the question
                Console.WriteLine("What is the coupon discount?");

                // re-check the user response
                couponString = Console.ReadLine();

                // convert the response to decimal
                decimal.TryParse(couponString, out coupon);


            }


            //math that checks which one is cheaper

            decimal bulkPrice = costBulk / itemNum;
            decimal singlePrice = costSingle - coupon;

            //determining the results
            if (singlePrice < bulkPrice) {
                Console.WriteLine("The cost of one item using a coupon is "+ singlePrice.ToString("C") + ", which is cheaper than the cost of the individual item from the bulk pack, which is " + bulkPrice.ToString("C") + ". Buy the individual item and use the coupon!");

            }
            else if (bulkPrice < singlePrice) {
                Console.WriteLine("The cost of one item in the bulk pack is "+ bulkPrice.ToString("C") +", which is cheaper than the cost of the individual item with the coupon, which is "+ singlePrice.ToString("C") +". Buy the bulk pack!");
            }

            /*
             * = ERROR TESTING =
             * ------------------
             * 
             * - TEST 1 -
             * Items in Bulk Pack | 50
             * Cost of Bulk Pack | $100
             * Cost of Single Item | $4.50
             * Coupon Amount |$1
             * Results: "The cost of one item in the bulk pack is $2.00, which is cheaper than the cost of the individual item with the coupon, which is $3.50. Buy the bulk pack!"
             * CORRECT
             * 
             * - TEST 2 - 
             * Items in Bulk Pack | 20
             * Cost of Bulk Pack | $80.50
             * Cost of Single Item | $6.25
             * Coupon Amount | $2.25
             * Results: "The cost of one item using a coupon is $4.00, which is cheaper than the cost of the individual item from the bulk pack, which is $4.03. Buy the individual item and use the coupon!"
             * CORRECT
             * 
             * - TEST 3 -
             * Items in Bulk Pack | 1000
             * Cost of Bulk Pack | $15000
             * Cost of Single Item | $65
             * Coupon Amount | $6.99
             * Results: "The cost of one item in the bulk pack is $15.00, which is cheaper than the cost of the individual item with the coupon, which is $58.01. Buy the bulk pack!"
             * CORRECT
             * 
             * ALL TESTS ARE CORRECT
             * 
             * 
             */








            //-------------------------------------------------------------------------------------------------------------


            //-- PROBLEM 3 | PUMPKIN PATCH PICKERS --

            //  a e s t h e t i c s again
            Console.WriteLine();
            Console.Write("-----------------");
            Console.WriteLine();

            // explain what the program does
            Console.WriteLine("How much does your pumpkin cost? Use this program to find out!");

            // ask the user how much the pumpkin weighs
            Console.WriteLine("\r\n How much does your pumpkin weight?");

            // check the user response
            string pumpkinWeightString = Console.ReadLine();

            // create a container for tryparse
            decimal pumpkinWeight;

            // validate the user response
            if (!(decimal.TryParse(pumpkinWeightString, out pumpkinWeight))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease only type in a numerical value.");

                // re-ask the question
                Console.WriteLine("How much does your pumpkin weight?");

                // re-catch the user response
                pumpkinWeightString = Console.ReadLine();

                // convert the user response to decimal
                decimal.TryParse(pumpkinWeightString, out pumpkinWeight);
            }

            decimal totalCost;

            // determine the cost of the pumpkin according to the user response
            if (pumpkinWeight <= 5.5M)
            {
                // calculate the price
                totalCost = pumpkinWeight * 1.00M;

                // tell the user the price
                Console.WriteLine("Your pumpkin of " + pumpkinWeight + " lbs. costs " + totalCost.ToString("C") + ".");

            }
            else if (5.5M < pumpkinWeight && pumpkinWeight <= 10.75M )
            {
                // calculate the price
                totalCost = pumpkinWeight * 0.90M;

                // tell the user the price
                Console.WriteLine("Your pumpkin of " + pumpkinWeight + " lbs. costs " + totalCost.ToString("C") + ".");

            }
            else if (10.75M < pumpkinWeight && pumpkinWeight <= 25M)
            {
                // calculate the price
                totalCost = pumpkinWeight * 0.80M;

                // tell the user the price
                Console.WriteLine("Your pumpkin of " + pumpkinWeight + " lbs. costs " + totalCost.ToString("C") + ".");
            }
            else if (25M < pumpkinWeight && pumpkinWeight <= 50M)
            {
                // calculate the price
                totalCost = pumpkinWeight * 0.70M;

                // tell the user the price
                Console.WriteLine("Your pumpkin of " + pumpkinWeight + " lbs. costs " + totalCost.ToString("C") + ".");

            }
            else if (50M < pumpkinWeight && pumpkinWeight <= 100M)
            {
                // calculate the price
                totalCost = pumpkinWeight * 0.60M;

                // tell the user the price
                Console.WriteLine("Your pumpkin of " + pumpkinWeight + " lbs. costs " + totalCost.ToString("C") + ".");

            }
            else {
                // calculate the price
                totalCost = pumpkinWeight * 0.50M;

                // tell the user the pricetotalCost
                Console.WriteLine("Your pumpkin of " + pumpkinWeight + " lbs. costs " + totalCost.ToString("C") + ".");
            }


            /*
            * = ERROR TESTING =
            * ------------------
            * 
            * - TEST 1 -
            * Pumpkin Weight = 4.5
            * Result: "Your pumpkin of 4.5 lbs costs $4.50"
            * 
            * - TEST 2 -
            * Pumpkin Weight = 10
            * Result: "Your pumpkin of 10 lbs costs $9"
            * 
            * - TEST 3 -
            * Pumpkin Weight = 20.75
            * Result: "Your pumpkin of 20.75 lbs costs $16.60"
            * 
            * - TEST 4 -
            * Pumpkin Weight = 40
            * Result: "Your pumpkin of 40 lbs costs $28"
            * 
            * - TEST 5 -
            * Pumpkin Weight = 100
            * Result: "Your pumpkin of 100 lbs costs $60"
            * 
            * - TEST 6 -
            * Pumpkin Weight = 150.30
            * Result: "Your pumpkin of 150.30 lbs costs $75.15"
            * 
            * - TEST 7 -
            * Pumpkin Weight = 1
            * Result: "Your pumpkin of 1 lbs costs $1"
            * 
            * TESTS ARE CORRECT
            */










            //-------------------------------------------------------------------------------------------------------------


            //-- PROBLEM 4 | LOYALTY CARD --

            // more  a e s t h e t i c s 
            Console.WriteLine();
            Console.Write("-----------------");
            Console.WriteLine();

            // explain what the program does
            Console.WriteLine("\r\nThis program will determine if you are a loyalty member or not, and give you a discount if you are one.");

            // ask the user the cost of item one
            Console.WriteLine("What is the cost of your first item?");

            // check the user response
            string firstItemCostString = Console.ReadLine();

            // create a container for tryparse
            decimal firstItemCost;

            // validate the user response
            if (!(decimal.TryParse(firstItemCostString, out firstItemCost))) {
                // tell user the mistake
                Console.WriteLine("\r\nPlease only type a numerical value.");

                // re-ask the question
                Console.WriteLine("What is the cost of your first item?");

                // re-catch the user response
                firstItemCostString = Console.ReadLine();

                // convert the user response
                decimal.TryParse(firstItemCostString, out firstItemCost);

            }


            // ask the user the cost of item two
            Console.WriteLine("What is the cost of your second item?");

            // check the user response
            string secItemCostString = Console.ReadLine();

            // create a container for tryparse
            decimal secItemCost;

            // validate the user response
            if (!(decimal.TryParse(secItemCostString, out secItemCost)))
            {
                // tell user the mistake
                Console.WriteLine("\r\nPlease only type a numerical value.");

                // re-ask the question
                Console.WriteLine("What is the cost of your second item?");

                // re-catch the user response
                secItemCostString = Console.ReadLine();

                // convert the user response
                decimal.TryParse(secItemCostString, out secItemCost);

            }

            // calculate total cost for later
            totalCost = firstItemCost + secItemCost;

            // ask the user if they are a loyalty member
            Console.WriteLine("Are you a loyalty member?");

            // check the user response
            string loyalMember = Console.ReadLine();


            // validate their response
            if (loyalMember.ToLower() != "yes" && loyalMember.ToLower() != "no") {

                // tell user the mistake
                Console.WriteLine("Please write either 'yes' or 'no' to the question.");

                // re-ask the question
                Console.WriteLine("Are you a loyalty member?");

                // re-catch the user response
                loyalMember = Console.ReadLine();

            }
            else if (loyalMember.ToLower() == "yes") {

                // calculate discount
                decimal discountCost = totalCost * 0.85M;

                // if user is a member, tell them total price with discount
                Console.WriteLine("Your total purchase is " + discountCost + ", which includes your 15% discount.");

            }
            else if (loyalMember.ToLower() == "no") {

                // if user is not a member, tell them total price
                Console.WriteLine("Your total price is "+ totalCost +".");

            }



            /*
            * = ERROR TESTING =
            * ------------------
            * 
            * - TEST 1 -
            * first item = $45.50
            * second item = $75
            * member = YES
            * results: "Your total purchase is $102.43, which includes your 15% discount."
            * 
            * 
            * - TEST 2 -
            * first item = $23
            * second item = $44.25
            * member = no
            * results: "Your total purchase is $67.25"
            * 
            * 
            * - TEST 3 -
            * first item = $80
            * second item = $20
            * member = no
            * results: "Your total purchase is $100."
            * 
            */



            Console.ReadKey();


        }
    }
}
