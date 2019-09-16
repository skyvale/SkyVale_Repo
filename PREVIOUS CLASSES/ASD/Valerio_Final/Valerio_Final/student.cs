using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Final
{
    class Student : Person
    {
        public string Degree { get; set; }
        public List<int> Grades { get; set; }


        public Student(string n, string d, List<int> g) : base(n)
        {
            Degree = d;
            Grades = g;
               
        }


        // method that calculates average grades
        public int Average()
        {
            int avrGrade = (Grades[0] + Grades[1] + Grades[2]) / 3;

            return avrGrade;

        }


        public override string StringToSave()
        {
            int grade1 = Grades[0];
            int grade2 = Grades[1];
            int grade3 = Grades[2];


            return $"{Name},{Degree},{grade1},{grade2},{grade3}";

        }
    }
}
