using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Company preferences.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class Preferences : ObservableObject
    {
        string _logo;
        string _unitOfMeasure;
        /// <summary>
        /// Initializes a new instance of the <see cref="Preferences"/> class.
        /// </summary>
        public Preferences()
        {
            MailSettings = new MailSettings();
            UnitOfMeasure = "N.";
        }
        /// <summary>
        /// Gets or sets the unit of measure.
        /// </summary>
        /// <value>
        /// The unit of measure.
        /// </value>
        [Display(Name = nameof(Resources.Properties.UnitOfMeasure), ResourceType = typeof(Resources.Properties))]
        public string UnitOfMeasure
        {
            set { SetProperty(ref _unitOfMeasure, value); }
            get { return _unitOfMeasure; }
        }
        /// <summary>
        /// Gets the email attachment.
        /// </summary>
        /// <value>
        /// The email attachment.
        /// </value>
        [Display(Name = nameof(Resources.Properties.MailSettings), ResourceType = typeof(Resources.Properties))]
        public MailSettings MailSettings { get; }
        /// <summary>
        /// Gets or sets the company logo. 
        /// </summary>
        /// <value>
        /// The company logo.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Logo), ResourceType = typeof(Resources.Properties))]
        public string Logo {
			set { SetProperty (ref _logo, value); }
			get { return _logo; } 
		}
    }
}
