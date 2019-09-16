using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Day6
{
    class Student
    {

        public string Name { get; set; }
        public int[] Grades { get; set; }
        public string Gender { get; set; }


        public Student(string n)
        {
            Name = n;
            Grades = new int[3];

        }

    }
}
