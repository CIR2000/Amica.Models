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
            UnitOfMeasure = UnitOfMeasureHelper.DefaultValue;
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
        [Display(Name = nameof(Resources.Properties.Logo), ResourceType = typeof(Resources.Properties))]
        public string Logo
        {
            set { SetProperty(ref _logo, value); }
            get { return _logo; }
        }
    }
}
