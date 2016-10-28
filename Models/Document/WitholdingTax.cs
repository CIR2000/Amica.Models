using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class WithholdingTax : ObservableObject
    {
		private double _rate;
        private decimal _amount;
        private double _taxableShare;
        private bool _includesSocialSecurity;

		public double Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; }
		}

		public decimal Amount {
			set { SetProperty (ref _amount, value); }
			get { return _amount; }
		}
		[JsonProperty("taxable_share")]
		public double TaxableShare {
			set { SetProperty (ref _taxableShare, value); }
			get { return _taxableShare; }
		}
		[JsonProperty("is_social_security_included")]
		public bool IsSocialSecurityIncluded {
			set { SetProperty (ref _includesSocialSecurity, value); }
			get { return _includesSocialSecurity; }
		}
    }
}
