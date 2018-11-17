using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Amica.Models.Resources;

namespace Amica.Models
{
    /// <summary>
    /// Product price information.
    /// </summary>
    public class ProductPrice : ObservableObject
    {
        private string _priceListId;
        private decimal _price;
        private float _markup;
        private List<float> _discount = new List<float>();

        /// <summary>
        /// Gets or sets the PriceList Id.
        /// </summary>
        /// <value>The Price List Id.</value>
        public string PriceListId
        {
            set { SetProperty(ref _priceListId, value); }
            get { return _priceListId; }
        }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [Display(Name = nameof(Properties.Price), ResourceType = typeof(Properties))]
        public decimal Price
        {
            set { SetProperty(ref _price, value); }
            get { return _price; }
        }

        /// <summary>
        /// Gets or sets the markup.
        /// </summary>
        /// <value>
        /// The markup.
        /// </value>
        [Display(Name = nameof(Properties.Markup), ResourceType = typeof(Properties))]
        public float Markup
        {
            set { SetProperty(ref _markup, value); }
            get { return _markup; }
        }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        [Display(Name = nameof(Properties.Discount), ResourceType = typeof(Properties))]
        public List<float> Discount
        {
            set { SetProperty(ref _discount, value); }
            get { return _discount; }
        }
    }
}