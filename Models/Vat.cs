using Newtonsoft.Json;
using Amica.Models.ItalianPA;
using Amica.Models.Resources;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// VAT details.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    /// <seealso cref="Amica.Models.IUniqueId" />
    public class Vat : BaseModelWithCompanyId, IUniqueId
    {
        private string _name;
        private string _code;
        private float _rate;
        private float _nonDeductible;
        private bool _isIntraCommunity;
        private bool _isSplitPayment;
        private  VatExemption _vat_exemption;

        /// <summary>
        /// Gets or sets the VAT name.
        /// </summary>
        /// <value>The VAT name.</value>
        [Display(Name = nameof(Properties.Name), Description = nameof(Properties.VatNameDescription), ResourceType = typeof(Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the VAT code.
        /// </summary>
        /// <value>The VAT code.</value>
        [Display(Name = nameof(Properties.Code), Description = nameof(Properties.VatCodeDescription), ResourceType = typeof(Properties))]
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the VAT rate.
        /// </summary>
        /// <value>The VAT rate.</value>
        [Display(Name = nameof(Properties.Rate), ResourceType = typeof(Properties))]
        public float Rate
        {
            set { SetProperty(ref _rate, value); }
            get { return _rate; }
        }

        /// <summary>
        /// Gets or sets the non-deductible rate.
        /// </summary>
        /// <value>The non-deductible rate.</value>
        [Display(Name = nameof(Properties.NonDeductible), Description = nameof(Properties.NonDeductibleDescription), ResourceType = typeof(Properties))]
        public float NonDeductible
        {
            set { SetProperty(ref _nonDeductible, value); }
            get { return _nonDeductible; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is intra community.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is intra community; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Properties.IsIntraCommunity), Description = nameof(Properties.IsIntraCommunity), ResourceType = typeof(Properties))]
        public bool IsIntraCommunity
        {
            set { SetProperty(ref _isIntraCommunity, value); }
            get { return _isIntraCommunity; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is split payment.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is split payment; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = nameof(Properties.IsSplitPayment), Description = nameof(Properties.IsIntraCommunityDescription), ResourceType = typeof(Properties))]
        public bool IsSplitPayment
        {
            set { SetProperty(ref _isSplitPayment, value); }
            get { return _isSplitPayment; }
        }

        /// <summary>
        /// Gets or sets the vat exemption.
        /// </summary>
        /// <value>
        /// The vat exemption.
        /// </value>
        [Display(Name = nameof(Properties.VatExemption), Description = nameof(Properties.VatExemptionDescription), ResourceType = typeof(Properties))]
        public VatExemption VatExemption
        {
            set { SetProperty(ref _vat_exemption, value); }
            get { return _vat_exemption; }
        }
    }
}
