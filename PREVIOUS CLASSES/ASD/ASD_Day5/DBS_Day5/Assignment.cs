using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Day5
{
    class Assignment
    {

        // you can use an abstract class as a datatype
        List<Bird> Birdcage { get; set; }


        public Assignment()
        {

            //Bird bird = new Bird();

            Duck duck = new Duck();
            Console.WriteLine(duck.Fly());

            Penguin penguin = new Penguin();
            Console.WriteLine(penguin.Fly());

            Peacock peacock = new Peacock();
            Console.WriteLine(peacock.Fly());

            Console.WriteLine("-----------\r\n");

            Console.WriteLine(duck.Attack());
            Console.WriteLine(penguin.Attack());
            Console.WriteLine(peacock.Attack());

        }



    }


    // an abstract class is a template only
    // it is only meant to build concrete birds (ducks, penguins, etc.) so you can't instantiate it
    abstract class Bird
    {

        public string Name { get; set; }
        public string Color { get; set; }


        // ctor tabtab
        public Bird()
        {
            Console.WriteLine("\r\nBird created!\r\n");



        }

        // you need keyword VIRTUAL so that concrete class functions can OVERRIDE this base function and
        // have their own way of flying
        public virtual string Fly()
        {

            return "I flap my wings and go up!";

        }


        // an abstract method is meant to be overridden!
        // you cannot have a concrete class without a method override for a base class' abstract method
        public abstract string Attack();


    }





    class Duck : Bird
    {


        public Duck()
        {
            Console.WriteLine("\r\nDuck created!\r\n");


        }


        public override string Fly()
        {
            return "Quack";

        }


        public override string Attack()
        {
            return "I attack with my foots";

        }

    }



    class Penguin : Bird
    {

        public Penguin()
        {
            Console.WriteLine("\r\nPenguin created!\r\n");


        }

        // this is how the concrete class can OVERRIDE the base class' function Fly( )
        public override string Fly()
        {

            return "No can do, man. I can't fly.";

        }


        public override string Attack()
        {

            return "I flipper smack you";

        }


    }




    class Peacock : Bird
    {

        public Peacock()
        {

            Console.WriteLine("\r\nPeacock created!");


        }

        // if it doesn't have a different way to Fly(), you don't have to add a new method Fly()

        public override string Attack()
        {

            return "I murder you with tail slappy";
        }

    }




}

