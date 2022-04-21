using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Framework_Configurations
{
    #region Object Element 
    public class WorldObjectElements : ConfigurationElement
    {
       
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("defencepoints", DefaultValue = "", IsRequired = true)]
        public string DefencePoints
        {
            get { return (string)this["defencepoints"]; }
            set { this["defencepoints"] = value; }
        }

        [ConfigurationProperty("attackpoints", DefaultValue = "", IsRequired = true)]
        public string AttackPoints
        {
            get { return (string)this["attackpoints"]; }
            set { this["attackpoints"] = value; }
        }

        [ConfigurationProperty("len", DefaultValue = "", IsRequired = true)]
        public string len
        {
            get { return (string)this["len"]; }
            set { this["len"] = value; }
        }
    }
    #endregion

}
