using Newtonsoft.Json;
using System.Reflection;

namespace Amica.Models
{
    /// <summary>
    /// Billing address information.
    /// </summary>
    /// <seealso cref="Amica.Models.Address" />
    /// <seealso cref="Amica.Models.IBillingAddress" />
    public class BillingAddress : Address, IBillingAddress
    {
        private string _id;
        private string _name;
        private string _vatIdNumber;
        private string _taxIdNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress"/> class.
        /// </summary>
        public BillingAddress()
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress"/> class.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public BillingAddress(Contact contact)
        {
            ContactId = contact.ContactId;

            Name = contact.Name;
            VatIdentificationNumber = contact.VatIdentificationNumber;
            TaxIdentificationNumber = contact.TaxIdentificationNumber;

            var properties = typeof(IAddress).GetType().GetRuntimeProperties();

            foreach (var property in properties)
                property.SetValue(this, property.GetValue(contact.Address, null), null);
        }

        /// <summary>
        /// Gets or sets the unique id.
        /// </summary>
        /// <value>The unique id.</value>
		[JsonProperty("contact_id")]
        public string ContactId
        {
            set { SetProperty(ref _id, value); }
            get { return _id; }
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
        [JsonProperty("vat_id_number")]
        public string VatIdentificationNumber
        {
            set { SetProperty(ref _vatIdNumber, value); }
            get { return _vatIdNumber; }
        }

        /// <summary>
        /// Gets or sets the tax identification number.
        /// </summary>
        /// <value>
        /// The tax identification number.
        /// </value>
        [JsonProperty("tax_id_number")]
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }
    }
}