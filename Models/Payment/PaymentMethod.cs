using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Payment method information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    /// <seealso cref="Amica.Models.IUniqueId" />
    public class PaymentMethod : BaseModelWithCompanyId, IUniqueId
    {
        private string _name;
        private bool _IsBankReceipt;
        private ItalianPA.PaymentMethod _paPaymentMethod;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is bank receipt.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is bank receipt; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_bank_receipt")]
        public bool IsBankReceipt
        {
            set { SetProperty(ref _IsBankReceipt, value); }
            get { return _IsBankReceipt; }
        }

        /// <summary>
        /// Gets or sets the public administration payment method.
        /// </summary>
        /// <value>
        /// The public administration payment method.
        /// </value>
        [JsonProperty("public_administration_payment_method")]
        public ItalianPA.PaymentMethod PublicAdministrationPaymentMethod
        {
            set { SetProperty(ref _paPaymentMethod, value); }
            get { return _paPaymentMethod; }
        }
    }
}
