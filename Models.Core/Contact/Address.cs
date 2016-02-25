using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class Address : ObservableObject, IAddress
    {
        private string _street;
        private string _town;
        private string _postalCode;
        private string _state;
        private string _province;
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
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }
        public string Province
        {
            get { return _province; }
            set { SetProperty(ref _province, value); }
        }
    }
}
