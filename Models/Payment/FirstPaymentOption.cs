namespace Amica.vNext.Models
{
    public class FirstPaymentOption : ObservableObject
    {
        private PaymentOption _code;
        private string _description;

        public PaymentOption Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
    }
}