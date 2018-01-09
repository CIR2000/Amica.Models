using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Amica.Models
{
    public class AddressEx : ObservableObject, IAddress, IContactDetails
    {
        private Address _address = new Address();
        private ContactDetails _contactDetails = new ContactDetails();

		public AddressEx()
        {
			// TODO
			// Could use reflection to bind private object fields to OnInternalPropertyChanged
			// and we could do this in ObservableObject, so all OO can use composition without
			// explictly coding this boilerplate.
            _address.PropertyChanged += OnInternalObjectPropertyChanged;
            _contactDetails.PropertyChanged += OnInternalObjectPropertyChanged;

        }

        private void OnInternalObjectPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged(e.PropertyName);
        }

        public string Phone
        {
            get { return _contactDetails.Phone; }
            set { _contactDetails.Phone = value; }
        }
        public string Mobile
        {
            get { return _contactDetails.Mobile; }
            set { _contactDetails.Mobile = value; }
        }
        public string Fax
        {
            get { return _contactDetails.Fax; }
            set { _contactDetails.Fax = value; }
        }
        public string Mail
        {
            get { return _contactDetails.Mail; }
            set { _contactDetails.Mail = value; }
        }
		[JsonProperty("pec_mail")]
        public string PecMail
        {
            get { return _contactDetails.PecMail; }
            set { _contactDetails.PecMail = value; }
        }
		[JsonProperty("web_site")]
        public string WebSite
        {
            get { return _contactDetails.WebSite; }
            set { _contactDetails.WebSite = value; }
        }

        public string Street
        {
            get { return _address.Street; }
            set { _address.Street = value; }
        }

        public string Town
        {
            get { return _address.Town; }
            set { _address.Town = value; }
        }

		[JsonProperty("postal_code")]
        public string PostalCode
        {
            get { return _address.PostalCode; }
            set { _address.PostalCode = value; }
        }

		[JsonProperty("state_or_province")]
        public string StateOrProvince
        {
            get { return _address.StateOrProvince; }
            set { _address.StateOrProvince = value; }
        }

        public string Country
        {
            get { return _address.Country; }
            set { _address.Country = value; }
        }
        public string Notes
        {
            get { return _address.Notes; }
            set { _address.Notes = value; }
        }

    }
}
