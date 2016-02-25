using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class ContactMinimal : Address, IContactMinimal
    {
        private string _id;
        private string _name;
        private string _vat;

		public ContactMinimal()
		{ }
        public ContactMinimal(Contact contact)
        {
            UniqueId = contact.UniqueId;

            Name = contact.Name;
            Vat = contact.Vat;
            var properties = typeof(IAddress).GetProperties();
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
        public string Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }
    }
}