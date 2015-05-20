using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrangeVanilla.Utils.Feature.Configuration
{
    using System.Configuration;

	public class FeaturesCollection : ConfigurationElementCollection
    {
		public FeatureElement this[object key]
		{
			get
			{
				return base.BaseGet(key) as FeatureElement;
			}
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		protected override string ElementName
		{
			get
			{
				return "feature";
			}
		}

		protected override bool IsElementName(string elementName)
		{
			bool isName = false;
			if (!String.IsNullOrEmpty(elementName))
				isName = elementName.Equals("feature");
			return isName;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new FeatureElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((FeatureElement)element).Name;
		}
    }
}

