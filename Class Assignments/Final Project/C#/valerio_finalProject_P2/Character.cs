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
        // base character stats all start at 10, the min is 1 and the max is 20
        public string Name { get; set; }
        public string characterClass { get; set; }
        public int Health = 10;
        public int Attack = 10;
        public int Defense = 10;
        public int Speed = 10;
        public int Magic = 10;

        // all characters must have a name, character class, and a value for the five base stats
        public Character(string n, string cc)
        {
            Name = n;
            characterClass = cc;

            Health = 10;
            Attack = 10;
            Defense = 10;
            Speed = 10;
            Magic = 10;

        }


        // this will be used in each concrete class to save characters to File IO
        public abstract string SaveToFile();


        // this method makes sure the created characters are listed in alphabetical order
        public int CompareTo(Character other)
        {
            return Name.CompareTo(other.Name);

        }

    }
}
