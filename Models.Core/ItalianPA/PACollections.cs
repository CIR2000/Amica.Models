using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.vNext.Models.ItalianPA
{
    public class PACollections
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

    }
}
