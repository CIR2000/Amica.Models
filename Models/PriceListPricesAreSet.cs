using System.ComponentModel.DataAnnotations;
using Amica.Models.Resources;

namespace Amica.Models
{
    /// <summary>
    /// How price lists prices can be determined.
    /// </summary>
    public enum PriceListPricesAreSet
    {
        [Display(Name = nameof(Properties.PriceListPricesAreSetManually), ResourceType = typeof(Properties))]
        Manually,
        [Display(Name = nameof(Properties.PriceListPricesAreSetMarkupOnRecentCost), ResourceType = typeof(Properties))]
        MarkupOnRecentCost,
        [Display(Name = nameof(Properties.PriceListPricesAreSetGlobalMarkupOnRecentCost), ResourceType = typeof(Properties))]
        GlobalMarkupOnRecentCost,
        [Display(Name = nameof(Properties.PriceListPricesAreSetMarkupOnAverageCost), ResourceType = typeof(Properties))]
        MarkupOnAverageCost,
        [Display(Name = nameof(Properties.PriceListPricesAreSetGlobalMarkupOnAverageCost), ResourceType = typeof(Properties))]
        GlobalMarkupOnAverageCost,
    }
}
