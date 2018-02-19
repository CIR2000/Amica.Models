using System.ComponentModel.DataAnnotations;

namespace Amica.Models.ItalianPA
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
        [Display(Name = nameof(Resources.PropertyNames.Code), ResourceType = typeof(Resources.PropertyNames))]
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
        [Display(Name = nameof(Resources.PropertyNames.Description), ResourceType = typeof(Resources.PropertyNames))]
        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
    }
}
