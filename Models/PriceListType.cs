using System.ComponentModel.DataAnnotations;
using Amica.Models.Resources;

namespace Amica.Models
{
    /// <summary>
    /// Types of available price lists.
    /// </summary>
    public enum PriceListType
    {
        [Display(Name = nameof(Properties.PriceListTypeBuy), ResourceType = typeof(Properties))]
        Buy,
        [Display(Name = nameof(Properties.PriceListTypeSell), ResourceType = typeof(Properties))]
        Sell
    }

}
