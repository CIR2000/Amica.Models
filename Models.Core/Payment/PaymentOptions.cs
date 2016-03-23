using System.Collections.Generic;

namespace Amica.vNext.Models
{
    public static class PaymentOptions
    {
		public static readonly ReadOnlyDictionary<int, FirstPaymentOption> FirstPaymentOptions = 
			new ReadOnlyDictionary<int, FirstPaymentOption>(
				new Dictionary<int, FirstPaymentOption>
				{
					{ 1, new FirstPaymentOption { Code = 1, Description = "Normale" } },
					{ 2, new FirstPaymentOption { Code = 2, Description =  "Con IVA" } },
					{ 3, new FirstPaymentOption { Code = 3, Description = "Solo IVA" } },
					{ 4, new FirstPaymentOption { Code = 4, Description = "Con spese" } },
				});

        public static readonly ReadOnlyDictionary<int, string> FirstPaymentDueAt = 
			new ReadOnlyDictionary<int, string>(
                new Dictionary<int, string>
                {
					{ 1, "Data documento" },
					{ 2, "Fine mese" },
					{ 3, "Data indicata" },
                });

    }
}
