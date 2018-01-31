using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Contact information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class Contact : BaseModelWithCompanyId
    {
        private string _name;
        private string _vatIdNumber;
        private string _marketArea;
        private string _idCode;
        private string _taxIdNumber;
        private string _paIndex;

        private AddressEx _address;
        private Currency _currency;
        private Relationship _relationship = new Relationship();
        private Bank _bank;

        private List<ShippingAddress> _otherAddresses = new List<ShippingAddress>();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the identifier code.
        /// </summary>
        /// <value>
        /// The identifier code.
        /// </value>
        public string IdCode
        {
            set { SetProperty(ref _idCode, value); }
            get { return _idCode; }
        }

        /// <summary>
        /// Gets or sets the tax identification number.
        /// </summary>
        /// <value>
        /// The tax identification number.
        /// </value>
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }

        /// <summary>
        /// Gets or sets the index of the public administration.
        /// </summary>
        /// <value>
        /// The index of the public administration.
        /// </value>
        public string PublicAdministrationIndex
        {
            set { SetProperty(ref _paIndex, value); }
            get { return _paIndex; }
        }
        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
        public string VatIdentificationNumber
        {
            set { SetProperty(ref _vatIdNumber, value); }
            get { return _vatIdNumber; }
        }

        /// <summary>
        /// Gets or sets the market area.
        /// </summary>
        /// <value>
        /// The market area.
        /// </value>
        public string MarketArea
        {
            set { SetProperty(ref _marketArea, value); }
            get { return _marketArea; }
        }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public Currency Currency
        {
            set { SetProperty(ref _currency, value); }
            get { return _currency; }
        }

        /// <summary>
        /// Gets or sets the is.
        /// </summary>
        /// <value>
        /// The is.
        /// </value>
        public Relationship Relationship
        {
            set { SetProperty(ref _relationship, value); }
            get { return _relationship; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public AddressEx Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
        }

        /// <summary>
        /// Gets or sets the bank.
        /// </summary>
        /// <value>
        /// The bank.
        /// </value>
        public Bank Bank
        {
            set { SetProperty(ref _bank, value); }
            get { return _bank; }
        }

        /// <summary>
        /// Gets or sets the other addresses.
        /// </summary>
        /// <value>
        /// The other addresses.
        /// </value>
        public List<ShippingAddress> OtherAddresses
        {
            set { SetProperty(ref _otherAddresses, value); }
            get { return _otherAddresses; }
        }
    }
}
