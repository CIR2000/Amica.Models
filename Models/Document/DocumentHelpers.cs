using Amica.Models.Resources;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.Models.Documents
{
    public class DocumentHelpers
    {

		public static readonly ReadOnlyDictionary<DocumentCategory, Category> Categories = 
			new ReadOnlyDictionary<DocumentCategory, Category>(
				new Dictionary<DocumentCategory, Category>
				{
                    { DocumentCategory.DeliveryNote, new Category { Code = DocumentCategory.DeliveryNote, Description = DocumentResources.DeliveryNote }},
					{ DocumentCategory.ShippingInvoice, new Category { Code = DocumentCategory.ShippingInvoice, Description =  DocumentResources.ShippingInvoice }},
					{ DocumentCategory.DepositInvoice, new Category { Code = DocumentCategory.DepositInvoice, Description = DocumentResources.DepositInvoice }},
					{ DocumentCategory.Invoice, new Category { Code = DocumentCategory.Invoice, Description = DocumentResources.Invoice }},
					{ DocumentCategory.ProFormaInvoice, new Category { Code = DocumentCategory.ProFormaInvoice, Description = DocumentResources.Invoice }},
				});

		public static readonly ReadOnlyDictionary<DocumentStatus, Status> Statuses = 
			new ReadOnlyDictionary<DocumentStatus, Status>(
				new Dictionary<DocumentStatus, Status>
				{
                    { DocumentStatus.Draft, new Status { Code = DocumentStatus.Draft, Description = DocumentResources.Draft }},
					{ DocumentStatus.InvoicedDelieryNote, new Status { Code = DocumentStatus.InvoicedDelieryNote, Description =  DocumentResources.InvoicedDeliveryNote }},
					{ DocumentStatus.Issued, new Status { Code = DocumentStatus.Issued, Description = DocumentResources.Issued }},
				});


		public static readonly ReadOnlyDictionary<SocialSecurityCategoryType, SocialSecurityCategory> SocialSecurityCategories = 
			new ReadOnlyDictionary<SocialSecurityCategoryType, SocialSecurityCategory>(
				new Dictionary<SocialSecurityCategoryType, SocialSecurityCategory>
				{
                    { SocialSecurityCategoryType.TC01, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC01, Description = SocialSecurityResources.TC01} },
                    { SocialSecurityCategoryType.TC02, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC02, Description = SocialSecurityResources.TC02} },
                    { SocialSecurityCategoryType.TC03, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC03, Description = SocialSecurityResources.TC03} },
                    { SocialSecurityCategoryType.TC04, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC04, Description = SocialSecurityResources.TC04} },
                    { SocialSecurityCategoryType.TC05, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC05, Description = SocialSecurityResources.TC05} },
                    { SocialSecurityCategoryType.TC06, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC06, Description = SocialSecurityResources.TC06} },
                    { SocialSecurityCategoryType.TC07, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC07, Description = SocialSecurityResources.TC07} },
                    { SocialSecurityCategoryType.TC08, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC08, Description = SocialSecurityResources.TC08} },
                    { SocialSecurityCategoryType.TC09, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC09, Description = SocialSecurityResources.TC09} },
                    { SocialSecurityCategoryType.TC10, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC10, Description = SocialSecurityResources.TC10} },
                    { SocialSecurityCategoryType.TC11, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC11, Description = SocialSecurityResources.TC11} },
                    { SocialSecurityCategoryType.TC12, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC12, Description = SocialSecurityResources.TC12} },
                    { SocialSecurityCategoryType.TC13, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC13, Description = SocialSecurityResources.TC13} },
                    { SocialSecurityCategoryType.TC14, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC14, Description = SocialSecurityResources.TC14} },
                    { SocialSecurityCategoryType.TC15, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC15, Description = SocialSecurityResources.TC15} },
                    { SocialSecurityCategoryType.TC16, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC16, Description = SocialSecurityResources.TC16} },
                    { SocialSecurityCategoryType.TC17, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC17, Description = SocialSecurityResources.TC17} },
                    { SocialSecurityCategoryType.TC18, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC18, Description = SocialSecurityResources.TC18} },
                    { SocialSecurityCategoryType.TC19, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC19, Description = SocialSecurityResources.TC19} },
                    { SocialSecurityCategoryType.TC20, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC20, Description = SocialSecurityResources.TC20} },
                    { SocialSecurityCategoryType.TC21, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC21, Description = SocialSecurityResources.TC21} },
                    { SocialSecurityCategoryType.TC22, new SocialSecurityCategory { Category = SocialSecurityCategoryType.TC22, Description = SocialSecurityResources.TC22} },

				});

		public static readonly ReadOnlyDictionary<DocumentTransportMode, TransportMode> TransportModes = 
			new ReadOnlyDictionary<DocumentTransportMode, TransportMode>(
				new Dictionary<DocumentTransportMode, TransportMode>
				{
                    { DocumentTransportMode.Sender, new TransportMode { Code = DocumentTransportMode.Sender, Description = TransportModeResources.Sender }},
                    { DocumentTransportMode.Recipient, new TransportMode { Code = DocumentTransportMode.Recipient, Description = TransportModeResources.Recipient }},
                    { DocumentTransportMode.Courier, new TransportMode { Code = DocumentTransportMode.Courier, Description = TransportModeResources.Courier }},
				});

		public static readonly ReadOnlyDictionary<DocumentShippingTerm, ShippingTerm> ShippingTerms = 
			new ReadOnlyDictionary<DocumentShippingTerm, ShippingTerm>(
				new Dictionary<DocumentShippingTerm, ShippingTerm>
				{
                    { DocumentShippingTerm.DeliveredDutyPaid, new ShippingTerm { Code = DocumentShippingTerm.DeliveredDutyPaid, Description = ShippingTermsResources.DeliveredDutyPaid }},
                    { DocumentShippingTerm.ExWorks, new ShippingTerm { Code = DocumentShippingTerm.ExWorks, Description = ShippingTermsResources.ExWorks }},
				});

		public static readonly ReadOnlyDictionary<DocumentVariation, VariationCategory > Variations = 
			new ReadOnlyDictionary<DocumentVariation, VariationCategory>(
				new Dictionary<DocumentVariation, VariationCategory>
				{
                    { DocumentVariation.Discount, new VariationCategory { Category = DocumentVariation.Discount, Description = VariationResources.Discount }},
                    { DocumentVariation.PaymentDiscount, new VariationCategory { Category = DocumentVariation.PaymentDiscount, Description = VariationResources.PaymentDiscount }},
                    { DocumentVariation.Raise, new VariationCategory { Category = DocumentVariation.Raise, Description = VariationResources.Raise }},
				});
   }
}
