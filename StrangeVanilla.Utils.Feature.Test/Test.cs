using NUnit.Framework;
using System;

namespace StrangeVanilla.Utils.Feature.Test
{
	[TestFixture ()]
	public class FeaturesHelperTest
	{
		[Test ()]
		public void Feature_Set_To_On_Should_Be_Inactive ()
		{
			bool expectedResult = true;
			bool actualResult = FeaturesHelper.IsActive ("on_feature");

			Assert.AreEqual (expectedResult, actualResult);
		}

		[Test ()]
		public void Feature_Set_To_Off_Should_Be_Inactive ()
		{
			bool expectedResult = false;
			bool actualResult = FeaturesHelper.IsActive ("off_feature");

			Assert.AreEqual (expectedResult, actualResult);
		}

		[Test ()]
		public void Feature_Not_Defined_Should_Be_Inactive ()
		{
			bool expectedResult = false;
			bool actualResult = FeaturesHelper.IsActive ("missing");

			Assert.AreEqual (expectedResult, actualResult);
		}

	}
}

