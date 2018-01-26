namespace Amica.Models
{
    /// <summary>
    /// Extended contact information.
    /// </summary>
    /// <seealso cref="Amica.Models.IContactDetails" />
    /// <seealso cref="Amica.Models.IUniqueId" />
    public interface IContactDetailsEx : IContactDetails, IUniqueId
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }
    }
}
