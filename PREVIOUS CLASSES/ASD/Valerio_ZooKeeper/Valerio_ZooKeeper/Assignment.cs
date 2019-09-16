using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Assignment
    {

        public Menu mainMenu = new Menu();

        public List<Animal> Animals = new List<Animal>();
        Sasquatch sasquatch = new Sasquatch();
        Chicken chicken = new Chicken();
        Cat cat = new Cat();
        Dog dog = new Dog();
        Horse horse = new Horse();
        Snake snake = new Snake();

        public Assignment()
        {

            Animals.Add(sasquatch);
            Animals.Add(chicken);
            Animals.Add(cat);
            Animals.Add(dog);
            Animals.Add(horse);
            Animals.Add(snake);

            Selection();

        }


        public void Selection()
        {
            Console.Clear();

            mainMenu = new Menu("Cat (can train!)", "Dog (can train!)", "Horse (can train!)", "Snake", "Chicken", "Sasquatch (can train!)", "EXIT");
            mainMenu.Display();

            string menuSelection = Validation.ValidateString("\nMake a selection from the menu...");

            switch (menuSelection.ToLower())
            {
                case "1":
                case "cat":
                    {
                        CatSelect();
                    }
                    break;
                case "2":
                case "dog":
                    {
                        DogSelect();
                    }
                    break;
                case "3":
                case "horse":
                    {
                        HorseSelect();
                    }
                    break;
                case "4":
                case "snake":
                    {
                        SnakeSelect();

                    }break;
                case "5":
                case "chicken":
                    {
                        ChickenSelect();
                    }
                    break;
                case "6":
                case "sasquatch":
                    {
                        SasqSelect();
                    }
                    break;
                case "7":
                case "exit":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nGoodbye!");
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();
                        Selection();

                    }
                    break;
            }


        }


        public void CatSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou selected the cat.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n1. Train the animal in a new behaviour." +
                "\n2. Feed the animal a treat." +
                "\n3. Signal the animal to perform a behaviour." +
                "\n4. Listen to the animal make a noise." +
                "\n5. Return to the main menu.\n");

            string interactChoice = Validation.ValidateString("\nWhat would you like to do with the cat?\n");

            switch (interactChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        if (cat.Behaviours.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe cat doesn't know any tricks yet!");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.WriteLine("\nLet's teach it one!");
                            string trick = Validation.ValidateString("What trick do you want the cat to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the cat to do the trick?");

                            cat.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe cat will now {trick} when you {signal}!\n");

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                        else if (cat.Behaviours.Count != 0)
                        {
                            string trick = Validation.ValidateString("What trick do you want the cat to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the cat to do the trick?");

                            while (cat.Behaviours.ContainsKey(signal))
                            {

                                Console.Clear();
                                Console.WriteLine($"\nOh, the cat already knows the signal {signal} for a trick!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\nPlease choose a different signal!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                signal = Validation.ValidateString("\nWhat signal will you give the cat to do the trick?");

                            }


                            cat.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe cat will now {trick} when you {signal}!\n");


                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                    }
                    break;
                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine(cat.Eat());
                        Console.WriteLine(cat.Poop());

                        string moreFood = Validation.ValidateString("Feed cat again?\n[yes]\n[no]");

                        while (!(moreFood.ToLower() == "yes" || moreFood.ToLower() == "no"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nPlease choose 'yes' or 'no'.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            moreFood = Validation.ValidateString("\nFeed cat again?\n[yes]\n[no]");

                        }

                        while (moreFood.ToLower() == "yes" || moreFood.ToLower() == "no")
                        {

                            if (moreFood.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou decided to feed the cat again!\n");
                                Console.WriteLine(cat.Eat());
                                Console.WriteLine(cat.Poop());

                                moreFood = Validation.ValidateString("Feed cat again?\n[yes]\n[no]");

                            }
                            else if (moreFood.ToLower() == "no")
                            {
                                Selection();
                            }

                        }


                    }
                    break;
                case "3":
                    {
                        Console.Clear();

                        if (cat.Behaviours.Count > 0)
                        {
                            string signaling = Validation.ValidateString("How do you signal the cat?");
                            Console.WriteLine(cat.Perform(signaling));

                            string anotherTrick = Validation.ValidateString("\nHave the cat do another trick?\n[yes]\n[no]");

                            while (!(anotherTrick.ToLower() == "yes" || anotherTrick.ToLower() == "no"))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nPlease choose 'yes' or 'no'!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                anotherTrick = Validation.ValidateString("\nHave the cat do another trick?\n[yes]\n[no]");
                            }

                            if (anotherTrick.ToLower() == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nYou decided to have the cat do another trick!\n");
                                signaling = Validation.ValidateString("How do you signal the cat?\n");
                                Console.WriteLine(cat.Perform(signaling));

                                Console.ReadKey();
                                Console.WriteLine("\nPress any key to continue...");
                                Selection();

                            }
                            else if (anotherTrick.ToLower() == "no")
                            {
                                Selection();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe cat doesn't know any tricks yet!\n");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();

                    }
                    break;
                case "4":
                    {
                        Console.Clear();

                        Console.WriteLine(cat.MakeNoise());

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();
                    }
                    break;
                case "5":
                    {
                        Selection();

                    }
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;


            }

        }


        public void DogSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou selected the dog.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n1. Train the animal in a new behaviour." +
                "\n2. Feed the animal a treat." +
                "\n3. Signal the animal to perform a behaviour." +
                "\n4. Listen to the animal make a noise." +
                "\n5. Return to the main menu.\n");

            string interactChoice = Validation.ValidateString("\nWhat would you like to do with the dog?\n");

            switch (interactChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        if (dog.Behaviours.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe dog doesn't know any tricks yet!");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.WriteLine("\nLet's teach it one!");
                            string trick = Validation.ValidateString("What trick do you want the dog to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the dog to do the trick?");

                            dog.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe dog will now {trick} when you {signal}!\n");

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                        else if (dog.Behaviours.Count != 0)
                        {
                            string trick = Validation.ValidateString("What trick do you want the dog to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the dog to do the trick?");

                            while (dog.Behaviours.ContainsKey(signal))
                            {

                                Console.Clear();
                                Console.WriteLine($"\nOh, the dog already knows the signal {signal} for a trick!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\nPlease choose a different signal!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                signal = Validation.ValidateString("\nWhat signal will you give the dog to do the trick?");

                            }


                            dog.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe dog will now {trick} when you {signal}!\n");


                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                    }
                    break;
                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine(dog.Eat());
                        Console.WriteLine(dog.Poop());

                        string moreFood = Validation.ValidateString("Feed dog again?\n[yes]\n[no]");

                        while (!(moreFood.ToLower() == "yes" || moreFood.ToLower() == "no"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nPlease choose 'yes' or 'no'.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            moreFood = Validation.ValidateString("\nFeed dog again?\n[yes]\n[no]");

                        }

                        while (moreFood.ToLower() == "yes" || moreFood.ToLower() == "no")
                        {

                            if (moreFood.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou decided to feed the dog again!\n");
                                Console.WriteLine(dog.Eat());
                                Console.WriteLine(dog.Poop());

                                moreFood = Validation.ValidateString("Feed dog again?\n[yes]\n[no]");

                            }
                            else if (moreFood.ToLower() == "no")
                            {
                                Selection();
                            }

                        }


                    }
                    break;
                case "3":
                    {
                        Console.Clear();

                        if (dog.Behaviours.Count > 0)
                        {
                            string signaling = Validation.ValidateString("How do you signal the dog?");
                            Console.WriteLine(dog.Perform(signaling));

                            string anotherTrick = Validation.ValidateString("\nHave the dog do another trick?\n[yes]\n[no]");

                            while (!(anotherTrick.ToLower() == "yes" || anotherTrick.ToLower() == "no"))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nPlease choose 'yes' or 'no'!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                anotherTrick = Validation.ValidateString("\nHave the dog do another trick?\n[yes]\n[no]");
                            }

                            if (anotherTrick.ToLower() == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nYou decided to have the dog do another trick!\n");
                                signaling = Validation.ValidateString("How do you signal the dog?\n");
                                Console.WriteLine(dog.Perform(signaling));

                                Console.ReadKey();
                                Console.WriteLine("\nPress any key to continue...");
                                Selection();

                            }
                            else if (anotherTrick.ToLower() == "no")
                            {
                                Selection();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe dog doesn't know any tricks yet!\n");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();

                    }
                    break;
                case "4":
                    {
                        Console.Clear();

                        Console.WriteLine(dog.MakeNoise());

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();
                    }
                    break;
                case "5":
                    {
                        Selection();

                    }
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;


            }
        }


        public void HorseSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou selected the horse.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n1. Train the animal in a new behaviour." +
                "\n2. Feed the animal a treat." +
                "\n3. Signal the animal to perform a behaviour." +
                "\n4. Listen to the animal make a noise." +
                "\n5. Return to the main menu.\n");

            string interactChoice = Validation.ValidateString("\nWhat would you like to do with the horse?\n");

            switch (interactChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        if (horse.Behaviours.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe horse doesn't know any tricks yet!");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.WriteLine("\nLet's teach it one!");
                            string trick = Validation.ValidateString("What trick do you want the horse to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the horse to do the trick?");

                            horse.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe horse will now {trick} when you {signal}!\n");

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                        else if (horse.Behaviours.Count != 0)
                        {
                            string trick = Validation.ValidateString("What trick do you want the horse to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the horse to do the trick?");

                            while (horse.Behaviours.ContainsKey(signal))
                            {

                                Console.Clear();
                                Console.WriteLine($"\nOh, the horse already knows the signal {signal} for a trick!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\nPlease choose a different signal!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                signal = Validation.ValidateString("\nWhat signal will you give the horse to do the trick?");

                            }


                            horse.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe horse will now {trick} when you {signal}!\n");


                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                    }
                    break;
                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine(horse.Eat());
                        Console.WriteLine(horse.Poop());

                        string moreFood = Validation.ValidateString("Feed horse again?\n[yes]\n[no]");

                        while (!(moreFood.ToLower() == "yes" || moreFood.ToLower() == "no"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nPlease choose 'yes' or 'no'.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            moreFood = Validation.ValidateString("\nFeed horse again?\n[yes]\n[no]");

                        }

                        while (moreFood.ToLower() == "yes" || moreFood.ToLower() == "no")
                        {

                            if (moreFood.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou decided to feed the horse again!\n");
                                Console.WriteLine(horse.Eat());
                                Console.WriteLine(horse.Poop());

                                moreFood = Validation.ValidateString("Feed horse again?\n[yes]\n[no]");

                            }
                            else if (moreFood.ToLower() == "no")
                            {
                                Selection();
                            }

                        }


                    }
                    break;
                case "3":
                    {
                        Console.Clear();

                        if (horse.Behaviours.Count > 0)
                        {
                            string signaling = Validation.ValidateString("How do you signal the horse?");
                            Console.WriteLine(horse.Perform(signaling));

                            string anotherTrick = Validation.ValidateString("\nHave the horse do another trick?\n[yes]\n[no]");

                            while (!(anotherTrick.ToLower() == "yes" || anotherTrick.ToLower() == "no"))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nPlease choose 'yes' or 'no'!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                anotherTrick = Validation.ValidateString("\nHave the horse do another trick?\n[yes]\n[no]");
                            }

                            if (anotherTrick.ToLower() == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nYou decided to have the horse do another trick!\n");
                                signaling = Validation.ValidateString("How do you signal the horse?\n");
                                Console.WriteLine(horse.Perform(signaling));

                                Console.ReadKey();
                                Console.WriteLine("\nPress any key to continue...");
                                Selection();

                            }
                            else if (anotherTrick.ToLower() == "no")
                            {
                                Selection();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe horse doesn't know any tricks yet!\n");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();

                    }
                    break;
                case "4":
                    {
                        Console.Clear();

                        Console.WriteLine(horse.MakeNoise());

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();
                    }
                    break;
                case "5":
                    {
                        Selection();

                    }
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;


            }

        }

        public void SnakeSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou selected the snake.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n1. Feed the animal a treat." +
                "\n2. Listen to the animal make a noise." +
                "\n3. Return to the main menu.\n");

            string interactChoice = Validation.ValidateString("\nWhat would you like to do with the snake?\n");

            switch (interactChoice)
            {
                case "1":
                    {
                        Console.Clear();

                        Console.WriteLine(snake.Eat());
                        Console.WriteLine(snake.Poop());

                        string moreFood = Validation.ValidateString("Feed snake again?\n[yes]\n[no]");

                        while (!(moreFood.ToLower() == "yes" || moreFood.ToLower() == "no"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nPlease choose 'yes' or 'no'.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            moreFood = Validation.ValidateString("\nFeed snake again?\n[yes]\n[no]");

                        }

                        while (moreFood.ToLower() == "yes" || moreFood.ToLower() == "no")
                        {

                            if (moreFood.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou decided to feed the snake again!\n");
                                Console.WriteLine(snake.Eat());
                                Console.WriteLine(snake.Poop());

                                moreFood = Validation.ValidateString("Feed snake again?\n[yes]\n[no]");

                            }
                            else if (moreFood.ToLower() == "no")
                            {
                                Selection();
                            }

                        }

                    }
                    break;
                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine(snake.MakeNoise());

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();

                    }
                    break;
                case "3":
                    {
                        Selection();

                    }break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;

            }

        }


        public void ChickenSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou selected the chicken.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n1. Feed the animal a treat." +
                "\n2. Listen to the animal make a noise." +
                "\n3. Return to the main menu.\n");

            string interactChoice = Validation.ValidateString("\nWhat would you like to do with the chicken?\n");

            switch (interactChoice)
            {
                case "1":
                    {
                        Console.Clear();

                        Console.WriteLine(chicken.Eat());
                        Console.WriteLine(chicken.Poop());

                        string moreFood = Validation.ValidateString("Feed chicken again?\n[yes]\n[no]");

                        while (!(moreFood.ToLower() == "yes" || moreFood.ToLower() == "no"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nPlease choose 'yes' or 'no'.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            moreFood = Validation.ValidateString("\nFeed chicken again?\n[yes]\n[no]");

                        }

                        while (moreFood.ToLower() == "yes" || moreFood.ToLower() == "no")
                        {

                            if (moreFood.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou decided to feed the chicken again!\n");
                                Console.WriteLine(chicken.Eat());
                                Console.WriteLine(chicken.Poop());

                                moreFood = Validation.ValidateString("Feed chicken again?\n[yes]\n[no]");

                            }
                            else if (moreFood.ToLower() == "no")
                            {
                                Selection();
                            }

                        }

                    }
                    break;
                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine(chicken.MakeNoise());

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();

                    }
                    break;
                case "3":
                    {
                        Selection();

                    }break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;

            }
        }


        public void SasqSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou selected the sasquatch.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n1. Train the animal in a new behaviour." +
                "\n2. Feed the animal a treat." +
                "\n3. Signal the animal to perform a behaviour." +
                "\n4. Listen to the animal make a noise." +
                "\n5. Return to the main menu.\n");

            string interactChoice = Validation.ValidateString("\nWhat would you like to do with the sasquatch?\n");

            switch (interactChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        if (sasquatch.Behaviours.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe sasquatch doesn't know any tricks yet!");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.WriteLine("\nLet's teach it one!");
                            string trick = Validation.ValidateString("What trick do you want the sasquatch to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the sasquatch to do the trick?");

                            sasquatch.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe sasquatch will now {trick} when you {signal}!\n");

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                        else if (sasquatch.Behaviours.Count != 0)
                        {
                            string trick = Validation.ValidateString("What trick do you want the sasquatch to do?");

                            string signal = Validation.ValidateString("\nOkay! What signal will you give the sasquatch to do the trick?");

                            while (sasquatch.Behaviours.ContainsKey(signal))
                            {

                                Console.Clear();
                                Console.WriteLine($"\nOh, the sasquatch already knows the signal {signal} for a trick!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\nPlease choose a different signal!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                signal = Validation.ValidateString("\nWhat signal will you give the sasquatch to do the trick?");

                            }


                            sasquatch.Behaviours.Add(signal, trick);
                            Console.WriteLine($"\nThe sasquatch will now {trick} when you {signal}!\n");


                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }
                    }
                    break;
                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine(sasquatch.Eat());
                        Console.WriteLine(sasquatch.Poop());

                        string moreFood = Validation.ValidateString("Feed sasquatch again?\n[yes]\n[no]");

                        while (!(moreFood.ToLower() == "yes" || moreFood.ToLower() == "no"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nPlease choose 'yes' or 'no'.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            moreFood = Validation.ValidateString("\nFeed sasquatch again?\n[yes]\n[no]");

                        }

                        while (moreFood.ToLower() == "yes" || moreFood.ToLower() == "no")
                        {

                            if (moreFood.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou decided to feed the sasquatch again!\n");
                                Console.WriteLine(sasquatch.Eat());
                                Console.WriteLine(sasquatch.Poop());

                                moreFood = Validation.ValidateString("Feed sasquatch again?\n[yes]\n[no]");

                            }
                            else if (moreFood.ToLower() == "no")
                            {
                                Selection();
                            }

                        }


                    }
                    break;
                case "3":
                    {
                        Console.Clear();

                        if (sasquatch.Behaviours.Count > 0)
                        {
                            string signaling = Validation.ValidateString("How do you signal the sasquatch?");
                            Console.WriteLine(sasquatch.Perform(signaling));

                            string anotherTrick = Validation.ValidateString("\nHave the sasquatch do another trick?\n[yes]\n[no]");

                            while (!(anotherTrick.ToLower() == "yes" || anotherTrick.ToLower() == "no"))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nPlease choose 'yes' or 'no'!\n");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                anotherTrick = Validation.ValidateString("\nHave the sasquatch do another trick?\n[yes]\n[no]");
                            }

                            if (anotherTrick.ToLower() == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nYou decided to have the sasquatch do another trick!\n");
                                signaling = Validation.ValidateString("How do you signal the sasquatch?\n");
                                Console.WriteLine(sasquatch.Perform(signaling));

                                Console.ReadKey();
                                Console.WriteLine("\nPress any key to continue...");
                                Selection();

                            }
                            else if (anotherTrick.ToLower() == "no")
                            {
                                Selection();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe sasquatch doesn't know any tricks yet!\n");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.ReadKey();
                            Console.WriteLine("\nPress any key to continue...");
                            Selection();

                        }

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();

                    }
                    break;
                case "4":
                    {
                        Console.Clear();

                        Console.WriteLine(sasquatch.MakeNoise());

                        Console.ReadKey();
                        Console.WriteLine("\nPress any key to continue...");
                        Selection();
                    }
                    break;
                case "5":
                    {
                        Selection();

                    }
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu.\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;


            }
        }


    }
}
