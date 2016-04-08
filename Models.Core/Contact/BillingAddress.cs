using Newtonsoft.Json;
#if NET45
using System.Reflection;
#endif

namespace Amica.vNext.Models
{
    public class BillingAddress : Address, IBillingAddress
    {
        private string _id;
        private string _name;
        private string _vatIdNumber;
        private string _taxIdNumber;

		public BillingAddress()
		{ }
        public BillingAddress(Contact contact)
        {
            UniqueId = contact.UniqueId;

            Name = contact.Name;
            VatIdentificationNumber = contact.VatIdentificationNumber;

			#if NET45
            var properties = typeof(IAddress).GetType().GetRuntimeProperties();
			#else
            var properties = typeof(IAddress).GetProperties();
			#endif

            foreach (var property in properties)
                property.SetValue(this, property.GetValue(contact.Address, null), null);
        }

        /// <summary>
        /// Gets or sets the unique id.
        /// </summary>
        /// <value>The unique id.</value>
		[JsonProperty("contact_id")]
        public string UniqueId
        {
            set { SetProperty(ref _id, value); }
            get { return _id; }
        }
        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        /// <value>The contact name.</value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the VAT number.
        /// </summary>
        /// <value>The VAT number.</value>
		[JsonProperty("vat_id_number")]
        public string VatIdentificationNumber
        {
            set { SetProperty(ref _vatIdNumber, value); }
            get { return _vatIdNumber; }
        }

        /// <summary>
        /// Gets or sets the Tax Id number.
        /// </summary>
        /// <value>The Tax Identification number.</value>
		[JsonProperty("tax_id_number")]
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }
    }
}