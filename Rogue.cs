using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameDD
{
    internal class Rogue
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public Rogue()
        {

            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;
        }
    }
}
