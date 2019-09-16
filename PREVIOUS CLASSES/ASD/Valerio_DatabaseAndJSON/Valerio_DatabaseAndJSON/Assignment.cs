using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using System.IO;

namespace Valerio_DatabaseAndJSON
{
    class Assignment
    {

        Menu menu = new Menu();
        public Dictionary<string, List<Food>> foodList;
        public string FoodName;
        public string FoodType;
        private string _directory = @"..\..\output\";
        private string _json = @"food.json";



        public Assignment()
        {

            Directory.CreateDirectory(_directory);

            if (File.Exists(_directory + _json))
            {
                Console.WriteLine("File exists.\n");
                Console.Clear();

            }
            else
            {
                File.Create(_directory + _json);
                Console.WriteLine("File created.");
                Console.Clear();
            }

            Selection();

        }


        public void Selection()
        {
            Console.Clear();

            // display menu
            menu = new Menu("Load Table", "Display to Console", "Exit");
            menu.Display();

            // ask for user input
            string menuChoice = Validation.ValidateString("\nPlease make a selection from the menu...");

            // menu options
            switch (menuChoice.ToLower())
            {
                case "1":
                case "load table":
                    {
                        LoadDatabase();

                    }break;
                case "2":
                case "display to console":
                    {
                        DisplayDatabase();

                    }break;
                case "3":
                case "exit":
                    {
                        Console.Clear();
                        Console.WriteLine("\nGood bye!\n");

                    }break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease choose an option from the menu!");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Selection();

                    }
                    break;
            }

        }

        // method that loads from database and stores in dictionary list
        public void LoadDatabase()
        {
            Console.Clear();
            
            // MySQL Database Connection String
            string cs = @"server=10.63.25.191;userid=admin;password=password;database=ASD;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            foodList = new Dictionary<string, List<Food>>();


            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "SELECT name, type " +
                             "FROM food;";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

            
                while (rdr.Read())
                {

                    FoodName = rdr["name"].ToString();
                    FoodType = rdr["type"].ToString();

                    foodList.Add(FoodName, new List<Food>());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The {FoodName} has been loaded!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                }

                rdr.Close();

                Console.WriteLine("\nPress any key to return to the main menu...\n");
                Console.ReadKey();
                Selection();


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                Console.ReadKey();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        // method that displays the table from the SQL database
        public void DisplayDatabase()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("FOOD");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n-------------------------------\n");

            // MySQL Database Connection String
            string cs = @"server=10.63.25.191;userid=admin;password=password;database=ASD;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "SELECT name, type " +
                             "FROM food;";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    

                    FoodName = rdr["name"].ToString();
                    FoodType = rdr["type"].ToString();

                    Console.WriteLine("Name: " + FoodName);
                    Console.WriteLine("Type: " + FoodType);
                    Console.WriteLine("\n-------------\n");


                }

                rdr.Close();

                Console.WriteLine("\nPress any key to return to the main menu...\n");
                Console.ReadKey();
                Selection();


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                Console.ReadKey();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
 

        }

        // method that puts the data from dictionary into json file
        //public void ExportToJSON()
        //{
        //    Console.Clear();
        //    Console.WriteLine("\nExporting to JSON");
        //    int dotCount = 0;
        //    while (dotCount < 3)
        //    {
        //        Console.WriteLine(".");
        //        dotCount++;
        //        Thread.Sleep(500);

        //    }

        //    using (StreamWriter sw = new StreamWriter(_directory + _json))
        //    {
        //        StreamReader sr = new StreamReader(_directory + _json);
        //        string line = sr.ReadLine();

        //        int index = 0;

        //        sw.WriteLine("[");

        //    }

        //    foreach (KeyValuePair<string, List<Food>> item in foodList)
        //    {
        //        Console.WriteLine("\nName: " + item.Value[0].Name + "\nType: " + item.Value[0].Type + "\n");
        //        Console.WriteLine("\n--------------");

        //    }

        //}

    }
}
