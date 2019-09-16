using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Example
{
    class Card
    {

        public string Suite { get; set; }
        public int Value { get; set; }


        // there are 52 cards in a deck

        public Card(int v, string s)
        {

            Value = v;
            Suite = s;

            //Console.WriteLine("Card created!");

        }


    }
}
