using System.Collections.Generic;
using Models;

namespace Amica.Models.ItalianPA
{
    public static class PAHelpers
    {
        public static ReadOnlyDictionary<string, NaturaPA> NaturaPA = 
			new ReadOnlyDictionary<string, NaturaPA>(
                new Dictionary<string, NaturaPA>
                {
                    { "N1", new NaturaPA {Code = "N1", Description= ItalianPAResources.N1 }},
                    { "N2", new NaturaPA {Code = "N2", Description= ItalianPAResources.N2 }},
                    { "N3", new NaturaPA {Code = "N3", Description= ItalianPAResources.N3 }},
                    { "N4", new NaturaPA {Code = "N4", Description= ItalianPAResources.N4 }},
                    { "N5", new NaturaPA {Code = "N5", Description= ItalianPAResources.N5 }},
                    { "N6", new NaturaPA {Code = "N6", Description= ItalianPAResources.N6 }},
				});

        public static readonly ReadOnlyDictionary<string, ModalitaPagamentoPA> ModalitaPagamentoPA = 
			new ReadOnlyDictionary<string, ModalitaPagamentoPA>(
                new Dictionary<string, ModalitaPagamentoPA>
                {
                    { "MP01", new ModalitaPagamentoPA {Code="MP01", Description= ItalianPAResources.MP01 } },
                    { "MP02", new ModalitaPagamentoPA {Code="MP02", Description= ItalianPAResources.MP02 } },
                    { "MP03", new ModalitaPagamentoPA {Code="MP03", Description= ItalianPAResources.MP03 } },
                    { "MP04", new ModalitaPagamentoPA {Code="MP04", Description= ItalianPAResources.MP04 } },
                    { "MP05", new ModalitaPagamentoPA {Code="MP05", Description= ItalianPAResources.MP05 } },
                    { "MP06", new ModalitaPagamentoPA {Code="MP06", Description= ItalianPAResources.MP06 } },
                    { "MP07", new ModalitaPagamentoPA {Code="MP07", Description= ItalianPAResources.MP07 } },
                    { "MP08", new ModalitaPagamentoPA {Code="MP08", Description= ItalianPAResources.MP08 } },
                    { "MP09", new ModalitaPagamentoPA {Code="MP09", Description= ItalianPAResources.MP09 } },
                    { "MP10", new ModalitaPagamentoPA {Code="MP10", Description= ItalianPAResources.MP10 } },
                    { "MP11", new ModalitaPagamentoPA {Code="MP11", Description= ItalianPAResources.MP11 } },
                    { "MP12", new ModalitaPagamentoPA {Code="MP12", Description= ItalianPAResources.MP12 } },
                    { "MP13",new ModalitaPagamentoPA {Code="MP13", Description= ItalianPAResources.MP13 } },
                    { "MP14",new ModalitaPagamentoPA {Code="MP14", Description= ItalianPAResources.MP14 } },
                    { "MP15",new ModalitaPagamentoPA {Code="MP15", Description= ItalianPAResources.MP15} },
                    { "MP16",new ModalitaPagamentoPA {Code="MP16", Description= ItalianPAResources.MP16 } },
                    { "MP17",new ModalitaPagamentoPA {Code="MP17", Description= ItalianPAResources.MP17 } },
                    { "MP18",new ModalitaPagamentoPA {Code="MP18", Description= ItalianPAResources.MP18 } },
                    { "MP19",new ModalitaPagamentoPA {Code="MP19", Description= ItalianPAResources.MP19 } },
                    { "MP20",new ModalitaPagamentoPA {Code="MP20", Description= ItalianPAResources.MP20 } },
                    { "MP21",new ModalitaPagamentoPA {Code="MP21", Description= ItalianPAResources.MP21 } },
            });
    }
}
