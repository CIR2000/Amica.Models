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
        public InpsReimbursement InpsReimbursement { get; }
        /// <summary>
        /// Gets the freelance fund.
        /// </summary>
        /// <value>
        /// The freelance fund.
        /// </value>
        public FreelanceFund FreelanceFund { get; }
        /// <summary>
        /// Gets the deduction.
        /// </summary>
        /// <value>
        /// The deduction.
        /// </value>
        public Deduction Deduction { get; }
        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
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
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }
    }
}
