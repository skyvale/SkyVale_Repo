using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    class Snake : Animal
    {

        public Snake()
        {
            Species = "snake";
            _treat = "fuzzy mouse";
        }

        public override string Eat()
        {
            return "\nThe snake swallowed a rat!";

        }

        public override string MakeNoise()
        {
            return "\nThe snake wiggled its tongue at you and made a hissy sound!";

        }

    }
}
