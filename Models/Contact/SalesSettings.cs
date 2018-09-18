using Amica.Models.Resources;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// Contact sales settings.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class SalesSettings : ObservableObject
    {
        private string _vatId;
        private string _agentId;
        private string _pricelistId;
        private string _paymentId;
        private float _discount;

        /// <summary>
        /// Gets or sets the VAT Id for the contact.
        /// </summary>
        /// <value>
        /// The VAT Id.
        /// </value>
        [Display(Name = nameof(Properties.Vat), ResourceType = typeof(Properties))]
        public string VatId
        {
            set { SetProperty(ref _vatId, value); }
            get { return _vatId; }
        }
        /// <summary>
        /// Gets or sets the Agent Id for the contact.
        /// </summary>
        /// <value>
        /// The Agent Id.
        /// </value>
        [Display(Name = nameof(Properties.Agent), ResourceType = typeof(Properties))]
        public string AgentId
        {
            set { SetProperty(ref _agentId, value); }
            get { return _agentId; }
        }

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

        /// <summary>
        /// Gets or sets a standard discount for the customer.
        /// </summary>
        /// <value>
        /// The discount value.
        /// </value>
        [Display(Name = nameof(Properties.Discount), ResourceType = typeof(Properties))]
        public float Discount
        {
            set { SetProperty(ref _discount, value); }
            get { return _discount; }
        }
    }
}