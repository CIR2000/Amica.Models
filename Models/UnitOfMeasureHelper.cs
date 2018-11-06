using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.Models
{
    /// <summary>
    /// Currency helpers
    /// <summary>
    public class UnitOfMeasureHelper
    {
        /// <summary>
        /// Known unit of measures
        ///
        public static readonly ReadOnlyCollection<string> UnitOfMeasures =
            new ReadOnlyCollection<string>(new List<string> { "n", "m", "kg", "l", "g", "cm" });
        public static string DefaultValue => "n";
    }
}
