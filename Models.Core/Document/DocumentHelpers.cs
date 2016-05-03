using System;
using System.Collections.Generic;

namespace Amica.vNext.Models.Documents
{
    public class DocumentHelpers
    {

		public static readonly ReadOnlyDictionary<DocumentCategory, Category> Categories = 
			new ReadOnlyDictionary<DocumentCategory, Category>(
				new Dictionary<DocumentCategory, Category>
				{
                    { DocumentCategory.DeliveryNote, new Category { Code = DocumentCategory.DeliveryNote, Description = Properties.Document.DeliveryNote }},
					{ DocumentCategory.ShippingInvoice, new Category { Code = DocumentCategory.ShippingInvoice, Description =  Properties.Document.ShippingInvoice }},
					{ DocumentCategory.DepositInvoice, new Category { Code = DocumentCategory.DepositInvoice, Description = Properties.Document.DepositInvoice }},
					{ DocumentCategory.Invoice, new Category { Code = DocumentCategory.Invoice, Description = Properties.Document.Invoice }},
					{ DocumentCategory.ProFormaInvoice, new Category { Code = DocumentCategory.ProFormaInvoice, Description = Properties.Document.Invoice }},
				});

		public static readonly ReadOnlyDictionary<DocumentStatus, Status> Statuses = 
			new ReadOnlyDictionary<DocumentStatus, Status>(
				new Dictionary<DocumentStatus, Status>
				{
                    { DocumentStatus.Draft, new Status { Code = DocumentStatus.Draft, Description = Properties.Document.Draft }},
					{ DocumentStatus.InvoicedDelieryNote, new Status { Code = DocumentStatus.InvoicedDelieryNote, Description =  Properties.Document.InvoicedDeliveryNote }},
					{ DocumentStatus.Issued, new Status { Code = DocumentStatus.Issued, Description = Properties.Document.Issued }},
				});
    }
}
