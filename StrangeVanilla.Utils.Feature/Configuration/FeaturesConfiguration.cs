using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrangeVanilla.Utils.Feature.Configuration
{
    using System.Configuration;

    public class FeaturesConfiguration : ConfigurationSection
    {
		private static FeaturesConfiguration _configuration = ConfigurationManager.GetSection ("featuresConfiguration") as FeaturesConfiguration;
		public static FeaturesConfiguration Get()
		{
			return _configuration;
		}

		[ConfigurationProperty("features")]
		public FeaturesCollection Features
		{
			get
			{
				return this["features"] as FeaturesCollection;
			}
		}
    }
}
