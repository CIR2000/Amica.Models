using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class Contact : BaseModelWithCompanyId
    {
        private string _name;
        private string _vat;
        private string _marketArea;
        private string _idCode;
        private string _taxIdNumber;
        private string _paIndex;

        private AddressEx _address = new AddressEx();
        private Currency _currency = new Currency();
        private ContactIs _is = new ContactIs();
        private Bank _bank = new Bank();

        private List<AddressExWithName> _otherAddresses = new List<AddressExWithName>();

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
        /// Gets or sets the contact ID.
        /// </summary>
        /// <value>The contact ID.</value>
		[JsonProperty("id_code")]
        public string IdCode
        {
            set { SetProperty(ref _idCode, value); }
            get { return _idCode; }
        }

        /// <summary>
        /// Gets or sets the wax Identification Code.
        /// </summary>
        /// <value>The Tax Identification Code.</value>
		[JsonProperty("tax_id_number")]
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }

        /// <summary>
        /// Gets or sets the wax Public Administration Index number.
        /// </summary>
        /// <value>The Public Administration index number.</value>
		[JsonProperty("pa_index")]
        public string PublicAdministrationIndex
        {
            set { SetProperty(ref _paIndex, value); }
            get { return _paIndex; }
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
        /// Gets or sets the contact currency.
        /// </summary>
        /// <value>The contact currency.</value>
        public Currency Currency
        {
            set { SetProperty(ref _currency, value); }
            get { return _currency; }
        }

        /// <summary>
        /// Gets or sets the contact status.
        /// </summary>
        /// <value>The contact status.</value>
        public ContactIs Is
        {
            set { SetProperty(ref _is, value); }
            get { return _is; }
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

        /// <summary>
        /// Gets or sets the bank.
        /// </summary>
        /// <value>The bank</value>
        public Bank Bank
        {
            set { SetProperty(ref _bank, value); }
            get { return _bank; }
        }

        /// <summary>
        /// Gets or sets the secondary addresses.
        /// </summary>
        /// <value>The secondary addresses</value>
		[JsonProperty("other_addresses")]
        public List<AddressExWithName> OtherAddresses
        {
            set { SetProperty(ref _otherAddresses, value); }
            get { return _otherAddresses; }
        }
    }
}
