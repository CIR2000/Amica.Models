using NUnit.Framework;

namespace Amica.Models.Tests
{
	[TestFixture]
	public class FiscalProfile : BaseTestClass
	{
		[Test]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Company.FiscalProfile));
		}
		[Test]
		public void DefaultValues ()
		{
            var fp = new Company.FiscalProfile();
            Assert.True(fp.IsLegalEntity);
            Assert.True(fp.IsVatExcluded);
		}

	}
}