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
        private string _paCode;

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
        public bool IsBankReceipt
        {
            set { SetProperty(ref _IsBankReceipt, value); }
            get { return _IsBankReceipt; }
        }

        /// <summary>
        /// Gets or sets the public administration payment method code.
        /// </summary>
        /// <value>
        /// The public administration payment method code.
        /// </value>
        public string PublicAdministrationCode
        {
            set { SetProperty(ref _paCode, value); }
            get { return _paCode; }
        }
    }
}
