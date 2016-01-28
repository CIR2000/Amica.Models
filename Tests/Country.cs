using NUnit.Framework;

namespace Amica.vNext.Models.Tests
{
	[TestFixture]
	public class Country : BaseTestClass
	{
		[Test]
		public void WritablePropertyAssertions ()
		{
            WritablePropertyAssertions(typeof(Models.Country));
		}
	}
}