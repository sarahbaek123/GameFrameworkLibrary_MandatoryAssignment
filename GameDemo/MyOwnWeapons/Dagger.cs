using GameFrameworkLibrary_MandatoryAssignment.Creatures;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.MyOwnWeapons
{
    public class Dagger :IWeaponAttackItem
    {
      
            public string Name { get; set; }
            public bool Lootable { get; set; } = true;
            public bool Removable { get; set; } = true;
            public Position Position { get; set; }
            public int Range { get; set; } = 1;
            public int Hitpoints { get; set; }

            public Dagger(string name, int hitpoints)
            {
                Name = name;
                Hitpoints = hitpoints;
            }
        
    }
}
