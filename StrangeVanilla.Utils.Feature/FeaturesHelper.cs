namespace StrangeVanilla.Utils.Feature
{
    using System.Configuration;
	using Configuration;
	using System.Linq;
	using System.Collections;
	using System.Collections.Generic;

    public static class FeaturesHelper
    {
        
		public static bool IsActive(string feature)
        {
			FeaturesCollection features = FeaturesConfiguration.Get().Features;
			var featureElement = features [feature];
			return featureElement != null && featureElement.IsOn;
        }
	}   
}