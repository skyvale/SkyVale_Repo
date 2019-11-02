using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Skylar Valerio
 * 10.07.19
 * CE03: Custom Events
 * VFW
 * 
 * This class holds the getters and setters for all the properties of a Character object
 */

namespace SkylarValerio_CE03_2_
{
    public class Character
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Starter { get; set; }
        public string Region { get; set; }
        public bool NewPlayer { get; set; }

        // show the character's name in the ListBox
        public override string ToString()
        {
            return Name;
        }
    }
}
