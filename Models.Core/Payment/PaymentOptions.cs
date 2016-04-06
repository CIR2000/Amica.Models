using System.Collections.Generic;

namespace Amica.vNext.Models
{
    public static class PaymentOptions
    {
        // by convention, item with key 1 is the default value

		public static readonly ReadOnlyDictionary<int, CollectionItemOfInt> FirstPaymentOptions = 
			new ReadOnlyDictionary<int, CollectionItemOfInt>(
				new Dictionary<int, CollectionItemOfInt>
				{
                    { 1, new FirstPaymentOption { Code = 1, Description = Properties.Payment.Normal }},
					{ 2, new FirstPaymentOption { Code = 2, Description =  Properties.Payment.VatIncluded }},
					{ 3, new FirstPaymentOption { Code = 3, Description = Properties.Payment.VatOnly }},
					{ 4, new FirstPaymentOption { Code = 4, Description = Properties.Payment.FeesIncluded }},
				});

        public static readonly ReadOnlyDictionary<int, CollectionItemOfInt> FirstPaymentDates = 
			new ReadOnlyDictionary<int,  CollectionItemOfInt>(
                new Dictionary<int,  CollectionItemOfInt>
                {
					{ 1, new FirstPaymentDate { Code = 1, Description = Properties.Payment.AtDocumentDate }},
					{ 2, new FirstPaymentDate { Code = 2, Description = Properties.Payment.AtEndOfMonth }},
					{ 3, new FirstPaymentDate { Code = 3, Description = Properties.Payment.AtExplicitDate }},
                });

    }
}
