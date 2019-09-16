using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Horse : Animal, ITrainable
    {

        public Dictionary<string, string> Behaviours { get; set; }

        public Horse()
        {
            Species = "horse";
            _treat = "apple slice";

            Behaviours = new Dictionary<string, string>();
        }

        public override string Eat()
        {
            return "\nThe horse bent down and chomped up the grass!";
        }


        public override string MakeNoise()
        {
            return "\nThe horse shook its mane and let out a happy whiny!";
        }


        public string Perform(string signal)
        {
            if (Behaviours.ContainsKey(signal))
            {
                return $"The horse can {Behaviours[signal]}";

            }
            else
            {
                return "The horse can't do that trick yet!";
            }


        }


        public string Train(string signal, string behaviour)
        {
            Behaviours.Add(signal, behaviour);

            return $"The horse can now {signal} when you {behaviour}";

        }


    }
}
