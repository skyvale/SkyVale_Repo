using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Day6
{
    class Assignment
    {

        private Menu _menu;
        private Dictionary<string, List<Student>> _students;


        public Assignment()
        {

            // instantiate all variables, including the LIST within the dictionary
            _menu = new Menu("Create Student", "Remove Student", "Display", "Exit");
            _students = new Dictionary<string, List<Student>>();

            // add to the dictionary with keys and the instantiation of the list variable
            _students.Add("male", new List<Student>());
            _students.Add("female", new List<Student>());


            Console.Clear();
            _menu.Display();
            Selection();




        }



        private void Selection()
        {

            string userInput = Validation.ValidateString("\r\nMake a selection...");

            switch (userInput.ToLower())
            {

                case "1":
                case "create":
                    {
                        CreateStudent();


                    }break;
                case "2":
                case "remove":
                    {
                        RemoveStudent();


                    }break;
                case "3":
                case "display":
                    {
                        DisplayStudents();

                    }break;
                case "4":
                case "exit":
                    {
                        Exit();

                    }break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\nPlease choose from the menu.\r\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Console.Clear();
                        _menu.Display();
                        Selection();

                    }
                    break;

            }


        }



        private void CreateStudent()
        {

            Console.Clear();

            string studentInput = Validation.ValidateString("\r\nWhat is their name?");

            string gender = Validation.ValidateString("\r\nWhat is their gender?");
            //TODO !! Make sure you add a ContainsKey validation so that the program doesn't crash if they misspell the key

            // create an instance of the student class to reference
            Student student = new Student(studentInput);

            // add their gender to the dictionary
            student.Gender = gender;

            // ask and add their grades to the dictionary grade list
            for (int i = 0; i < 3; i++)
            {
                int grade = Validation.ValidateInt($"\r\nWhat is grade {i + 1}?");

                student.Grades[i] = grade;

            }

            // remember, the way you drill into a dictionary is using []
            // add the new student to the dictionary
            _students[gender].Add(student);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nStudent has been added!\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            _menu.Display();
            Selection();



        }



        private void RemoveStudent()
        {




        }



        private void DisplayStudents()
        {

            Console.Clear();

            // create a new menu to display the different ways to display the students
            Menu choiceMenu = new Menu("Male", "Female", "All");
            choiceMenu.Display();

            string userInput = Validation.ValidateString("\r\nMake a selection...");

            switch (userInput.ToLower())
            {
                case "1":
                case "male":
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\r\nMales");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("--------------\r\n");
                        // look through the dictionary's list of students
                        // item is a Student because the items in the list are Students
                        foreach (Student item in _students["male"])
                        {
                            Console.WriteLine($"{item.Name, -10}{item.Grades, -10} ");

                        }


                    }break;
                case "2":
                case "female":
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\r\nFemales");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("--------------\r\n");

                        foreach (Student item in _students["female"])
                        {
                            Console.WriteLine($"{item.Name,-15}{item.Grades,-10} ");

                        }

                    }
                    break;
                case "3":
                case "all":
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\r\nAll Students");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("--------------\r\n");

                        foreach (KeyValuePair<string, List<Student>> item in _students)
                        {
                            // this loops through the list of students
                            foreach (Student student in item.Value)
                            {
                                Console.Write($"{student.Name}");

                                // this loops through the array of grades within the list of students
                                foreach (int grade in student.Grades)
                                {
                                    Console.Write($"{grade} ");

                                }

                                Console.WriteLine();

                            }

                        }


                    }break;
                case "4":
                case "exit":
                    {


                    }break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\nInvalid response. Please make a selection from the menu.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\r\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        DisplayStudents();


                    }
                    break;

            }



        }



        private void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\nExiting...\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;

        }

    }
}
