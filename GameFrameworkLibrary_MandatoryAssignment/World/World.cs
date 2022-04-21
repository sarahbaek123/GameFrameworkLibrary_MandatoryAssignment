using GameFrameworkLibrary_MandatoryAssignment.Creatures;
using GameFrameworkLibrary_MandatoryAssignment.WorldObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.World
{
    //Singleton Design Pattern - The world is only initialized once
    public class World
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public List<Creature> Creatures { get; set; }
        public List<IWorldObject> WorldObjects { get; set; }

        private static World _instance;

        private World(int x, int y)
        {
            X = x;
            Y = y;
            Creatures = new List<Creature>();
            WorldObjects = new List<IWorldObject>();
        }

        public static World GetWorld
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("World doesn't exist");
                }
                return _instance;
            }

            private set
            {
                _instance = value;
            }
        }

        public static void Create(int x, int y)
        {
            if (_instance != null)
            {
                throw new ArgumentException("World already exists");
            }

            _instance = new World(x, y);
        }

        public static void Reset()
        {
            _instance = null;
        }


        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
