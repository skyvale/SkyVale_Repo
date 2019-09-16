using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Example
{
    class Deck
    {

        public List<Card> Cards { get; set; }
        // never have more than one random number generator in a program
        private static Random rnd = new Random();



        public Deck()
        {

            Cards = new List<Card>();

        }


        public void CreateDeck()
        {

            string[] tempSuite = { "Clubs", "Diamonds", "Spades", "Clubs" };

            for (int i = 0; i < 51; i++)
            {
                Card card = new Card(i%13, tempSuite[i%4]);

                Console.WriteLine(card.Suite + " " + card.Value);
                Cards.Add(card);
            }


        }


        public Card Deal()
        {
            // go one number higher than you want it to stop at
            // also start at 0 because it is an index
            int index = Deck.rnd.Next(0, Cards.Count);

            Card myCard = Cards[index];
            Cards.RemoveAt(index);

            return myCard;

        }


        public void Shuffle()
        {



        }




    }
}
