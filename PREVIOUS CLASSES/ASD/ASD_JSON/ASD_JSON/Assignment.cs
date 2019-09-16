using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASD_JSON
{
    class Assignment
    {
        private string _directory = @"..\..\output\";
        private string _file = @"data.txt";
        private Menu _myMenu;
        private List<Employee> _employee = new List<Employee>();



        public Assignment()
        {
            Directory.CreateDirectory(_directory);

            if (!File.Exists(_directory + _file))
            {
                File.Create(_directory + _file).Dispose();
            }
            else
            {
                Console.WriteLine("File already exists");
            }

            LoadEmployees();

            Console.Clear();

            _myMenu = new Menu("Add", "Display", "Save", "Save to JSON", "Exit");
            _myMenu.Display();

            Selection();
        }


        // select from menu
        private void Selection()
        {
            int selection = Validation.ValidateInt("Choose something on the menu...");
            switch (selection)
            {
                case 1:
                    {
                        AddEmployee();
                    }break;

                case 2:
                    {
                        DisplayEmployees();
                    }break;

                case 3:
                    {
                        Save();
                    }break;

                case 4:
                    {
                        ExportToJSON();
                    }break;
                case 5:
                    {
                        Exit();
                    }break;
                    
                default:
                    {
                        Console.WriteLine("\nPlease choose from the menu!");
                        Console.ReadKey();
                        Console.Clear();
                        _myMenu.Display();
                        Selection();
                    }
                    break;
            }
        }


        // mimic the JSON file using C#
        private void ExportToJSON()
        {
            Console.Clear();
            Console.WriteLine("\nExporting to JSON...");
            using (StreamWriter sw = new StreamWriter(_directory + "workers.json"))
            {
                int index = 0;
                sw.WriteLine("[");
                foreach (Employee employee in _employee)
                {
                    sw.WriteLine("{");
                    sw.WriteLine($"\"name\": \"{employee.Name}\",");
                    sw.WriteLine($"\"id\": \"{employee.Id}\"");
                    
                    // check to make sure its not the last line (since the last line doesnt need a comma)
                    if (index ==  _employee.Count -1)
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



        }

        // save any new employees to the file (using File I/O)
        private void Save()
        {
            Console.Clear();
            Console.WriteLine("Saving...");
            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {
                foreach (Employee employee in _employee)
                {
                    sw.WriteLine(employee.StringToSave());
                }
            }

            Console.ReadKey();

            Console.Clear();

            _myMenu.Display();

            Selection();

        }


        // add an employee
        private void AddEmployee()
        {
            Console.Clear();

            int empType = Validation.ValidateInt("1-Manager or 2-Hourly?");

            string name = Validation.ValidateString("Name of employee?");

            string empId = Validation.ValidateString("Id of employee?");

            if (empType == 1)
            {
                int salary = Validation.ValidateInt("Salary?");
                int bonus = Validation.ValidateInt("Bonus?");

                Manager manager = new Manager(name, empId, salary, bonus);

                _employee.Add(manager);

            }
            else
            {
                int hours = Validation.ValidateInt("Hours for employee?");
                float rate = Validation.ValidateFloat("Rate for employee?");

                Hourly hourly = new Hourly(name, empId, hours, rate);
                _employee.Add(hourly);
            }

            Console.Clear();

            _myMenu.Display();

            Selection();
        }


        // load employees from the file (using File I/O)
        private void LoadEmployees()
        {
            using (StreamReader sr = new StreamReader(_directory + _file))
            {
                while (sr.Peek() > 0)
                {
                    string line = sr.ReadLine();
                    if (line.StartsWith("m"))
                    {

                        Manager manager = new Manager(line.Split(','));
                        _employee.Add(manager);
                    }
                    else
                    {
                        Hourly hourly = new Hourly(line.Split(','));
                        _employee.Add(hourly);
                    }
                }
            }


        }


        // display list of employees
        private void DisplayEmployees()
        {
            Console.Clear();

            foreach (Employee employee in _employee)
            {
                Console.WriteLine($"{employee.Name,-12} {employee.CalculatePay().ToString("c"),-7}");
            }

            Console.ReadKey();

            Console.Clear();

            _myMenu.Display();

            Selection();

        }


        private void Exit()
        {
            Console.WriteLine("Exiting...");

            Console.ReadKey();

        }




    }




    abstract class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Employee(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public abstract float CalculatePay();

        public abstract string StringToSave();

    }



    class Manager : Employee
    {
        public int Salary { get; set; }
        public int Bonus { get; set; }

        public Manager(string[] data) : base(data[1], data[2])
        {
            Salary = int.Parse(data[3]);
            Bonus = int.Parse(data[4]);

            Console.WriteLine("Manager created");
        }

        public Manager(string name, string id, int salary, int bonus) : base(name, id)
        {
            Salary = salary;
            Bonus = bonus;
        }

        public override float CalculatePay()
        {

            return Salary + Bonus;
        }
        //m,Bob,12345,50000,500
        public override string StringToSave()
        {
            return $"m,{Name},{Id},{Salary},{Bonus}";
        }

    }



    class Hourly : Employee
    {
        public int Hours { get; set; }
        public float Rate { get; set; }

        public Hourly(string[] data) : base(data[1], data[2])
        {
            Hours = int.Parse(data[3]);
            Rate = float.Parse(data[4]);

            Console.WriteLine("Hourly employee created");
        }

        public Hourly(string name, string id, int hours, float rate) : base(name, id)
        {
            Hours = hours;
            Rate = rate;
        }

        public override float CalculatePay()
        {
            return Hours * Rate;
        }

        public override string StringToSave()
        {
            return $"h,{Name},{Id},{Hours},{Rate}";
        }


    }

}