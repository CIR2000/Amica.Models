using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Amica.vNext.Models.Documents
{
    public class DocumentItem : ObservableObject
    {
		private string _sku;
        private string _description;

		public string Sku {
			set { SetProperty (ref _sku, value); }
			get { return _sku; }
		}

		public string Description {
			set { SetProperty (ref _description, value); }
			get { return _description; }
		}
    }
}
