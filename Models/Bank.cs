using Newtonsoft.Json;
using System.ComponentModel;

namespace Amica.Models
{
    /// <summary>
    /// Bank information.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class Bank : ObservableObject
    {
        private string _name;
        private string _ibanCode;
        private string _bicSwiftCode;

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
        /// Gets or sets the IBAN code.
        /// </summary>
        /// <value>
        /// The IBAN code.
        /// </value>
        [JsonProperty("iban_code")]
        public string IbanCode
        {
            set { SetProperty(ref _ibanCode, value); }
            get { return _ibanCode; }
        }

        /// <summary>
        /// Gets or sets the BIG/SWIFT code.
        /// </summary>
        /// <value>
        /// The BIC/SWIFT code.
        /// </value>
        [JsonProperty("bic_swift_code")]
        public string BicSwiftCode
        {
            set { SetProperty(ref _bicSwiftCode, value); }
            get { return _bicSwiftCode; }
        }
    }
}
