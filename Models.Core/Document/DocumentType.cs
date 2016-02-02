using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.vNext.Models.Documents
{
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
