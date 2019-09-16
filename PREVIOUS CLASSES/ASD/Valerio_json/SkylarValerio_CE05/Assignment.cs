using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Valerio_JSON2
{
    class Assignment
    {

        public List<Employee> Employees = new List<Employee>();
        private string _directory = @"..\..\output\";
        private string _file = @"employees.txt";


        public Assignment()
        {

            Directory.CreateDirectory(_directory);

            if (File.Exists(_directory + _file))
            {
                Console.WriteLine("File exists.\n");
                Console.Clear();

            }
            else
            {
                File.Create(_directory + _file);
                Console.WriteLine("File created.");
                Console.ReadKey();
                Console.Clear();
            }

            Load();
            Selection();


        }


        // this method loads the employees from the .txt file
        private void Load()
        {
            using (StreamReader sr = new StreamReader(_directory + _file))
            {
                while (sr.Peek() > 0)
                {
                    string line = sr.ReadLine();

                    if (line.StartsWith("m"))
                    {
                        string[] mArray = line.Split(',');
                        string name = mArray[1];
                        string address = mArray[2];
                        decimal salary = decimal.Parse(mArray[3]);
                        decimal bonus = decimal.Parse(mArray[4]);

                        Manager manager = new Manager(bonus, salary, name, address);
                        Employees.Add(manager);
                    }
                    else if (line.StartsWith("h"))
                    {
                        string[] hArray = line.Split(',');
                        string name = hArray[1];
                        string address = hArray[2];
                        int hourlyPay = int.Parse(hArray[3]);
                        int hoursWeek = int.Parse(hArray[4]);

                        Hourly hourly = new Hourly(hourlyPay, hoursWeek, name, address);
                        Employees.Add(hourly);
                    }
                    else if (line.StartsWith("f"))
                    {
                        string[] fArray = line.Split(',');
                        string name = fArray[1];
                        string address = fArray[2];
                        decimal hourlyPay = decimal.Parse(fArray[3]);
                        int hoursWeek = int.Parse(fArray[4]);

                        FullTime fulltime = new FullTime(name, address, hourlyPay, hoursWeek);
                        Employees.Add(fulltime);

                    }
                    else if (line.StartsWith("s"))
                    {
                        string[] sArray = line.Split(',');
                        string name = sArray[1];
                        string address = sArray[2];
                        decimal salary = decimal.Parse(sArray[3]);

                        Salaried salaried = new Salaried(salary, name, address);
                        Employees.Add(salaried);

                    }
                    else if (line.StartsWith("p"))
                    {
                        string[] fArray = line.Split(',');
                        string name = fArray[1];
                        string address = fArray[2];
                        decimal hourlyPay = decimal.Parse(fArray[3]);
                        decimal hoursWeek = decimal.Parse(fArray[4]);

                        PartTime parttime = new PartTime(hourlyPay, hoursWeek, name, address);
                        Employees.Add(parttime);

                    }
                }
            }

        }

        // this method calls the menu and lets the user select options
        public void Selection()
        {

            Console.Clear();
            Menu menu = new Menu("Add Employee", "Remove Employee", "Display Payroll", "Save Employees", "Save to JSON", "Exit");
            menu.Display();

            string userInput = Validation.ValidateString("\r\nMake a selection...");


            switch (userInput.ToLower())
            {

                case "1":
                case "add employee":
                    {
                        AddEmployee();

                    }
                    break;
                case "2":
                case "remove employee":
                    {
                        RemoveEmployee();

                    }
                    break;
                case "3":
                case "display payroll":
                case "display":
                    {
                        Display();

                    } break;
                case "4":
                case "save employees":
                    {
                        Save();

                    }break;
                case "5":
                case "save to json":
                    {
                        SaveToJSON();

                    }break;
                case "6":
                case "exit":
                    {
                        Exit();

                    }
                    break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\nPlease select an option from the menu.\r\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey();
                        Console.Clear();
                        Selection();


                    }
                    break;


            }

        }


        // this method adds employees
        public void AddEmployee()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nAdd Employee\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------\r\n");

            string employeeType = Validation.ValidateString("\r\nWhat kind of employee are you adding?\r\n[1] Full-Time\r\n[2] Part-Time\r\n[3] Salaried\r\n[4] Manager");

            switch (employeeType)
            {
                case "1":
                    {
                        string name = Validation.ValidateString("\r\nWhat is their name?");
                        string address = Validation.ValidateString("\r\nWhat is their address?");
                        decimal payHourly = Validation.ValidateDecimal("\r\nWhat is their pay per hour?");

                        FullTime newFulltime = new FullTime(name, address, payHourly, 40);
                        Employees.Add(newFulltime);

                    }
                    break;
                case "2":
                    {
                        string name = Validation.ValidateString("\r\nWhat is their name?");
                        string address = Validation.ValidateString("\r\nWhat is their address?");
                        decimal payHourly = Validation.ValidateDecimal("\r\nWhat is their pay per hour?");
                        decimal hours = Validation.ValidateDecimal("\r\nHow many hours are they working each week?");

                        PartTime newParttime = new PartTime(payHourly, hours, name, address);
                        Employees.Add(newParttime);

                    }
                    break;
                case "3":
                    {
                        string name = Validation.ValidateString("\r\nWhat is their name?");
                        string address = Validation.ValidateString("\r\nWhat is their address?");
                        decimal salary = Validation.ValidateDecimal("\r\nWhat is their yearly salary?");

                        Salaried newSalaried = new Salaried(salary, name, address);
                        Employees.Add(newSalaried);
                    }
                    break;
                case "4":
                    {
                        string name = Validation.ValidateString("\r\nWhat is their name?");
                        string address = Validation.ValidateString("\r\nWhat is their address?");
                        decimal salary = Validation.ValidateDecimal("\r\nWhat is their yearly salary?");
                        decimal bonus = Validation.ValidateDecimal("\r\nWhat is the bonus amount?");

                        Manager newManager = new Manager(bonus, salary, name, address);
                        Employees.Add(newManager);

                    }
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\nPlease select an option from the list.\r\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("\r\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        AddEmployee();

                    }
                    break;


            }

            Employees.Sort();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nEmployee was added!\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            Selection();



        }


        // this removes employees that were added
        public void RemoveEmployee()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nRemove Employee\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------\r\n");

            if (Employees.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nThere are no employees to remove.\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\r\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                Selection();

            }
            else
            {

                for (int i = 0; i < Employees.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {Employees[i].GetName}");

                }

                int userInput = Validation.ValidateInt("\r\nWho would you like to terminate?");

                if (userInput > Employees.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nInvalid entry. Please choose a valid number for the corresponding employee.\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("\r\nPress any button to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    RemoveEmployee();



                }
                else
                {
                    Console.WriteLine($"\r\n{Employees[userInput - 1].GetName} says {Employees[userInput - 1].Terminate()}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nThey have been fired!!\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Employees.RemoveAt(userInput - 1);

                    Console.WriteLine("\r\nPress any key to return to the main menu...");
                    Console.ReadKey();
                    Console.Clear();
                    Selection();

                }


            }


        }


        // this method displays all the employees, including the ones in the loaded .txt file
        public void Display()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nEMPLOYEES\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------\r\n");

            foreach (Employee item in Employees)
            {
                Console.WriteLine($"\r\nName: {item.GetName}\r\nAddress: {item.GetAddress}\r\nPay: {item.CalculatePay().ToString("c")}");
                Console.WriteLine("\r\n-----------\r\n");


            }

            Console.WriteLine();
            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            Selection();


        }


        // this method saves the employees to the .txt file (employees.txt)
        public void Save()
        {
            Console.Clear();

            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {

                foreach (Employee employee in Employees)
                {
                    sw.WriteLine(employee.StringtoSave());
                }

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEmployees have been saved!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            Selection();


        }


        // this method saves to the .json file (workers.json)
        public void SaveToJSON()
        {

            Console.Clear();
            Console.WriteLine("\nSaving to JSON");
            int dotCount = 0;
            while (dotCount < 3)
            {
                Console.WriteLine(".");
                dotCount++;
                Thread.Sleep(500);

            }

            using (StreamWriter sw = new StreamWriter(_directory + "workers.json"))
            {
                StreamReader sr = new StreamReader(_directory + _file);
                string line = sr.ReadLine();

                int index = 0;

                sw.WriteLine("[");
                foreach (Employee employee in Employees)
                {
                    if (line.StartsWith("m"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"name\": \"{employee.GetName}\",");
                        sw.WriteLine($"\"address\": \"{employee.GetAddress}\"");
                        sw.WriteLine($"\"position\": \"manager\"");
                        sw.WriteLine($"\"position\": \"{employee.CalculatePay()}\"");

                    }
                    else if (line.StartsWith("h"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"name\": \"{employee.GetName}\",");
                        sw.WriteLine($"\"address\": \"{employee.GetAddress}\"");
                        sw.WriteLine($"\"position\": \"hourly\"");
                        sw.WriteLine($"\"position\": \"{employee.CalculatePay()}\"");

                    }
                    else if (line.StartsWith("f"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"name\": \"{employee.GetName}\",");
                        sw.WriteLine($"\"address\": \"{employee.GetAddress}\"");
                        sw.WriteLine($"\"position\": \"full-time\"");
                        sw.WriteLine($"\"position\": \"{employee.CalculatePay()}\"");

                    }
                    else if (line.StartsWith("s"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"name\": \"{employee.GetName}\",");
                        sw.WriteLine($"\"address\": \"{employee.GetAddress}\"");
                        sw.WriteLine($"\"position\": \"salaried\"");
                        sw.WriteLine($"\"position\": \"{employee.CalculatePay()}\"");

                    }
                    else if (line.StartsWith("p"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"name\": \"{employee.GetName}\",");
                        sw.WriteLine($"\"address\": \"{employee.GetAddress}\"");
                        sw.WriteLine($"\"position\": \"part-time\"");
                        sw.WriteLine($"\"position\": \"{employee.CalculatePay()}\"");

                    }

                    // check to make sure its not the last line (since the last line doesnt need a comma)
                    if (index == Employees.Count - 1)
                    {
                        sw.WriteLine("}");

                    }
                    else
                    {
                        sw.WriteLine("},");
                    }

                    index++;
                }

                sw.WriteLine("]");

            }


            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSaved!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();

            Console.Clear();
            Selection();



        }



        public void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\nUntil next time.\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;

        }


    }
}
