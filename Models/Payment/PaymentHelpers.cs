using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.Models
{
    /// <summary>
    /// Payment helpers.
    /// </summary>
    public class PaymentHelpers
    {
        // by convention, item with key 1 is the default value

        /// <summary>
        /// The first payment options
        /// </summary>
        public static readonly ReadOnlyDictionary<PaymentOption, FirstPaymentOption> FirstPaymentOptions = 
			new ReadOnlyDictionary<PaymentOption, FirstPaymentOption>(
				new Dictionary<PaymentOption, FirstPaymentOption>
				{
                    { PaymentOption.Normal, new FirstPaymentOption { Option = PaymentOption.Normal, Description = PaymentResources.Normal }},
					{ PaymentOption.VatIncluded, new FirstPaymentOption { Option = PaymentOption.VatIncluded, Description =  PaymentResources.VatIncluded }},
					{ PaymentOption.VatOnly, new FirstPaymentOption { Option = PaymentOption.VatOnly, Description = PaymentResources.VatOnly }},
					{ PaymentOption.FeesIncluded, new FirstPaymentOption { Option = PaymentOption.FeesIncluded, Description = PaymentResources.FeesIncluded }},
				});

        /// <summary>
        /// The first payment date options
        /// </summary>
        public static readonly ReadOnlyDictionary<PaymentDate, FirstPaymentDate> FirstPaymentDates = 
			new ReadOnlyDictionary<PaymentDate,  FirstPaymentDate>(
                new Dictionary<PaymentDate,  FirstPaymentDate>
                {
					{ PaymentDate.DocumentDate, new FirstPaymentDate { Option = PaymentDate.DocumentDate, Description = PaymentResources.AtDocumentDate }},
					{ PaymentDate.EndOfMonth, new FirstPaymentDate { Option = PaymentDate.EndOfMonth, Description = PaymentResources.AtEndOfMonth }},
					{ PaymentDate.Explicit, new FirstPaymentDate { Option = PaymentDate.Explicit, Description = PaymentResources.AtExplicitDate }},
                });
    }
}
