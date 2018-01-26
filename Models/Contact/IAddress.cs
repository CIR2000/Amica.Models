namespace Amica.Models
{
    /// <summary>
    /// Basic address information.
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        string Street { get; set; }
        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        /// <value>
        /// The town.
        /// </value>
        string Town { get; set; }
        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        string PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the state or province.
        /// </summary>
        /// <value>
        /// The state or province.
        /// </value>
        string StateOrProvince { get; set; }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        string Country { get; set; }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        string Notes { get; set; }
    }
}
