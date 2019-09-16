using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Review
{
    abstract class Animal
    {

        public string Species { get; set; }
        private int _foodConsumed;
        protected string _treats;

        public Animal()
        {

        }

        public virtual string MakeNoise()
        {
            return "The animal makes a noise.";

        }

    }

    public interface ITrainable
    {
        Dictionary<string, string> Behaviours { get; set; }
        string Perform(string p);
        string Train(string t, String b);

    }
}
