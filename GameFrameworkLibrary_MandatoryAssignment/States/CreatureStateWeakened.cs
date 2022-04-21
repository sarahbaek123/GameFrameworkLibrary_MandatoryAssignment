using GameFrameworkLibrary_MandatoryAssignment.Creatures;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.States
{
    public class CreatureStateWeakened :ICreatureState
    {
       /// <summary>
       /// This is a weakened state of the creature
       /// </summary>
       /// <param name="hitpoints">hit points</param>
       /// <returns>reduced hit points</returns>
        public int Hit(int hitpoints)
        {
            return hitpoints - 5 ;
        }

       /// <summary>
       /// This is a weakened state of the creature after it has received hits
       /// </summary>
       /// <param name="creature">creature</param>
       /// <param name="damage">the amount of damage caused</param>
        public void ReceiveHit(Creature creature, int damage)
        {
            creature.Hitpoints -= damage * 2;
        }
    }
}
