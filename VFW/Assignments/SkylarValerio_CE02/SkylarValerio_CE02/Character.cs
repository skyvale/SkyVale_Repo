using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Skylar Valerio
 * 10.02.19
 * CE: Passing Data & Multiple Forms
 * VFW
 */

namespace SkylarValerio_CE02
{
    class Character
    {
        public string Name;
        public bool Gender;
        public string Clan;
        public string Role;
        public bool Former;

        public override string ToString()
        {
            return Name;
        }
    }
}
