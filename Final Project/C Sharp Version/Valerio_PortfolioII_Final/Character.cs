using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_PortfolioII_Final
{
    class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string EyeCol { get; set; }

        public Character(string n, string g, int a, string ey)
        {
            Name = n;
            Gender = g;
            Age = a;
            EyeCol = ey;
        }

        public string SaveCharacter()
        {

            return $"{Name},{Gender},{Age},{EyeCol}";

        }

    }
}
