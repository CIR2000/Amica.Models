namespace Amica.vNext.Models
{
    public class FirstPaymentOption : ObservableObject
    {
        private int _code;
        private string _description;

		public int Code
        {
			get { return _code; }
			set { SetProperty(ref _code, value); }
        }
		public string Description
        {
			get { return _description; }
			set { SetProperty(ref _description, value); }
        }
    }
}
