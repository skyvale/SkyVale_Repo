using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Valerio_PortfolioII_Final
{
    class Program
    {

        private Menu _menu = new Menu();
        private List<Character> _characterList = new List<Character>();


        static void Main(string[] args)
        {
            Program program = new Program();
        }


        // file.io stuff
        private string _directory = @"..\..\output\";
        private string _file = @"info.txt";

        public Program()
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

            // load the file.io
            Load();

            // display menu to chooses
            Selection();
        }



        private void Load()
        {

            using (StreamReader sr = new StreamReader(_directory + _file))
            {
                while (sr.Peek() > 0)
                {
                    string line = sr.ReadLine();

                    // put txt file stuff into an array
                    string[] characterArray = line.Split(',');
                    string name = characterArray[0];
                    string gender = characterArray[1];
                    int age = int.Parse(characterArray[2]);
                    string eyeCol = characterArray[3];

                    Character newCharacter = new Character(name, gender, age, eyeCol);
                    _characterList.Add(newCharacter);

                    _characterList.Sort();

                }
            }
        }



        private void Selection()
        {
            Console.Clear();

            _menu = new Menu("Create Character", "Delete Character", "Display Characters", "Exit");
            _menu.Display();

            string menuSelect = Validation.ValidateString("\nPlease make a selection...");

            switch (menuSelect.ToLower())
            {
                case "1":
                case "create character":
                    {
                        Create();
                    }break;

                case "2":
                case "delete character":
                    {
                        Delete();
                    }break;
                case "3":
                case "display characters":
                    {
                        Display();
                    }break;
                case "4":
                case "exit":
                    {
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nGood bye!\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();

                    }
                    break;
                    

                default:
                    {
                        
                    }break;

            }

        }



        private void Create()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCreate a Character\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------------\n");

            // get the character information
            string inputName = Validation.ValidateString("\nWhat is your character's name?");
            string inputGender = Validation.ValidateString("\nWhat is your character's gender?");
            int inputAge = Validation.ValidateInt("\nWhat is your character's age?");
            string inputEyeCol = Validation.ValidateString("\nWhat is your character's eye color?");

            // create the new character
            Character newCharacter = new Character(inputName, inputGender, inputAge, inputEyeCol);
            _characterList.Add(newCharacter);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{inputName} has been added!\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            _characterList.Sort();

            // save character to file.io
            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {

                foreach (Character character in _characterList)
                {
                    sw.WriteLine(character.SaveCharacter());
                }

            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Selection();
        }



        private void Delete()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDelete a Character\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------------\n");

            string inputName = Validation.ValidateString("\nWhich character would you like to delete?");


            if (_characterList.Exists(Character => Character.Name == inputName))
            {
                // this finds the character by name and removes them from the list
                Character removeChara = _characterList.Find(Character => Character.Name == inputName);
                _characterList.Remove(removeChara);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n{inputName} has been deleted!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Selection();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThat character does not exist in the system.\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ReadKey();
                Delete();

            }

        }


        private void Display()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nYour Characters\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------------------------\n");

            foreach (Character character in _characterList)
            {
                Console.Write($"Name: {character.Name,-10}\nGender: {character.Gender,-10}" +
                              $"\nAge: {character.Age}\nEye Color: {character.EyeCol}");

                Console.WriteLine();
                Console.WriteLine("\n----------\n");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Selection();


        }

    }


}
