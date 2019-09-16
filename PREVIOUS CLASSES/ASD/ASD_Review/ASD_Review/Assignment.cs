using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Review
{

    class Assignment
    {

        //Dictionary<int, Car> stuff = new Dictionary<int, Car>();

        //public Assignment()
        //{
        //    Random rnd = new Random();
        //    Console.WriteLine(rnd.Next(1, 7));

        //    Car car = new Car();
        //    car.Make = "hyundai";
        //    car.Name = "cabbage";
        //    car.Vin = 12345;

        //    Car car2 = new Car();
        //    car2.Make = "jeep";
        //    car2.Name = "jeremy";
        //    car2.Vin = 67890;

        //    stuff.Add(12345, car);
        //    stuff.Add(67890, car2);

        //    Console.WriteLine(stuff[12345].Name);

        //}


        //----------------------------------------------------------------
        // ZOOKEEPER STUFF


        private List<Animal> _animals = new List<Animal>();

        public Assignment()
        {
            Snake snake = new Snake();
            Dolphin dolphin = new Dolphin();

            _animals.Add(snake);
            _animals.Add(dolphin);

            Console.WriteLine(dolphin.Train("snap fingers", "jump"));
            Console.WriteLine(dolphin.Perform("snap fingers"));

            // TYPE CASTING
            // you are telling the compiler that _animals[1] is trainable  when the compiler doesn't know, this is type casting
            if (_animals[1] is ITrainable)
            {
                ITrainable trainAnimal = (ITrainable)_animals[1];
                trainAnimal.Train("clap hands", "spin");

            }


            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, 7));

        }

    class Car
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public int Vin { get; set; }
    }


}



