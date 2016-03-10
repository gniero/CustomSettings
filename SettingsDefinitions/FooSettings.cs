using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsTest
{
    public class FooSettings : ConfigurationElement
    {
        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get
            {
                return this["Name"] as string;
            }
        }

        [ConfigurationProperty("Address", IsRequired = true)]
        public string Address
        {
            get
            {
                return this["Address"] as string;
            }
        }
    }
}
