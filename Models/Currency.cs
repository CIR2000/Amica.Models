using Newtonsoft.Json;
using System.ComponentModel;

namespace Amica.Models
{
    public class Currency : ObservableObject
    {
        private string _name;
        private string _code;
        private string _symbol;

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
        /// Gets or sets the ISO 4217 currency code.
        /// </summary>
        /// <value>The ISO 4217 currency code.</value>
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        /// <value>The currency symbol.</value>
        public string Symbol
        {
            set { SetProperty(ref _symbol, value); }
            get { return _symbol; }
        }
    }
}
