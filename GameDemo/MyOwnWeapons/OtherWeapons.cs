using GameFrameworkLibrary_MandatoryAssignment.Creatures;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Factories;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Weapons;

namespace GameDemo.MyOwnWeapons
{
    public class OtherWeapons : IWeaponFactoryForAttackItems
    {
        public IWeaponAttackItem Create(WeaponTypeAttack weaponType)
        {
            switch (weaponType)
            {
                case WeaponTypeAttack.Melee:
                    return  new Dagger("ADagger", 5);
                default:
                    return null;
            }
        }

    }
}
