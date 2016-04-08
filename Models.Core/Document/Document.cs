using System;
using System.Collections.Generic;

namespace Amica.vNext.Models.Documents
{
    public class Document : BaseModelWithCompanyId
	{

		private DateTime _date;
	    private decimal _total;
	    private Category _category;
        private Status _status;
        private ContactDetailsEx _agent;
        private ContactDetailsEx _courier;
        private Payment _payment;
        private string _reason;



        private BillingAddress _billingAddress;
        private DeliveryAddress _deliveryAddress;
		private  List<DocumentItem> _items = new List<DocumentItem>();

		public Document()
		{
		    Date = DateTime.Now;
			Status = DocumentHelpers.Statuses[DocumentStatus.Draft];
		}
		/// <summary>
		/// Gets or sets the document date.
		/// </summary>
		/// <value>The document date.</value>
		public DateTime Date {
			set { SetProperty (ref _date, value); }
			get { return _date; }
		}

		/// <summary>
		/// Gets or sets the document status.
		/// </summary>
		/// <value>The document status.</value>
		public Status Status {
			set { SetProperty (ref _status, value); }
			get { return _status; }
		}

		/// <summary>
		/// Gets or sets the document contact.
		/// </summary>
		/// <value>The document contact.</value>
		public BillingAddress Contact {
			set { SetProperty (ref _billingAddress, value); }
			get { return _billingAddress; }
		}

		/// <summary>
		/// Gets or sets the total amount.
		/// </summary>
		/// <value>The total amount.</value>
		public decimal Total {
			set { SetProperty (ref _total, value); }
			get { return _total; }
		}

		/// <summary>
		/// Gets or sets the document type.
		/// </summary>
		/// <value>The total amount.</value>
		public Category Category {
			set { SetProperty (ref _category, value); }
			get { return _category; }
		}
		public List<DocumentItem> Items
        {
			set { SetProperty (ref _items, value); }
			get { return _items; }

        }
	}
}
