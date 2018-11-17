using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
    [TestClass]
    public class ProductInventory
    {
        [TestMethod]
        public void DefaultValues()
        {
            var x = new Models.ProductInventory() { CurrentStock = 10f, Reserved = 1f };

            Assert.AreEqual(9, x.AvailableStock);
        }

    }
}