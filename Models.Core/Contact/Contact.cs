namespace Amica.vNext.Models
{
    public class Contact : BaseModelWithCompanyId
    {
        private string _name;
        private string _vat;

        private AddressEx _address = new AddressEx();

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

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The contact address</value>
        public AddressEx Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
        }
    }
}
