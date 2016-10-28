using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.Models
{
    public class Size : BaseModelWithCompanyId
    {
        private string _name;
        private List<string> _numberCollection;

		public Size()
        {
            _numberCollection = new List<string>();
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

		[JsonProperty("number_collection")]
        public List<string> NumberCollection
        {
            get { return _numberCollection; }
            set { SetProperty(ref _numberCollection, value); }
        }
    }
}
