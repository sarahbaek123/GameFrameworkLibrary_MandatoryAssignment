using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.WorldObjects
{
    public class AttackItem
    {
        public int Hitpoints { get; set; }
        public int Range { get; set; }

        public AttackItem(string name, bool lootable, bool removable, int hitpoints, int range)
        {
            Hitpoints = hitpoints;
            Range = range;
        }
    }
}
