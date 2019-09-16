using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Valerio_Final
{
    class Assignment
    {

        private Menu _mainMenu = new Menu();
        private List<Student> _studentList = new List<Student>();
        private Dictionary<string, List<Student>> _studentDict = new Dictionary<string, List<Student>>();
        private List<string> _address = new List<string>();

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

            Load();
            Selection();


        }


        private void Load()
        {

            using (StreamReader sr = new StreamReader(_directory + _file))
            {
                // skip full sail address lines in txt file and put into list for later
                string address1 = sr.ReadLine();
                string address2 = sr.ReadLine();
                string address3 = sr.ReadLine();
                _address.Add(address1);
                _address.Add(address2);
                _address.Add(address3);
                sr.ReadLine();

                while (sr.Peek() > 0)
                {
 
                    string line = sr.ReadLine();

                    // put txt file stuff into an array
                    string[] studentArray = line.Split(',');
                    string name = studentArray[0];
                    string degree = studentArray[1];
                    int grade1 = int.Parse(studentArray[2]);
                    int grade2 = int.Parse(studentArray[3]);
                    int grade3 = int.Parse(studentArray[4]);

                    List<int> grades = new List<int> { grade1, grade2, grade3 };

                    // add the next student
                    Student student = new Student(name, degree, grades);
                    _studentList.Add(student);

                    // add the student to proper dictionary
                    if (degree == "web")
                    {
                        if (!(_studentDict.ContainsKey("web")))
                        {
                            _studentDict.Add("web", _studentList);
                        }


                    }
                    else if (degree == "mobile")
                    {
                        if (!(_studentDict.ContainsKey("mobile")))
                        {
                            _studentDict.Add("mobile", _studentList);
                        }

                    }

                    _studentList.Sort();


                }


            }


        }


        private void Selection()
        {
            Console.Clear();

            // school address
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < _address.Count; i++)
            {
                Console.WriteLine(_address[i]);

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\n----------------------------------------");


            _mainMenu = new Menu("Show All Students", "Show Mobile Students", "Show Web Students", "Add a Student", "Remove a Student", "Save Students", "EXIT");
            _mainMenu.Display();


            string menuChoice = Validation.ValidateString("\nMake a selection...");

            switch (menuChoice.ToLower())
            {
                case "1":
                case "show all students":
                    {
                        ShowAll();

                    }break;
                case "2":
                case "show mobile students":
                    {
                        ShowMobile();

                    }break;
                case "3":
                case "show web students":
                    {
                        ShowWeb();

                    }break;
                case "4":
                case "add a student":
                    {
                        AddStudent();

                    }break;
                case "5":
                case "remove a student":
                    {
                        RemoveStudent();

                    }break;
                case "6":
                case "save students":
                    {
                        SaveStudents();

                    }break;
                case "7":
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


        private void ShowAll()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nALL STUDENTS\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            foreach (Student student in _studentList)
            {
                Console.Write($"Name: {student.Name,-10} | Degree: {student.Degree.ToLower(),-10} | " +
                              $" Grades: {student.Grades[0]}, {student.Grades[1]}, {student.Grades[2]}\t | " +
                              $"Average: {student.Average()}");

                Console.WriteLine();
                Console.WriteLine("\n--------------\n");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Selection();

        }


        private void ShowWeb()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nWEB STUDENTS\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            foreach (Student student in _studentList)
            {
                if (student.Degree == "web")
                {
                    Console.Write($"Name: {student.Name,-10} | Degree: {student.Degree.ToLower(),-10} | " +
                                  $" Grades: {student.Grades[0]}, {student.Grades[1]}, {student.Grades[2]}\t | " +
                                  $"Average: {student.Average()}");

                    Console.WriteLine();
                    Console.WriteLine("\n--------------\n");

                }

            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Selection();

        }


        private void ShowMobile()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nMOBILE STUDENTS\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            foreach (Student student in _studentList)
            {
                if (student.Degree == "mobile")
                {
                    Console.Write($"Name: {student.Name,-10} | Degree: {student.Degree.ToLower(),-10} | " +
                                  $" Grades: {student.Grades[0]}, {student.Grades[1]}, {student.Grades[2]}\t | " +
                                  $"Average: {student.Average()}");

                    Console.WriteLine();
                    Console.WriteLine("\n--------------\n");

                }

            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Selection();

        }

        
        private void AddStudent()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nAdd a Student\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            string inputName = Validation.ValidateString("\nWhat is the new student's name?");
            string inputDegree = Validation.ValidateString($"\nIs {inputName} in web or mobile?");

            if (inputDegree.ToLower() == "web" || inputDegree.ToLower() == "mobile")
            {
                // generate random grades for new student
                Random rnd = new Random();
                int grade1 = rnd.Next(1, 100);
                int grade2 = rnd.Next(1, 100);
                int grade3 = rnd.Next(1, 100);

                // put random grades into a list
                List<int> randomGrades = new List<int>();
                randomGrades.Add(grade1);
                randomGrades.Add(grade2);
                randomGrades.Add(grade3);

                // create new student
                Student newStudent = new Student(inputName, inputDegree, randomGrades);

                // add student to proper dictionary
                if (inputDegree.ToLower() == "web")
                {
                    // add new student to web dict
                    _studentDict["web"].Add(newStudent);

                }
                else if (inputDegree.ToLower() == "mobile")
                {
                    // add new student to mobile dictionary
                    _studentDict["mobile"].Add(newStudent);
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{inputName} has been added!\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                _studentList.Sort();

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
                Selection();


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nPlease choose either web or mobile.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                AddStudent();

            }


        }


        private void RemoveStudent()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRemove a Student\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================================\n");

            string inputName = Validation.ValidateString("\nWhich student would you like to remove?");


            if (_studentList.Exists(Student => Student.Name == inputName))
            {
                // this finds the student by name and removes them from the list
                Student removeStudent = _studentList.Find(Student => Student.Name == inputName);
                _studentList.Remove(removeStudent);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n{inputName} has been removed!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Selection();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThat student does not exist in the system.\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ReadKey();
                RemoveStudent();

            }

        }


        private void SaveStudents()
        {
            Console.Clear();

            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {
                for (int i = 0; i < _address.Count; i++)
                {
                    sw.WriteLine(_address[i]);

                }
                sw.WriteLine();

                foreach (Student student in _studentList)
                {
                    sw.WriteLine(student.StringToSave());
                }

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nStudents have been saved!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            Selection();

        }
    }
}
