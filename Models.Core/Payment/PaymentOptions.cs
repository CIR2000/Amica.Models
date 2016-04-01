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
					{ 1, new FirstPaymentOption { Code = 1, Description = "Normale" }},
					{ 2, new FirstPaymentOption { Code = 2, Description =  "Con IVA" }},
					{ 3, new FirstPaymentOption { Code = 3, Description = "Solo IVA" }},
					{ 4, new FirstPaymentOption { Code = 4, Description = "Con spese" }},
				});

        public static readonly ReadOnlyDictionary<int, CollectionItemOfInt> FirstPaymentDates = 
			new ReadOnlyDictionary<int,  CollectionItemOfInt>(
                new Dictionary<int,  CollectionItemOfInt>
                {
					{ 1, new FirstPaymentDate { Code = 1, Description = "Data documento" }},
					{ 2, new FirstPaymentDate { Code = 2, Description = "Fine mese" }},
					{ 3, new FirstPaymentDate { Code = 3, Description = "Data indicata" }},
                });

    }
}
