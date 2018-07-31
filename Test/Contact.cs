using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
	[TestClass]
	public class Contact 
	{
		[TestMethod]
		public void DefaultValues ()
		{
                  var c = new Models.Contact();
                  Assert.AreEqual(CurrencyHelpers.Currencies["EUR"], c.Currency);
		}

	}
}