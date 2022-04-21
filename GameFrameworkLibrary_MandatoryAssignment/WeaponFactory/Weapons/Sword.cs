using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFrameworkLibrary_MandatoryAssignment.Creatures;

namespace GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Weapons
{
    public class Sword : IWeaponAttackItem
    {
        public string Name { get; set; }
        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;
        public Position Position { get; set; }
        public int Range { get; set; } = 1;
        public int Hitpoints { get; set; } = 10;

        public Sword(string name, Position position)
        {
            Name = name;
            Position = position;
            // catch/handle position exception 
        }

        public override string ToString()
        {
            return $"Sword with name {Name}, Hitpoints: {10}";
        }
    }
}
