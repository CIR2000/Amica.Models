using Newtonsoft.Json;
using System.ComponentModel;

namespace Amica.Models
{
    public class Bank : ObservableObject
    {
        private string _name;
        private string _ibanCode;
        private string _bicSwiftCode;

        /// <summary>
        /// Gets or sets the currency name.
        /// </summary>
        /// <value>The currency name.</value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the IBAN code.
        /// </summary>
        /// <value>The IBAN code.</value>
		[JsonProperty("iban")]
        public string IbanCode
        {
            set { SetProperty(ref _ibanCode, value); }
            get { return _ibanCode; }
        }

        /// <summary>
        /// Gets or sets the BIC/Swift symbol.
        /// </summary>
        /// <value>The BIC/SWIFT code.</value>
		[JsonProperty("bic_swift")]
        public string BicSwiftCode
        {
            set { SetProperty(ref _bicSwiftCode, value); }
            get { return _bicSwiftCode; }
        }
    }
}
