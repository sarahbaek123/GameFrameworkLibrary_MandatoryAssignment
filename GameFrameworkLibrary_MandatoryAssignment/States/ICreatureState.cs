namespace GameFrameworkLibrary_MandatoryAssignment.Creatures
{
    public interface ICreatureState
    {
        /// <summary>
        /// The creature state changes the way how the creature behaves depending on its state.
        /// </summary>
    
            int Hit(int hitpoint);
            void ReceiveHit(Creature creature, int damage);

        
    }
}