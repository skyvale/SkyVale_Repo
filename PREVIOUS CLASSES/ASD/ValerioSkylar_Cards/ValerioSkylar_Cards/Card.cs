using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_Cards
{
    class Card
    {

        public string Suite { get; set; }
        public int ValueDeck { get; set; }
        public string CardName { get; set; }

        public Card(int v, string s)
        {

            Suite = s;
            ValueDeck = v;

            string[] names = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            CardName = names[ValueDeck];
        }








    }
}
