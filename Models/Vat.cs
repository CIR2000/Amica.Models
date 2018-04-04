using Newtonsoft.Json;
using Amica.Models.ItalianPA;
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
        [Display(Name = nameof(Resources.Properties.Name), ResourceType = typeof(Resources.Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the VAT code.
        /// </summary>
        /// <value>The VAT code.</value>
        [Display(Name = nameof(Resources.Properties.Code), ResourceType = typeof(Resources.Properties))]
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the VAT rate.
        /// </summary>
        /// <value>The VAT rate.</value>
        [Display(Name = nameof(Resources.Properties.Rate), ResourceType = typeof(Resources.Properties))]
        public float Rate
        {
            set { SetProperty(ref _rate, value); }
            get { return _rate; }
        }

        /// <summary>
        /// Gets or sets the non-deductible rate.
        /// </summary>
        /// <value>The non-deductible rate.</value>
        [Display(Name = nameof(Resources.Properties.NonDeductible), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.IsIntraCommunity), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.IsSplitPayment), ResourceType = typeof(Resources.Properties))]
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
        [Display(Name = nameof(Resources.Properties.VatExemption), ResourceType = typeof(Resources.Properties))]
        public VatExemption VatExemption
        {
            set { SetProperty(ref _vat_exemption, value); }
            get { return _vat_exemption; }
        }
    }
}
