using GameFrameworkLibrary_MandatoryAssignment.Creatures;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.States
{
    public class CreatureStateNormal
    {
        /// <summary>
        /// This is the normal state of the creature before it has taken any energizer
        /// </summary>
        /// <param name="hitpoints">When it hits an opponent it earns hit points</param>
        /// <returns></returns>
        public int Hit(int hitpoints)
        {
            return hitpoints;
        }

        /// <summary>
        /// When a creature is hit by an opponent , it gets a damage which reduces its hit points.
        /// </summary>
        /// <param name="creature">The creature that is hit</param>
        /// <param name="damage">The damages caused by the hit which will be reduced from the creatures hit points.</param>
        public void ReceiveHit(Creature creature, int damage)
        {
            creature.Hitpoints -= damage;
        }
    }
}
