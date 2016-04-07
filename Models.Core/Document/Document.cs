using System;
using System.Collections.Generic;

namespace Amica.vNext.Models.Documents
{
    public class Document : BaseModelWithCompanyId
	{

		private DateTime _date;
	    private decimal _total;
	    private Type _type;
        private Status _status;

	    private  ContactMinimal _contact = new ContactMinimal();
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
		public ContactMinimal Contact {
			set { SetProperty (ref _contact, value); }
			get { return _contact; }
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
		public Type Type {
			set { SetProperty (ref _type, value); }
			get { return _type; }
		}
		public List<DocumentItem> Items
        {
			set { SetProperty (ref _items, value); }
			get { return _items; }

        }
	}
}
