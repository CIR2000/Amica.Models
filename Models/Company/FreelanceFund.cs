using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Freelance fund details.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class FreelanceFund : ObservableObject
    {
        float _rate;
        string _description;
        /// <summary>
        /// Gets or sets the fund rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Rate), ResourceType = typeof(Resources.Properties))]
        public float Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; } 
		}
        /// <summary>
        /// Gets or sets the fund description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Description), ResourceType = typeof(Resources.Properties))]
        public string Description {
			set { SetProperty (ref _description, value); }
			get { return _description; } 
		}

    }
}
