using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
	[TestClass]
	public class FiscalProfile 
	{
		[TestMethod]
		public void DefaultValues ()
		{
            var fp = new Company.FiscalProfile();
            Assert.IsTrue(fp.IsLegalEntity);
            Assert.IsTrue(fp.IsVatExcluded);
		}

	}
}