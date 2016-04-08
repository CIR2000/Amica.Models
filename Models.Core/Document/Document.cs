using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.vNext.Models.Documents
{
    public class Document : BaseModelWithCompanyId
	{

		private DateTime _date;
        private string _reason;
	    private decimal _total;


        private DocumentNumber _number;
        private Status _status;
	    private Category _category;
        private Currency _currency;
        private Payment _payment;
        private BillingAddress _billTo;
        private ShippingAddress _shipTo;
        private ContactDetailsEx _agent;
        private ContactDetailsEx _courier;
        private WithholdingTax _witholdingTax;
        private SocialSecurity _socialSecurity;

		private  List<DocumentItem> _items = new List<DocumentItem>();

		public Document()
		{
		    Date = DateTime.Now;
			Status = DocumentHelpers.Statuses[DocumentStatus.Draft];
		}

		public DateTime Date {
			set { SetProperty (ref _date, value); }
			get { return _date; }
		}

		public string Reason {
			set { SetProperty (ref _reason, value); }
			get { return _reason; }
		}

		public DocumentNumber Number {
			set { SetProperty (ref _number, value); }
			get { return Number; }
		}
		public Status Status {
			set { SetProperty (ref _status, value); }
			get { return _status; }
		}

		public Category Category {
			set { SetProperty (ref _category, value); }
			get { return _category; }
		}

		public Currency Currency {
			set { SetProperty (ref _currency, value); }
			get { return _currency; }
		}

		public Payment Payment {
			set { SetProperty (ref _payment, value); }
			get { return _payment; }
		}


		[JsonProperty("bill_to")]
		public BillingAddress BillTo {
			set { SetProperty (ref _billTo, value); }
			get { return _billTo; }
		}

		[JsonProperty("ship_to")]
		public ShippingAddress ShipTo {
			set { SetProperty (ref _shipTo, value); }
			get { return _shipTo; }
		}

		public ContactDetailsEx Agent {
			set { SetProperty (ref _agent, value); }
			get { return _agent; }
		}

		public ContactDetailsEx Courier {
			set { SetProperty (ref _courier, value); }
			get { return _courier; }
		}

		[JsonProperty("witholding_tax")]
		public WithholdingTax WitholdingTax {
			set { SetProperty (ref _witholdingTax, value); }
			get { return _witholdingTax; }
		}

		[JsonProperty("social_security")]
		public SocialSecurity SocialSecurity {
			set { SetProperty (ref _socialSecurity, value); }
			get { return _socialSecurity; }
		}

		public decimal Total {
			set { SetProperty (ref _total, value); }
			get { return _total; }
		}

		public List<DocumentItem> Items
        {
			set { SetProperty (ref _items, value); }
			get { return _items; }

        }
	}
}
