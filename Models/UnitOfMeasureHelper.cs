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
            new ReadOnlyCollection<string>(new List<string> { "nr", "m", "m2", "m3", "dz", "gg", "kg", "lt", "gr", "km", "min", "h", "cm" });
        public static string DefaultValue => "nr";
    }
}
