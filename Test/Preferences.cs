using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
    [TestClass]
    public class Preferences
    {
        [TestMethod]
        public void DefaultValues()
        {
            var p = new Company.Preferences();
            Assert.AreEqual(UnitOfMeasureHelper.DefaultValue, p.UnitOfMeasure);
        }
    }
}