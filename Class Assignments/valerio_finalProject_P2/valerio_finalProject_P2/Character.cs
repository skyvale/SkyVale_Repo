using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valerio_finalProject_P2
{
    // this abstract class contains the mandatory components to create a character

    // all characters have two good stats (boons) and two bad stats (banes)

    abstract class Character : IComparable<Character>
    {

        public string Name { get; set; }
        public int Health;
        public int Attack;
        public int Defense;
        public int Speed;
        public int Magic;

        // all characters must have a name and a value for the five base stats
        public Character(string n, int h, int a, int d, int s, int m)
        {
            Name = n;
            Health = h;
            Attack = a;
            Defense = d;
            Speed = s;
            Magic = m;

        }

        // this method makes sure the created characters are listed in alphabetical order
        public int CompareTo(Character other)
        {
            return Name.CompareTo(other.Name);

        }

    }
}
