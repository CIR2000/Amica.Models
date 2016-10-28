using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.Models
{
	// TODO this is just a stub

    public class PriceList : BaseModelWithCompanyId
    {
        private string _name;

		public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; } 
		}
    }
}
