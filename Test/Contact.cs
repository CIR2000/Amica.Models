using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
    [TestClass]
    public class Contact
    {
        [TestMethod]
        public void DefaultValues()
        {
            var contact = new Models.Contact();
            var currency = CurrencyHelpers.Currencies["EUR"];
            Assert.AreEqual(currency.Name, contact.Currency.Name);
            Assert.AreEqual(currency.Symbol, contact.Currency.Symbol);
            Assert.AreEqual(currency.Code, contact.Currency.Code);
            Assert.AreEqual(true, contact.Relationship.IsActive);
            Assert.AreEqual(true, contact.Relationship.IsClient);
            Assert.AreEqual(true, contact.Relationship.IsCompany);
        }

    }
}