using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameDD
{
    internal class Wizard
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public Wizard()
        {
          
            Strength = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;
        }

        public void IncreaseStrength()
        {
            Strength++;
        }

        public void DecreaseStrength()
        {
            if (Strength > 0)
            {
                Strength--;
            }
        }

       
    }
}
