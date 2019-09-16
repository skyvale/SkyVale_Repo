using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_CE04
{
    class Student : Person
    {

        public int Grade { get; set; }


        public Student(int g, string n, int a, Dictionary<string, string> add): base(n, a, add)
        {
            Grade = g;


        }


    }
}
