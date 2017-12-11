using Newtonsoft.Json;

namespace Amica.Models.Company
{
    public class Predefinizioni : ObservableObject
    {
        bool _ivaEsclusa;
        string _unitaMisura;
        Vat _vat;
        EmailAttachment _attachment;
        public Predefinizioni()
        {
            Vat = new Vat();
            EmailAttachment = new EmailAttachment();
        }
        [JsonProperty("iva_esclusa")]
		public bool IvaEsclusa {
			set { SetProperty (ref _ivaEsclusa, value); }
			get { return _ivaEsclusa; } 
		}
        [JsonProperty("unita_misura")]
		public string UnitaMisura {
			set { SetProperty (ref _unitaMisura, value); }
			get { return _unitaMisura; } 
		}
        public Vat Vat { get; }
        [JsonProperty("email_attachment")]
        public EmailAttachment EmailAttachment { get; }
    }
}
