using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.vNext.Models.ItalianPA
{
    public class PACollections
    {
        public static readonly ReadOnlyCollection<NaturaPA> NaturaPA = new ReadOnlyCollection<NaturaPA>(
			new List<NaturaPA>
            {
                new NaturaPA {Name="N1", Description="escluse ex art. 15" },
                new NaturaPA {Name="N2", Description="non soggette" },
				new NaturaPA {Name="N3", Description="non imponibili" },
				new NaturaPA {Name="N4", Description="esenti" },
				new NaturaPA {Name="N5", Description="regime del margine" },
				new NaturaPA {Name="N6", Description="inversione contabile (reverse charge)" },
            });

    }
}
