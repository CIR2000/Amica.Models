using System.Collections.Generic;

namespace Amica.vNext.Models
{
    public  class PaymentHelpers
    {
        // by convention, item with key 1 is the default value

		public static readonly ReadOnlyDictionary<PaymentOption, FirstPaymentOption> FirstPaymentOptions = 
			new ReadOnlyDictionary<PaymentOption, FirstPaymentOption>(
				new Dictionary<PaymentOption, FirstPaymentOption>
				{
                    { PaymentOption.Normal, new FirstPaymentOption { Code = PaymentOption.Normal, Description = Properties.Payment.Normal }},
					{ PaymentOption.VatIncluded, new FirstPaymentOption { Code = PaymentOption.VatIncluded, Description =  Properties.Payment.VatIncluded }},
					{ PaymentOption.VatOnly, new FirstPaymentOption { Code = PaymentOption.VatOnly, Description = Properties.Payment.VatOnly }},
					{ PaymentOption.FeesIncluded, new FirstPaymentOption { Code = PaymentOption.FeesIncluded, Description = Properties.Payment.FeesIncluded }},
				});

        public static readonly ReadOnlyDictionary<PaymentDate, FirstPaymentDate> FirstPaymentDates = 
			new ReadOnlyDictionary<PaymentDate,  FirstPaymentDate>(
                new Dictionary<PaymentDate,  FirstPaymentDate>
                {
					{ PaymentDate.DocumentDate, new FirstPaymentDate { Code = PaymentDate.DocumentDate, Description = Properties.Payment.AtDocumentDate }},
					{ PaymentDate.EndOfMonth, new FirstPaymentDate { Code = PaymentDate.EndOfMonth, Description = Properties.Payment.AtEndOfMonth }},
					{ PaymentDate.ExplicitDate, new FirstPaymentDate { Code = PaymentDate.ExplicitDate, Description = Properties.Payment.AtExplicitDate }},
                });
    }
}
