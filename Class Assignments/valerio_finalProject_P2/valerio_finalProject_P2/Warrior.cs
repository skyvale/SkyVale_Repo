using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valerio_finalProject_P2
{
    // warrior characters have high attack and defense, and low magic and speed
    class Warrior : Character
    {
        // the altered stats are put into a list
        public List<int> Stats = new List<int>();
        public Random rnd = new Random();

        public Warrior(string n, string cc) : base(n,cc)
        {

            // the bane stats on a warrior are magic and speed, so they will have a penalty

            // this will take the speed stat and subtract a random amount
            Speed = Speed - rnd.Next(1, 9);

            // this will take the magic stat and do the same thing
            Magic = Magic - rnd.Next(1, 9);

            // the boon stats on a warrior are attack and defense, so they will increase
            Attack = Attack + rnd.Next(1, 10);
            Defense = Defense + rnd.Next(1, 10);

            // finally, all the stats are added to the Stats list
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
