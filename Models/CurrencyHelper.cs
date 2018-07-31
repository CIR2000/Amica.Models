using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.Models
{
    /// <summary>
    /// Currency helpers
    /// <summary>
    public class CurrencyHelpers {
        /// <summary>
        /// Supported currencies
        ///
        public static readonly ReadOnlyDictionary<string, Currency> Currencies =
            new ReadOnlyDictionary<string, Currency>(
                new Dictionary<string, Currency>
                {
                    {"EUR", new Currency {Name = "Euro", Code = "EUR", Symbol = "€"}},
                    {"USD", new Currency {Name = "Dollar", Code = "USD", Symbol = "$"}}
                });
    }
}
