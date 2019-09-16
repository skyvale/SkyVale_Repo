using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Day5_2_
{
    class Assignment
    {

        public Assignment()
        {

        }


    }


    // every method (besides the constructor) in an abstract class MUST be either
    // an abstract or a virtual method
    abstract class Person
    {

        public string Name { get; set; }
        public int Social { get; set; }

        public Person()
        {


        }


        public virtual void Sleep()
        {
            Console.WriteLine("Close your eyes.");

        }


        public abstract void Exercise();


    }



    class Employee : Person
    {

        public Employee()
        {

        }


        public override void Exercise()
        {
            Console.WriteLine("Exercise is for the weak!");

        }

    }

}
