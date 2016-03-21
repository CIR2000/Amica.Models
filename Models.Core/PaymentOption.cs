using Newtonsoft.Json;
using Amica.vNext.Models.ItalianPA;

namespace Amica.vNext.Models
{
    public class PaymentOption : BaseModelWithCompanyId
    {
        private string _name;
        private bool _IsRiBa;
        private ModalitaPagamentoPA _modalitaPagamentoPA = new ModalitaPagamentoPA();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets wether this is a RiBa method.
        /// </summary>
        /// <value>The wether this is a RiBa method.</value>
		[JsonProperty("is_riba")]
        public bool IsRiBa
        {
            set { SetProperty(ref _IsRiBa, value); }
            get { return _IsRiBa; }
        }

		[JsonProperty("pagamento_pa")]
        public ModalitaPagamentoPA ModalitaPagamentoPA
        {
            set { SetProperty(ref _modalitaPagamentoPA, value); }
            get { return _modalitaPagamentoPA; }
        }
    }
}
