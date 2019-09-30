using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Skylar Valerio
 * 08.18.2019
 * CE04: ListViews
 * MDV1830-O
 */

namespace SkylarValerio_CE04
{
    // custom event class for Characters
    public class CharacterArgs : EventArgs
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Region { get; set; }
        public string StarterPokemon { get; set; }
        public int ImageIndex { get; set; }

    }
}
