using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Skylar Valerio
 * 10.19.19
 * CE08: XML and Treeviews
 * VFW
 * 
 */ 

namespace ValerioSkylar_CE08
{
    public class Stock
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string LastPrice { get; set; }
        public string OpeningPrice { get; set; }
        public string HighPrice { get; set; }
        public string LowPrice { get; set; }



        public override string ToString()
        {
            return Name;
        }

    }
}
