using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
    [TestClass]
    public class PriceList
    {
        [TestMethod]
        public void DefaultValues()
        {
            var x = new Models.PriceList();

            Assert.AreEqual(PriceListType.Sell, x.Type);
            Assert.AreEqual(PriceListPricesAreSet.Manually, x.PricesAreSet);
            Assert.IsTrue(x.IsVatExcluded);
            Assert.AreEqual(CurrencyHelpers.Currencies["EUR"].Code, x.CurrencyCode);
        }

    }
}