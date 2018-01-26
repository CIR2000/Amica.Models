using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Extended contact information.
    /// </summary>
    /// <seealso cref="Amica.Models.ContactDetails" />
    /// <seealso cref="Amica.Models.IContactDetailsEx" />
    public class ContactDetailsEx : ContactDetails, IContactDetailsEx
    {
        private string _uniqueId;
        private string _name;

        /// <summary>
        /// Gets or sets the contact identifier.
        /// </summary>
        /// <value>
        /// The contact identifier.
        /// </value>
        [JsonProperty("contact_id")]
        public string ContactId
        {
            get { return _uniqueId; }
            set { SetProperty(ref _uniqueId, value); }
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
