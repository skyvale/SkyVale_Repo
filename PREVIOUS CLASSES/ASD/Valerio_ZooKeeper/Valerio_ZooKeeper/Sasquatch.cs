using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Sasquatch : Animal, ITrainable
    {

       public Dictionary<string, string> Behaviours { get; set; }

        public Sasquatch()
        {
            Species = "sasquatch";
            _treat = "vanilla wafers";

            Behaviours = new Dictionary<string, string>();
        }


        public override string Eat()
        {
            return "\nThe sasquatch tried to eat you, so you threw it your lunch and ran!";
        }


        public override string MakeNoise()
        {
            return "\nThe sasquatch let out an intimdating screech!";
        }


        public string Perform(string signal)
        {
            if (Behaviours.ContainsKey(signal))
            {
                return $"The sasquatch can {Behaviours[signal]}";

            }
            else
            {
                return "The sasquatch can't do that trick yet!";
            }

        }


        public string Train(string signal, string behaviour)
        {
            Behaviours.Add(signal, behaviour);

            return $"The sasquatch can now {signal} when you {behaviour}";

        }


    }
}
