using System.Collections.Generic;

namespace Amica.vNext.Models.Documents
{
    public class DocumentHelpers
    {

		public static readonly ReadOnlyDictionary<DocumentType, Type> Types = 
			new ReadOnlyDictionary<DocumentType, Type>(
				new Dictionary<DocumentType, Type>
				{
                    { DocumentType.DeliveryNote, new Type { Code = (int)DocumentType.DeliveryNote, Description = Properties.Document.DeliveryNote }},
					{ DocumentType.ShippingInvoice, new Type { Code = (int)DocumentType.ShippingInvoice, Description =  Properties.Document.ShippingInvoice }},
					{ DocumentType.DepositInvoice, new Type { Code = (int)DocumentType.DepositInvoice, Description = Properties.Document.DepositInvoice }},
					{ DocumentType.Invoice, new Type { Code = (int)DocumentType.Invoice, Description = Properties.Document.Invoice }},
					{ DocumentType.ProFormaInvoice, new Type { Code = (int)DocumentType.ProFormaInvoice, Description = Properties.Document.Invoice }},
				});

		public static readonly ReadOnlyDictionary<DocumentStatus, Status> Statuses = 
			new ReadOnlyDictionary<DocumentStatus, Status>(
				new Dictionary<DocumentStatus, Status>
				{
                    { DocumentStatus.Draft, new Status { Code = (int)DocumentStatus.Draft, Description = Properties.Document.Draft }},
					{ DocumentStatus.InvoicedDelieryNote, new Status { Code = (int)DocumentStatus.InvoicedDelieryNote, Description =  Properties.Document.InvoicedDeliveryNote }},
					{ DocumentStatus.Issued, new Status { Code = (int)DocumentStatus.Issued, Description = Properties.Document.Issued }},
				});
    }

    #region Document Status
    public enum DocumentStatus
    {
		Draft = 1,
		InvoicedDelieryNote = 2,
		Issued = 3,
		// TODO
		//FatturaAccontoScontataInFattura = 4
		//PreventivoChiuso = 5
		//OrdineEvaso = 6
		//OrdineParzialmenteEvaso = 7
		//OrdineAnnullato = 8
		//ResoAccreditato = 9
		//DDTNonFatturare = 10
    }

    public class Status : CollectionItemOfInt
    {
    }
    #endregion

    #region Document Type
    public enum DocumentType
	{
		DeliveryNote = 1,
		ShippingInvoice = 2,
		DepositInvoice = 3,
		Invoice = 4,
		ProFormaInvoice = 22,
		// TODO
		//FatturaProfessionista = 5,
		//RicevutaFiscale = 6,
		//NotaCredito = 7,
		//NotaDebito = 8,
		//Scontrino = 9,
		//OrdineCliente = 10,
		//Preventivo = 11,
		//DdtFornitore = 12,
		//FatturaAccompagnatoriaFornitore = 13,
		//FatturaDifferitaFornitore = 14,
		//FatturaProfessionistaFornitore = 15,
		//NotaCreditoFornitore = 16,
		//NotaDebitoFornitore = 17,
		//PreventivoFornitore = 18,
		//OrdineFornitore = 19,
		//ResoCliente = 20,
		//FatturaAccontoFornitore = 21,
	}

    public class Type : CollectionItemOfInt
    {
    }
    #endregion
}
