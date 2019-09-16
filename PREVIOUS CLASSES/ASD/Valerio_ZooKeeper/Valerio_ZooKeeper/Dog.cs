using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Dog : Animal, ITrainable
    {
        public Dictionary<string, string> Behaviours { get; set; }

        public Dog()
        {
            Species = "dog";
            _treat = "peanut butter";

            Behaviours = new Dictionary<string, string>();
        }


        public override string Eat()
        {
            return "\nThe dog gobbled up all the kibble you brought!";
        }


        public override string MakeNoise()
        {
            return "\nThe dog hopped around, barking at you excitedly!";
        }


        public string Perform(string signal)
        {
            if (Behaviours.ContainsKey(signal))
            {
                return $"The dog can {Behaviours[signal]}";

            }
            else
            {
                return "The dog can't do that trick yet!";
            }

        }


        public string Train(string signal, string behaviour)
        {
            Behaviours.Add(signal, behaviour);

            return $"The dog can now {signal} when you {behaviour}";

        }

    }
}
