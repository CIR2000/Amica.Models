using Amica.Models.Resources;
using System.ComponentModel.DataAnnotations;

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
        private string _code;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.Name), ResourceType =typeof(Properties))]
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
        [Display(Name = nameof(Properties.IsBankReceipt), ResourceType =typeof(Properties))]
        public bool IsBankReceipt
        {
            set { SetProperty(ref _IsBankReceipt, value); }
            get { return _IsBankReceipt; }
        }

        /// <summary>
        /// Gets or sets the payment method code.
        /// </summary>
        /// <value>
        /// The payment method code.
        /// </value>
        [Display(Name = nameof(Properties.Code), ResourceType =typeof(Properties))]
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }
    }
}
