using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Amica.Models.Resources;

namespace Amica.Models
{
    /// <summary>
    /// Price list information.
    /// </summary>
    public class PriceList : BaseModelWithCompanyId
    {
        private string _name;
        private float _markup;
        private bool _isVatExcluded = true;
        private PriceListType _type = PriceListType.Sell;
        private string _currencyCode = CurrencyHelpers.Currencies["EUR"].Code;
        private PriceListPricesAreSet _pricesAreSet = PriceListPricesAreSet.Manually;

        /// <summary>
        /// Gets or sets the price list name.
        /// </summary>
        /// <value>The name.</value>
        [Display(Name = nameof(Properties.Name), ResourceType = typeof(Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }
        /// <summary>
        /// Gets or sets the list type.
        /// </summary>
        /// <value>The price list type.</value>
        [Display(Name = nameof(Properties.Name), ResourceType = typeof(Properties))]
        public PriceListType Type
        {
            set { SetProperty(ref _type, value); }
            get { return _type; }
        }
        /// <summary>
        /// Gets or sets the currency code for all prices listed.
        /// </summary>
        /// <value>The currency code.</value>
        [Display(Name = nameof(Properties.Currency), ResourceType = typeof(Properties))]
        public string CurrencyCode
        {
            set { SetProperty(ref _currencyCode, value); }
            get { return _currencyCode; }
        }
        /// <summary>
        /// Gets or sets wether the prices are VAT included or not.
        /// </summary>
        /// <value>If VAT is included.</value>
        [Display(Name = nameof(Properties.IsVatExcluded), ResourceType = typeof(Properties))]
        public bool IsVatExcluded
        {
            set { SetProperty(ref _isVatExcluded, value); }
            get { return _isVatExcluded; }
        }
        /// <summary>
        /// Gets or sets the markup eventually applied on product costs (either avreage or most recent.)
        /// </summary>
        /// <value>The markup.</value>
        [Display(Name = nameof(Properties.Markup), ResourceType = typeof(Properties))]
        public float Markup
        {
            set { SetProperty(ref _markup, value); }
            get { return _markup; }
        }
        /// <summary>
        /// Gets or sets how prices are determined.
        /// </summary>
        /// <value>The price type.</value>
        [Display(Name = nameof(Properties.PriceListPricesAreSet), ResourceType = typeof(Properties))]
        public PriceListPricesAreSet PricesAreSet
        {
            set { SetProperty(ref _pricesAreSet, value); }
            get { return _pricesAreSet; }
        }
    }
}
