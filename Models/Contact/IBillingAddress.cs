namespace Amica.Models
{
    /// <summary>
    /// Billing address.
    /// </summary>
    /// <seealso cref="Amica.Models.IAddress" />
    /// <seealso cref="Amica.Models.IUniqueId" />
    public interface IBillingAddress : IAddress, IUniqueId
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }
        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
        string VatIdentificationNumber { get; set; }
        /// <summary>
        /// Gets or sets the tax identification number.
        /// </summary>
        /// <value>
        /// The tax identification number.
        /// </value>
        string TaxIdentificationNumber { get; set; }
    }
}
