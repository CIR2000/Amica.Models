using NUnit.Framework;

namespace Amica.Models.Tests
{
	[TestFixture]
	public class Preferences : BaseTestClass
	{
		[Test]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Company.Preferences));
		}
		[Test]
		public void DefaultValues ()
		{
            var p = new Company.Preferences();
            Assert.AreEqual("N.", p.UnitOfMeasure);
		}
	}
}