using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Day3
{
    class Student
    {
        // declare getsetter properties
        // *remember, properties expose fields
        public List<int> Grades { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }



        // bring in the name of the student from the other class, set it equal to the public property getsetter
        public Student(string n)
        {

            Name = n;
            Grades = new List<int>();

            // check to make sure it works
            //Console.WriteLine("Student created!");

        }


        public string DisplayGrades()
        {

            string gradeString = "";

            for (int i = 0; i < Grades.Count; i++)
            {
                gradeString += Grades[i] + ",";

            }

            return gradeString;

        }
        



    }
}
