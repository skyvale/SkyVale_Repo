using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_CE04
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Dictionary<string, string> address { get; set; }


        public Person(string n, int a, Dictionary<string, string> add)
        {

            Name = n;
            Age = a;
            address = add;


        }





    }
}
