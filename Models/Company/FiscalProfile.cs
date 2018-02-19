using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Company's fiscal profile.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class FiscalProfile : ObservableObject
    {
        bool _isFreelance, _isExclusiveAgent;
        float _enasarco;
        string _vatIdNumber, _taxIdNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="FiscalProfile"/> class.
        /// </summary>
        public FiscalProfile()
        {
            InpsReimbursement = new InpsReimbursement();
            FreelanceFund = new FreelanceFund();
            Deduction = new Deduction();
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is freelance.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is freelance; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Vat), ResourceType = typeof(Resources.PropertyNames))]
        public bool IsFreelance {
			set { SetProperty (ref _isFreelance, value); }
			get { return _isFreelance; } 
		}
        /// <summary>
        /// Gets or sets a value indicating whether the company acts as an exclusive agent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the company acts as an exclusive agent; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.IsExclusiveAgent), ResourceType = typeof(Resources.PropertyNames))]
        public bool IsExclusiveAgent {
			set { SetProperty (ref _isExclusiveAgent, value); }
			get { return _isExclusiveAgent; } 
		}
        /// <summary>
        /// Gets or sets the Enasarco fund.
        /// </summary>
        /// <value>
        /// The Enasarco fund.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.EnasarcoFund), ResourceType = typeof(Resources.PropertyNames))]
        public float EnasarcoFund {
			set { SetProperty (ref _enasarco, value); }
			get { return _enasarco; } 
		}
        /// <summary>
        /// Gets the INPS reimbursement.
        /// </summary>
        /// <value>
        /// The INPS reimbursement.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.InpsReimbursement), ResourceType = typeof(Resources.PropertyNames))]
        public InpsReimbursement InpsReimbursement { get; }
        /// <summary>
        /// Gets the freelance fund.
        /// </summary>
        /// <value>
        /// The freelance fund.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.FreelanceFund), ResourceType = typeof(Resources.PropertyNames))]
        public FreelanceFund FreelanceFund { get; }
        /// <summary>
        /// Gets the deduction.
        /// </summary>
        /// <value>
        /// The deduction.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Deduction), ResourceType = typeof(Resources.PropertyNames))]
        public Deduction Deduction { get; }
        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.VatIdentificationNumber), ResourceType = typeof(Resources.PropertyNames))]
        public string VatIdentificationNumber
        {
            set { SetProperty(ref _vatIdNumber, value); }
            get { return _vatIdNumber; }
        }

        /// <summary>
        /// Gets or sets the tax identification number.
        /// </summary>
        /// <value>
        /// The tax identification number.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.TaxIdentificationNumber), ResourceType = typeof(Resources.PropertyNames))]
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }
    }
}
