using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_Cards
{
    class Deck
    {

        public static Random _random = new Random();
        public List<Card> Cards { get; set; }



        public Deck()
        {

            Cards = new List<Card>();


        }



        public void CreateDeck()
        {

            // these are codes for the card symbols
            string[] tempSuite = { "\u2663", "\u2666", "\u2660", "\u2665" };

            for (int i = 0; i < 51; i++)
            {
                Card card = new Card(i % 13, tempSuite[i % 4]);

               //Console.WriteLine(card.Suite + " " + card.ValueDeck);
                Cards.Add(card);

            }


        }




        public void Shuffle()
        {

            for (int i = Cards.Count - 1; i > 0; i--)
            {

                Card temp = Cards[i];
                int index = _random.Next(0, i + 1);
                Cards[i] = Cards[index];
                Cards[index] = temp;


            }

        }




        public Card Deal()
        {

            Card tempCard = Cards[0];
            Cards.RemoveAt(0);

            return tempCard;


        }





    }
}
