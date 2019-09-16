using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Chicken : Animal
    {

        public Chicken()
        {
            Species = "chicken";
            _treat = "sweet corn";
        }

        public override string Eat()
        {
            return "\nThe chicken pecked up all the seed!";
        }

        public override string MakeNoise()
        {
            return "\nThe chicken strutted up and bokked at you!";
        }

    }
}
