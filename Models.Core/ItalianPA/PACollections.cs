using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.vNext.Models.ItalianPA
{
    public static class PACollections
    {
        public static readonly ReadOnlyCollection<NaturaPA> NaturaPA = new ReadOnlyCollection<NaturaPA>(
			new List<NaturaPA>
            {
                new NaturaPA {Code="N1", Description="escluse ex art. 15" },
                new NaturaPA {Code="N2", Description="non soggette" },
				new NaturaPA {Code="N3", Description="non imponibili" },
				new NaturaPA {Code="N4", Description="esenti" },
				new NaturaPA {Code="N5", Description="regime del margine" },
				new NaturaPA {Code="N6", Description="inversione contabile (reverse charge)" },
            });

        public static readonly ReadOnlyCollection<ModalitaPagamentoPA> ModalitaPagamentoPA = new ReadOnlyCollection<ModalitaPagamentoPA>(
			new List<ModalitaPagamentoPA>
            {
                new ModalitaPagamentoPA {Code="MP01", Description="contanti" },
                new ModalitaPagamentoPA {Code="MP02", Description="assegno" },
				new ModalitaPagamentoPA {Code="MP03", Description="assegno circolare" },
				new ModalitaPagamentoPA {Code="MP04", Description="contanti presso Tesoreria" },
				new ModalitaPagamentoPA {Code="MP05", Description="bonifico" },
				new ModalitaPagamentoPA {Code="MP06", Description="vaglia cambiario" },
				new ModalitaPagamentoPA {Code="MP07", Description="bollettino bancario" },
				new ModalitaPagamentoPA {Code="MP08", Description="carta di pagamento" },
				new ModalitaPagamentoPA {Code="MP09", Description="RID" },
				new ModalitaPagamentoPA {Code="MP10", Description="RID utenze" },
				new ModalitaPagamentoPA {Code="MP11", Description="RID veloce" },
				new ModalitaPagamentoPA {Code="MP12", Description="RIBA" },
				new ModalitaPagamentoPA {Code="MP13", Description="MAV" },
				new ModalitaPagamentoPA {Code="MP14", Description="quietanza erario" },
				new ModalitaPagamentoPA {Code="MP15", Description="giroconto su conti di contabilità speciale" },
				new ModalitaPagamentoPA {Code="MP16", Description="domiciliazione bancaria" },
				new ModalitaPagamentoPA {Code="MP17", Description="domicialiazione postale" },
				new ModalitaPagamentoPA {Code="MP18", Description="bollettino di c/c postale" },
				new ModalitaPagamentoPA {Code="MP19", Description="SEPA Direct Debit" },
				new ModalitaPagamentoPA {Code="MP20", Description="SEPA Direct Debit CORE" },
				new ModalitaPagamentoPA {Code="MP21", Description="SEPA Direct Debit B2B" },
            });

    }
}
