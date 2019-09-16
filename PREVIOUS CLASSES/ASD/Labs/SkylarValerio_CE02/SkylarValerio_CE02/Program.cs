using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylarValerio_CE02
{
    class Program
    {

        public static Customer currentCustomer = null;



        static void Main(string[] args)
        {

            /* Name: Skylar Valerio
             * Date: 04.01.2019
             * Code Exercise Bank Terminal
             */

            MainMenu();

            

        }


        public static void MainMenu()
        {

            // display the menu options
            Menu menu = new Menu();


            string userInput = Console.ReadLine();


            // choose between the menu options 
            switch (userInput)
            {
                case "1":
                    {
                        CreateCustomer();
                    }
                    break;
                case "2":
                    {
                        CreateAccount();
                    }
                    break;
                case "3":
                    {
                        AccountBalance();
                    }
                    break;
                case "4":
                    {
                        DisplayBalance();
                    }
                    break;
                case "5":
                    {
                        Environment.Exit(0);
                    }
                    break;


                default:
                    {
                        Console.WriteLine("Invalid input. Please choose 1-5 from the menu.");
                    }
                    break;

            }

        }







        public static void CreateCustomer()
        {

            Console.WriteLine("\r\nWhat is your name?");

            string name = Validation.ValidateString(Console.ReadLine());

            currentCustomer = new Customer(name);

            Console.WriteLine("\r\nNew customer has been created.");

            Console.ReadKey();

            Console.Clear();
            MainMenu();


            

        }



        public static void CreateAccount()
        {


            if (currentCustomer != null)
            {
                Console.WriteLine("\r\nWhat is the account number?");
                int numberInput = Validation.ValidateInt(Console.ReadLine());

                Console.WriteLine("\r\nWhat is the account balance?");
                decimal accountInput = Validation.ValidateDeci(Console.ReadLine());

                 currentCustomer.checkingAccount = new CheckingAccount(numberInput, accountInput);

                //currentCustomer.checkingAccount = new CheckingAccount(numberInput, accountInput);


            }
            else
            {
                Console.WriteLine("\r\nCustomer does not exist.\r\n");
            }

            Console.ReadKey();
            Console.Clear();
            MainMenu();

        }




        public static void AccountBalance()
        {

            if (currentCustomer.checkingAccount != null)
            {

                Console.WriteLine("\r\nInput how much money is in the account now.");

                currentCustomer.checkingAccount.accBalance = Validation.ValidateDeci(Console.ReadLine());


            }
            else
            {

                Console.WriteLine("\r\nThere is no current balance.");

                Console.WriteLine("\r\nCreate a new balance?");
                Console.WriteLine("[1] Yes");
                Console.WriteLine("[2] No");

                string yesOrNo = Console.ReadLine();


                if (yesOrNo == "1")
                {

                    Console.Clear();
                    CreateAccount();

                }
                else if (yesOrNo == "2")
                {

                    Console.WriteLine("\r\nGood-bye.\r\n");
                    Environment.Exit(0);

                }
                else
                {

                    Console.WriteLine("\r\nInvalid input. Please choose [1] or [2].");

                    Console.Clear();

                    Console.WriteLine("\r\nThere is no current balance.");

                    Console.WriteLine("\r\nCreate a new balance?");
                    Console.WriteLine("[1] Yes");
                    Console.WriteLine("[2] No");

                    yesOrNo = Console.ReadLine();


                }

            }

            Console.ReadKey();
            Console.Clear();
            MainMenu();

        }




        public static void DisplayBalance()
        {

            Console.WriteLine($"\r\nCurrent Balance: {currentCustomer.checkingAccount.accBalance.ToString("c")}\r\n");

            Console.ReadKey();
            Console.Clear();
            MainMenu();

        }





    }
}
