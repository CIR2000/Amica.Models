using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
	[TestClass]
	public class Preferences : BaseTestClass
	{
		[TestMethod]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Company.Preferences));
		}
		[TestMethod]
		public void DefaultValues ()
		{
            var p = new Company.Preferences();
            Assert.AreEqual("N.", p.UnitOfMeasure);
		}
	}
}