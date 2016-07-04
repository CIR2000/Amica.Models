namespace Amica.vNext.Models
{
    public class Warehouse : BaseModelWithCompanyId
    {
        private string _name;
        private Address _address;
        private string _notes;

        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        public Address Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
        }

        public string Notes
        {
            set { SetProperty(ref _notes, value); }
            get { return _notes; }
        }
    }
}
