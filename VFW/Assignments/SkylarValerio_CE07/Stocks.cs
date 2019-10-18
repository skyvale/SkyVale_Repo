using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Skylar Valerio
 * 10.15.19
 * CE07: JSON and Web Connectivity
 * VFW
 * 
 */

namespace SkylarValerio_CE07
{
    public class Stocks
    {
        string name;
        decimal lastPrice;
        decimal openingPrice;
        decimal highPrice;
        decimal lowPrice;
        string symbol;

        public string Name { get => name; set => name = value; }
        public decimal LastPrice { get => lastPrice; set => lastPrice = value; }
        public decimal OpeningPrice { get => openingPrice; set => openingPrice = value; }
        public decimal HighPrice { get => highPrice; set => highPrice = value; }
        public decimal LowPrice { get => lowPrice; set => lowPrice = value; }
        public string Symbol { get => Symbol; set => Symbol = value; }



        public override string ToString()
        {
            return Name;
        }

    }
}
