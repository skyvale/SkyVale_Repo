using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_CE04
{
    class Teacher : Person
    {
        public string[] Background { get; set; }


        public Teacher (string[] b, string n, int a, Dictionary<string, string> add): base(n, a, add)
        {
            Background = b;
       

        }


    }
}
