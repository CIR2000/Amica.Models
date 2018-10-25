using Amica.Models.Resources;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// Payment information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class Payment : BaseModelWithCompanyId
    {
        private string _name;
        private string _feeId;
        private string _bankId;
        private float _discount;
        private int _firstPaymentDateAdditionalDays;
        private int _installmentsEveryNumberOfDays;
        private int _installments;
        private bool _forceEndOfMonth;
        private int _extraDays;
        private bool _exactDays;

        private FirstPaymentDate _firstPaymentDate;
        private FirstPaymentOption _firstPaymentOption;
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

            var defaultFirstPaymentDate = PaymentHelpers.FirstPaymentDates[PaymentDate.DocumentDate];
            FirstPaymentDate = new FirstPaymentDate
            {
                Option = defaultFirstPaymentDate.Option,
                Description = defaultFirstPaymentDate.Description,
            };

            var defaultPaymentOption = PaymentHelpers.FirstPaymentOptions[PaymentOption.Normal];
            FirstPaymentOption = new FirstPaymentOption
            {
                Option = defaultPaymentOption.Option,
                Description = defaultPaymentOption.Description
            };

            var defaultPayment = PaymentHelpers.PaymentMethods[0];
            PaymentMethod = new PaymentMethod()
            {
                Code = defaultPayment.Code,
                Name = defaultPayment.Name,
                IsBankReceipt = defaultPayment.IsBankReceipt
            };
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.Name), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.Discount), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.FirstPaymentDateAdditionalDays), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.InstallmentsEveryNumberOfDays), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.Installments), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.ShouldForceToEndOfMonth), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.ExtraDays), Description = nameof(Properties.ExtraDaysDescription), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.IsExactDays), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.FirstPaymentDate), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.FirstPaymentOption), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.Bank), ResourceType =typeof(Properties))]
        public string BankId
        {
            set { SetProperty(ref _bankId, value); }
            get { return _bankId; }
        }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        [Display(Name = nameof(Properties.Fee), ResourceType =typeof(Properties))]
        public string FeeId
        {
            set { SetProperty(ref _feeId, value); }
            get { return _feeId; }
        }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        /// <value>
        /// The payment method.
        /// </value>
        [Display(Name = nameof(Properties.PaymentMethod), ResourceType =typeof(Properties))]
        public PaymentMethod PaymentMethod
        {
            set { SetProperty(ref _paymentMethod, value); }
            get { return _paymentMethod; }
        }
    }
}
