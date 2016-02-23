using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class ContactMinimal : ObservableObject, IContactMinimal
    {
        private string _id;
        private string _name;
        private string _address;
        private string _vat;

		public ContactMinimal() : base() { }
        public ContactMinimal(IContactMinimal contact) : base()
        {
            UniqueId = contact.UniqueId;

            PropertyInfo[] properties = typeof(IContactMinimal).GetProperties();
            foreach (var property in properties)
                property.SetValue(this, property.GetValue(contact, null), null);
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
        /// Gets or sets the address.
        /// </summary>
        /// <value>The contact address</value>
        public string Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
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