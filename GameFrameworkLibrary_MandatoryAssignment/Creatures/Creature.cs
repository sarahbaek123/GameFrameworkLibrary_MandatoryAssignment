using GameFrameworkLibrary_MandatoryAssignment.WorldObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Creatures
{
    public class Creature
    {
        public int Hitpoints { get; set; }
        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;

        public ICreatureState State { get; set; }

        public Position Position { get; set; }

       

        public List<IWeaponAttackItem> AttackWeapons { get; set; }
        public List<IWeaponDefenseItem> DefenceWeapons { get; set; }
    

        public List<IWorldObject> Rucksack { get; set; }

      
        /// <summary>
        /// Constructor for creature class.
        /// </summary>
        /// <param name="weapons">Amount of attack weapons this creature can use at same time. Default: 1</param>
        /// <param name="defense">Amount of defense weapons this creature can use at same time. Default: 1</param>
        public Creature(int weapons = 1, int defense = 1)
        {
            AttackWeapons = new List<IWeaponAttackItem>(weapons);
            DefenceWeapons = new List<IWeaponDefenseItem>(defense);
            Rucksack = new List<IWorldObject>();
        }

        /// <summary>
        /// Method for the creature to deal damage.
        /// Delegated to the state class.
        /// Dealt damage depends on the creatures state.
        /// </summary>
        /// <returns>Amount of damage points.</returns>
        public int Hit()
        {
         
            return State.Hit(AttackWeapons.Sum(weapon => weapon.Hitpoints));
        }

        public void Loot(IWorldObject @object)
        {
            Rucksack.Add(@object);
        }

        /// <summary>
        /// Method for the creature to take damage.
        /// Delegated to the state class.
        /// Taken damage depends on the creatures state.
        /// </summary>
        /// <param name="damage"></param>
        public void ReceiveHit(int damage)
        {
            State.ReceiveHit(this, damage - DefenceWeapons.Sum(defense => defense.ReduceHitPoints));
            if (Hitpoints <= 0)
            {
                IsAlive = false;
                Hitpoints = 0;
            }
        }

        /// <summary>
        /// Changes the state of the creature.
        /// </summary>
        /// <param name="state">A creature state object. Must implement ICreatureState.</param>
        public void ChangeState(ICreatureState state)
        {
            State = state;
        }

        public override string ToString()
        {
            return $"{Name}, Hitpoints: {Hitpoints}, State: {State.GetType().Name}";
        }
    }
}

