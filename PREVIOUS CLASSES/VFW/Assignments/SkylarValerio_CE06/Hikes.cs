using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Skylar Valerio
 * 10.13.19
 * CE06: Treeview & Tab Control
 * VFW
 */

namespace SkylarValerio_CE06
{
    public class Hikes
    {
        string direction;
        decimal miles;
        decimal hours;
        string mode;
        int imageIndex;

        public string Direction { get => direction; set => direction = value; }
        public decimal Miles { get => miles; set => miles = value; }
        public decimal Hours { get => hours; set => hours = value; }
        public string Mode { get => mode; set => mode = value; }
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }

        public override string ToString()
        {
            return Direction;
        }
    }
}
