using System;
using Newtonsoft.Json;

namespace Amica.vNext.Models
{
	public class Document : BaseModelWithCompanyId
	{

		private DateTime _date;
	    private decimal _total;
	    private DocumentType _type;

		/// <summary>
		/// Gets or sets the document date.
		/// </summary>
		/// <value>The document date.</value>
		[JsonProperty ("d")]
		public DateTime Date {
			set { SetProperty (ref _date, value); }
			get { return _date; }
		}

		/// <summary>
		/// Gets or sets the total amount.
		/// </summary>
		/// <value>The total amount.</value>
		[JsonProperty ("t")]
		public decimal Total {
			set { SetProperty (ref _total, value); }
			get { return _total; }
		}

		/// <summary>
		/// Gets or sets the document type.
		/// </summary>
		/// <value>The total amount.</value>
		[JsonProperty ("ty")]
		public DocumentType Type {
			set { SetProperty (ref _type, value); }
			get { return _type; }
		}

	    private Lazy<string> _test;
	    public string Test
	    {
            get { return _test?.Value; }
			set { if (value != null) _test = new Lazy<string>(value); }
	    }
	}

	// TODO complete english translation 
    public enum DocumentType
    {
		// DDT
		DeliveryNote = 1,
		// Fattura accompagnatoria
		ShippingInvoice = 2,
		// Fattura di acconto
		DepositInvoice = 3,
		// Fattura differita
		Invoice = 4,
		FatturaProfessionista = 5,
		RicevutaFiscale = 6,
		NotaCredito = 7,
		NotaDebito = 8,
		Scontrino = 9,
		OrdineCliente = 10,
		Preventivo = 11,
		DdtFornitore = 12,
		FatturaAccompagnatoriaFornitore = 13,
		FatturaDifferitaFornitore = 14,
		FatturaProfessionistaFornitore = 15,
		NotaCreditoFornitore = 16,
		NotaDebitoFornitore = 17,
		PreventivoFornitore = 18,
		OrdineFornitore = 19,
		ResoCliente = 20,
		FatturaAccontoFornitore = 21,
		// Fattura proforma
		ProFormaInvoice = 22
    }
}
