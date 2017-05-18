namespace Amica.Models
{
    public class Warehouse : BaseModelWithCompanyId
    {
        private string _name;
        private string _notes;
        private Address _address;

        public Warehouse()
        {
            _address = new Address();
        }

        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        public string Notes
        {
            set { SetProperty(ref _notes, value); }
            get { return _notes; }
        }

        public Address Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
        }
    }
}
