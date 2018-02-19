using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Deduction details.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class Deduction : ObservableObject
    {
        float _rate, _taxableShare;
        bool _isWelfareIncluded;
        /// <summary>
        /// Gets or sets the deduction rate.
        /// </summary>
        /// <value>
        /// The deduction rate.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Rate), ResourceType = typeof(Resources.PropertyNames))]
        public float Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; } 
		}
        /// <summary>
        /// Gets or sets the taxable share on which the deduction should be computed.
        /// </summary>
        /// <value>
        /// The taxable share.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.TaxableShare), ResourceType = typeof(Resources.PropertyNames))]
		public float TaxableShare {
			set { SetProperty (ref _taxableShare, value); }
			get { return _taxableShare; } 
		}
        /// <summary>
        /// Gets or sets a value indicating whether the deduction includes the welfare fund.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deduction includes welfare; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.IsWelfareIncluded), ResourceType = typeof(Resources.PropertyNames))]
		public bool IsWelfareIncluded{
			set { SetProperty (ref _isWelfareIncluded, value); }
			get { return _isWelfareIncluded; } 
		}

    }
}
