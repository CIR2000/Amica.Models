using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class DocumentFee : ObservableObject
    {
        private string _name;
        private decimal _amount;
        private Vat _vat;
        private bool _is_from_payment;

		public DocumentFee()
        {
            IsFromPayment = false;
        }

        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        public decimal Amount
        {
            set { SetProperty(ref _amount, value); }
            get { return _amount; }
        }

        public Vat Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }

		[JsonProperty("is_from_payment")]
        public bool IsFromPayment
        {
            set { SetProperty(ref _is_from_payment, value); }
            get { return _is_from_payment; }
        }
    }
}
