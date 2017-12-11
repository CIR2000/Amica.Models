using Newtonsoft.Json;

namespace Amica.Models
{
    public class Payment : BaseModelWithCompanyId
    {
        private string _name;
        private float _discount;
		// inizio scadenze
        private int _firstPaymentDateAdditionalDays;
		// periodicità
        private int _installmentsEveryNumberOfDays;
		// numero di rate
        private int _installments;
		// scadenze fine mese	
        private bool _forceEndOfMonth;
		// giorni extra
        private int _extraDays;
		// giorni esatti
        private bool _exactDays;

        // periodo prima rata
        private FirstPaymentDate _firstPaymentDate;
        private FirstPaymentOption _firstPaymentOption;
        private Bank _bank;
        private Fee _fee;
        private PaymentMethod _paymentMethod;

		public Payment()
        {
            Installments = 1;
            ForceEndOfMonth = true;
            FirstPaymentDateAdditionalDays = 30;
            InstallmentsEveryNumberOfDays = 30;
			FirstPaymentDate= PaymentHelpers.FirstPaymentDates[PaymentDate.DocumentDate];
			FirstPaymentOption = PaymentHelpers.FirstPaymentOptions[PaymentOption.Normal];
            PaymentMethod = new PaymentMethod();
        }

        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        public float Discount
        {
            set { SetProperty(ref _discount, value); }
            get { return _discount; }
        }

		[JsonProperty("first_payment_additional_days")]
        public int FirstPaymentDateAdditionalDays
        {
            set { SetProperty(ref _firstPaymentDateAdditionalDays, value); }
            get { return _firstPaymentDateAdditionalDays; }
        }

		[JsonProperty("installments_every_number_of_days")]
        public int InstallmentsEveryNumberOfDays
        {
            set { SetProperty(ref _installmentsEveryNumberOfDays, value); }
            get { return _installmentsEveryNumberOfDays; }
        }

        public int Installments
        {
            set { SetProperty(ref _installments, value); }
            get { return _installments; }
        }

		[JsonProperty("force_end_of_month")]
        public bool ForceEndOfMonth
        {
            set { SetProperty(ref _forceEndOfMonth, value); }
            get { return _forceEndOfMonth; }
        }

		[JsonProperty("extra_days")]
        public int ExtraDays
        {
            set { SetProperty(ref _extraDays, value); }
            get { return _extraDays; }
        }

		[JsonProperty("exact_days")]
        public bool ExactDays
        {
            set { SetProperty(ref _exactDays, value); }
            get { return _exactDays; }
        }

		[JsonProperty("first_payment_date")]
        public FirstPaymentDate FirstPaymentDate
        {
            set { SetProperty(ref _firstPaymentDate, value); }
            get { return _firstPaymentDate; }
        }

		[JsonProperty("first_payment_option")]
        public FirstPaymentOption FirstPaymentOption
        {
            set { SetProperty(ref _firstPaymentOption, value); }
            get { return _firstPaymentOption; }
        }

        public Bank Bank
        {
            set { SetProperty(ref _bank, value); }
            get { return _bank; }
        }

        public Fee Fee
        {
            set { SetProperty(ref _fee, value); }
            get { return _fee; }
        }
		
		[JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod
        {
            set { SetProperty(ref _paymentMethod, value); }
            get { return _paymentMethod; }
        }
    }
}
