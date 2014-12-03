using NUnit.Framework;

namespace Amica.vNext.Models.Tests
{
	[TestFixture]
	public class CountryTests : BaseTestClass
	{
		[Test]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Country));
		}
	}
}