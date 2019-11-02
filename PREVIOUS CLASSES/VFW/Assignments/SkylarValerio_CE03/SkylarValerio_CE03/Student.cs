using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylarValerio_CE03
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public bool Gender;
        public string Program;
        public bool Above21;

        // this is what will display to the user in the Display ListBox
        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}
