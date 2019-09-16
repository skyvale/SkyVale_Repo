using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_ZooKeeper
{
    abstract class Animal
    {
        public string Species { get; set; }
        private int _foodConsumed;
        protected string _treat;

        public Animal()
        {
            _treat = "generic treat";
        }


        public virtual string Eat()
        {
 
            return "\nThe animal ate food!";


        }

        public virtual string MakeNoise()
        {
            return "\nThe animal makes a noise.";

        }

        public string Poop()
        {
            _foodConsumed++;

            if (_foodConsumed > 3)
            {
                Console.WriteLine("\nThey ate the food and then...\n");

                return "Oh no! They pooped!\n";

            }
            else
            {
                return "";
            }
 

        }


    }

    interface ITrainable
    {
        Dictionary<string, string> Behaviours { get; set; }
        string Perform(String signal);
        string Train(string signal, String behaviour);

    }
}
