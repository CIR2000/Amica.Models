using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.vNext.Models.ItalianPA
{
    public static class PACollections
    {
        public static ReadOnlyDictionary<string, object> NaturaPA = 
			new ReadOnlyDictionary<string, object>(
                new Dictionary<string, object>
                {
                    { "N1", new NaturaPA {Code = "N1", Description="escluse ex art. 15" }},
                    { "N2", new NaturaPA {Code = "N2", Description="non soggette" }},
                    { "N3", new NaturaPA {Code = "N3", Description="non imponibili" }},
                    { "N4", new NaturaPA {Code = "N4", Description="esenti" }},
                    { "N5", new NaturaPA {Code = "N5", Description="regime del margine" }},
                    { "N6", new NaturaPA {Code = "N6", Description="inversione contabile (reverse charge)" }},

                });

        public static readonly ReadOnlyDictionary<string, object> ModalitaPagamentoPA = 
			new ReadOnlyDictionary<string, object>(
                new Dictionary<string, object>
                {
                    { "MP01", new ModalitaPagamentoPA {Code="MP01", Description="contanti" } },
                    { "MP02", new ModalitaPagamentoPA {Code="MP02", Description="assegno" } },
                    { "MP03", new ModalitaPagamentoPA {Code="MP03", Description="assegno circolare" } },
                    { "MP04", new ModalitaPagamentoPA {Code="MP04", Description="contanti presso Tesoreria" } },
                    { "MP05", new ModalitaPagamentoPA {Code="MP05", Description="bonifico" } },
                    { "MP06", new ModalitaPagamentoPA {Code="MP06", Description="vaglia cambiario" } },
                    { "MP07", new ModalitaPagamentoPA {Code="MP07", Description="bollettino bancario" } },
                    { "MP08", new ModalitaPagamentoPA {Code="MP08", Description="carta di pagamento" } },
                    { "MP09", new ModalitaPagamentoPA {Code="MP09", Description="RID" } },
                    { "MP10", new ModalitaPagamentoPA {Code="MP10", Description="RID utenze" } },
                    { "MP11", new ModalitaPagamentoPA {Code="MP11", Description="RID veloce" } },
                    { "MP12", new ModalitaPagamentoPA {Code="MP12", Description="RIBA" } },
                    { "MP13",new ModalitaPagamentoPA {Code="MP13", Description="MAV" } },
                    { "MP14",new ModalitaPagamentoPA {Code="MP14", Description="quietanza erario" } },
                    { "MP15",new ModalitaPagamentoPA {Code="MP15", Description="giroconto su conti di contabilità speciale" } },
                    { "MP16",new ModalitaPagamentoPA {Code="MP16", Description="domiciliazione bancaria" } },
                    { "MP17",new ModalitaPagamentoPA {Code="MP17", Description="domicialiazione postale" } },
                    { "MP18",new ModalitaPagamentoPA {Code="MP18", Description="bollettino di c/c postale" } },
                    { "MP19",new ModalitaPagamentoPA {Code="MP19", Description="SEPA Direct Debit" } },
                    { "MP20",new ModalitaPagamentoPA {Code="MP20", Description="SEPA Direct Debit CORE" } },
                    { "MP21",new ModalitaPagamentoPA {Code="MP21", Description="SEPA Direct Debit B2B" } },
            });

    }
}
