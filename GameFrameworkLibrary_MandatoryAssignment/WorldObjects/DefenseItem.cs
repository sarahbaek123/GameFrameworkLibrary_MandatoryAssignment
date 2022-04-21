using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.WorldObjects
{
    public class DefenseItem
    {
        public int ReduceHitpoints { get; set; }

        public DefenseItem(string name, bool lootable, bool removable, int reduceHitpoints)
        {
            ReduceHitpoints = reduceHitpoints;
        }
    }
}
