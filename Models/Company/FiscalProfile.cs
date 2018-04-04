using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Company's fiscal profile.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class FiscalProfile : ObservableObject
    {
        bool _legalEntity, _isVatExcluded, _isFreelance, _isExclusiveAgent;
        float _enasarco;
        string _vatIdNumber, _taxIdNumber, _siaCode, _reaCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="FiscalProfile"/> class.
        /// </summary>
        public FiscalProfile()
        {
            InpsReimbursement = new InpsReimbursement();
            FreelanceFund = new FreelanceFund();
            Deduction = new Deduction();
            Vat = new Vat();

            IsVatExcluded = true;
            IsLegalEntity = true;
        }
        /// <summary>
        /// Gets or sets the SIA code.
        /// </summary>
        /// <value>
        /// The SIA code.
        /// </value>
        [Display(Name = nameof(Resources.Properties.SIACode), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.REACode), ResourceType = typeof(Resources.Properties))]
		public string REACode {
			set { SetProperty (ref _reaCode, value); }
			get { return _reaCode; } 
		}
        /// <summary>
        /// Gets or sets a value indicating whether this instance is freelance.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is freelance; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.Properties.IsFreelance), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.IsExclusiveAgent), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.EnasarcoFund), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.InpsReimbursement), ResourceType = typeof(Resources.Properties))]
        public InpsReimbursement InpsReimbursement { get; }
        /// <summary>
        /// Gets the freelance fund.
        /// </summary>
        /// <value>
        /// The freelance fund.
        /// </value>
        [Display(Name = nameof(Resources.Properties.FreelanceFund), ResourceType = typeof(Resources.Properties))]
        public FreelanceFund FreelanceFund { get; }
        /// <summary>
        /// Gets the deduction.
        /// </summary>
        /// <value>
        /// The deduction.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Deduction), ResourceType = typeof(Resources.Properties))]
        public Deduction Deduction { get; }
        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
        [Display(Name = nameof(Resources.Properties.VatIdentificationNumber), Prompt = "ITXXXXXXXXXXX", ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.TaxIdentificationNumber), ResourceType = typeof(Resources.Properties))]
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is a legal entity.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is a legal entity; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.Properties.IsLegalEntity), ResourceType = typeof(Resources.Properties))]
		public bool IsLegalEntity {
			set { SetProperty (ref _legalEntity, value); }
			get { return _legalEntity; } 
		}
        /// <summary>
        /// Gets or sets a value indicating whether VAT is excluded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if VAT is excluded; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Resources.Properties.IsVatExcluded), ResourceType = typeof(Resources.Properties))]
        public bool IsVatExcluded
        {
            set { SetProperty(ref _isVatExcluded, value); }
            get { return _isVatExcluded; }
        }
        /// <summary>
        /// Gets the standard VAT.
        /// </summary>
        /// <value>
        /// The VAT.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Vat), ResourceType = typeof(Resources.Properties))]
        public Vat Vat { get; }
    }
}
