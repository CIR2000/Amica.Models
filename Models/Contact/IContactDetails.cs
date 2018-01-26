namespace Amica.Models
{
    /// <summary>
    /// Contact details.
    /// </summary>
    public interface IContactDetails
    {
        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        /// <value>
        /// The mail.
        /// </value>
        string Mail { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        string Phone { get; set; }
        /// <summary>
        /// Gets or sets the web site.
        /// </summary>
        /// <value>
        /// The web site.
        /// </value>
        string WebSite { get; set; }
        /// <summary>
        /// Gets or sets the pec mail.
        /// </summary>
        /// <value>
        /// The pec mail.
        /// </value>
        string PecMail { get; set; }
        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        string Mobile { get; set; }
        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        /// <value>
        /// The fax.
        /// </value>
        string Fax { get; set; }
    }
}
