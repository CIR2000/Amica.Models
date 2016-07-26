using System.Collections.Generic;

namespace Amica.vNext.Models.ItalianPA
{
    public static class PAHelpers
    {
        public static ReadOnlyDictionary<string, NaturaPA> NaturaPA = 
			new ReadOnlyDictionary<string, NaturaPA>(
                new Dictionary<string, NaturaPA>
                {
                    { "N1", new NaturaPA {Code = "N1", Description= Properties.ItalianPA.N1 }},
                    { "N2", new NaturaPA {Code = "N2", Description= Properties.ItalianPA.N2 }},
                    { "N3", new NaturaPA {Code = "N3", Description= Properties.ItalianPA.N3 }},
                    { "N4", new NaturaPA {Code = "N4", Description= Properties.ItalianPA.N4 }},
                    { "N5", new NaturaPA {Code = "N5", Description= Properties.ItalianPA.N5 }},
                    { "N6", new NaturaPA {Code = "N6", Description= Properties.ItalianPA.N6 }},
				});

        public static readonly ReadOnlyDictionary<string, ModalitaPagamentoPA> ModalitaPagamentoPA = 
			new ReadOnlyDictionary<string, ModalitaPagamentoPA>(
                new Dictionary<string, ModalitaPagamentoPA>
                {
                    { "MP01", new ModalitaPagamentoPA {Code="MP01", Description= Properties.ItalianPA.MP01 } },
                    { "MP02", new ModalitaPagamentoPA {Code="MP02", Description= Properties.ItalianPA.MP02 } },
                    { "MP03", new ModalitaPagamentoPA {Code="MP03", Description= Properties.ItalianPA.MP03 } },
                    { "MP04", new ModalitaPagamentoPA {Code="MP04", Description= Properties.ItalianPA.MP04 } },
                    { "MP05", new ModalitaPagamentoPA {Code="MP05", Description= Properties.ItalianPA.MP05 } },
                    { "MP06", new ModalitaPagamentoPA {Code="MP06", Description= Properties.ItalianPA.MP06 } },
                    { "MP07", new ModalitaPagamentoPA {Code="MP07", Description= Properties.ItalianPA.MP07 } },
                    { "MP08", new ModalitaPagamentoPA {Code="MP08", Description= Properties.ItalianPA.MP08 } },
                    { "MP09", new ModalitaPagamentoPA {Code="MP09", Description= Properties.ItalianPA.MP09 } },
                    { "MP10", new ModalitaPagamentoPA {Code="MP10", Description= Properties.ItalianPA.MP10 } },
                    { "MP11", new ModalitaPagamentoPA {Code="MP11", Description= Properties.ItalianPA.MP11 } },
                    { "MP12", new ModalitaPagamentoPA {Code="MP12", Description= Properties.ItalianPA.MP12 } },
                    { "MP13",new ModalitaPagamentoPA {Code="MP13", Description= Properties.ItalianPA.MP13 } },
                    { "MP14",new ModalitaPagamentoPA {Code="MP14", Description= Properties.ItalianPA.MP14 } },
                    { "MP15",new ModalitaPagamentoPA {Code="MP15", Description= Properties.ItalianPA.MP15} },
                    { "MP16",new ModalitaPagamentoPA {Code="MP16", Description= Properties.ItalianPA.MP16 } },
                    { "MP17",new ModalitaPagamentoPA {Code="MP17", Description= Properties.ItalianPA.MP17 } },
                    { "MP18",new ModalitaPagamentoPA {Code="MP18", Description= Properties.ItalianPA.MP18 } },
                    { "MP19",new ModalitaPagamentoPA {Code="MP19", Description= Properties.ItalianPA.MP19 } },
                    { "MP20",new ModalitaPagamentoPA {Code="MP20", Description= Properties.ItalianPA.MP20 } },
                    { "MP21",new ModalitaPagamentoPA {Code="MP21", Description= Properties.ItalianPA.MP21 } },
            });
    }
}
