using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_Final
{
    abstract class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public Person(string n)
        {
            Name = n;

        }

        public abstract string StringToSave();

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);

        }

    }
}
