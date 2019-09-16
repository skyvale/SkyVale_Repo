using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_Cards
{
    class Assignment
    {

        private Menu _myMenu;
        private string _name;
        private string _name2;
        public int Score1;
        public int Score2;
        public int RoundNumber;
        public Dictionary<string, List<Card>> cardDictionary;


        



        public Assignment()
        {
            Console.Clear();

            // this is so I can use the cool symbols for the cards
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            cardDictionary = new Dictionary<string, List<Card>>();

            // display the menu
            _myMenu = new Menu("Create Players", "Play Game", "Exit");
            _myMenu.Display();

            Selection();



        }


        private void Selection()
        {

            // select from the menu

            int userSelect = Validation.ValidateInt("\r\nMake a selection...", 1, 3);

            switch (userSelect)
            {

                case 1:
                    {
                        CreatePlayers();

                    }break;
                case 2:
                    {
                        PlayGame();

                    }break;
                case 3:
                    {
                        Exit();

                    }break;

            }

        }



        public void CreatePlayers()
        {

            Console.Clear();

            // check if players were already created
            if (cardDictionary.Count() == 0)
            {

                _name = Validation.ValidateString("\r\nWho is player one?");

                cardDictionary.Add(_name, new List<Card>());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Player {_name} added!");
                Console.ForegroundColor = ConsoleColor.Gray;

                _name2 = Validation.ValidateString("\r\nWho is player two?");

                if (_name2 != _name)
                {

                    cardDictionary.Add(_name2, new List<Card>());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\r\bPlayer {_name2} added!\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\r\nPress any key to continue...");
                    Console.ReadKey();

                    Console.Clear();
                    _myMenu.Display();
                    Selection();

                }
                else
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nPlayers must have different names!\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\r\nPlease add the players again. Be sure that the names are all different.\r\n");

                    // remove previous entry so that they user can create players again
                    cardDictionary.Remove(_name);
                    Console.ReadKey();

                    Console.Clear();
                    CreatePlayers();

                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nPlayers already added!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Return to the main menu and choose 'Play Game' to begin!\r\n");
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();

                
                Console.Clear();
                _myMenu.Display();
                Selection();

            }




        }



        public void PlayGame()
        {

            Console.Clear();

            // check to make sure there are players first
            if (cardDictionary.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nThere are no players!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Return to the main menu and choose 'Create Players' before starting a game.\r\n");
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();

                Console.Clear();
                _myMenu.Display();
                Selection();

            }
            else
            {
                Instructions();

                Console.Clear();
                Deck deck = new Deck();

                deck.CreateDeck();
                deck.Shuffle();

                AmountRounds();

                for (int i = 0; i < RoundNumber; i++)
                {
                    cardDictionary[_name].Add(deck.Deal());
                    cardDictionary[_name2].Add(deck.Deal());
                    
                }

                for (int i = 0; i < RoundNumber; i++)
                {
                    Console.Clear();
                    Scoreboard();
                    Console.WriteLine("\r\nPress any button to reveal your cards!");
                    Console.ReadKey();

                    Console.Clear();
                    Scoreboard();
                    Display();
                    ScoreKeeper();

                    cardDictionary[_name].RemoveAt(0);
                    cardDictionary[_name2].RemoveAt(0);

                    Console.Clear();
                      
                }

                Scoreboard();
                WinnerScreen();
                PlayAgain();

                Console.ReadKey();



            }




        }



        public void Instructions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nWelcome to the Card Game!\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\nINSTRUCTIONS:\r\n");
            Console.WriteLine("Each player will start with as many cards as there are rounds (max 25). Every round, the players will reveal the top card in their hand. " +
                "Whoever has the highest value will receive a point. If it is a tie, no one receives a point. When the round is over, the cards are discarded " +
                "and the players draw a new one until there are no longer any cards in their hand.\r\nThe player with the most points wins!\r\n");
            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();

        }


        public void AmountRounds()
        {

            int userInput = Validation.ValidateInt("\r\nHow many rounds would you like to play?\r\n");

            while (userInput >= 0)
            {

                if (userInput < 26 && userInput > 0)
                {
                    RoundNumber = userInput;
                    break;

                }
                else if (userInput == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nYou must play at least ONE round!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    userInput = Validation.ValidateInt("\r\nHow many rounds would you like to play?\r\n");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nPlease choose a number between 1-25!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    userInput = Validation.ValidateInt("\r\nHow many rounds would you like to play?\r\n");

                }


            }

        }




        public void Display()
        {

            foreach (KeyValuePair<string, List<Card>> item in cardDictionary)
            {

                Console.WriteLine("\r\n" + item.Key + " - " + item.Value[0].CardName + " " + item.Value[0].Suite);

                //Console.WriteLine($"{item.Key,-15}{item.Key,-20}");
                //Console.WriteLine($"{item.Value,-15}{item.Value, -20}");
            }

        }



        public void Scoreboard()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\r\n{_name, -15}{_name2, -15}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"{Score1, -15}{Score2, -15}\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------------");

        }
         


        public void ScoreKeeper()
        {

            if (cardDictionary[_name][0].ValueDeck > cardDictionary[_name2][0].ValueDeck)
            {
                Score1 += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\r\nPlayer {_name} recieves a point!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();


            }
            else if (cardDictionary[_name][0].ValueDeck < cardDictionary[_name2][0].ValueDeck)
            {
                Score2 += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\r\nPlayer {_name2} recieves a point!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nIt's a tie! No points.\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();

            }


        }


        public void WinnerScreen()
        {

            if (Score1 > Score2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\r\nCongratulations, Player {_name}! You have won the card game!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();


            }
            else if (Score1 < Score2)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\r\nCongratulations, Player {_name2}! You have won the card game!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();


            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\r\nIt's a tie!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();


            }

        }



        public void PlayAgain()
        {

            Console.Clear();

            string userInput = Validation.ValidateString("\r\nWould you like to play again?\r\n[yes]\r\n[no]");

            switch (userInput)
            {
                case "yes":
                    {
                        Score1 = 0;
                        Score2 = 0;

                        Console.Clear();
                        _myMenu.Display();
                        Selection();


                    }break;
                case "no":
                    {
                        Exit();

                    }break;

            }


        }



        public void Exit()
        {

            Console.WriteLine("\r\nUntil next time.\r\n");

        }



    }
}
