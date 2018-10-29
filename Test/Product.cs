using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests {
      [TestClass]
      public class Product {
            [TestMethod]
            public void DefaultValues () {
                  var p = new Models.Product ();

                  Assert.AreEqual ("n.", p.UnitOfMeasure);
                  Assert.IsTrue (p.IsProduct);
            }

      }
}