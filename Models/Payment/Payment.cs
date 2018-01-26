using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Payment information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class Payment : BaseModelWithCompanyId
    {
        private string _name;
        private float _discount;
        private int _firstPaymentDateAdditionalDays;
        private int _installmentsEveryNumberOfDays;
        private int _installments;
        private bool _forceEndOfMonth;
        private int _extraDays;
        private bool _exactDays;

        private FirstPaymentDate _firstPaymentDate;
        private FirstPaymentOption _firstPaymentOption;
        private Bank _bank;
        private Fee _fee;
        private PaymentMethod _paymentMethod;

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class.
        /// </summary>
        public Payment()
        {
            Installments = 1;
            ShouldForceToEndOfMonth = true;
            FirstPaymentDateAdditionalDays = 30;
            InstallmentsEveryNumberOfDays = 30;
			FirstPaymentDate= PaymentHelpers.FirstPaymentDates[PaymentDate.DocumentDate];
			FirstPaymentOption = PaymentHelpers.FirstPaymentOptions[PaymentOption.Normal];
            PaymentMethod = new PaymentMethod();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the discount rate.
        /// </summary>
        /// <value>
        /// The discount rate.
        /// </value>
        public float Discount
        {
            set { SetProperty(ref _discount, value); }
            get { return _discount; }
        }

        /// <summary>
        /// Gets or sets additional days to the first payment date.
        /// </summary>
        /// <value>
        /// The additional days to the first payment date.
        /// </value>
        [JsonProperty("first_payment_additional_days")]
        public int FirstPaymentDateAdditionalDays
        {
            set { SetProperty(ref _firstPaymentDateAdditionalDays, value); }
            get { return _firstPaymentDateAdditionalDays; }
        }

        /// <summary>
        /// Gets or sets the installments every number of days.
        /// </summary>
        /// <value>
        /// The installments every number of days.
        /// </value>
        [JsonProperty("installments_every_number_of_days")]
        public int InstallmentsEveryNumberOfDays
        {
            set { SetProperty(ref _installmentsEveryNumberOfDays, value); }
            get { return _installmentsEveryNumberOfDays; }
        }

        /// <summary>
        /// Gets or sets the number of installments.
        /// </summary>
        /// <value>
        /// The number of installments.
        /// </value>
        public int Installments
        {
            set { SetProperty(ref _installments, value); }
            get { return _installments; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether installments should be forced to the end of month.
        /// </summary>
        /// <value>
        ///   <c>true</c> if installments should be force to the end of month; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("should_force_to_end_of_month")]
        public bool ShouldForceToEndOfMonth
        {
            set { SetProperty(ref _forceEndOfMonth, value); }
            get { return _forceEndOfMonth; }
        }

        /// <summary>
        /// Gets or sets the extra days.
        /// </summary>
        /// <value>
        /// The extra days.
        /// </value>
        [JsonProperty("extra_days")]
        public int ExtraDays
        {
            set { SetProperty(ref _extraDays, value); }
            get { return _extraDays; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether exact days should be considered.
        /// </summary>
        /// <value>
        ///   <c>true</c> if exact days should be considered; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_exact_days")]
        public bool IsExactDays
        {
            set { SetProperty(ref _exactDays, value); }
            get { return _exactDays; }
        }

        /// <summary>
        /// Gets or sets the first payment date.
        /// </summary>
        /// <value>
        /// The first payment date.
        /// </value>
        [JsonProperty("first_payment_date")]
        public FirstPaymentDate FirstPaymentDate
        {
            set { SetProperty(ref _firstPaymentDate, value); }
            get { return _firstPaymentDate; }
        }

        /// <summary>
        /// Gets or sets the first payment option.
        /// </summary>
        /// <value>
        /// The first payment option.
        /// </value>
        [JsonProperty("first_payment_option")]
        public FirstPaymentOption FirstPaymentOption
        {
            set { SetProperty(ref _firstPaymentOption, value); }
            get { return _firstPaymentOption; }
        }

        /// <summary>
        /// Gets or sets the bank.
        /// </summary>
        /// <value>
        /// The bank.
        /// </value>
        public Bank Bank
        {
            set { SetProperty(ref _bank, value); }
            get { return _bank; }
        }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        public Fee Fee
        {
            set { SetProperty(ref _fee, value); }
            get { return _fee; }
        }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        /// <value>
        /// The payment method.
        /// </value>
        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod
        {
            set { SetProperty(ref _paymentMethod, value); }
            get { return _paymentMethod; }
        }
    }
}
