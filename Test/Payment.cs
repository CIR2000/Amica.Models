using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
	[TestClass]
	public class Payment 
	{
		[TestMethod]
		public void DefaultValues ()
		{
            var p = new Models.Payment();
            Assert.AreEqual(PaymentHelpers.FirstPaymentOptions[PaymentOption.Normal], p.FirstPaymentOption);
            Assert.AreEqual(PaymentHelpers.FirstPaymentDates[PaymentDate.DocumentDate], p.FirstPaymentDate);
            Assert.AreEqual(30, p.FirstPaymentDateAdditionalDays);
            Assert.AreEqual(1, p.Installments);
            Assert.AreEqual(30, p.InstallmentsEveryNumberOfDays);
            Assert.IsTrue(p.ShouldForceToEndOfMonth);
		}

	}
}