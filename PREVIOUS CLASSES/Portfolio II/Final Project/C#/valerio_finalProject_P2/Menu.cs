using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valerio_finalProject_P2
{
    // this is a generic menu class given to us by the Portfolio I teacher to use in school

    class Menu
    {
        public string Title { get; set; }
        private List<string> _items;


        // don't forget to change the menu title!
        public Menu()
        {

            Title = "\nCharacter Creator";

            _items = new List<string>();
        }


        // params will take whatever you put into a list and converts it
        public Menu(params string[] items)
        {

            Title = "\nCharacter Creator";

            _items = items.ToList();

        }



        // adds new item to current menu
        public void AddMenuItem(string item)
        {
            _items.Add(item);
        }



        // displays title and things
        public void FullDisplay()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\n----------------------------------------\r\n");

            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {_items[i]}");
            }

        }

        // displays just the list
        public void Display()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {_items[i]}");
            }
        }

    }
}
