using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
    [TestClass]
    public class ProductPrice
    {
        [TestMethod]
        public void DefaultValues()
        {
            var x = new Models.ProductPrice();

            Assert.IsNotNull(x.Discount);
            Assert.AreEqual(0, x.Discount.Count);
        }

    }
}