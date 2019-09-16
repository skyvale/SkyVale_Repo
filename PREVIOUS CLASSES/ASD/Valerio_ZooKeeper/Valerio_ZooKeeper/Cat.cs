using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Cat : Animal, ITrainable
    {

        public Dictionary<string, string> Behaviours { get; set; }

        public Cat()
        {
            Species = "cat";
            _treat = "catnip";

            Behaviours = new Dictionary<string, string>();
        }

        public override string Eat()
        {
            return $"\nThe cat gently ate the {_treat} from your hand!";

        }


        public override string MakeNoise()
        {
            return "\nThe cat rubbed against your hand, letting out a loud purr!";
        }


        public string Perform(string signal)
        {
            if (Behaviours.ContainsKey(signal))
            {
                return $"The cat can {Behaviours[signal]}";

            }
            else
            {
                return "The cat can't do that trick yet!";
            }

        }


        public string Train(string signal, string behaviour)
        {
            Behaviours.Add(signal, behaviour);

            return $"The cat can now {signal} when you {behaviour}";

        }


    }
}
