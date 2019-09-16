using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Review
{
    class Dolphin : Animal, ITrainable
    {
        public Dictionary<string, string> Behaviours { get; set; }

        public Dolphin()
        {
            Species = "dolphin";
            _treats = "fish";

            Behaviours = new Dictionary<string, string>();

        }

        public string Perform (string p)
        {
            if (Behaviours.ContainsKey(p))
            {
                return $"The dolphin can {Behaviours[p]}";

            }
            else
            {
                return "The dolphin can't do that trick yet!";
            }


        }

        public string Train (string t, string b)
        {
            Behaviours.Add(t,b);

            return $"The dolphin can now {b} when you {t}";

        }
    }
}
