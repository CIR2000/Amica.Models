namespace Amica.Models
{
    /// <summary>
    /// Payment options.
    /// </summary>
    public enum PaymentOption
    {
        /// <summary>
        /// Normal
        /// </summary>
        Normal = 1,
        /// <summary>
        /// VAT is included
        /// </summary>
        VatIncluded = 2,
        /// <summary>
        /// VAT only
        /// </summary>
        VatOnly = 3,
        /// <summary>
        /// Fees are included
        /// </summary>
        FeesIncluded = 4
    }
}