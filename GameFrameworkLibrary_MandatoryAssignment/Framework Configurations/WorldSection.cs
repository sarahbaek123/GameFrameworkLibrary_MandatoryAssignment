using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Framework_Configurations
{
   public class WorldSection : ConfigurationSectionGroup
   {
       // These are configuration properties
        #region MySection Group 

        [ConfigurationProperty("setting", IsRequired = false)]
        public SettingSection GeneralSettings
        {
            get { return (SettingSection)base.Sections["setting"]; }
        }

        [ConfigurationProperty("worldEnviron", IsRequired = false)]
        public GameEnvironment ContextSettings
        {
            get { return (GameEnvironment)base.Sections["worldEnviron"]; }
        }
   }
        #endregion
}
