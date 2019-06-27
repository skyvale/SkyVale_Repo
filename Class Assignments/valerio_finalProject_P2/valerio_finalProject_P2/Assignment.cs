using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace valerio_finalProject_P2
{
    class Assignment
    {

        // variables
        private Menu _mainMenu = new Menu();

        // file.io stuff
        private string _directory = @"..\..\output\";
        private string _file = @"info.txt";

        public Assignment()
        {

            // create directory + check if directory was already created
            Directory.CreateDirectory(_directory);

            if (File.Exists(_directory + _file))
            {
                Console.WriteLine("File exists.\n");
                Console.Clear();

            }
            else
            {
                File.Create(_directory + _file);
                Console.WriteLine("File created!");
                Console.Clear();

            }
        }

        // method to load File IO (happens at start of program)
        private void Load()
        {

            using (StreamReader sr = new StreamReader(_directory + _file))
            {

                {

                }
            }
        }


        // method to route selection from menu based on user input
        private void Selection()
        {

        }




    }

}
