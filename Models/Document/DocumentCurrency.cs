using Newtonsoft.Json;

namespace Amica.vNext.Models.Documents
{
    public class DocumentCurrency : ObservableObject
    {
        private Currency _currency;
        private decimal _exchange_rate;

		public DocumentCurrency() { }

        public Currency Current
        {
            set { SetProperty(ref _currency, value); }
            get { return _currency; }
        }

		[JsonProperty("exchange_rate")]
        public decimal ExchangeRate
        {
            set { SetProperty(ref _exchange_rate, value); }
            get { return _exchange_rate; }
        }
    }
}
