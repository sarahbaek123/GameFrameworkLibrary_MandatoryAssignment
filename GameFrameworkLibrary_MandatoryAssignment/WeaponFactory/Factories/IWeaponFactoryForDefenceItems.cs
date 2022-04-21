using GameFrameworkLibrary_MandatoryAssignment.Creatures;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Enums;

namespace GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Factories
{
    public interface IWeaponFactoryForDefenceItems
    {
        IWeaponDefenseItem Create(WeaponTypeDefence weaponType);
    }
}