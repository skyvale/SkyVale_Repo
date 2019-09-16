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
    public class Character
    {
        // properties for the data from UserInputForm
        string name;
        string gender;
        string region;
        string starterPokemon;
        int imageIndex;


        // getters and setters for the above properties(?)
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Region { get => region; set => region = value; }
        public string StarterPokemon { get => starterPokemon; set => starterPokemon = value; }
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }


        //override to show the name
        public override string ToString()
        {
            return Name;
        }

    }
}
