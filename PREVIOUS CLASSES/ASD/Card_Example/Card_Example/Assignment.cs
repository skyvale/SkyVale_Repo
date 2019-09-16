using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Example
{
    class Assignment
    {

        public Assignment()
        {

            Deck deck = new Deck();

            deck.CreateDeck();

            Card card1 = deck.Deal();
            Card card2 = deck.Deal();

            Console.WriteLine("\r\n" + card1.Value + " of " + card1.Suite);
            Console.WriteLine(card2.Value + " of " + card2.Suite);

        }



    }
}
