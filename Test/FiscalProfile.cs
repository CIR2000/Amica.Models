using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
	[TestClass]
	public class FiscalProfile : BaseTestClass
	{
		[TestMethod]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Company.FiscalProfile));
		}
		[TestMethod]
		public void DefaultValues ()
		{
            var fp = new Company.FiscalProfile();
            Assert.IsTrue(fp.IsLegalEntity);
            Assert.IsTrue(fp.IsVatExcluded);
		}

	}
}