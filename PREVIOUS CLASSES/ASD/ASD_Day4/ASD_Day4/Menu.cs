using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Day4
{
    class Menu
    {

        public string Title { get; set; }
        private List<string> _items;


        // don't forget to change the menu title!
        public Menu()
        {

            Title = "\r\nLibrary";
            _items = new List<string>();
        }


        // params will take whatever you put into a list and converts it
        public Menu(params string[] items)
        {
            Title = "\r\nLibrary";
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
