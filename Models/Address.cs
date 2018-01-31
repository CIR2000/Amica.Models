using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Address information.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    /// <seealso cref="Amica.Models.IAddress" />
    public class Address : ObservableObject, IAddress
    {
        private string _street;
        private string _town;
        private string _postalCode;
        private string _country;
        private string _stateOrProvince;
        private string _notes;
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        public string Street
        {
            get { return _street; }
            set { SetProperty(ref _street, value); }
        }
        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        /// <value>
        /// The town.
        /// </value>
        public string Town
        {
            get { return _town; }
            set { SetProperty(ref _town, value); }
        }
        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode
        {
            get { return _postalCode; }
            set { SetProperty(ref _postalCode, value); }
        }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country
        {
            get { return _country; }
            set { SetProperty(ref _country, value); }
        }
        /// <summary>
        /// Gets or sets the state or province.
        /// </summary>
        /// <value>
        /// The state or province.
        /// </value>
        public string StateOrProvince
        {
            get { return _stateOrProvince; }
            set { SetProperty(ref _stateOrProvince, value); }
        }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public string Notes
        {
            get { return _notes; }
            set { SetProperty(ref _notes, value); }
        }
    }
}