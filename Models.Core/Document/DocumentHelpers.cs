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


		public static readonly ReadOnlyDictionary<SocialSecurityCategoryType, SocialSecurityCategory> SocialSecurityCategories = 
			new ReadOnlyDictionary<SocialSecurityCategoryType, SocialSecurityCategory>(
				new Dictionary<SocialSecurityCategoryType, SocialSecurityCategory>
				{
                    { SocialSecurityCategoryType.TC01, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC01, Description = Properties.SocialSecurity.TC01} },
                    { SocialSecurityCategoryType.TC02, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC02, Description = Properties.SocialSecurity.TC02} },
                    { SocialSecurityCategoryType.TC03, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC03, Description = Properties.SocialSecurity.TC03} },
                    { SocialSecurityCategoryType.TC04, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC04, Description = Properties.SocialSecurity.TC04} },
                    { SocialSecurityCategoryType.TC05, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC05, Description = Properties.SocialSecurity.TC05} },
                    { SocialSecurityCategoryType.TC06, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC06, Description = Properties.SocialSecurity.TC06} },
                    { SocialSecurityCategoryType.TC07, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC07, Description = Properties.SocialSecurity.TC07} },
                    { SocialSecurityCategoryType.TC08, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC08, Description = Properties.SocialSecurity.TC08} },
                    { SocialSecurityCategoryType.TC09, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC09, Description = Properties.SocialSecurity.TC09} },
                    { SocialSecurityCategoryType.TC10, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC10, Description = Properties.SocialSecurity.TC10} },
                    { SocialSecurityCategoryType.TC11, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC11, Description = Properties.SocialSecurity.TC11} },
                    { SocialSecurityCategoryType.TC12, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC12, Description = Properties.SocialSecurity.TC12} },
                    { SocialSecurityCategoryType.TC13, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC13, Description = Properties.SocialSecurity.TC13} },
                    { SocialSecurityCategoryType.TC14, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC14, Description = Properties.SocialSecurity.TC14} },
                    { SocialSecurityCategoryType.TC15, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC15, Description = Properties.SocialSecurity.TC15} },
                    { SocialSecurityCategoryType.TC16, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC16, Description = Properties.SocialSecurity.TC16} },
                    { SocialSecurityCategoryType.TC17, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC17, Description = Properties.SocialSecurity.TC17} },
                    { SocialSecurityCategoryType.TC18, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC18, Description = Properties.SocialSecurity.TC18} },
                    { SocialSecurityCategoryType.TC19, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC19, Description = Properties.SocialSecurity.TC19} },
                    { SocialSecurityCategoryType.TC20, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC20, Description = Properties.SocialSecurity.TC20} },
                    { SocialSecurityCategoryType.TC21, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC21, Description = Properties.SocialSecurity.TC21} },
                    { SocialSecurityCategoryType.TC22, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC22, Description = Properties.SocialSecurity.TC22} },

				});

		public static readonly ReadOnlyDictionary<DocumentTransportMode, TransportMode> TransportModes = 
			new ReadOnlyDictionary<DocumentTransportMode, TransportMode>(
				new Dictionary<DocumentTransportMode, TransportMode>
				{
                    { DocumentTransportMode.Sender, new TransportMode { Code = DocumentTransportMode.Sender, Description = Properties.TransportMode.Sender }},
                    { DocumentTransportMode.Recipient, new TransportMode { Code = DocumentTransportMode.Recipient, Description = Properties.TransportMode.Recipient }},
                    { DocumentTransportMode.Courier, new TransportMode { Code = DocumentTransportMode.Courier, Description = Properties.TransportMode.Courier }},
				});

		public static readonly ReadOnlyDictionary<DocumentShippingTerm, ShippingTerm> TransportTerms = 
			new ReadOnlyDictionary<DocumentShippingTerm, ShippingTerm>(
				new Dictionary<DocumentShippingTerm, ShippingTerm>
				{
                    { DocumentShippingTerm.DeliveredDutyPaid, new ShippingTerm { Code = DocumentShippingTerm.DeliveredDutyPaid, Description = Properties.ShippingTerms.DeliveredDutyPaid }},
                    { DocumentShippingTerm.ExWorks, new ShippingTerm { Code = DocumentShippingTerm.ExWorks, Description = Properties.ShippingTerms.ExWorks }},
				});

		public static readonly ReadOnlyDictionary<DocumentVariation, VariationCategory > Variations = 
			new ReadOnlyDictionary<DocumentVariation, VariationCategory>(
				new Dictionary<DocumentVariation, VariationCategory>
				{
                    { DocumentVariation.Discount, new VariationCategory { Category = DocumentVariation.Discount, Description = Properties.Variation.Discount }},
                    { DocumentVariation.PaymentDiscount, new VariationCategory { Category = DocumentVariation.PaymentDiscount, Description = Properties.Variation.PaymentDiscount }},
                    { DocumentVariation.Raise, new VariationCategory { Category = DocumentVariation.Raise, Description = Properties.Variation.Raise }},
				});
   }
}
