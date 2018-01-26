using System.Collections.Generic;
using Models;
using System.Collections.ObjectModel;

namespace Amica.Models.ItalianPA
{
    /// <summary>
    /// Helpers for the Italian public administration.
    /// </summary>
    public static class ItalianPAHelpers
    {
        /// <summary>
        /// VAT exemption options.
        /// </summary>
        public static ReadOnlyDictionary<string, VatExemption> VatExemption = 
			new ReadOnlyDictionary<string, VatExemption>(
                new Dictionary<string, VatExemption>
                {
                    { "N1", new VatExemption {Code = "N1", Description= ItalianPAResources.N1 }},
                    { "N2", new VatExemption {Code = "N2", Description= ItalianPAResources.N2 }},
                    { "N3", new VatExemption {Code = "N3", Description= ItalianPAResources.N3 }},
                    { "N4", new VatExemption {Code = "N4", Description= ItalianPAResources.N4 }},
                    { "N5", new VatExemption {Code = "N5", Description= ItalianPAResources.N5 }},
                    { "N6", new VatExemption {Code = "N6", Description= ItalianPAResources.N6 }},
				});

        /// <summary>
        /// Italian public administration payment methods.
        /// </summary>
        public static readonly ReadOnlyDictionary<string, PaymentMethod> PaymentMethod = 
			new ReadOnlyDictionary<string, PaymentMethod>(
                new Dictionary<string, PaymentMethod>
                {
                    { "MP01", new PaymentMethod {Code="MP01", Description= ItalianPAResources.MP01 } },
                    { "MP02", new PaymentMethod {Code="MP02", Description= ItalianPAResources.MP02 } },
                    { "MP03", new PaymentMethod {Code="MP03", Description= ItalianPAResources.MP03 } },
                    { "MP04", new PaymentMethod {Code="MP04", Description= ItalianPAResources.MP04 } },
                    { "MP05", new PaymentMethod {Code="MP05", Description= ItalianPAResources.MP05 } },
                    { "MP06", new PaymentMethod {Code="MP06", Description= ItalianPAResources.MP06 } },
                    { "MP07", new PaymentMethod {Code="MP07", Description= ItalianPAResources.MP07 } },
                    { "MP08", new PaymentMethod {Code="MP08", Description= ItalianPAResources.MP08 } },
                    { "MP09", new PaymentMethod {Code="MP09", Description= ItalianPAResources.MP09 } },
                    { "MP10", new PaymentMethod {Code="MP10", Description= ItalianPAResources.MP10 } },
                    { "MP11", new PaymentMethod {Code="MP11", Description= ItalianPAResources.MP11 } },
                    { "MP12", new PaymentMethod {Code="MP12", Description= ItalianPAResources.MP12 } },
                    { "MP13",new PaymentMethod {Code="MP13", Description= ItalianPAResources.MP13 } },
                    { "MP14",new PaymentMethod {Code="MP14", Description= ItalianPAResources.MP14 } },
                    { "MP15",new PaymentMethod {Code="MP15", Description= ItalianPAResources.MP15} },
                    { "MP16",new PaymentMethod {Code="MP16", Description= ItalianPAResources.MP16 } },
                    { "MP17",new PaymentMethod {Code="MP17", Description= ItalianPAResources.MP17 } },
                    { "MP18",new PaymentMethod {Code="MP18", Description= ItalianPAResources.MP18 } },
                    { "MP19",new PaymentMethod {Code="MP19", Description= ItalianPAResources.MP19 } },
                    { "MP20",new PaymentMethod {Code="MP20", Description= ItalianPAResources.MP20 } },
                    { "MP21",new PaymentMethod {Code="MP21", Description= ItalianPAResources.MP21 } },
            });
    }
}
