using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameDD
{
    internal class Warrior
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public Warrior()
        {

            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;
        }
    }
}
