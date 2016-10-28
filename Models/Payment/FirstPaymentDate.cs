namespace Amica.Models
{
    public class FirstPaymentDate : ObservableObject
    {
        private PaymentDate _code;
        private string _description;

        public PaymentDate Code
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
