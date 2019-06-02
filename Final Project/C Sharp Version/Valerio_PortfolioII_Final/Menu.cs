using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_PortfolioII_Final
{
    class Menu
    {

        public string Title { get; set; }
        private List<string> _items;


        // don't forget to change the menu title!
        public Menu()
        {

            Title = "   ____   _                                       _                   " +
                    "  / ___| | |__      __ _   _ __     __ _     ___ | |_     ___    _ __   " +
                    " | |     | '_ \\   / _` | | '__ |  / _` |  / __  |  __|  / _ \\ | '__|" +
                    " | |___  | | | |  | (_| | | |     | (_| | | (__  | |_   |  __/  | |     " +
                    "  \\____| |_| |_|   \\__,_| |_|      \\__,_| \\___|  \\__|   \\___|  |_|   ";  
;

            _items = new List<string>();
        }


        // params will take whatever you put into a list and converts it
        public Menu(params string[] items)
        {

            Title = "   ____   _                                       _                   " +
                    "  / ___| | |__      __ _   _ __     __ _     ___ | |_     ___    _ __   " +
                    " | |     | '_ \\   / _` | | '__ |  / _` |  / __  |  __|  / _ \\ | '__|" +
                    " | |___  | | | |  | (_| | | |     | (_| | | (__  | |_   |  __/  | |     " +
                    "  \\____| |_| |_|   \\__,_| |_|      \\__,_| \\___|  \\__|   \\___|  |_|   ";

            _items = items.ToList();

        }



        // adds new item to current menu
        public void AddMenuItem(string item)
        {
            _items.Add(item);
        }



        // displays title and things
        public void Display()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\n----------------------------------------\r\n");

            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_items[i]}");
            }

        }


    }
}

