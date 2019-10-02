using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFW_MultiForms
{
    class Person
    {
        // make the variables public since you are still storing this info in a private listbox
        public string Firstname;
        public string Lastname;
        public bool Student;

        // this is what will show in the listbox
        public override string ToString()
        {
            return Lastname + ", " + Firstname;
        }
    }
}
