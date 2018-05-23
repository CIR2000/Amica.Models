using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// VAT exception item.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class VatExemptionItem : ObservableObject
    {
        private string _code;
        private string _description;

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Code), ResourceType = typeof(Resources.Properties))]
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Description), ResourceType = typeof(Resources.Properties))]
        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
    }
}
