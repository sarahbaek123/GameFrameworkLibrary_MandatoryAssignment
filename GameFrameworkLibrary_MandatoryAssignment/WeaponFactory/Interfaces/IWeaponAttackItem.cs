using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Enums;
using GameFrameworkLibrary_MandatoryAssignment.WorldObjects;

using System;

namespace GameFrameworkLibrary_MandatoryAssignment.Creatures
{
        /// <summary>
        /// Represents Attack Weapons
        /// </summary>
        public interface IWeaponAttackItem : IWorldObject
        {
            int Range { get; set; }
            int Hitpoints { get; set; }
        }
    
}