using Newtonsoft.Json;
using Amica.vNext.Models.ItalianPA;

namespace Amica.vNext.Models
{
    public class Vat : BaseModelWithCompanyId, IUniqueId
    {
        private string _name;
        private string _code;
        private double _rate;
        private double _nonDeductible;
        private bool _isIntraCommunity;
        private bool _isSplitPayment;
        private NaturaPA _naturaPA = new NaturaPA();

        /// <summary>
        /// Gets or sets the VAT name.
        /// </summary>
        /// <value>The VAT name.</value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the VAT code.
        /// </summary>
        /// <value>The VAT code.</value>
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the VAT rage.
        /// </summary>
        /// <value>The VAT rate.</value>
        public double Rate
        {
            set { SetProperty(ref _rate, value); }
            get { return _rate; }
        }

        /// <summary>
        /// Gets or sets the non-deductible rate.
        /// </summary>
        /// <value>The non-deductible rate.</value>
		[JsonProperty("non_deductible")]
        public double NonDeductible
        {
            set { SetProperty(ref _nonDeductible, value); }
            get { return _nonDeductible; }
        }
        /// <summary>
        /// Gets or sets intra-community flag.
        /// </summary>
        /// <value>The intra-community flag.</value>
		[JsonProperty("is_intra")]
        public bool IsIntraCommunity
        {
            set { SetProperty(ref _isIntraCommunity, value); }
            get { return _isIntraCommunity; }
        }

        /// <summary>
        /// Gets or sets split payment flag.
        /// </summary>
        /// <value>The split payment flag.</value>
		[JsonProperty("is_split_payment")]
        public bool IsSplitPayment
        {
            set { SetProperty(ref _isSplitPayment, value); }
            get { return _isSplitPayment; }
        }

        /// <summary>
        /// Gets or sets the Public Administration nature.
        /// </summary>
        /// <value>The Public Administration nature.</value>
		[JsonProperty("natura_pa")]
        public NaturaPA NaturaPA
        {
            set { SetProperty(ref _naturaPA, value); }
            get { return _naturaPA; }
        }
    }
}
