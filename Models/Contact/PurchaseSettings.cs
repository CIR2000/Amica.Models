using Amica.Models.Resources;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// Contact purchase settings.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class PurchaseSettings : ObservableObject
    {
        private string _paymentId;
        private string _pricelistId;

        /// <summary>
        /// Gets or sets the Payment Id for the contact.
        /// </summary>
        /// <value>
        /// The Payment Id.
        /// </value>
        [Display(Name = nameof(Properties.Payment), ResourceType = typeof(Properties))]
        public string PaymentId
        {
            set { SetProperty(ref _paymentId, value); }
            get { return _paymentId; }
        }

        /// <summary>
        /// Gets or sets the PriceList Id for the contact.
        /// </summary>
        /// <value>
        /// The PriceList Id.
        /// </value>
        [Display(Name = nameof(Properties.Pricelist), ResourceType = typeof(Properties))]
        public string PricelistId
        {
            set { SetProperty(ref _pricelistId, value); }
            get { return _pricelistId; }
        }
    }
}