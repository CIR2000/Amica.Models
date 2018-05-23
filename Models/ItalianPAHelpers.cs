using Amica.Models.Resources;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.Models
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
                    { "N2", new VatExemption {Code = "N2", Description= ItalianPA.N2 }},
                    { "N3", new VatExemption {Code = "N3", Description= ItalianPA.N3 }},
                    { "N4", new VatExemption {Code = "N4", Description= ItalianPA.N4 }},
                    { "N5", new VatExemption {Code = "N5", Description= ItalianPA.N5 }},
                    { "N6", new VatExemption {Code = "N6", Description= ItalianPA.N6 }},
				});
    }
}
