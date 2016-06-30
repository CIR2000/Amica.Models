using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.vNext.Models.Documents
{
    public class Document : BaseModelWithCompanyId
	{

        private string _reason;
        private decimal _rebate;
        private string _notes;
		private DateTime _date;
        private DateTime _expirationDate;


        private DocumentNumber _number;
        private Status _status;
        private Category _category;
        private DocumentCurrency _currency;
        private DocumentPayment _payment;
        private BillingAddress _billTo;
        private ShippingAddress _shipTo;
        private ContactDetailsEx _agent;
        private WithholdingTax _withholdingTax;
        private Shipping _shipping;
        private Bank _bank;

        private List<SocialSecurity> _socialSecurityCollection;
        private List<Variation> _variationCollection;
        private List<DocumentFee> _feeCollection;
        private List<DocumentItem> _itemCollection;

        public Document()
		{
		    Date = DateTime.Now;
            Payment = new DocumentPayment();
            Currency = new DocumentCurrency();
            SocialSecurityCollection = new List<SocialSecurity>();
			VariationCollection = new List<Variation>();
            FeeCollection = new List<DocumentFee>();
            ItemCollection = new List<DocumentItem>();
        }

		public DateTime Date
        {
			set { SetProperty (ref _date, value); }
			get { return _date; }
		}

        public string Reason
        {
            set { SetProperty(ref _reason, value); }
            get { return _reason; }
        }

		[JsonProperty("expiration_date")]
        public DateTime ExpirationDate
        {
            set { SetProperty(ref _expirationDate, value); }
            get { return _expirationDate; }
        }

        public DocumentNumber Number
        {
            set { SetProperty(ref _number, value); }
            get { return _number; }
        }

        public Status Status
        {
            set { SetProperty(ref _status, value); }
            get { return _status; }
        }

        public Category Category {
			set { SetProperty (ref _category, value); }
			get { return _category; }
		}

        public DocumentCurrency Currency
        {
            set { SetProperty(ref _currency, value); }
            get { return _currency; }
        }

        public DocumentPayment Payment
        {
            set { SetProperty(ref _payment, value); }
            get { return _payment; }
        }

        [JsonProperty("bill_to")]
        public BillingAddress BillTo
        {
            set { SetProperty(ref _billTo, value); }
            get { return _billTo; }
        }

        [JsonProperty("ship_to")]
        public ShippingAddress ShipTo
        {
            set { SetProperty(ref _shipTo, value); }
            get { return _shipTo; }
        }

        public ContactDetailsEx Agent
        {
            set { SetProperty(ref _agent, value); }
            get { return _agent; }
        }

        [JsonProperty("withholding_tax")]
        public WithholdingTax WithholdingTax
        {
            set { SetProperty(ref _withholdingTax, value); }
            get { return _withholdingTax; }
        }

        public Shipping Shipping
        {
            set { SetProperty(ref _shipping, value); }
            get { return _shipping; }
        }

        public Bank Bank
        {
            set { SetProperty(ref _bank, value); }
            get { return _bank; }
        }

        public decimal Rebate
        {
            set { SetProperty(ref _rebate, value); }
            get { return _rebate; }
        }

        public string Notes
        {
            set { SetProperty(ref _notes, value); }
            get { return _notes; }
        }

        [JsonProperty("social_security_collection")]
        public List<SocialSecurity> SocialSecurityCollection
        {
            set { SetProperty(ref _socialSecurityCollection, value); }
            get { return _socialSecurityCollection; }
        }

        [JsonProperty("variation_collection")]
        public List<Variation> VariationCollection
        {
            set { SetProperty(ref _variationCollection, value); }
            get { return _variationCollection; }
        }

        [JsonProperty("fee_collection")]
        public List<DocumentFee> FeeCollection
        {
            set { SetProperty(ref _feeCollection, value); }
            get { return _feeCollection; }
        }

        [JsonProperty("item_collection")]
        public List<DocumentItem> ItemCollection
        {
            set { SetProperty(ref _itemCollection, value); }
            get { return _itemCollection; }
        }
    }
}
