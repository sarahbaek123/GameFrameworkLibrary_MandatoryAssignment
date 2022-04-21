using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Framework_Configurations
{
   
        #region Object Element  Collection    
        [ConfigurationCollection(typeof(WorldObjectElements), AddItemName = "objects")]
        public class WorldObjectElementCollection : ConfigurationElementCollection
        {
            protected override ConfigurationElement CreateNewElement()
            {
                return new WorldObjectElements();
            }

            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((WorldObjectElements)element).Name;
            }

        }

        #endregion
    
}
