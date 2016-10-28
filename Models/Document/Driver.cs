using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class Driver : ObservableObject
    {
        private string _name;
        private string _licenseId;
        private string _plateId;
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }
		[JsonProperty("license_id")]
        public string LicenseID
        {
            set { SetProperty(ref _licenseId, value); }
            get { return _licenseId; }
        }

		[JsonProperty("plate_id")]
        public string PlateID
        {
            set { SetProperty(ref _plateId, value); }
            get { return _plateId; }
        }
    }
}
