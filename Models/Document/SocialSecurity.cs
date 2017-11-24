namespace Amica.Models.Documents
{
    public class SocialSecurity : ObservableObject
    {
        private float _rate;
        private decimal _amount;
        private decimal _taxable;
        private SocialSecurityCategory _category;
        private Vat _vat;
        private bool _withholding;

		public float Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; }
		}
		public decimal Amount {
			set { SetProperty (ref _amount, value); }
			get { return _amount; }
		}
		public decimal Taxable {
			set { SetProperty (ref _taxable, value); }
			get { return _taxable; }
		}
		/// <summary>
        /// Wether the social security is subject to withholding
        /// </summary>
		public bool Withholding {
			set { SetProperty (ref _withholding, value); }
			get { return _withholding; }
		}
		public SocialSecurityCategory Category {
			set { SetProperty (ref _category, value); }
			get { return _category; }
		}
		public Vat Vat {
			set { SetProperty (ref _vat, value); }
			get { return _vat; }
		}

    }
}
