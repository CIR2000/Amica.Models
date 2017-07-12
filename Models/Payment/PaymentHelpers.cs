using System.Collections.Generic;
using Models;

namespace Amica.Models
{
    public  class PaymentHelpers
    {
        // by convention, item with key 1 is the default value

		public static readonly ReadOnlyDictionary<PaymentOption, FirstPaymentOption> FirstPaymentOptions = 
			new ReadOnlyDictionary<PaymentOption, FirstPaymentOption>(
				new Dictionary<PaymentOption, FirstPaymentOption>
				{
                    { PaymentOption.Normal, new FirstPaymentOption { Code = PaymentOption.Normal, Description = PaymentResources.Normal }},
					{ PaymentOption.VatIncluded, new FirstPaymentOption { Code = PaymentOption.VatIncluded, Description =  PaymentResources.VatIncluded }},
					{ PaymentOption.VatOnly, new FirstPaymentOption { Code = PaymentOption.VatOnly, Description = PaymentResources.VatOnly }},
					{ PaymentOption.FeesIncluded, new FirstPaymentOption { Code = PaymentOption.FeesIncluded, Description = PaymentResources.FeesIncluded }},
				});

        public static readonly ReadOnlyDictionary<PaymentDate, FirstPaymentDate> FirstPaymentDates = 
			new ReadOnlyDictionary<PaymentDate,  FirstPaymentDate>(
                new Dictionary<PaymentDate,  FirstPaymentDate>
                {
					{ PaymentDate.DocumentDate, new FirstPaymentDate { Code = PaymentDate.DocumentDate, Description = PaymentResources.AtDocumentDate }},
					{ PaymentDate.EndOfMonth, new FirstPaymentDate { Code = PaymentDate.EndOfMonth, Description = PaymentResources.AtEndOfMonth }},
					{ PaymentDate.Explicit, new FirstPaymentDate { Code = PaymentDate.Explicit, Description = PaymentResources.AtExplicitDate }},
                });
    }
}
