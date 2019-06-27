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
        private List<Character> _characterList = new List<Character>();


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
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                File.Create(_directory + _file);
                Console.WriteLine("File created!");
                Console.ReadKey();
                Console.Clear();

            }

            // load the file io
            Load();

            // display main menu with selection
            Selection();
        }

        // method to load File IO (happens at start of program)
        private void Load()
        {

            using (StreamReader sr = new StreamReader(_directory + _file))
            {
                while (sr.Peek() > 0)
                {

                    string line = sr.ReadLine();

                    // put .txt file stuff into an array
                    string[] characterArray = line.Split(',');
                    string name = characterArray[0];
                    string characterClass = characterArray[1];
                    int health = int.Parse(characterArray[2]);
                    int attack = int.Parse(characterArray[3]);
                    int defense = int.Parse(characterArray[4]);
                    int speed = int.Parse(characterArray[5]);
                    int magic = int.Parse(characterArray[6]);

                    switch (characterClass.ToLower())
                    {
                        case "warrior":
                            {
                                // create and load character
                                Warrior loadWarrior = new Warrior(name, characterClass);
                                _characterList.Add(loadWarrior);

                            }break;
                        case "mage":
                            {
                                // create and load character
                                Mage loadMage = new Mage(name, characterClass);
                                _characterList.Add(loadMage);

                            }
                            break;
                        case "cleric":
                            {
                                // create and load character
                                Cleric loadCleric = new Cleric(name, characterClass);
                                _characterList.Add(loadCleric);

                            }
                            break;
                        case "rogue":
                            {
                                // create and load character
                                Rogue loadRogue = new Rogue(name, characterClass);
                                _characterList.Add(loadRogue);
                            }
                            break;

                    }

                    // alphabetizes the character list
                    _characterList.Sort();

                }

            }
                
        }


        // method to route selection from menu based on user input
        private void Selection()
        {

            Console.Clear();

            // create and display the main menu
            _mainMenu = new Menu("Create Character", "Delete Character", "Display Characters", "Exit");
            _mainMenu.FullDisplay();

            // get user input
            string selection = Validation.ValidateString("\nMake a selection...");

            // user input to select from the menu
            switch (selection.ToLower())
            {
                case "1":
                case "create character":
                case "create":
                    {
                        // user selects option to create a new character
                        Create();

                    }break;
                case "2":
                case "delete character":
                case "delete":
                    {
                        // user selects option to delete an existing character
                        Delete();

                    }break;
                case "3":
                case "display characters":
                case "display":
                    {
                        // user selects option to display a list of existing character(s)
                        Display();

                    }break;
                case "4":
                case "exit":
                    {
                        // exits the program

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nGood bye!\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();

                    }
                    break;
                default:
                    {
                        // if the user input is invalid, this will display and the method will restart

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease select an option from the menu!\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Console.Clear();
                        Selection();
                    }
                    break;
            }
        }


        // method to create a new character
        private void Create()
        {
            // aesthetic menu stuff
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCreate Character\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            // get the character NAME
            string inputName = Validation.ValidateString("\nWhat is the character's name?");

            // redo aesthetic menu stuff
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCreate Character\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            // get the character CLASS
            Menu classMenu = new Menu("Warrior", "Mage", "Cleric", "Rogue");
            classMenu.Display();
            string inputClass = Validation.ValidateString("\nWhat is the character's class?\n(Please choose from list)");

            // create character based on chosen class
            switch (inputClass.ToLower())
            {
                case "1":
                case "warrior":
                    {                      
                        // create new warrior character
                        Warrior newWarrior = new Warrior(inputName, "warrior");

                        // add character to the character list
                        _characterList.Add(newWarrior);


                    }break;
                case "2":
                case "mage":
                    {
                        // create new mage character
                        Mage newMage = new Mage(inputName, "mage");

                        // add character to character list
                        _characterList.Add(newMage);

                    }break;
                case "3":
                case "cleric":
                    {
                        // create new cleric character
                        Cleric newCleric = new Cleric(inputName, "cleric");

                        // add new character to character list
                        _characterList.Add(newCleric);

                    }break;
                case "4":
                case "rogue":
                    {
                        // create new rogue character
                        Rogue newRogue = new Rogue(inputName, "rogue");

                        // add new character to character list
                        _characterList.Add(newRogue);

                    }break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\nThat is not a valid character class. Please choose from the list!\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Create();

                    }
                    break;
            }

            // this will save the created character to the File IO
            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {

                foreach (Character character in _characterList)
                {
                    sw.WriteLine(character.SaveToFile());
                }

            }

            // redo aesthetic menu stuff
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCreate Character\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            // feedback
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{inputName} has been created!");
            Console.ForegroundColor = ConsoleColor.Gray;

            // returns to the main menu
            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
            Selection();

        }


        // method to delete character(s)
        private void Delete()
        {
            // aesthetic menu stuff
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDelete a Character\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            // check if there are existing characters, and if not, stop the method and return to main menu
            if (_characterList.Count != 0)
            {

                // show list of existing characters that can be deleted
                foreach (Character character in _characterList)
                {
                    Console.WriteLine(character.Name);
                }

                // get user input
                string inputName = Validation.ValidateString("\nWhich student would you like to remove?" +
                    "\n(*Once a character is deleted, it cannot be undone)");

                // this method finds the character by name and removes them from the list
                if (_characterList.Exists(Character => Character.Name == inputName))
                {
                    // finds and removes character
                    Character removeCharacter = _characterList.Find(Character => Character.Name == inputName);
                    _characterList.Remove(removeCharacter);

                    // feedback
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\n{inputName} has been removed!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    // returns to the main menu
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    Selection();

                }
                else
                {
                    // if the character name doesn't exist, the method will restart itself
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nThat character does not exist!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.ReadKey();
                    Delete();

                }
            }
            else
            {
                // feedback
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("There are no characters yet.");
                Console.ForegroundColor = ConsoleColor.Gray;

                // returns to the main menu
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Selection();
            }

            // this will save the changes to the File IO
            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {

                foreach (Character character in _characterList)
                {
                    sw.WriteLine(character.SaveToFile());
                }

            }


        }


        // method to display existing characters
        private void Display()
        {
            // aesthetic menu stuff
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nALL CHARACTERS\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            // if there are existing characters
            if (_characterList.Count != 0)
            {
                // display each character including their name, class, and stats
                foreach (Character character in _characterList)
                {
                    Console.Write($"\nName: {character.Name,-10}\nClass: {character.characterClass,-10}" +
                                  $"\n--Stats--\nHealth {character.Health}\nAttack {character.Attack}\nDefense {character.Defense}" +
                                  $"\nSpeed {character.Speed}\nMagic {character.Magic}\n");

                    Console.WriteLine();
                    Console.WriteLine("\n--------------\n");

                }

                // returns to the main menu
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Selection();

            }
            // if there are no existing characters
            else
            {
                // feedback
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("There are no characters to display.");
                Console.ForegroundColor = ConsoleColor.Gray;

                // returns to the main menu
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Selection();
            }

        }


    }

}
