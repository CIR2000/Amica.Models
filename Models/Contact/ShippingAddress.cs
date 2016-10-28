namespace Amica.Models
{
    public class ShippingAddress : AddressEx
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
