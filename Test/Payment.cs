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

            var defaultPaymentOption = PaymentHelpers.FirstPaymentOptions[PaymentOption.Normal];
            Assert.AreEqual(defaultPaymentOption.Option, p.FirstPaymentOption.Option);
            Assert.AreEqual(defaultPaymentOption.Description, p.FirstPaymentOption.Description);

            var defaultPaymentDate = PaymentHelpers.FirstPaymentDates[PaymentDate.DocumentDate];
            Assert.AreEqual(defaultPaymentDate.Option, p.FirstPaymentDate.Option);
            Assert.AreEqual(defaultPaymentDate.Description, p.FirstPaymentDate.Description);

            var defaultPaymentMethod = PaymentHelpers.PaymentMethods[0];
            Assert.AreEqual(defaultPaymentMethod.Code, p.PaymentMethod.Code);
            Assert.AreEqual(defaultPaymentMethod.Name, p.PaymentMethod.Name);
            Assert.AreEqual(defaultPaymentMethod.IsBankReceipt, p.PaymentMethod.IsBankReceipt);

            Assert.AreEqual(30, p.FirstPaymentDateAdditionalDays);
            Assert.AreEqual(1, p.Installments);
            Assert.AreEqual(30, p.InstallmentsEveryNumberOfDays);
            Assert.IsTrue(p.ShouldForceToEndOfMonth);
		}

	}
}