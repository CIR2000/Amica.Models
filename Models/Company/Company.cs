using Newtonsoft.Json;

namespace Amica.Models.Company
{
	public class Company : BaseModel
	{
		private string _name, _password, _codiceSia, _codiceRea, _logo, _lastPosition;
        private bool _legalEntity;

        public Company()
        {
            ProfiloFiscale = new ProfiloFiscale();
            Predefinizioni = new Predefinizioni();
            Address = new AddressEx();
        }
		public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; } 
		}

		public string Password {
			set { SetProperty (ref _password, value); }
			get { return _password; }
		}
        [JsonProperty("codice_sia")]
		public string CodiceSia {
			set { SetProperty (ref _codiceSia, value); }
			get { return _codiceSia; } 
		}
        [JsonProperty("codice_rea")]
		public string CodiceRea {
			set { SetProperty (ref _codiceRea, value); }
			get { return _codiceRea; } 
		}
        [JsonProperty("legal_entity")]
		public bool LegalEntity {
			set { SetProperty (ref _legalEntity, value); }
			get { return _legalEntity; } 
		}
		public string Logo {
			set { SetProperty (ref _logo, value); }
			get { return _logo; } 
		}
        [JsonProperty("last_position")]
		public string LastPosition {
			set { SetProperty (ref _lastPosition, value); }
			get { return _lastPosition; } 
		}
        [JsonProperty("profilo_fiscale")]
        public ProfiloFiscale ProfiloFiscale { get; }
        public Predefinizioni Predefinizioni { get; }
        public AddressEx Address { get; }
    }
}
