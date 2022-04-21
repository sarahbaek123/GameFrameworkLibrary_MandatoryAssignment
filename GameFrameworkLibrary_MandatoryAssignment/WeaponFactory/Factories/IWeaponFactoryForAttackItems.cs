using GameFrameworkLibrary_MandatoryAssignment.Creatures;

namespace GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Factories
{
    public interface IWeaponFactoryForAttackItems
    {
        IWeaponAttackItem Create(WeaponTypeAttack weaponType);
    }
}