using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Review
{
    class Snake : Animal
    {
        public Snake()
        {
            Species = "snake";

        }

        public override string MakeNoise()
        {
            return "hissihissihissi";
     
        }

    }
}
