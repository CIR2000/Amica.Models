using Newtonsoft.Json;
using Amica.vNext.Models.ItalianPA;

namespace Amica.vNext.Models
{
    public class PaymentMethod : BaseModelWithCompanyId
    {
        private string _name;
        private bool _IsBankReceipt;
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
		[JsonProperty("is_bank_receipt")]
        public bool IsBankReceipt
        {
            set { SetProperty(ref _IsBankReceipt, value); }
            get { return _IsBankReceipt; }
        }

		[JsonProperty("pagamento_pa")]
        public ModalitaPagamentoPA ModalitaPagamentoPA
        {
            set { SetProperty(ref _modalitaPagamentoPA, value); }
            get { return _modalitaPagamentoPA; }
        }
    }
}
