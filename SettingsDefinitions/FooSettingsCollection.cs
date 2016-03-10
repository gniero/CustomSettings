using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsTest
{
    [Serializable]
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class FooSettingsCollection : SortedSet<FooSettings>
    {
    }
}
