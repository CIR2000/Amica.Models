using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class Address : ObservableObject, IAddress
    {
        private string _street;
        private string _town;
        private string _postalCode;
        private string _country;
        private string _stateOrProvince;
        public string Street
        {
            get { return _street; }
            set { SetProperty(ref _street, value); }
        }
        public string Town
        {
            get { return _town; }
            set { SetProperty(ref _town, value); }
        }
		[JsonProperty("postal_code")]
        public string PostalCode
        {
            get { return _postalCode; }
            set { SetProperty(ref _postalCode, value); }
        }
        public string Country
        {
            get { return _country; }
            set { SetProperty(ref _country, value); }
        }
        public string StateOrProvince
        {
            get { return _stateOrProvince; }
            set { SetProperty(ref _stateOrProvince, value); }
        }
    }
}
