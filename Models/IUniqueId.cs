namespace Amica.Models
{
    /// <summary>
    /// Unique id interface.
    /// </summary>
    public interface IUniqueId
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        string UniqueId { get; set; }
    }
}
