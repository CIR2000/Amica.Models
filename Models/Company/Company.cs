using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Amica.Models.Resources;

namespace Amica.Models.Company
{
    /// <summary>
    /// This namespace holds data model classes used to store and retrieve company information.
    /// </summary>
    [CompilerGenerated]
    class NamespaceDoc
    {
    }

    /// <summary>
    /// Represents a user company.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModel" />
    public class Company : BaseModel
	{
		private string _name, _password, _lastPosition;
        private bool _adminAccount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            FiscalProfile = new FiscalProfile();
            Preferences = new Preferences();
            Address = new AddressEx();
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(PropertyNames.CompanyName))]
        [Description(nameof(PropertyDescriptions.CompanyName))]
        public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; } 
		}

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Description(nameof(PropertyDescriptions.Password))]
        public string Password {
			set { SetProperty (ref _password, value); }
			get { return _password; }
		}
        /// <summary>
        /// Gets or sets a value indicating whether this instance is the administrative account.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is the administrative account; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(PropertyNames.IsAdministrativeAccount), ResourceType = typeof(PropertyNames))]
		public bool IsAdministrativeAccount {
			set { SetProperty (ref _adminAccount, value); }
			get { return _adminAccount; } 
		}
        /// <summary>
        /// Gets or sets the last user position known he was while working with the company.
        /// </summary>
        /// <value>
        /// The last position.
        /// </value>
		public string LastPosition {
			set { SetProperty (ref _lastPosition, value); }
			get { return _lastPosition; } 
		}
        /// <summary>
        /// Gets the company's fiscal profile.
        /// </summary>
        /// <value>
        /// The fiscal profile.
        /// </value>
        [Display(Name = nameof(PropertyNames.FiscalProfile), ResourceType = typeof(PropertyNames))]
        [Description(nameof(PropertyDescriptions.FiscalProfile))]
        public FiscalProfile FiscalProfile { get; }
        /// <summary>
        /// Gets the company preferences.
        /// </summary>
        /// <value>
        /// The company preferences.
        /// </value>
        [Display(Name = nameof(PropertyNames.Preferences), ResourceType = typeof(PropertyNames))]
        [Description(nameof(PropertyDescriptions.Preferences))]
        public Preferences Preferences { get; }
        /// <summary>
        /// Gets the companyt address.
        /// </summary>
        /// <value>
        /// The companyt address.
        /// </value>
        [Display(Name = nameof(PropertyNames.Address), ResourceType = typeof(PropertyNames))]
        [Description(nameof(PropertyDescriptions.Address))]
        public AddressEx Address { get; }
    }
}