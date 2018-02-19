using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Company preferences.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class Preferences : ObservableObject
    {
        bool _isVatExcluded;
        string _unitOfMeasure;
        /// <summary>
        /// Initializes a new instance of the <see cref="Preferences"/> class.
        /// </summary>
        public Preferences()
        {
            Vat = new Vat();
            EmailAttachment = new EmailAttachment();
        }
        /// <summary>
        /// Gets or sets a value indicating whether VAT is excluded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if VAT is excluded; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.IsVatExcluded), ResourceType = typeof(Resources.PropertyNames))]
        public bool IsVatExcluded
        {
            set { SetProperty(ref _isVatExcluded, value); }
            get { return _isVatExcluded; }
        }
        /// <summary>
        /// Gets or sets the unit of measure.
        /// </summary>
        /// <value>
        /// The unit of measure.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.UnitOfMeasure), ResourceType = typeof(Resources.PropertyNames))]
        public string UnitOfMeasure
        {
            set { SetProperty(ref _unitOfMeasure, value); }
            get { return _unitOfMeasure; }
        }
        /// <summary>
        /// Gets the standard VAT.
        /// </summary>
        /// <value>
        /// The VAT.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Vat), ResourceType = typeof(Resources.PropertyNames))]
        public Vat Vat { get; }
        /// <summary>
        /// Gets the email attachment.
        /// </summary>
        /// <value>
        /// The email attachment.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.EmailAttachment), ResourceType = typeof(Resources.PropertyNames))]
        public EmailAttachment EmailAttachment { get; }
    }
}
