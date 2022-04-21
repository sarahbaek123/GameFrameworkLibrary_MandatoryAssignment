using GameFrameworkLibrary_MandatoryAssignment.Creatures;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Weapons;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Factories
{
    public class WeaponFactoryAttackItem :IWeaponFactoryForAttackItems
    {
        //These are Attack items
        public IWeaponAttackItem Create(WeaponTypeAttack weaponType)
        {
            if (weaponType == WeaponTypeAttack.Melee)

                return new Sword("MySword", new Position(1, 1));

            if (weaponType == WeaponTypeAttack.Ranged)
                return new Sword("Bow", new Position(2, 2));

            if (weaponType == WeaponTypeAttack.Magic)
                return new Sword("YellowDeath", new Position(3, 3));

            throw new ArgumentException("Weapon type  was not found");
        }
    }
}
