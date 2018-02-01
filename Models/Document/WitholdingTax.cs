using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class WithholdingTax : ObservableObject
    {
		private float _rate;
        private decimal _amount;
        private float _taxableShare;
        private bool _includesSocialSecurity;

		public float Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; }
		}

		public decimal Amount {
			set { SetProperty (ref _amount, value); }
			get { return _amount; }
		}
		public float TaxableShare {
			set { SetProperty (ref _taxableShare, value); }
			get { return _taxableShare; }
		}
		public bool IsSocialSecurityIncluded {
			set { SetProperty (ref _includesSocialSecurity, value); }
			get { return _includesSocialSecurity; }
		}
    }
}
