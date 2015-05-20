using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrangeVanilla.Framework.Feature.Configuration
{
    using System.Configuration;

    public class FeatureElement : ConfigurationElement
    {
		[ConfigurationProperty("name", IsRequired = true, IsKey = true)]
		public string Name
        {
            get
            {
                return (string)base["name"];
            }
        }

		[ConfigurationProperty("ison")]
        public bool IsOn
        {
            get
            {
                return ((bool)base["ison"]);
            }
        }

    }
}
