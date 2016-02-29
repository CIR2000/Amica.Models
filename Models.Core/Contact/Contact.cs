using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class Contact : BaseModelWithCompanyId
    {
        private string _name;
        private string _vat;
        private string _marketArea;

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
        /// Gets or sets the geographic market area.
        /// </summary>
        /// <value>The geographic market area.</value>
		[JsonProperty("market_area")]
        public string MarketArea
        {
            set { SetProperty(ref _marketArea, value); }
            get { return _marketArea; }
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
