using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Day4
{
    class Assignment
    {
        public Assignment()
        {

            Student student = new Student("Bob", 12345);
            //student.Age = 60;
            //student.Name = "Bob";



        }



    }

    // person is the BASE CLASS
    // student is the CONCRETE CLASS (the class that inherits from the base)
     class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Social { get; set; }

        public Person(string n)
        {
            Console.WriteLine("Person created!\r\n");

            Name = n;

        }

    }


    // student should INHERIT the traits of a person, because a student is a person
    // use a colon on the class name to do this

    /* remember: a student inherits the properties of a person (name, age, social) but not every person
    *            has grades and a student number, so those properties are confined to the student class only
    */ 

    class Student: Person
    {

        public int[] Grades { get; set; }
        public int Number { get; set; }

        // make sure to reference student's base class (person)
        // the arguments have to match in order to referene
        public Student(string n, int num): base(n)
        {
            Number = num;
            Console.WriteLine("\r\nStudent created!");
            Console.WriteLine("Student number = " + Number);

        }


    }



    class Employee : Person
    {

        public Employee(string n) : base(n)
        {


        }


    }



    class Player : Person
    {

        public Player(string n) : base(n)
        {


        }

    }
}
