namespace Amica.vNext.Models.Documents
{
    public class SocialSecurity : ObservableObject
    {
		private string _name;
        private double _rate;
        private decimal _amount;
        private Vat _vat;

		public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; }
		}

		public double Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; }
		}
		public decimal Amount {
			set { SetProperty (ref _amount, value); }
			get { return _amount; }
		}
		public Vat Vat {
			set { SetProperty (ref _vat, value); }
			get { return _vat; }
		}
    }
}
