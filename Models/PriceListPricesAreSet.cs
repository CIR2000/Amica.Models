namespace Amica.Models
{
    /// <summary>
    /// How price lists prices can be determined.
    /// </summary>
    public enum PriceListPricesAreSet
    {
        Manually,
        MarkupOnRecentCost,
        GlobalMarkupOnRecentCost,
        MarkupOnAverageCost,
        GlobalMarkupOnAverageCost,
    }
}
