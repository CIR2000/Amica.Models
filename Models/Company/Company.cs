using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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
		private string _name, _password, _siaCode, _reaCode, _logo, _lastPosition;
        private bool _legalEntity, _adminAccount;

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
        [Display(Name = nameof(Resources.PropertyNames.CompanyName), ResourceType = typeof(Resources.PropertyNames))]
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
        public string Password {
			set { SetProperty (ref _password, value); }
			get { return _password; }
		}
        /// <summary>
        /// Gets or sets the SIA code.
        /// </summary>
        /// <value>
        /// The SIA code.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.SIACode), ResourceType = typeof(Resources.PropertyNames))]
		public string SIACode {
			set { SetProperty (ref _siaCode, value); }
			get { return _siaCode; } 
		}
        /// <summary>
        /// Gets or sets the REA code.
        /// </summary>
        /// <value>
        /// The REA code.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.REACode), ResourceType = typeof(Resources.PropertyNames))]
		public string REACode {
			set { SetProperty (ref _reaCode, value); }
			get { return _reaCode; } 
		}
        /// <summary>
        /// Gets or sets a value indicating whether this instance is a legal entity.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is a legal entity; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.IsLegalEntity), ResourceType = typeof(Resources.PropertyNames))]
		public bool IsLegalEntity {
			set { SetProperty (ref _legalEntity, value); }
			get { return _legalEntity; } 
		}
        /// <summary>
        /// Gets or sets a value indicating whether this instance is the administrative account.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is the administrative account; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.IsAdministrativeAccount), ResourceType = typeof(Resources.PropertyNames))]
		public bool IsAdministrativeAccount {
			set { SetProperty (ref _adminAccount, value); }
			get { return _adminAccount; } 
		}
        /// <summary>
        /// Gets or sets the company logo filename. 
        /// </summary>
        /// <value>
        /// The company logo filename.
        /// </value>
        public string Logo {
			set { SetProperty (ref _logo, value); }
			get { return _logo; } 
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
        [Display(Name = nameof(Resources.PropertyNames.FiscalProfile), ResourceType = typeof(Resources.PropertyNames))]
        public FiscalProfile FiscalProfile { get; }
        /// <summary>
        /// Gets the company preferences.
        /// </summary>
        /// <value>
        /// The company preferences.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Preferences), ResourceType = typeof(Resources.PropertyNames))]
        public Preferences Preferences { get; }
        /// <summary>
        /// Gets the companyt address.
        /// </summary>
        /// <value>
        /// The companyt address.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Address), ResourceType = typeof(Resources.PropertyNames))]
        public AddressEx Address { get; }
    }
}