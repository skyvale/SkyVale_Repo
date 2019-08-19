using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFW_Day2Notes
{
    class Person
    {

        public string firstName;
        public string lastName;
        public bool isStudent;

        public override string ToString()
        {
            return lastName + ", " + firstName;
        }
    }
}
