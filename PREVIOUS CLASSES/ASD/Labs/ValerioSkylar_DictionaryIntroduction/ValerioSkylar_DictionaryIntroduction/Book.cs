using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_DictionaryIntroduction
{
    class Book
    {

        public int ISBN { get; set; }
        public string BookTitle { get; set; }
        public string Availability { get; set; }

        public Book(int i, string t)
        {

            ISBN = i;
            BookTitle = t;
            Availability = "yes";

        }






    }
}
