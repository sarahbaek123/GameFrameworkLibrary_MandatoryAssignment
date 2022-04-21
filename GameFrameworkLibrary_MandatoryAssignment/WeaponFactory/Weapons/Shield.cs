using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFrameworkLibrary_MandatoryAssignment.Creatures;

namespace GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Weapons
{
    public class Shield :IWeaponDefenseItem
    {
        public string Name { get; set; }
        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;
        public Position Position { get; set; }
        public int Range { get; set; } = 1;

        public int ReduceHitPoints { get; set; } = -2;

        public Shield(string name, Position position)
        {
            Name = name;
            Position = position;
            // catch/handle position exception 
        }
        public override string ToString()
        {
            return $"Shield with name {Name}, ReduceHitpoints: {-2}";
        }
    }
}

