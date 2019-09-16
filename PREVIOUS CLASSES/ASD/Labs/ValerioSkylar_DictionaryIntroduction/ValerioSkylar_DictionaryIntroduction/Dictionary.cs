using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_DictionaryIntroduction
{
    class Dictionary
    {

        private Menu _menu;
        private Dictionary<int, Book> _library;


        public Dictionary()
        {

            Console.Clear();

            _library = new Dictionary<int, Book>();

            _menu = new Menu("Create a Book", "Check out a Book", "Return a Book", "Display Books", "Exit");

            _menu.Display();
            Selection();


        }


        public void Selection()
        {

            int userInput = Validation.ValidateInt("\r\nMake a selection....", 1, 5);

            switch (userInput)
            {

                case 1:
                    {
                        CreateBook();

                    }break;
                case 2:
                    {
                        Checkout();

                    }break;
                case 3:
                    {
                        ReturnBook();

                    }break;
                case 4:
                    {
                        BookDisplay();

                    }
                    break;
                case 5:
                    {
                        Exit();

                    }break;

            }


        }




        public void CreateBook()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Create a Book");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------");

            int isbn = Validation.ValidateIsbn("\r\nWhat is the 5-digit ISBN?", 5, 5);
            string title = Validation.ValidateString("\r\nWhat is the book title?");

            Book book = new Book(isbn, title);


            if (_library.ContainsKey(isbn))
            {
                Console.WriteLine("\r\nBook already exists.\r\n");

                Console.WriteLine("\r\nReturning to menu...");
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();

                Console.Clear();

                _menu.Display();
                Selection();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\r\n{title} was created!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                _library.Add(isbn, book);

                Console.WriteLine("\r\nReturning to menu...");
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();

                Console.Clear();

                _menu.Display();
                Selection();

            }


        }



        public void Checkout()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Checkout a Book");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------");

            if (!(_library.Count == 0))
            {
                int isbn = Validation.ValidateIsbn("\r\nWhat is the ISBN of the book?", 5, 5);


                if (_library.ContainsKey(isbn))
                {
                    if (_library[isbn].Availability == "yes")
                    {

                        string userInput = Validation.ValidateString($"\r\nWould you like to check out {_library[isbn].BookTitle}?\r\n[yes]\r\n[no]");

                        if (userInput.ToLower() == "yes")
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\r\nYou have checked out {_library[isbn].BookTitle}!");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            _library[isbn].Availability = "no";

                            Console.WriteLine("\r\nReturning to main menu...");
                            Console.WriteLine("\r\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            _menu.Display();
                            Selection();


                        }
                        else if (userInput.ToLower() == "no")
                        {
                            Console.WriteLine("\r\nReturning to main menu...");
                            Console.WriteLine("\r\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            _menu.Display();
                            Selection();

                        }

                    }
                    else if (_library[isbn].Availability == "no")
                    {
                        Console.WriteLine("\r\nSorry, this book is not available.");

                        Console.WriteLine("\r\nReturning to main menu...");
                        Console.WriteLine("\r\nPress any key to continue...");
                        Console.ReadKey();

                        Console.Clear();
                        _menu.Display();
                        Selection();
                    }

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nThat ISBN does not exist.\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("\r\nReturning to main menu...");
                    Console.WriteLine("\r\nPress any key to continue....");
                    Console.ReadKey();

                    Console.Clear();
                    _menu.Display();
                    Selection();

                }


            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nThere are no books to check out!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;


                Console.WriteLine("\r\nReturning to main menu...");
                Console.WriteLine("\r\nPress any key to continue....");
                Console.ReadKey();

                Console.Clear();
                _menu.Display();
                Selection();

            }
            


        }



        public void ReturnBook()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Return a Book");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------");

            int isbn = Validation.ValidateIsbn("\r\nWhat is the ISBN of the book you are returning?", 5, 5);

            if (_library.ContainsKey(isbn))
            {

                if (_library[isbn].Availability == "no")
                {
                
                    Console.WriteLine($"\r\nReturned {_library[isbn].BookTitle}.\r\n");

                    _library[isbn].Availability = "yes";

                    Console.WriteLine("\r\nReturning to menu...");
                    Console.WriteLine("\r\nPress any key to continue....");
                    Console.ReadKey();

                    Console.Clear();
                    _menu.Display();
                    Selection();


                }
                else if (_library[isbn].Availability == "yes")
                {
                    Console.WriteLine("\r\nThis book has already been returned.\r\n");

                    Console.WriteLine("\r\nReturning to menu...");
                    Console.WriteLine("\r\nPress any key to continue....");
                    Console.ReadKey();

                    Console.Clear();
                    _menu.Display();
                    Selection();

                }


            }
            else
            {
                Console.WriteLine("\r\nThat ISBN does not exist.\r\n");
                Console.WriteLine("\r\nReturning to menu...");
                Console.WriteLine("\r\nPress any key to continue....");
                Console.ReadKey();

                Console.Clear();
                _menu.Display();
                Selection();

            }




        }


        public void BookDisplay()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\r\n{"ISBN",-15}{"Title",-20}{"Availability", -20}"); 
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (KeyValuePair<int, Book> item in _library)
            {
                Console.WriteLine($"{item.Key,-15}{item.Value.BookTitle,-20}{item.Value.Availability, -20}");

            }

            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();

            Console.Clear();

            _menu.Display();
            Selection();

        }


        public void Exit()
        {
            Console.WriteLine("\r\nExiting program...\r\n");
            Console.WriteLine("\r\nPress any key to continue...");

        }


    }
}
