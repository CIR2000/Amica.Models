namespace Amica.Models
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBank
    {
        /// <summary>
        /// Gets or sets the bic swift code.
        /// </summary>
        /// <value>
        /// The bic swift code.
        /// </value>
        string BicSwiftCode { get; set; }
        /// <summary>
        /// Gets or sets the iban code.
        /// </summary>
        /// <value>
        /// The iban code.
        /// </value>
        string IbanCode { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }
    }
}