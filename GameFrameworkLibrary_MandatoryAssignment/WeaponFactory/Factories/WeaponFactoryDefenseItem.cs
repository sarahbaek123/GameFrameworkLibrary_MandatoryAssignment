using GameFrameworkLibrary_MandatoryAssignment.Creatures;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Weapons;

namespace GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Factories
{
    public class WeaponFactoryDefenseItem :IWeaponFactoryForDefenceItems
    {
        public IWeaponDefenseItem Create(WeaponTypeDefence weaponType)
        {
            if (weaponType == WeaponTypeDefence.A)

                return new Shield("Weapon Defence Type A", new Position(4, 4));
            if (weaponType == WeaponTypeDefence.B)

                return new Shield("Weapon Defence Type B", new Position(5, 5));
            if (weaponType == WeaponTypeDefence.C)

                return new Shield("Weapon Defence Type C", new Position(6, 6));


            throw new ArgumentException("Weapon type  was not found");
        }
    }
}
