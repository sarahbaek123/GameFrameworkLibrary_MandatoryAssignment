using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Framework_Configurations
{
    public class GameEnvironment : ConfigurationSection
    {
        #region Company Section

        [ConfigurationProperty("World", IsDefaultCollection = true)]
            public WorldObjectElementCollection world
            {
                get { return (WorldObjectElementCollection)this["World"]; }
                set { this["World"] = value; }
            }

            [ConfigurationProperty("worldObjects", IsDefaultCollection = true)]
         
            public WorldObjectElementCollection WorldWorldObject
            {
                get { return (WorldObjectElementCollection)this["worldObjects"]; }
                set { this["worldObjects"] = value; }
            }

        #endregion
    }
}
