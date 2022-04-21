using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Framework_Configurations
{
  
        #region A class that contains properties of the Settings Section  
        public class SettingSection : ConfigurationSection
        {
            [ConfigurationProperty("countrycode", DefaultValue = "", IsKey = true, IsRequired = true)]
            public string CountryCode
            {
                get { return (string)this["countrycode"]; }
                set { this["countrycode"] = value; }
            }
            [ConfigurationProperty("isenabled", DefaultValue = true, IsRequired = true)]
            public bool IsEnabled
            {
                get { return (bool)this["isenabled"]; }
                set { this["isEnabled"] = value; }
            }
        }
        #endregion  
}
