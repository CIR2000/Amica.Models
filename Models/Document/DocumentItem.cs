using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class DocumentItem : ObservableObject
    {
        private string _uniqueId;
        private string _sourcePriceList;
        private bool _withholdingTax;
        private float _quantity;
        private float _processedQuantity;
        private float _commission;
        private float _areaManagerCommission;
        private decimal _price;
        private decimal _priceVatInclusive;
        private decimal _netPrice;
        private decimal _total;

        private DocumentItemDetail _detail;
		private OrderReference _order;
        private Vat _vat;
        private Warehouse _warehouse;

        private List<Variation> _variationCollection;

		public DocumentItem()
        {
            Quantity = 1;
            VariationCollection = new List<Variation>();
            Guid = System.Guid.NewGuid().ToString();
        }

        public string Guid
        {
            set { SetProperty(ref _uniqueId, value); }
            get { return _uniqueId; }
        }


        public DocumentItemDetail Detail
        {
            set { SetProperty(ref _detail, value); }
            get { return _detail; }
        }

		public OrderReference Order {
			set { SetProperty (ref _order, value); }
			get { return _order; }
		}
        public string SourcePriceList
        {
            set { SetProperty(ref _sourcePriceList, value); }
            get { return _sourcePriceList; }
        }

        public Vat Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }

		public Warehouse Warehouse {
			set { SetProperty (ref _warehouse, value); }
			get { return _warehouse; }
		}

		[JsonProperty ("withholding_tax")]
        public bool WithholdingTax
        {
            set { SetProperty(ref _withholdingTax, value); }
            get { return _withholdingTax; }
        }

        public float Quantity
        {
            set { SetProperty(ref _quantity, value); }
            get { return _quantity; }
        }

		[JsonProperty ("processed_quantity")]
        public float ProcessedQuantity
        {
            set { SetProperty(ref _processedQuantity, value); }
            get { return _processedQuantity; }
        }

		[JsonProperty("variation_collection")]
        public List<Variation> VariationCollection
        {
            set { SetProperty(ref _variationCollection, value); }
            get { return _variationCollection; }
        }

        public float Commission
        {
            set { SetProperty(ref _commission, value); }
            get { return _commission; }
        }

		[JsonProperty("area_manager_commission")]
        public float AreaManagerCommission
        {
            set { SetProperty(ref _areaManagerCommission, value); }
            get { return _areaManagerCommission; }
        }

        public decimal Price
        {
            set { SetProperty(ref _price, value); }
            get { return _price; }
        }

		[JsonProperty ("net_price")]
        public decimal NetPrice
        {
            set { SetProperty(ref _netPrice, value); }
            get { return _netPrice; }
        }

		[JsonProperty ("price_vat_inclusive")]
        public decimal PriceVatInclusive
        {
            set { SetProperty(ref _priceVatInclusive, value); }
            get { return _priceVatInclusive; }
        }

        public decimal Total
        {
            set { SetProperty(ref _total, value); }
            get { return _total; }
        }
    }
}
