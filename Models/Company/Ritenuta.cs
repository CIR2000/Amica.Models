using Newtonsoft.Json;

namespace Amica.Models.Company
{
    public class Ritenuta : ObservableObject
    {
        float _rate, _rate_su_imponibile;
        bool _include_cassa_previdenziale;
		public float Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; } 
		}
        [JsonProperty("rate_su_imponibile")]
		public float RateSuImponibile {
			set { SetProperty (ref _rate_su_imponibile, value); }
			get { return _rate_su_imponibile; } 
		}
        [JsonProperty("include_cassa_previdenziale")]
		public bool IncludeCassaPrevidenziale {
			set { SetProperty (ref _include_cassa_previdenziale, value); }
			get { return _include_cassa_previdenziale; } 
		}

    }
}
