using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_CE04
{
    class Assignment
    {
        public Course currentCourse;
        public Menu MainMenu;


        public Assignment()
        {

            Console.Clear();

            // instantiate and create the menu
            MainMenu = new Menu("Create Course", "Create Teacher", "Add Students", "Display", "Exit");
            MainMenu.Display();
            Selection();


        }



        public void Selection()
        {

            string userInput = Validation.ValidateString("\r\nMake a selection...");

            switch (userInput)
            {
                case "1":
                    {
                        CreateCourse();

                    }
                    break;
                case "2":
                    {
                        CreateTeacher();

                    }
                    break;
                case "3":
                    {
                        AddStudents();

                    }
                    break;
                case "4":
                    {
                        Display();

                    }
                    break;
                case "5":
                    {
                        Exit();

                    }
                    break;

            }

        }




        public void CreateCourse()
        {
            Console.Clear();

            string courseName = Validation.ValidateString("\r\nWhat is the name of the new course?");
            int numStudents = Validation.ValidateInt($"\r\nHow many students are in the {courseName}?");

            currentCourse = new Course(courseName, numStudents);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nNew course has been created!\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();

            Console.Clear();
            MainMenu.Display();
            Selection();

        }




        public void CreateTeacher()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Create Teacher");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\n----------------------------------------\r\n");

            if (currentCourse == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nThere is no course yet!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                MainMenu.Display();
                Selection();

            }
            else
            {

                string teacherName = Validation.ValidateString("\r\nWhat is the teacher's name?");
                int teacherAge = Validation.ValidateInt("\r\nWhat is the teacher's age?");

                Console.Clear();
                Console.WriteLine("\r\nNow we need the teacher's address.");
                string city = Validation.ValidateString("\r\nWhat city do they live in?");
                string state = Validation.ValidateString("\r\nWhat state?");
                string zip = Validation.ValidateString("\r\nWhat is their zip code?");

                Dictionary<string, string> TeacherDict = new Dictionary<string, string>();
                TeacherDict.Add("city", city);
                TeacherDict.Add("state", state);
                TeacherDict.Add("zipcode", zip);

                Console.Clear();
                Console.WriteLine("Now we need the teacher's qualifications.");
                string college = Validation.ValidateString("\r\nWhat college did they go to?");
                string certificate = Validation.ValidateString("\r\nWhat certificate do they have?");
                string experience = Validation.ValidateString("\r\nWhat prior work experience (job) do they have?");

                string[] qualifications = { college, certificate, experience };

                Teacher newTeacher = new Teacher(qualifications, teacherName, teacherAge, TeacherDict);
                currentCourse.AssignedTeacher = newTeacher;

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nNew teacher has been created!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();

                Console.Clear();
                MainMenu.Display();
                Selection();

            }



        }




        public void AddStudents()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add Students");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\n----------------------------------------\r\n");

            if (currentCourse == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nThere is no course yet!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                MainMenu.Display();
                Selection();


            }
            else
            {
                for (int i = 0; i < currentCourse.AssignedStudents.Length; i++)
                {

                    string studentName = Validation.ValidateString("\r\nWhat is the student's name?");
                    int studentAge = Validation.ValidateInt("\r\nWhat is the student's age?");
                    int grade = Validation.ValidateInt("\r\nWhat is the student's grade? Please enter a numerical value.");

                    Console.Clear();
                    Console.WriteLine("Now we will need the student's address.");
                    string city = Validation.ValidateString("\r\nWhat city do they live in?");
                    string state = Validation.ValidateString("\r\nWhat state?");
                    string zip = Validation.ValidateString("\r\nWhat is their zip code?");

                    Dictionary<string, string> StudentDict = new Dictionary<string, string>();
                    StudentDict.Add("city", city);
                    StudentDict.Add("state", state);
                    StudentDict.Add("zipcode", zip);

                    Student newStudent = new Student(grade, studentName, studentAge, StudentDict);
                    currentCourse.AssignedStudents[i] = newStudent;

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\nNew student has been created!\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                }

                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();

                Console.Clear();
                MainMenu.Display();
                Selection();

            }


        }




        public void Display()
        {
            Console.Clear();

            if (currentCourse == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nThere is no course yet!\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                MainMenu.Display();
                Selection();

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\r\n{currentCourse.Title, -20}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\r\n----------------------------------------\r\n");


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\r\nTeacher\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine($"Name: {currentCourse.AssignedTeacher.Name}");
                Console.WriteLine($"Age: {currentCourse.AssignedTeacher.Age}");
                Console.WriteLine($"\r\nAddress: ");
                Console.WriteLine($"{currentCourse.AssignedTeacher.address["city"]}, { currentCourse.AssignedTeacher.address["state"]}, { currentCourse.AssignedTeacher.address["zipcode"]}");

                Console.WriteLine($"\r\nBackground: ");
                for (int i = 0; i < currentCourse.AssignedTeacher.Background.Length; i++)
                {
                    Console.WriteLine($"{currentCourse.AssignedTeacher.Background[i]}");

                }

                Console.WriteLine("\r\n-------------------");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\r\nStudents\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                for (int i = 0; i < currentCourse.AssignedStudents.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Name: {currentCourse.AssignedStudents[i].Name}");
                    Console.WriteLine($"Age: {currentCourse.AssignedStudents[i].Age}");
                    Console.WriteLine($"Address: ");
                    Console.WriteLine($"{currentCourse.AssignedStudents[i].address["city"]}, {currentCourse.AssignedStudents[i].address["state"]}, {currentCourse.AssignedStudents[i].address["zipcode"]}");

                }


                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                MainMenu.Display();
                Selection();

            }


        }



        public void Exit()
        {
            Console.Clear();

            Console.WriteLine("\r\nUntil next time.\r\n");

        }

    }
}
