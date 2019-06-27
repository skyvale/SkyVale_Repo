using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valerio_finalProject_P2
{
    // cleric characters have high magic and speed, but low attack and defense
    class Cleric : Character
    {
        public List<int> Stats = new List<int>();
        public Random rnd = new Random();


        public Cleric(string n, string cc) : base (n, cc)
        {
            // refer to warrior constructor function for explanation on what I'm doing here

            // banes
            Attack = Attack - rnd.Next(1, 9);
            Defense = Defense - rnd.Next(1, 9);

            // boons
            Magic = Magic + rnd.Next(1, 10);
            Speed = Speed + rnd.Next(1, 10);

            // Add stats to the Stats list
            Stats.Add(Health);
            Stats.Add(Attack);
            Stats.Add(Defense);
            Stats.Add(Speed);
            Stats.Add(Magic);

        }

        // this method takes the list of stats and arranges them so they can be neatly printed out to the console
        public string StatsToString()
        {
            int health = Stats[0];
            int attack = Stats[1];
            int defense = Stats[2];
            int speed = Stats[3];
            int magic = Stats[4];

            return $"Health: {health}\nAttack: {attack}\nDefense: {defense}\nSpeed: {speed}\nMagic: {magic}\n";
        }

        // this is the string that will save to the File IO when the character is created
        public override string SaveToFile()
        {
            int health = Stats[0];
            int attack = Stats[1];
            int defense = Stats[2];
            int speed = Stats[3];
            int magic = Stats[4];

            return $"{Name},{characterClass},{health},{attack},{defense},{speed},{magic}";
        }
    }
}
