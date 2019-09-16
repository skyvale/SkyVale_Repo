using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_DatabaseAndJSON
{
    class Food
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Food(string n, string t)
        {
            Name = n;
            Type = t;

        }



    }
}
