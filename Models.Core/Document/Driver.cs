namespace Amica.vNext.Models.Documents
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
        public string LicenseID
        {
            set { SetProperty(ref _licenseId, value); }
            get { return _licenseId; }
        }

        public string PlateID
        {
            set { SetProperty(ref _plateId, value); }
            get { return _plateId; }
        }
    }
}
