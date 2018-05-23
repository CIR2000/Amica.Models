using Amica.Models.Resources;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = nameof(Properties.Name), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.IbanCode), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.BicSwiftCode), ResourceType =typeof(Properties))]
        public string BicSwiftCode
        {
            set { SetProperty(ref _bicSwiftCode, value); }
            get { return _bicSwiftCode; }
        }
    }
}
