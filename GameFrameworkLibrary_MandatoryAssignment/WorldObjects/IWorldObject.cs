using GameFrameworkLibrary_MandatoryAssignment.Creatures;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.WorldObjects
{
    public interface IWorldObject
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removable { get; set; }
        public Position Position { get; set; }

     
    }
}
